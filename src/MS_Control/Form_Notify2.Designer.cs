namespace MS_Control
{
    partial class Form_Notify2
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
            this.components = new System.ComponentModel.Container();
            this.lblMessage = new System.Windows.Forms.Label();
            this.picMessage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessage.Size = new System.Drawing.Size(244, 98);
            this.lblMessage.TabIndex = 216;
            this.lblMessage.Text = "بررسی کنید.";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Click += new System.EventHandler(this.Form_Notify_Click);
            // 
            // picMessage
            // 
            this.picMessage.BackColor = System.Drawing.Color.Transparent;
            this.picMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.picMessage.Image = global::MS_Control.Properties.Resources.i;
            this.picMessage.Location = new System.Drawing.Point(244, 0);
            this.picMessage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.picMessage.Name = "picMessage";
            this.picMessage.Size = new System.Drawing.Size(76, 98);
            this.picMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMessage.TabIndex = 215;
            this.picMessage.TabStop = false;
            this.picMessage.Click += new System.EventHandler(this.Form_Notify_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form_Notify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 98);
            this.ControlBox = false;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.picMessage);
            this.Name = "Form_Notify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "پـیـغــام";
            this.Click += new System.EventHandler(this.Form_Notify_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox picMessage;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
    }
}