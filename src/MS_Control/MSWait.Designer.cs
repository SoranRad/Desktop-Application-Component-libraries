namespace MS_Control
{
    partial class MSWait
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSWait));
            this.lblPardazesh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPardazesh
            // 
            this.lblPardazesh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPardazesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPardazesh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPardazesh.ForeColor = System.Drawing.Color.Black;
            this.lblPardazesh.Image = ((System.Drawing.Image)(resources.GetObject("lblPardazesh.Image")));
            this.lblPardazesh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPardazesh.Location = new System.Drawing.Point(0, 0);
            this.lblPardazesh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPardazesh.Name = "lblPardazesh";
            this.lblPardazesh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPardazesh.Size = new System.Drawing.Size(427, 94);
            this.lblPardazesh.TabIndex = 52;
            this.lblPardazesh.Text = "           پـردازش تـوسـط سـیـسـتـم . . . ";
            this.lblPardazesh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MSWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 94);
            this.ControlBox = false;
            this.Controls.Add(this.lblPardazesh);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MSWait";
            this.Text = "کـمـی صـبـر کـنـیـد";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPardazesh;
    }
}