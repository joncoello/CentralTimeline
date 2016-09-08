﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralTimeline {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.ResizeRedraw = true;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            var repo = new Repo.TimelineRepository();
            var timeline = repo.GetTimeline();

            //ctlTimeline1.DataBind(timeline);

            foreach (var item in timeline.Items) {
                flowLayoutPanel.Controls.Add(new Controls.ctlTimelineItem(item));
            }

        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e) {
            int leftMargin = 27;
            int topMargin = 10;
            e.Graphics.DrawLine(Pens.Black, leftMargin, topMargin, leftMargin, flowLayoutPanel.Height - topMargin);
        }

        private void flowLayoutPanel_Resize(object sender, EventArgs e) {
            flowLayoutPanel.Refresh();
        }
    }
}
