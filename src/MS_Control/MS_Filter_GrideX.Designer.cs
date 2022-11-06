namespace MS_Control
{
    partial class MS_Filter_GrideX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MS_Filter_GrideX));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ms_tree_View = new System.Windows.Forms.TreeView();
            this.ms_filter_del = new MS_Control.Controls.MS_Button();
            this.ms_filter_add = new MS_Control.Controls.MS_Button();
            this.ms_search = new MS_Control.Controls.MS_TextBox();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search.png");
            this.imageList1.Images.SetKeyName(1, "stock_close.png");
            // 
            // ms_tree_View
            // 
            this.ms_tree_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_tree_View.BackColor = System.Drawing.Color.White;
            this.ms_tree_View.CheckBoxes = true;
            this.ms_tree_View.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_tree_View.Location = new System.Drawing.Point(0, 23);
            this.ms_tree_View.Name = "ms_tree_View";
            this.ms_tree_View.RightToLeftLayout = true;
            this.ms_tree_View.Size = new System.Drawing.Size(247, 212);
            this.ms_tree_View.TabIndex = 1;
            // 
            // ms_filter_del
            // 
            this.ms_filter_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ms_filter_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_filter_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ms_filter_del.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_filter_del.Image = ((System.Drawing.Image)(resources.GetObject("ms_filter_del.Image")));
            this.ms_filter_del.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ms_filter_del.Location = new System.Drawing.Point(3, 239);
            this.ms_filter_del.MS_BorderColor = System.Drawing.Color.Maroon;
            this.ms_filter_del.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_filter_del.MS_Change_Border_Color_On_Enter = true;
            this.ms_filter_del.MS_Change_Color_On_Enter = true;
            this.ms_filter_del.MS_Color_End = System.Drawing.Color.Empty;
            this.ms_filter_del.MS_Color_Start = System.Drawing.Color.Empty;
            this.ms_filter_del.MS_Draw_Border = true;
            this.ms_filter_del.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_filter_del.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ms_filter_del.Name = "ms_filter_del";
            this.ms_filter_del.Size = new System.Drawing.Size(104, 21);
            this.ms_filter_del.TabIndex = 216;
            this.ms_filter_del.Text = "حذف فیـلتر";
            this.ms_filter_del.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ms_filter_del.UseVisualStyleBackColor = true;
            this.ms_filter_del.Click += new System.EventHandler(this.ms_filter_del_Click);
            // 
            // ms_filter_add
            // 
            this.ms_filter_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_filter_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_filter_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ms_filter_add.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_filter_add.Image = ((System.Drawing.Image)(resources.GetObject("ms_filter_add.Image")));
            this.ms_filter_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ms_filter_add.Location = new System.Drawing.Point(140, 239);
            this.ms_filter_add.MS_BorderColor = System.Drawing.Color.Green;
            this.ms_filter_add.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_filter_add.MS_Change_Border_Color_On_Enter = true;
            this.ms_filter_add.MS_Change_Color_On_Enter = true;
            this.ms_filter_add.MS_Color_End = System.Drawing.Color.Empty;
            this.ms_filter_add.MS_Color_Start = System.Drawing.Color.Empty;
            this.ms_filter_add.MS_Draw_Border = true;
            this.ms_filter_add.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_filter_add.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_filter_add.Name = "ms_filter_add";
            this.ms_filter_add.Size = new System.Drawing.Size(104, 21);
            this.ms_filter_add.TabIndex = 218;
            this.ms_filter_add.Text = "اعـمال فیلـتر";
            this.ms_filter_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ms_filter_add.UseVisualStyleBackColor = true;
            this.ms_filter_add.Click += new System.EventHandler(this.ms_filter_add_Click);
            // 
            // ms_search
            // 
            this.ms_search.BorderStyle = Janus.Windows.GridEX.BorderStyle.None;
            this.ms_search.ButtonFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_search.ButtonImageSize = new System.Drawing.Size(16, 13);
            this.ms_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.ms_search.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_search.Image = ((System.Drawing.Image)(resources.GetObject("ms_search.Image")));
            this.ms_search.ImageIndex = 0;
            this.ms_search.ImageKey = "search.png";
            this.ms_search.ImageList = this.imageList1;
            this.ms_search.Location = new System.Drawing.Point(0, 0);
            this.ms_search.MS_BorderColor = System.Drawing.Color.Black;
            this.ms_search.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.ms_search.MS_Change_Border_Color_On_Enter = true;
            this.ms_search.MS_Change_Color_On_Enter = true;
            this.ms_search.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ms_search.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.ms_search.MS_Exit_By_Down = true;
            this.ms_search.MS_Exit_By_Enter = true;
            this.ms_search.MS_Exit_By_Up = true;
            this.ms_search.MS_Last_Control = null;
            this.ms_search.MS_Next_Control = null;
            this.ms_search.Name = "ms_search";
            this.ms_search.Size = new System.Drawing.Size(247, 20);
            this.ms_search.TabIndex = 0;
            this.ms_search.TextChanged += new System.EventHandler(this.ms_search_TextChanged);
            // 
            // MS_Filter_GrideX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ms_filter_del);
            this.Controls.Add(this.ms_filter_add);
            this.Controls.Add(this.ms_tree_View);
            this.Controls.Add(this.ms_search);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MS_Filter_GrideX";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(247, 262);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MS_TextBox ms_search;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView ms_tree_View;
        private Controls.MS_Button ms_filter_del;
        private Controls.MS_Button ms_filter_add;
    }
}
