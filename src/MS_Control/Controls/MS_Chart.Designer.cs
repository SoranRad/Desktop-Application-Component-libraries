namespace MS_Control.Controls
{
    partial class MS_Chart
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MS_Chart));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mp_menu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ms_Ofoghi = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Dayere = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Herami = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mp_export_picture = new System.Windows.Forms.Button();
            this.mp_full_screen = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_picture.png");
            this.imageList1.Images.SetKeyName(1, "printer.png");
            this.imageList1.Images.SetKeyName(2, "chart_curve_go.png");
            this.imageList1.Images.SetKeyName(3, "resize_picture.png");
            // 
            // mp_menu
            // 
            this.mp_menu.BackColor = System.Drawing.SystemColors.Control;
            this.mp_menu.ContextMenuStrip = this.contextMenuStrip1;
            this.mp_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mp_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mp_menu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp_menu.ImageIndex = 2;
            this.mp_menu.ImageList = this.imageList1;
            this.mp_menu.Location = new System.Drawing.Point(0, 0);
            this.mp_menu.Name = "mp_menu";
            this.mp_menu.Size = new System.Drawing.Size(25, 25);
            this.mp_menu.TabIndex = 0;
            this.mp_menu.UseVisualStyleBackColor = false;
            this.mp_menu.MouseEnter += new System.EventHandler(this.mp_menu_MouseEnter);
            this.mp_menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mp_menu_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_Ofoghi,
            this.ms_Dayere,
            this.ms_Herami});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // ms_Ofoghi
            // 
            this.ms_Ofoghi.Image = ((System.Drawing.Image)(resources.GetObject("ms_Ofoghi.Image")));
            this.ms_Ofoghi.Name = "ms_Ofoghi";
            this.ms_Ofoghi.Size = new System.Drawing.Size(152, 22);
            this.ms_Ofoghi.Text = "نـمـودار افـقـی";
            this.ms_Ofoghi.Click += new System.EventHandler(this.ms_Ofoghi_Click);
            // 
            // ms_Dayere
            // 
            this.ms_Dayere.Image = ((System.Drawing.Image)(resources.GetObject("ms_Dayere.Image")));
            this.ms_Dayere.Name = "ms_Dayere";
            this.ms_Dayere.Size = new System.Drawing.Size(152, 22);
            this.ms_Dayere.Text = "نـمـودار دایـره ای";
            this.ms_Dayere.Click += new System.EventHandler(this.ms_Dayere_Click);
            // 
            // ms_Herami
            // 
            this.ms_Herami.Image = ((System.Drawing.Image)(resources.GetObject("ms_Herami.Image")));
            this.ms_Herami.Name = "ms_Herami";
            this.ms_Herami.Size = new System.Drawing.Size(152, 22);
            this.ms_Herami.Text = "نـمـودار هـرمـی";
            this.ms_Herami.Click += new System.EventHandler(this.ms_Herami_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.png";
            this.saveFileDialog1.Filter = "Bitmap Image (.bmp)|*.bmp|Emf Image (.emf)|*.emf|Exif Image (.exif)|*.exif|Gif Im" +
    "age (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.t" +
    "iff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            this.saveFileDialog1.Title = "انتخاب مسیر ذخیره فایل تصویر نمودار ";
            // 
            // mp_export_picture
            // 
            this.mp_export_picture.BackColor = System.Drawing.SystemColors.Control;
            this.mp_export_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mp_export_picture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mp_export_picture.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp_export_picture.ImageIndex = 0;
            this.mp_export_picture.ImageList = this.imageList1;
            this.mp_export_picture.Location = new System.Drawing.Point(0, 0);
            this.mp_export_picture.Name = "mp_export_picture";
            this.mp_export_picture.Size = new System.Drawing.Size(25, 25);
            this.mp_export_picture.TabIndex = 0;
            this.mp_export_picture.UseVisualStyleBackColor = false;
            this.mp_export_picture.Click += new System.EventHandler(this.mp_export_picture_Click);
            this.mp_export_picture.MouseEnter += new System.EventHandler(this.mp_export_picture_MouseEnter);
            // 
            // mp_full_screen
            // 
            this.mp_full_screen.BackColor = System.Drawing.SystemColors.Control;
            this.mp_full_screen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mp_full_screen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mp_full_screen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp_full_screen.ImageIndex = 3;
            this.mp_full_screen.ImageList = this.imageList1;
            this.mp_full_screen.Location = new System.Drawing.Point(0, 0);
            this.mp_full_screen.Name = "mp_full_screen";
            this.mp_full_screen.Size = new System.Drawing.Size(25, 25);
            this.mp_full_screen.TabIndex = 0;
            this.mp_full_screen.UseVisualStyleBackColor = false;
            this.mp_full_screen.Click += new System.EventHandler(this.mp_full_screen_Click);
            this.mp_full_screen.MouseEnter += new System.EventHandler(this.mp_full_screen_MouseEnter);
            // 
            // MS_Chart
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.BorderlineColor = System.Drawing.Color.Black;
            this.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.mp_export_picture);
            this.Controls.Add(this.mp_menu);
            this.Controls.Add(this.mp_full_screen);
            this.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button mp_menu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ms_Ofoghi;
        private System.Windows.Forms.ToolStripMenuItem ms_Dayere;
        private System.Windows.Forms.ToolStripMenuItem ms_Herami;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Button mp_export_picture;
        public System.Windows.Forms.Button mp_full_screen;
    }
}
