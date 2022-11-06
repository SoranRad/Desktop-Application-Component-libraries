namespace MS_Control.TSDD
{
    partial class MS_Base_GridPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MS_Base_GridPopup));
            Janus.Windows.GridEX.GridEXLayout ms_grid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.ms_grid = new MS_Control.Controls.MS_GridX();
            this.mS_Tool_Strip1 = new MS_Control.Controls.MS_Tool_Strip();
            this.ms_select = new System.Windows.Forms.ToolStripButton();
            this.ms_refresh = new System.Windows.Forms.ToolStripButton();
            this.ms_filter = new System.Windows.Forms.ToolStripButton();
            this.ms_Add = new System.Windows.Forms.ToolStripButton();
            this.ms_null = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ms_grid)).BeginInit();
            this.mS_Tool_Strip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_grid
            // 
            this.ms_grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.ms_grid.AlternatingColors = true;
            this.ms_grid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.ms_grid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ms_grid.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.ms_grid.BuiltInTextsData = resources.GetString("ms_grid.BuiltInTextsData");
            this.ms_grid.ColumnAutoResize = true;
            this.ms_grid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.ms_grid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ms_grid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            this.ms_grid.DefaultForeColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Opaque;
            ms_grid_DesignTimeLayout.LayoutString = resources.GetString("ms_grid_DesignTimeLayout.LayoutString");
            this.ms_grid.DesignTimeLayout = ms_grid_DesignTimeLayout;
            this.ms_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ms_grid.DynamicFiltering = true;
            this.ms_grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.ms_grid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.ms_grid.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.ms_grid.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_grid.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.ms_grid.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
            this.ms_grid.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.ms_grid.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.ms_grid.GridLineColor = System.Drawing.Color.Black;
            this.ms_grid.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
            this.ms_grid.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.ms_grid.GroupByBoxVisible = false;
            this.ms_grid.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ms_grid.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.ms_grid.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.ms_grid.LinkFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.ms_grid.Location = new System.Drawing.Point(0, 0);
            this.ms_grid.Name = "ms_grid";
            this.ms_grid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.ms_grid.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
            this.ms_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_grid.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.ms_grid.RowHeaderFormatStyle.Font = new System.Drawing.Font("B Yekan", 9.5F, System.Drawing.FontStyle.Italic);
            this.ms_grid.RowHeaderFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.True;
            this.ms_grid.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ms_grid.ScrollBarWidth = 17;
            this.ms_grid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ms_grid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.ms_grid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ms_grid.SelectOnExpand = false;
            this.ms_grid.Size = new System.Drawing.Size(378, 291);
            this.ms_grid.TabIndex = 0;
            this.ms_grid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_grid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.ms_grid.TreeLineColor = System.Drawing.Color.Black;
            this.ms_grid.UseCompatibleTextRendering = false;
            this.ms_grid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.ms_grid.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.ms_grid_RowDoubleClick);
            this.ms_grid.Scroll += new System.EventHandler(this.ms_grid_Scroll);
            this.ms_grid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ms_grid_KeyPress);
            // 
            // mS_Tool_Strip1
            // 
            this.mS_Tool_Strip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mS_Tool_Strip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mS_Tool_Strip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_select,
            this.ms_refresh,
            this.ms_filter,
            this.ms_Add,
            this.ms_null});
            this.mS_Tool_Strip1.Location = new System.Drawing.Point(0, 291);
            this.mS_Tool_Strip1.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.mS_Tool_Strip1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Tool_Strip1.MS_Color_End = System.Drawing.Color.LightBlue;
            this.mS_Tool_Strip1.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
            this.mS_Tool_Strip1.Name = "mS_Tool_Strip1";
            this.mS_Tool_Strip1.Size = new System.Drawing.Size(378, 25);
            this.mS_Tool_Strip1.TabIndex = 1;
            this.mS_Tool_Strip1.Text = "mS_Tool_Strip1";
            // 
            // ms_select
            // 
            this.ms_select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_select.Image = global::MS_Control.Properties.Resources.tick_button;
            this.ms_select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_select.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.ms_select.Name = "ms_select";
            this.ms_select.Size = new System.Drawing.Size(23, 25);
            this.ms_select.Text = "انتخـاب ردیف";
            this.ms_select.Click += new System.EventHandler(this.ms_select_Click);
            // 
            // ms_refresh
            // 
            this.ms_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_refresh.Image = global::MS_Control.Properties.Resources.refresh;
            this.ms_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_refresh.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ms_refresh.Name = "ms_refresh";
            this.ms_refresh.Size = new System.Drawing.Size(23, 25);
            this.ms_refresh.Text = "بارگذاری مجدد لیسـت";
            // 
            // ms_filter
            // 
            this.ms_filter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_filter.Image = global::MS_Control.Properties.Resources.filter;
            this.ms_filter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_filter.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ms_filter.Name = "ms_filter";
            this.ms_filter.Size = new System.Drawing.Size(23, 25);
            this.ms_filter.Text = "فعال کردن فیلتر در ستون ها";
            this.ms_filter.Click += new System.EventHandler(this.ms_filter_Click);
            // 
            // ms_Add
            // 
            this.ms_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_Add.Image = global::MS_Control.Properties.Resources.plus_button;
            this.ms_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_Add.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.ms_Add.Name = "ms_Add";
            this.ms_Add.Size = new System.Drawing.Size(23, 25);
            this.ms_Add.Text = "افزودن مورد جدید";
            this.ms_Add.ToolTipText = "افزودن مورد جدید";
            this.ms_Add.Click += new System.EventHandler(this.ms_Add_Click);
            // 
            // ms_null
            // 
            this.ms_null.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_null.Image = global::MS_Control.Properties.Resources.cross_button;
            this.ms_null.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_null.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ms_null.Name = "ms_null";
            this.ms_null.Size = new System.Drawing.Size(23, 25);
            this.ms_null.Text = "خالی کردن انتخاب";
            this.ms_null.Click += new System.EventHandler(this.ms_null_Click);
            // 
            // MS_Base_GridPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ms_grid);
            this.Controls.Add(this.mS_Tool_Strip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MS_Base_GridPopup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(378, 316);
            ((System.ComponentModel.ISupportInitialize)(this.ms_grid)).EndInit();
            this.mS_Tool_Strip1.ResumeLayout(false);
            this.mS_Tool_Strip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolStripButton ms_Add;
        public System.Windows.Forms.ToolStripButton ms_select;
        public System.Windows.Forms.ToolStripButton ms_null;
        public System.Windows.Forms.ToolStripButton ms_refresh;
        public System.Windows.Forms.ToolStripButton ms_filter;
        public Controls.MS_GridX ms_grid;
        public Controls.MS_Tool_Strip mS_Tool_Strip1;
    }
}
