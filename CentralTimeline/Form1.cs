using System;
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
                flowLayoutPanel.Controls.Add(new Controls.ctlTimelineItem(item) { Width = flowLayoutPanel.Width - 20 , Anchor = AnchorStyles.Left & AnchorStyles.Right});
            }

        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e) {
            int leftMargin = 37;
            int topMargin = 10;
            e.Graphics.DrawLine(new Pen(Color.LightGray, 3), leftMargin, topMargin, leftMargin, flowLayoutPanel.Height - topMargin);
        }

        private void flowLayoutPanel_Resize(object sender, EventArgs e) {
            flowLayoutPanel.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
