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
    public partial class ctlTimelineItem : UserControl {
        private TimelineItem item;

        public ctlTimelineItem() {
            InitializeComponent();
        }

        public ctlTimelineItem(TimelineItem item) {
            InitializeComponent();
            this.item = item;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if (item != null) {
                lblDescription.Text = item.Description;
                lblName.Text = item.Name;
                lblDue.Text = item.Due;
                if (item.AssignedToType == TimelineItem.AssignedType.Client) {
                    picAssignedTo.Image = imageList.Images[0];
                } else {
                    picAssignedTo.Image = imageList.Images[1];
                }
            }
        }

        private void ctlTimelineItem_Paint(object sender, PaintEventArgs e) {

            var l = panel1.Location;
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

        private void panel1_Paint(object sender, PaintEventArgs e) {
            var p = sender as Panel;
            e.Graphics.DrawLine(Pens.Gray, 0, 0, p.Width, 0);
            e.Graphics.DrawLine(Pens.Gray, p.Width - 1, 0, p.Width - 1, p.Height);
            e.Graphics.DrawLine(Pens.Gray, p.Width - 1, p.Height - 1, 0, p.Height - 1);
            e.Graphics.DrawLine(Pens.Gray, 0, p.Height - 1, 0, 30);
            e.Graphics.DrawLine(Pens.Gray, 0, 10, 0, 0);
        }
    }
}
