namespace CentralTimeline {
    partial class Form1 {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ctlTimeline1 = new CentralTimeline.Controls.ctlTimeline();
            this.SuspendLayout();
            // 
            // ctlTimeline1
            // 
            this.ctlTimeline1.BackColor = System.Drawing.SystemColors.Control;
            this.ctlTimeline1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTimeline1.Location = new System.Drawing.Point(0, 0);
            this.ctlTimeline1.Name = "ctlTimeline1";
            this.ctlTimeline1.Size = new System.Drawing.Size(373, 685);
            this.ctlTimeline1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(373, 685);
            this.Controls.Add(this.ctlTimeline1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctlTimeline ctlTimeline1;
    }
}

