﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralTimeline.Models;
using System.Drawing.Drawing2D;

namespace CentralTimeline.Controls {
    public partial class ctlTimeline : UserControl {
        
        public ctlTimeline() {
            InitializeComponent();
        }

        public void DataBind(Timeline timeline) {
            foreach (var item in timeline.Items) {
                var itemControl = new Controls.ctlTimelineItem(item) { Width = flowLayoutPanel.Width - 20, Anchor = AnchorStyles.Left & AnchorStyles.Right };
                itemControl.Controller.Highlighted += ItemControl_Highlighted;
                flowLayoutPanel.Controls.Add(itemControl);
            }
        }
        
        private void ItemControl_Highlighted(object sender, EventArgs e) {
            //var itemControl = sender as TimelineItemController;
            //foreach (var ctl in flowLayoutPanel.Controls) {
            //    var i = ctl as ctlTimelineItem;
            //    if (i.Controller != itemControl) {
            //        this.SuspendLayout();
            //        i.Controller.Highlight(false);
            //        this.ResumeLayout();
            //    }
            //}
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e) {
            int leftMargin = 32;
            int topMargin = 10;
            e.Graphics.DrawLine(new Pen(Color.LightGray, 3), leftMargin, topMargin, leftMargin, flowLayoutPanel.Height - topMargin);
        }

        private void flowLayoutPanel_Resize(object sender, EventArgs e) {
            flowLayoutPanel.Refresh();
        }

    }
}
