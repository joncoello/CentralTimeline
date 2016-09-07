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
        }

        internal void DataBind(Timeline timeline) {
            this.lblCount.DataBindings.Add("Text", timeline, "Name");
        }
    }
}
