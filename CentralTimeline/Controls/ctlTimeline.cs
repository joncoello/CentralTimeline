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
using System.Drawing.Drawing2D;

namespace CentralTimeline.Controls {
    public partial class ctlTimeline : UserControl {
        public ctlTimeline() {

            InitializeComponent();

            foreach (var label in GetStepLabels()) {
                label.Paint += Label_Paint;
            }

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
            foreach (var label in GetStepLabels()) {
                DrawTriangleForStep(e, label);
            }
        }

        private void DrawTriangleForStep(PaintEventArgs e, Label label1) {

            var l = label1.Location;
            var topPoint = new Point(l.X, l.Y + 10);
            var bottomPoint = new Point(l.X, l.Y + 30);
            var leftPoint = new Point(l.X - 10, l.Y + 20);

            var pathToFill = new GraphicsPath(
                new Point[] { topPoint, bottomPoint, leftPoint },
                new byte[] { (byte)PathPointType.Line, (byte)PathPointType.Line, (byte)PathPointType.Line }
                );
            e.Graphics.FillPath(Brushes.White, pathToFill);

            e.Graphics.DrawLine(Pens.Gray, leftPoint, topPoint);
            e.Graphics.DrawLine(Pens.Gray, leftPoint, bottomPoint);

        }

        private List<Label> GetStepLabels() {

            var results = new List<Label>();

            foreach (var control in this.Controls) {
                var label = (control as Label);
                if (label != null && label != lblCount) {
                    results.Add(label);
                }
            }

            return results;
        }
    }
}
