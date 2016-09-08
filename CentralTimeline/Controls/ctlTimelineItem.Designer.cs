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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picProgress = new System.Windows.Forms.PictureBox();
            this.chkComplete = new System.Windows.Forms.CheckBox();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDue = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.picAssignedTo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAssignedTo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picProgress);
            this.panel1.Controls.Add(this.chkComplete);
            this.panel1.Controls.Add(this.lblAssignment);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(100, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 89);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // picProgress
            // 
            this.picProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picProgress.Image = global::CentralTimeline.Properties.Resources.ajax_loader;
            this.picProgress.Location = new System.Drawing.Point(206, 69);
            this.picProgress.Name = "picProgress";
            this.picProgress.Size = new System.Drawing.Size(16, 16);
            this.picProgress.TabIndex = 5;
            this.picProgress.TabStop = false;
            this.picProgress.Click += new System.EventHandler(this.picProgress_Click);
            // 
            // chkComplete
            // 
            this.chkComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkComplete.AutoSize = true;
            this.chkComplete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkComplete.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComplete.ForeColor = System.Drawing.Color.Gray;
            this.chkComplete.Location = new System.Drawing.Point(136, 65);
            this.chkComplete.Name = "chkComplete";
            this.chkComplete.Size = new System.Drawing.Size(87, 23);
            this.chkComplete.TabIndex = 4;
            this.chkComplete.Text = "complete";
            this.chkComplete.UseVisualStyleBackColor = true;
            this.chkComplete.CheckedChanged += new System.EventHandler(this.chkComplete_CheckedChanged);
            // 
            // lblAssignment
            // 
            this.lblAssignment.AutoSize = true;
            this.lblAssignment.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignment.ForeColor = System.Drawing.Color.Gray;
            this.lblAssignment.Location = new System.Drawing.Point(14, 31);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(95, 19);
            this.lblAssignment.TabIndex = 3;
            this.lblAssignment.Text = "lblAssignment";
            this.lblAssignment.Visible = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(14, 8);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(114, 23);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "lblDescription";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(14, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "lblName";
            // 
            // lblDue
            // 
            this.lblDue.BackColor = System.Drawing.Color.White;
            this.lblDue.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDue.ForeColor = System.Drawing.Color.Gray;
            this.lblDue.Location = new System.Drawing.Point(-4, 35);
            this.lblDue.Name = "lblDue";
            this.lblDue.Padding = new System.Windows.Forms.Padding(1);
            this.lblDue.Size = new System.Drawing.Size(90, 19);
            this.lblDue.TabIndex = 2;
            this.lblDue.Text = "lblDue";
            this.lblDue.Click += new System.EventHandler(this.lblDue_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "studying.png");
            this.imageList.Images.SetKeyName(1, "student.png");
            // 
            // picAssignedTo
            // 
            this.picAssignedTo.Image = global::CentralTimeline.Properties.Resources.disc_jockey;
            this.picAssignedTo.Location = new System.Drawing.Point(19, 2);
            this.picAssignedTo.Name = "picAssignedTo";
            this.picAssignedTo.Size = new System.Drawing.Size(32, 32);
            this.picAssignedTo.TabIndex = 3;
            this.picAssignedTo.TabStop = false;
            // 
            // ctlTimelineItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picAssignedTo);
            this.Controls.Add(this.lblDue);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Name = "ctlTimelineItem";
            this.Size = new System.Drawing.Size(329, 96);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ctlTimelineItem_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAssignedTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picAssignedTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label lblAssignment;
        private System.Windows.Forms.CheckBox chkComplete;
        private System.Windows.Forms.PictureBox picProgress;
    }
}
