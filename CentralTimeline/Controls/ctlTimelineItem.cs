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

    }
}
