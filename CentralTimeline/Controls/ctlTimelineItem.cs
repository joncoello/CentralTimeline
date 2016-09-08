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
                lblAssignment.Text = item.Assignment;
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

            e.Graphics.DrawLine(Pens.LightGray, leftPoint, topPoint);
            e.Graphics.DrawLine(Pens.LightGray, leftPoint, bottomPoint);

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {
            var p = sender as Panel;
            e.Graphics.DrawLine(Pens.LightGray, 0, 0, p.Width, 0);
            e.Graphics.DrawLine(Pens.LightGray, p.Width - 1, 0, p.Width - 1, p.Height);
            e.Graphics.DrawLine(Pens.LightGray, p.Width - 1, p.Height - 1, 0, p.Height - 1);
            e.Graphics.DrawLine(Pens.LightGray, 0, p.Height - 1, 0, 30);
            e.Graphics.DrawLine(Pens.LightGray, 0, 10, 0, 0);
        }
        
        private void panel1_MouseEnter(object sender, EventArgs e) {
            ChangeHighlight();
        }

        private void panel1_MouseLeave(object sender, EventArgs e) {
            ChangeHighlight();
        }

        private void ChangeHighlight() {
            var proposedState = false;
            if (panel1.ClientRectangle.Contains(panel1.PointToClient(Cursor.Position))) {
                proposedState = true;
            }
            if (chkComplete.Visible != proposedState) {
                //chkComplete.Visible = proposedState;
                Highlight(proposedState);
            }
        }

        private void Highlight(bool proposedState) {
            chkComplete.Visible = proposedState;
            if (proposedState) {
                panel1.BackColor = Color.WhiteSmoke;
            } else {
                panel1.BackColor = Color.White;
            }
        }

        private void lblDue_Click(object sender, EventArgs e) {

        }
    }
}
