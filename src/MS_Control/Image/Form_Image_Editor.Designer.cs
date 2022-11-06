namespace MS_Control.Image
{
    partial class Form_Image_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Image_Editor));
            this.mS_Tool_Strip1 = new MS_Control.Controls.MS_Tool_Strip();
            this.ms_vertical_rotate = new System.Windows.Forms.ToolStripButton();
            this.ms_horizental_rotate = new System.Windows.Forms.ToolStripButton();
            this.ms_rotate_left = new System.Windows.Forms.ToolStripButton();
            this.ms_rotate_right = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_zoom_out = new System.Windows.Forms.ToolStripButton();
            this.ms_zoom_in = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_fit_image = new System.Windows.Forms.ToolStripButton();
            this.ms_crop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_undo = new System.Windows.Forms.ToolStripButton();
            this.ms_ok = new System.Windows.Forms.ToolStripButton();
            this.ms_cancel = new System.Windows.Forms.ToolStripButton();
            this.ms_image_Box = new MS_Control.Image.ImageBoxEx();
            this.mS_Tool_Strip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mS_Tool_Strip1
            // 
            this.mS_Tool_Strip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mS_Tool_Strip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_vertical_rotate,
            this.ms_horizental_rotate,
            this.ms_rotate_left,
            this.ms_rotate_right,
            this.toolStripSeparator1,
            this.ms_zoom_out,
            this.ms_zoom_in,
            this.toolStripSeparator6,
            this.ms_fit_image,
            this.ms_crop,
            this.toolStripSeparator2,
            this.ms_undo,
            this.ms_cancel,
            this.ms_ok});
            this.mS_Tool_Strip1.Location = new System.Drawing.Point(0, 0);
            this.mS_Tool_Strip1.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.mS_Tool_Strip1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Tool_Strip1.MS_Color_End = System.Drawing.Color.LightSkyBlue;
            this.mS_Tool_Strip1.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_Tool_Strip1.Name = "mS_Tool_Strip1";
            this.mS_Tool_Strip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_Tool_Strip1.Size = new System.Drawing.Size(696, 25);
            this.mS_Tool_Strip1.TabIndex = 0;
            this.mS_Tool_Strip1.Text = "mS_Tool_Strip1";
            // 
            // ms_vertical_rotate
            // 
            this.ms_vertical_rotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_vertical_rotate.Image = ((System.Drawing.Image)(resources.GetObject("ms_vertical_rotate.Image")));
            this.ms_vertical_rotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_vertical_rotate.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.ms_vertical_rotate.Name = "ms_vertical_rotate";
            this.ms_vertical_rotate.Size = new System.Drawing.Size(23, 22);
            this.ms_vertical_rotate.Text = "تصـویر آییـنه افقـی";
            this.ms_vertical_rotate.ToolTipText = "چرخش آینه ای عرضی";
            this.ms_vertical_rotate.Click += new System.EventHandler(this.ms_vertical_rotate_Click);
            // 
            // ms_horizental_rotate
            // 
            this.ms_horizental_rotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_horizental_rotate.Image = ((System.Drawing.Image)(resources.GetObject("ms_horizental_rotate.Image")));
            this.ms_horizental_rotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_horizental_rotate.Name = "ms_horizental_rotate";
            this.ms_horizental_rotate.Size = new System.Drawing.Size(23, 22);
            this.ms_horizental_rotate.Text = "تصویر آیینه ای عمـودی";
            this.ms_horizental_rotate.ToolTipText = "چـرخش آینه ای طولی";
            this.ms_horizental_rotate.Click += new System.EventHandler(this.ms_horizental_rotate_Click);
            // 
            // ms_rotate_left
            // 
            this.ms_rotate_left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_rotate_left.Image = ((System.Drawing.Image)(resources.GetObject("ms_rotate_left.Image")));
            this.ms_rotate_left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_rotate_left.Name = "ms_rotate_left";
            this.ms_rotate_left.Size = new System.Drawing.Size(23, 22);
            this.ms_rotate_left.Text = "پرخش به چپ";
            this.ms_rotate_left.Click += new System.EventHandler(this.ms_rotate_left_Click);
            // 
            // ms_rotate_right
            // 
            this.ms_rotate_right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_rotate_right.Image = ((System.Drawing.Image)(resources.GetObject("ms_rotate_right.Image")));
            this.ms_rotate_right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_rotate_right.Name = "ms_rotate_right";
            this.ms_rotate_right.Size = new System.Drawing.Size(23, 22);
            this.ms_rotate_right.Text = "چرخش به راست";
            this.ms_rotate_right.Click += new System.EventHandler(this.ms_rotate_right_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ms_zoom_out
            // 
            this.ms_zoom_out.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_zoom_out.Image = ((System.Drawing.Image)(resources.GetObject("ms_zoom_out.Image")));
            this.ms_zoom_out.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_zoom_out.Name = "ms_zoom_out";
            this.ms_zoom_out.Size = new System.Drawing.Size(23, 22);
            this.ms_zoom_out.Text = "بزرگـنمــایی";
            this.ms_zoom_out.ToolTipText = "بزرگ نمایی";
            this.ms_zoom_out.Click += new System.EventHandler(this.ms_zoom_out_Click);
            // 
            // ms_zoom_in
            // 
            this.ms_zoom_in.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_zoom_in.Image = ((System.Drawing.Image)(resources.GetObject("ms_zoom_in.Image")));
            this.ms_zoom_in.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_zoom_in.Name = "ms_zoom_in";
            this.ms_zoom_in.Size = new System.Drawing.Size(23, 22);
            this.ms_zoom_in.Text = "کوچـک نمـایـی";
            this.ms_zoom_in.ToolTipText = "کوچک نمایی";
            this.ms_zoom_in.Click += new System.EventHandler(this.ms_zoom_in_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // ms_fit_image
            // 
            this.ms_fit_image.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_fit_image.Image = global::MS_Control.Properties.Resources.image_resize_actual;
            this.ms_fit_image.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_fit_image.Name = "ms_fit_image";
            this.ms_fit_image.Size = new System.Drawing.Size(23, 22);
            this.ms_fit_image.Text = "پرکردن کادر انتخابی با تصویر";
            this.ms_fit_image.Click += new System.EventHandler(this.ms_fit_image_Click);
            // 
            // ms_crop
            // 
            this.ms_crop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_crop.Image = global::MS_Control.Properties.Resources.image_crop;
            this.ms_crop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_crop.Name = "ms_crop";
            this.ms_crop.Size = new System.Drawing.Size(23, 22);
            this.ms_crop.Text = "برش تصویر به اندازه کادر";
            this.ms_crop.Click += new System.EventHandler(this.ms_crop_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ms_undo
            // 
            this.ms_undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_undo.Image = global::MS_Control.Properties.Resources.undo;
            this.ms_undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_undo.Name = "ms_undo";
            this.ms_undo.Size = new System.Drawing.Size(23, 22);
            this.ms_undo.Text = "برگشت به حالت اولیه";
            this.ms_undo.Click += new System.EventHandler(this.ms_undo_Click);
            // 
            // ms_ok
            // 
            this.ms_ok.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ms_ok.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_ok.Image = global::MS_Control.Properties.Resources.check1;
            this.ms_ok.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_ok.Margin = new System.Windows.Forms.Padding(1, 1, 2, 2);
            this.ms_ok.Name = "ms_ok";
            this.ms_ok.Size = new System.Drawing.Size(23, 22);
            this.ms_ok.Text = "قبول تغییرات ";
            this.ms_ok.Click += new System.EventHandler(this.ms_ok_Click);
            // 
            // ms_cancel
            // 
            this.ms_cancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ms_cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_cancel.Image = global::MS_Control.Properties.Resources.close_16;
            this.ms_cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_cancel.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.ms_cancel.Name = "ms_cancel";
            this.ms_cancel.Size = new System.Drawing.Size(23, 22);
            this.ms_cancel.Text = "انصـراف از ویرایش تصویر";
            this.ms_cancel.Click += new System.EventHandler(this.ms_cancel_Click);
            // 
            // ms_image_Box
            // 
            this.ms_image_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ms_image_Box.GridCellSize = 10;
            this.ms_image_Box.GridColor = System.Drawing.Color.PowderBlue;
            this.ms_image_Box.Location = new System.Drawing.Point(0, 25);
            this.ms_image_Box.Name = "ms_image_Box";
            this.ms_image_Box.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_image_Box.SelectionMode = Cyotek.Windows.Forms.ImageBoxSelectionMode.Rectangle;
            this.ms_image_Box.ShowPixelGrid = true;
            this.ms_image_Box.Size = new System.Drawing.Size(696, 496);
            this.ms_image_Box.TabIndex = 1;
            this.ms_image_Box.Selecting += new System.EventHandler<Cyotek.Windows.Forms.ImageBoxCancelEventArgs>(this.ms_image_Box_Selecting);
            // 
            // Form_Image_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 521);
            this.Controls.Add(this.ms_image_Box);
            this.Controls.Add(this.mS_Tool_Strip1);
            this.MinimizeBox = false;
            this.Name = "Form_Image_Editor";
            this.Text = "ویرایش تصویر";
            this.Load += new System.EventHandler(this.Form_Image_Editor_Load);
            this.Shown += new System.EventHandler(this.Form_Image_Editor_Shown);
            this.mS_Tool_Strip1.ResumeLayout(false);
            this.mS_Tool_Strip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MS_Tool_Strip mS_Tool_Strip1;
        private System.Windows.Forms.ToolStripButton ms_vertical_rotate;
        private System.Windows.Forms.ToolStripButton ms_horizental_rotate;
        private System.Windows.Forms.ToolStripButton ms_rotate_left;
        private System.Windows.Forms.ToolStripButton ms_rotate_right;
        private System.Windows.Forms.ToolStripButton ms_zoom_out;
        private System.Windows.Forms.ToolStripButton ms_zoom_in;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ms_fit_image;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ms_crop;
        private System.Windows.Forms.ToolStripButton ms_undo;
        private System.Windows.Forms.ToolStripButton ms_ok;
        private ImageBoxEx ms_image_Box;
        private System.Windows.Forms.ToolStripButton ms_cancel;
    }
}