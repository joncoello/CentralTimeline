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
        public event EventHandler Highlighted;
        private const int COLLAPSED_HEIGHT = 55;
        private const int EXPANDED_HEIGHT = 100;

        private Brush _panelBrush = Brushes.White; 

        public ctlTimelineItem() {
            InitializeComponent();
        }

        public ctlTimelineItem(TimelineItem item) {
            InitializeComponent();
            this.item = item;
            this.Height = COLLAPSED_HEIGHT;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if (item != null) {
                lblDescription.Text = item.Description;
                lblName.Text = item.Name;
                lblDue.Text = item.Due;
                if (item.AssignedToType == TimelineItem.AssignedType.Client) {
                    picAssignedTo.Image = CentralTimeline.Properties.Resources.disc_jockey;
                } else {
                    picAssignedTo.Image = CentralTimeline.Properties.Resources.businessman;
                }
                lblAssignment.Text = item.Assignment;
                chkComplete.Checked = item.IsComplete;
            }
        }

        private void ctlTimelineItem_Paint(object sender, PaintEventArgs e) {

            // define triangle pointing to stage
            var l = panel1.Location;
            var topPoint = new Point(l.X, l.Y + 10);
            var bottomPoint = new Point(l.X, l.Y + 30);
            var leftPoint = new Point(l.X - 10, l.Y + 20);

            // fill it
            var pathToFill = new GraphicsPath(
                new Point[] { topPoint, bottomPoint, leftPoint },
                new byte[] { (byte)PathPointType.Line, (byte)PathPointType.Line, (byte)PathPointType.Line }
                );
            e.Graphics.FillPath(_panelBrush, pathToFill);

            // draw border
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

        public void Highlight(bool proposedState) {
            if (!item.IsComplete) {

                chkComplete.Visible = proposedState;
                lblAssignment.Visible = proposedState;

                if (proposedState) {
                    _panelBrush = Brushes.WhiteSmoke;
                    panel1.BackColor = Color.WhiteSmoke;
                    this.Height = EXPANDED_HEIGHT;
                    if (this.Highlighted!=null) {
                        this.Highlighted(this, EventArgs.Empty);
                    }
                } else {
                    _panelBrush = Brushes.White;
                    panel1.BackColor = Color.White;
                    this.Height = COLLAPSED_HEIGHT;
                }
                this.Refresh();
            }
        }

        private void lblDue_Click(object sender, EventArgs e) {

        }

        private void chkComplete_CheckedChanged(object sender, EventArgs e) {
            item.IsComplete = chkComplete.Checked;
            if (chkComplete.Checked) {
                panel1.BackColor = Color.WhiteSmoke;
                lblDescription.ForeColor = Color.LightGray;
                lblAssignment.ForeColor = Color.LightGray;
                lblDue.ForeColor = Color.LightGray;
                lblName.ForeColor = Color.LightGray;
            } else {
                panel1.BackColor = Color.White;
                lblDescription.ForeColor = SystemColors.ControlText;
                lblAssignment.ForeColor = Color.Gray;
                lblDue.ForeColor = Color.Gray;
                lblName.ForeColor = Color.Gray;
            }
        }
    }
}
