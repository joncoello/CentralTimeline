using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralTimeline.Models;

namespace CentralTimeline.Controls {
    public partial class ctlTimeline : UserControl {
        public ctlTimeline() {
            InitializeComponent();

            label1.Paint += Label_Paint;
            label2.Paint += Label_Paint;
            label3.Paint += Label_Paint;
        }

        private void Label_Paint(object sender, PaintEventArgs e) {
            var l = sender as Label;
            e.Graphics.DrawLine(Pens.Gray, 0, 0, l.Width, 0);
            e.Graphics.DrawLine(Pens.Gray, l.Width - 1, 0, l.Width - 1, l.Height);
            e.Graphics.DrawLine(Pens.Gray, l.Width - 1, l.Height - 1, 0, l.Height - 1);
            e.Graphics.DrawLine(Pens.Gray, 0, l.Height - 1, 0, 30);
            e.Graphics.DrawLine(Pens.Gray, 0, 10, 0, 0);
        }

        internal void DataBind(Timeline timeline) {
            this.lblCount.DataBindings.Add("Text", timeline, "Name");
        }
        
        private void ctlTimeline_Paint(object sender, PaintEventArgs e) {
            DrawTriangleForStep(e, label1);
            DrawTriangleForStep(e, label2);
            DrawTriangleForStep(e, label3);

        }

        private void DrawTriangleForStep(PaintEventArgs e, Label label1) {
            var l = label1.Location;
            e.Graphics.DrawLine(Pens.Gray, l.X - 10, l.Y + 20, l.X, l.Y + 10);
            e.Graphics.DrawLine(Pens.Gray, l.X - 10, l.Y + 20, l.X, l.Y + 30);
        }
    }
}
