
namespace MS_Control.Image
{
    partial class Form_Image_Viewer
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
            this.ms_image_Box = new MS_Control.Image.ImageBoxEx();
            this.SuspendLayout();
            // 
            // ms_image_Box
            // 
            this.ms_image_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ms_image_Box.GridCellSize = 10;
            this.ms_image_Box.GridColor = System.Drawing.Color.PowderBlue;
            this.ms_image_Box.Location = new System.Drawing.Point(0, 0);
            this.ms_image_Box.Name = "ms_image_Box";
            this.ms_image_Box.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_image_Box.SelectionMode = Cyotek.Windows.Forms.ImageBoxSelectionMode.Rectangle;
            this.ms_image_Box.ShowPixelGrid = true;
            this.ms_image_Box.Size = new System.Drawing.Size(800, 450);
            this.ms_image_Box.TabIndex = 2;
            // 
            // Form_Image_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ms_image_Box);
            this.MinimizeBox = false;
            this.Name = "Form_Image_Viewer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "مشاهده تصویر ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private ImageBoxEx ms_image_Box;
    }
}