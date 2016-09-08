namespace CentralTimeline.Controls {
    partial class ctlTimelineItem {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlTimelineItem));
            this.picAssignedTo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDue = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picAssignedTo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picAssignedTo
            // 
            this.picAssignedTo.Image = global::CentralTimeline.Properties.Resources.student;
            this.picAssignedTo.Location = new System.Drawing.Point(14, 27);
            this.picAssignedTo.Name = "picAssignedTo";
            this.picAssignedTo.Size = new System.Drawing.Size(40, 40);
            this.picAssignedTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAssignedTo.TabIndex = 3;
            this.picAssignedTo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lblDue);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(87, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 80);
            this.panel1.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "lblName";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 8);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 17);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "lblDescription";
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.Location = new System.Drawing.Point(14, 56);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(48, 17);
            this.lblDue.TabIndex = 2;
            this.lblDue.Text = "lblDue";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "studying.png");
            this.imageList.Images.SetKeyName(1, "student.png");
            // 
            // ctlTimelineItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picAssignedTo);
            this.Name = "ctlTimelineItem";
            this.Size = new System.Drawing.Size(348, 122);
            ((System.ComponentModel.ISupportInitialize)(this.picAssignedTo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picAssignedTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.ImageList imageList;
    }
}
