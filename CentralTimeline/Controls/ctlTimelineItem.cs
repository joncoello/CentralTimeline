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
        
        public readonly TimelineItemController Controller;

        public ctlTimelineItem() {
            InitializeComponent();
        }

        public ctlTimelineItem(TimelineItem item) {
            InitializeComponent();
            this.item = item;
            Controller = new TimelineItemController(item);
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if (Controller != null) {
                BindProperties();

            }
        }

        private void BindProperties() {

            lblDescription.DataBindings.Add("Text", item, "Description", false, DataSourceUpdateMode.OnPropertyChanged);
            lblName.DataBindings.Add("Text", item, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            lblDue.DataBindings.Add("Text", item, "Due", false, DataSourceUpdateMode.OnPropertyChanged);
            lblAssignment.DataBindings.Add("Text", item, "Assignment", false, DataSourceUpdateMode.OnPropertyChanged);
            chkComplete.DataBindings.Add("Checked", Controller.Item, "IsComplete", false, DataSourceUpdateMode.OnPropertyChanged);

            if (item.AssignedToType == TimelineItem.AssignedType.Client) {
                picAssignedTo.Image = CentralTimeline.Properties.Resources.disc_jockey;
            } else {
                picAssignedTo.Image = CentralTimeline.Properties.Resources.businessman;
            }

            panel1.DataBindings.Add("BackColor", Controller.Item, "ControlBackColour", false, DataSourceUpdateMode.OnPropertyChanged);
            lblAssignment.DataBindings.Add("ForeColor", Controller.Item, "ControlForeColour", false, DataSourceUpdateMode.OnPropertyChanged);
            lblDue.DataBindings.Add("ForeColor", Controller.Item, "ControlForeColour", false, DataSourceUpdateMode.OnPropertyChanged);
            lblName.DataBindings.Add("ForeColor", Controller.Item, "ControlForeColour", false, DataSourceUpdateMode.OnPropertyChanged);
            lblDescription.DataBindings.Add("ForeColor", Controller.Item, "DescriptionForeColour", false, DataSourceUpdateMode.OnPropertyChanged);
            chkComplete.DataBindings.Add("Visible", Controller.Item, "IsCompleteVisible", false, DataSourceUpdateMode.OnPropertyChanged);
            picProgress.DataBindings.Add("Image", Controller.Item, "LoadingIconImage", true, DataSourceUpdateMode.OnPropertyChanged);
            picProgress.DataBindings.Add("Visible", Controller.Item, "LoadingIconVisible", false, DataSourceUpdateMode.OnPropertyChanged);
            lblAssignment.DataBindings.Add("Visible", Controller.Item, "AssignmentVisible", false, DataSourceUpdateMode.OnPropertyChanged);
            this.DataBindings.Add("Height", Controller.Item, "Height", false, DataSourceUpdateMode.OnPropertyChanged);
            picOverdue.DataBindings.Add("Visible", Controller.Item, "OverdueIconVisible", false, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void ctlTimelineItem_Paint(object sender, PaintEventArgs e) {

            // define triangle pointing to stage
            var l = panel1.Location;
            var topPoint = new Point(l.X, l.Y + 10);
            var bottomPoint = new Point(l.X, l.Y + 20);
            var leftPoint = new Point(l.X - 5, l.Y + 15);

            // fill it
            var pathToFill = new GraphicsPath(
                new Point[] { topPoint, bottomPoint, leftPoint },
                new byte[] { (byte)PathPointType.Line, (byte)PathPointType.Line, (byte)PathPointType.Line }
                );
            e.Graphics.FillPath(Controller.PanelBrush, pathToFill);

            // draw border
            e.Graphics.DrawLine(this.Controller.Item.BorderColour, leftPoint, topPoint);
            e.Graphics.DrawLine(this.Controller.Item.BorderColour, leftPoint, bottomPoint);

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {
            var p = sender as Panel;
            e.Graphics.DrawLine(this.Controller.Item.BorderColour, 0, 0, p.Width, 0);
            e.Graphics.DrawLine(this.Controller.Item.BorderColour, p.Width - 1, 0, p.Width - 1, p.Height);
            e.Graphics.DrawLine(this.Controller.Item.BorderColour, p.Width - 1, p.Height - 1, 0, p.Height - 1);
            e.Graphics.DrawLine(this.Controller.Item.BorderColour, 0, p.Height - 1, 0, 20);
            e.Graphics.DrawLine(this.Controller.Item.BorderColour, 0, 10, 0, 0);
        }

        private void panel1_MouseEnter(object sender, EventArgs e) {
            ChangeHighlight();
        }

        private void panel1_MouseLeave(object sender, EventArgs e) {
            ChangeHighlight();
        }

        private void ChangeHighlight() {
            if (panel1.ClientRectangle.Contains(panel1.PointToClient(Cursor.Position))) {
                Controller.MouseEntersControl();
            } else {
                Controller.MouseLeavesControl();
            }
            this.Refresh();
        }
        
        private void picProgress_Click(object sender, EventArgs e) {
            Controller.ChangeIsComplete(false);
            Refresh();
        }
    }
}
