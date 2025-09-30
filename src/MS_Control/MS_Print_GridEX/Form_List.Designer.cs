namespace MS_Grid_Print
{
    partial class Form_List
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_List));
			Janus.Windows.GridEX.GridEXLayout ms_GridColumns_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem5 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem6 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.GridEX.GridEXLayout ms_grid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.Common.Layouts.JanusLayoutReference ms_grid_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference ms_grid_DesignTimeLayout_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
			this.superTabControl2 = new DevComponents.DotNetBar.SuperTabControl();
			this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
			this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
			this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
			this.mS_Panel1 = new MS_Control.Controls.MS_Panel();
			this.NzSelectorRows = new System.Windows.Forms.CheckBox();
			this.ms_GridColumns = new MS_Control.Controls.MS_GridX();
			this.ms_page_segment = new System.Windows.Forms.CheckBox();
			this.ms_RefreshReport = new Janus.Windows.EditControls.UIButton();
			this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
			this.ms_landscape = new MS_Control.Controls.MS_ComboBox_Janus();
			this.ms_paper_size = new MS_Control.Controls.MS_ComboBox_Janus();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ms_fix_Col = new System.Windows.Forms.CheckBox();
			this.ms_header_Color = new System.Windows.Forms.CheckBox();
			this.ms_alternative = new System.Windows.Forms.CheckBox();
			this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
			this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
			this.ms_grid = new MS_Control.Controls.MS_GridX();
			this.superTabItem4 = new DevComponents.DotNetBar.SuperTabItem();
			this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
			this.NsShrink = new MS_Control.Controls.MS_RadioBox();
			this.NsGrow = new MS_Control.Controls.MS_RadioBox();
			((System.ComponentModel.ISupportInitialize)(this.superTabControl2)).BeginInit();
			this.superTabControl2.SuspendLayout();
			this.superTabControlPanel3.SuspendLayout();
			this.mS_Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ms_GridColumns)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
			this.uiGroupBox1.SuspendLayout();
			this.superTabControlPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ms_grid)).BeginInit();
			this.SuspendLayout();
			// 
			// superTabControl2
			// 
			this.superTabControl2.AutoCloseTabs = false;
			this.superTabControl2.CloseButtonOnTabsAlwaysDisplayed = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.superTabControl2.ControlBox.CloseBox.Name = "";
			// 
			// 
			// 
			this.superTabControl2.ControlBox.MenuBox.Name = "";
			this.superTabControl2.ControlBox.MenuBox.Visible = false;
			this.superTabControl2.ControlBox.Name = "";
			this.superTabControl2.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl2.ControlBox.MenuBox,
            this.superTabControl2.ControlBox.CloseBox});
			this.superTabControl2.ControlBox.Visible = false;
			this.superTabControl2.Controls.Add(this.superTabControlPanel3);
			this.superTabControl2.Controls.Add(this.superTabControlPanel4);
			this.superTabControl2.Controls.Add(this.superTabControlPanel1);
			this.superTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.superTabControl2.Location = new System.Drawing.Point(0, 0);
			this.superTabControl2.Name = "superTabControl2";
			this.superTabControl2.ReorderTabsEnabled = true;
			this.superTabControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.superTabControl2.SelectedTabFont = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
			this.superTabControl2.SelectedTabIndex = 1;
			this.superTabControl2.Size = new System.Drawing.Size(1026, 634);
			this.superTabControl2.TabFont = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.superTabControl2.TabHorizontalSpacing = 10;
			this.superTabControl2.TabIndex = 3;
			this.superTabControl2.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.MultiLine;
			this.superTabControl2.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem3,
            this.superTabItem4});
			this.superTabControl2.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Document;
			this.superTabControl2.TabVerticalSpacing = 6;
			this.superTabControl2.Text = "superTabControl2";
			this.superTabControl2.TextAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
			// 
			// superTabControlPanel3
			// 
			this.superTabControlPanel3.AutoScroll = true;
			this.superTabControlPanel3.Controls.Add(this.stiViewerControl1);
			this.superTabControlPanel3.Controls.Add(this.expandableSplitter1);
			this.superTabControlPanel3.Controls.Add(this.mS_Panel1);
			this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.superTabControlPanel3.Location = new System.Drawing.Point(0, 32);
			this.superTabControlPanel3.Name = "superTabControlPanel3";
			this.superTabControlPanel3.Size = new System.Drawing.Size(1026, 602);
			this.superTabControlPanel3.TabIndex = 1;
			this.superTabControlPanel3.TabItem = this.superTabItem3;
			// 
			// stiViewerControl1
			// 
			this.stiViewerControl1.AllowDrop = true;
			this.stiViewerControl1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.stiViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stiViewerControl1.Location = new System.Drawing.Point(0, 0);
			this.stiViewerControl1.Name = "stiViewerControl1";
			this.stiViewerControl1.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.SinglePage;
			this.stiViewerControl1.Report = null;
			this.stiViewerControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.stiViewerControl1.ShowBookmarksPanel = false;
			this.stiViewerControl1.ShowCloseButton = false;
			this.stiViewerControl1.ShowEditor = false;
			this.stiViewerControl1.ShowFind = false;
			this.stiViewerControl1.ShowOpen = false;
			this.stiViewerControl1.ShowPageDelete = false;
			this.stiViewerControl1.ShowPageDesign = false;
			this.stiViewerControl1.ShowPageNew = false;
			this.stiViewerControl1.ShowPageSize = false;
			this.stiViewerControl1.ShowThumbsPanel = false;
			this.stiViewerControl1.ShowZoom = true;
			this.stiViewerControl1.Size = new System.Drawing.Size(739, 602);
			this.stiViewerControl1.TabIndex = 1;
			this.stiViewerControl1.ThumbsPanelEnabled = false;
			// 
			// expandableSplitter1
			// 
			this.expandableSplitter1.AnimationTime = 250;
			this.expandableSplitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
			this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
			this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Right;
			this.expandableSplitter1.ExpandableControl = this.mS_Panel1;
			this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
			this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
			this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
			this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
			this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
			this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
			this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
			this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
			this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
			this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.expandableSplitter1.Location = new System.Drawing.Point(739, 0);
			this.expandableSplitter1.MinExtra = 250;
			this.expandableSplitter1.MinSize = 250;
			this.expandableSplitter1.Name = "expandableSplitter1";
			this.expandableSplitter1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.expandableSplitter1.Size = new System.Drawing.Size(6, 602);
			this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
			this.expandableSplitter1.TabIndex = 4;
			this.expandableSplitter1.TabStop = false;
			// 
			// mS_Panel1
			// 
			this.mS_Panel1.Controls.Add(this.NsGrow);
			this.mS_Panel1.Controls.Add(this.NsShrink);
			this.mS_Panel1.Controls.Add(this.NzSelectorRows);
			this.mS_Panel1.Controls.Add(this.ms_GridColumns);
			this.mS_Panel1.Controls.Add(this.ms_page_segment);
			this.mS_Panel1.Controls.Add(this.ms_RefreshReport);
			this.mS_Panel1.Controls.Add(this.uiGroupBox1);
			this.mS_Panel1.Controls.Add(this.ms_fix_Col);
			this.mS_Panel1.Controls.Add(this.ms_header_Color);
			this.mS_Panel1.Controls.Add(this.ms_alternative);
			this.mS_Panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.mS_Panel1.Location = new System.Drawing.Point(745, 0);
			this.mS_Panel1.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_Panel1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Panel1.MS_Color_End = System.Drawing.Color.WhiteSmoke;
			this.mS_Panel1.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
			this.mS_Panel1.Name = "mS_Panel1";
			this.mS_Panel1.Size = new System.Drawing.Size(281, 602);
			this.mS_Panel1.TabIndex = 0;
			// 
			// NzSelectorRows
			// 
			this.NzSelectorRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzSelectorRows.AutoSize = true;
			this.NzSelectorRows.BackColor = System.Drawing.Color.Transparent;
			this.NzSelectorRows.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzSelectorRows.Location = new System.Drawing.Point(105, 168);
			this.NzSelectorRows.Name = "NzSelectorRows";
			this.NzSelectorRows.Size = new System.Drawing.Size(171, 18);
			this.NzSelectorRows.TabIndex = 7;
			this.NzSelectorRows.Text = "فقط ردیف های تیک زده شده";
			this.NzSelectorRows.UseVisualStyleBackColor = false;
			this.NzSelectorRows.CheckedChanged += new System.EventHandler(this.ms_fix_Col_CheckedChanged);
			// 
			// ms_GridColumns
			// 
			this.ms_GridColumns.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.ms_GridColumns.AlternatingColors = true;
			this.ms_GridColumns.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ms_GridColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ms_GridColumns.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ms_GridColumns.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
			this.ms_GridColumns.BuiltInTextsData = resources.GetString("ms_GridColumns.BuiltInTextsData");
			this.ms_GridColumns.ColumnAutoResize = true;
			this.ms_GridColumns.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
			this.ms_GridColumns.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.ms_GridColumns.Cursor = System.Windows.Forms.Cursors.Default;
			this.ms_GridColumns.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			ms_GridColumns_DesignTimeLayout.LayoutString = resources.GetString("ms_GridColumns_DesignTimeLayout.LayoutString");
			this.ms_GridColumns.DesignTimeLayout = ms_GridColumns_DesignTimeLayout;
			this.ms_GridColumns.DynamicFiltering = true;
			this.ms_GridColumns.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell;
			this.ms_GridColumns.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.ms_GridColumns.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.ms_GridColumns.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ms_GridColumns.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.ms_GridColumns.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.ms_GridColumns.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.ms_GridColumns.Font = new System.Drawing.Font("Tahoma", 10.5F);
			this.ms_GridColumns.GridLineColor = System.Drawing.Color.Black;
			this.ms_GridColumns.GridLines = Janus.Windows.GridEX.GridLines.None;
			this.ms_GridColumns.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.ms_GridColumns.GroupByBoxVisible = false;
			this.ms_GridColumns.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ms_GridColumns.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.ms_GridColumns.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.ms_GridColumns.Location = new System.Drawing.Point(1, 244);
			this.ms_GridColumns.Name = "ms_GridColumns";
			this.ms_GridColumns.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.ms_GridColumns.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.ms_GridColumns.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ms_GridColumns.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.ms_GridColumns.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ms_GridColumns.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.ms_GridColumns.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ms_GridColumns.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
			this.ms_GridColumns.SelectOnExpand = false;
			this.ms_GridColumns.Size = new System.Drawing.Size(279, 357);
			this.ms_GridColumns.TabIndex = 0;
			this.ms_GridColumns.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ms_GridColumns.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.ms_GridColumns.TreeLineColor = System.Drawing.Color.Black;
			this.ms_GridColumns.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.ms_GridColumns.RecordUpdated += new System.EventHandler(this.ms_GridColumns_RecordUpdated);
			// 
			// ms_page_segment
			// 
			this.ms_page_segment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ms_page_segment.AutoSize = true;
			this.ms_page_segment.BackColor = System.Drawing.Color.Transparent;
			this.ms_page_segment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ms_page_segment.Location = new System.Drawing.Point(72, 144);
			this.ms_page_segment.Name = "ms_page_segment";
			this.ms_page_segment.Size = new System.Drawing.Size(204, 18);
			this.ms_page_segment.TabIndex = 5;
			this.ms_page_segment.Text = "درج صفحات مورد نیاز به صورت افقی";
			this.ms_page_segment.UseVisualStyleBackColor = false;
			this.ms_page_segment.CheckedChanged += new System.EventHandler(this.ms_fix_Col_CheckedChanged);
			// 
			// ms_RefreshReport
			// 
			this.ms_RefreshReport.FlatBorderColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ms_RefreshReport.Image = global::MS_Control.Properties.Resources.refresh;
			this.ms_RefreshReport.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center;
			this.ms_RefreshReport.Location = new System.Drawing.Point(3, 217);
			this.ms_RefreshReport.Name = "ms_RefreshReport";
			this.ms_RefreshReport.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Blue;
			this.ms_RefreshReport.Office2007CustomColor = System.Drawing.Color.ForestGreen;
			this.ms_RefreshReport.ShowFocusRectangle = false;
			this.ms_RefreshReport.Size = new System.Drawing.Size(35, 24);
			this.ms_RefreshReport.TabIndex = 6;
			this.ms_RefreshReport.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.ms_RefreshReport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.ms_RefreshReport.Click += new System.EventHandler(this.ms_landscape_SelectedIndexChanged);
			// 
			// uiGroupBox1
			// 
			this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.uiGroupBox1.BorderColor = System.Drawing.Color.SteelBlue;
			this.uiGroupBox1.Controls.Add(this.ms_landscape);
			this.uiGroupBox1.Controls.Add(this.ms_paper_size);
			this.uiGroupBox1.Controls.Add(this.label3);
			this.uiGroupBox1.Controls.Add(this.label1);
			this.uiGroupBox1.Location = new System.Drawing.Point(5, 0);
			this.uiGroupBox1.Name = "uiGroupBox1";
			this.uiGroupBox1.Size = new System.Drawing.Size(271, 67);
			this.uiGroupBox1.TabIndex = 1;
			this.uiGroupBox1.Text = "اندازه";
			// 
			// ms_landscape
			// 
			this.ms_landscape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ms_landscape.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.ms_landscape.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ms_landscape.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			uiComboBoxItem5.FormatStyle.Alpha = 0;
			uiComboBoxItem5.Image = ((System.Drawing.Image)(resources.GetObject("uiComboBoxItem5.Image")));
			uiComboBoxItem5.IsSeparator = false;
			uiComboBoxItem5.Text = "عـمـودی";
			uiComboBoxItem6.FormatStyle.Alpha = 0;
			uiComboBoxItem6.Image = ((System.Drawing.Image)(resources.GetObject("uiComboBoxItem6.Image")));
			uiComboBoxItem6.IsSeparator = false;
			uiComboBoxItem6.Text = "افـقـی";
			this.ms_landscape.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem5,
            uiComboBoxItem6});
			this.ms_landscape.Location = new System.Drawing.Point(38, 39);
			this.ms_landscape.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.ms_landscape.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.ms_landscape.MS_Change_Border_Color_On_Enter = false;
			this.ms_landscape.MS_Change_Color_On_Enter = false;
			this.ms_landscape.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.ms_landscape.MS_Enter_Color = System.Drawing.Color.Empty;
			this.ms_landscape.MS_Exit_By_Down = false;
			this.ms_landscape.MS_Exit_By_Enter = false;
			this.ms_landscape.MS_Exit_By_Up = false;
			this.ms_landscape.MS_Last_Control = null;
			this.ms_landscape.MS_Next_Control = null;
			this.ms_landscape.Name = "ms_landscape";
			this.ms_landscape.Size = new System.Drawing.Size(122, 23);
			this.ms_landscape.TabIndex = 1;
			this.ms_landscape.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.ms_landscape.SelectedIndexChanged += new System.EventHandler(this.ms_landscape_SelectedIndexChanged_1);
			// 
			// ms_paper_size
			// 
			this.ms_paper_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ms_paper_size.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.ms_paper_size.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ms_paper_size.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			uiComboBoxItem1.FormatStyle.Alpha = 0;
			uiComboBoxItem1.IsSeparator = false;
			uiComboBoxItem1.Text = "A4";
			uiComboBoxItem2.FormatStyle.Alpha = 0;
			uiComboBoxItem2.IsSeparator = false;
			uiComboBoxItem2.Text = "A5";
			this.ms_paper_size.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1,
            uiComboBoxItem2});
			this.ms_paper_size.Location = new System.Drawing.Point(38, 12);
			this.ms_paper_size.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.ms_paper_size.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.ms_paper_size.MS_Change_Border_Color_On_Enter = false;
			this.ms_paper_size.MS_Change_Color_On_Enter = false;
			this.ms_paper_size.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.ms_paper_size.MS_Enter_Color = System.Drawing.Color.Empty;
			this.ms_paper_size.MS_Exit_By_Down = false;
			this.ms_paper_size.MS_Exit_By_Enter = false;
			this.ms_paper_size.MS_Exit_By_Up = false;
			this.ms_paper_size.MS_Last_Control = null;
			this.ms_paper_size.MS_Next_Control = null;
			this.ms_paper_size.Name = "ms_paper_size";
			this.ms_paper_size.Size = new System.Drawing.Size(122, 23);
			this.ms_paper_size.TabIndex = 0;
			this.ms_paper_size.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.ms_paper_size.SelectedIndexChanged += new System.EventHandler(this.ms_landscape_SelectedIndexChanged_1);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label3.Location = new System.Drawing.Point(160, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "حـالت :";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.Location = new System.Drawing.Point(159, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "نوع کاغذ :";
			// 
			// ms_fix_Col
			// 
			this.ms_fix_Col.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ms_fix_Col.AutoSize = true;
			this.ms_fix_Col.BackColor = System.Drawing.Color.Transparent;
			this.ms_fix_Col.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ms_fix_Col.Location = new System.Drawing.Point(73, 119);
			this.ms_fix_Col.Name = "ms_fix_Col";
			this.ms_fix_Col.Size = new System.Drawing.Size(203, 18);
			this.ms_fix_Col.TabIndex = 4;
			this.ms_fix_Col.Text = "درج کلیه ستون هـا به نسبت صفحه";
			this.ms_fix_Col.UseVisualStyleBackColor = false;
			this.ms_fix_Col.CheckedChanged += new System.EventHandler(this.ms_fix_Col_CheckedChanged);
			// 
			// ms_header_Color
			// 
			this.ms_header_Color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ms_header_Color.AutoSize = true;
			this.ms_header_Color.BackColor = System.Drawing.Color.Transparent;
			this.ms_header_Color.Checked = true;
			this.ms_header_Color.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ms_header_Color.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ms_header_Color.Location = new System.Drawing.Point(129, 94);
			this.ms_header_Color.Name = "ms_header_Color";
			this.ms_header_Color.Size = new System.Drawing.Size(147, 18);
			this.ms_header_Color.TabIndex = 3;
			this.ms_header_Color.Text = "تغییـر رنگ سر ستون هـا";
			this.ms_header_Color.UseVisualStyleBackColor = false;
			this.ms_header_Color.CheckedChanged += new System.EventHandler(this.ms_landscape_SelectedIndexChanged);
			// 
			// ms_alternative
			// 
			this.ms_alternative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ms_alternative.AutoSize = true;
			this.ms_alternative.BackColor = System.Drawing.Color.Transparent;
			this.ms_alternative.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ms_alternative.Location = new System.Drawing.Point(166, 69);
			this.ms_alternative.Name = "ms_alternative";
			this.ms_alternative.Size = new System.Drawing.Size(110, 18);
			this.ms_alternative.TabIndex = 2;
			this.ms_alternative.Text = "یک در میان رنگی";
			this.ms_alternative.UseVisualStyleBackColor = false;
			this.ms_alternative.CheckedChanged += new System.EventHandler(this.ms_landscape_SelectedIndexChanged);
			// 
			// superTabItem3
			// 
			this.superTabItem3.AttachedControl = this.superTabControlPanel3;
			this.superTabItem3.GlobalItem = false;
			this.superTabItem3.Name = "superTabItem3";
			this.superTabItem3.Text = "تغییر چـاپ";
			// 
			// superTabControlPanel4
			// 
			this.superTabControlPanel4.Controls.Add(this.ms_grid);
			this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.superTabControlPanel4.Location = new System.Drawing.Point(0, 32);
			this.superTabControlPanel4.Name = "superTabControlPanel4";
			this.superTabControlPanel4.Size = new System.Drawing.Size(1026, 602);
			this.superTabControlPanel4.TabIndex = 0;
			this.superTabControlPanel4.TabItem = this.superTabItem4;
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
			this.ms_grid.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
			this.ms_grid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.ms_grid.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.ms_grid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			this.ms_grid.DefaultForeColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Opaque;
			ms_grid_DesignTimeLayout_Reference_0.Instance = ((object)(resources.GetObject("ms_grid_DesignTimeLayout_Reference_0.Instance")));
			ms_grid_DesignTimeLayout_Reference_1.Instance = ((object)(resources.GetObject("ms_grid_DesignTimeLayout_Reference_1.Instance")));
			ms_grid_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            ms_grid_DesignTimeLayout_Reference_0,
            ms_grid_DesignTimeLayout_Reference_1});
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
			this.ms_grid.RowHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Italic);
			this.ms_grid.RowHeaderFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.True;
			this.ms_grid.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.ms_grid.ScrollBarWidth = 17;
			this.ms_grid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ms_grid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.ms_grid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ms_grid.SelectOnExpand = false;
			this.ms_grid.Size = new System.Drawing.Size(1026, 602);
			this.ms_grid.TabIndex = 1;
			this.ms_grid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ms_grid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.ms_grid.TreeLineColor = System.Drawing.Color.Black;
			this.ms_grid.UseCompatibleTextRendering = false;
			this.ms_grid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// superTabItem4
			// 
			this.superTabItem4.AttachedControl = this.superTabControlPanel4;
			this.superTabItem4.GlobalItem = false;
			this.superTabItem4.Name = "superTabItem4";
			this.superTabItem4.Text = "لیـست گزارشـات";
			this.superTabItem4.Visible = false;
			// 
			// superTabControlPanel1
			// 
			this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.superTabControlPanel1.Location = new System.Drawing.Point(0, 0);
			this.superTabControlPanel1.Name = "superTabControlPanel1";
			this.superTabControlPanel1.Size = new System.Drawing.Size(1026, 634);
			this.superTabControlPanel1.TabIndex = 0;
			// 
			// NsShrink
			// 
			this.NsShrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsShrink.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsShrink.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsShrink.Location = new System.Drawing.Point(64, 219);
			this.NsShrink.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NsShrink.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsShrink.MS_Change_Border_Color_On_Enter = false;
			this.NsShrink.MS_Change_Color_On_Checked = false;
			this.NsShrink.MS_Change_Color_On_Enter = false;
			this.NsShrink.MS_Checked_Color = System.Drawing.Color.Empty;
			this.NsShrink.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsShrink.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsShrink.MS_Exit_By_Down = false;
			this.NsShrink.MS_Exit_By_Enter = false;
			this.NsShrink.MS_Exit_By_Up = false;
			this.NsShrink.MS_Last_Control = null;
			this.NsShrink.MS_Next_Control = null;
			this.NsShrink.MS_UnChecked_Color = System.Drawing.Color.Empty;
			this.NsShrink.Name = "NsShrink";
			this.NsShrink.Size = new System.Drawing.Size(201, 23);
			this.NsShrink.TabIndex = 8;
			this.NsShrink.Text = " متن برای نمایش کامل کوچک شود";
			// 
			// NsGrow
			// 
			this.NsGrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsGrow.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsGrow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsGrow.Location = new System.Drawing.Point(64, 192);
			this.NsGrow.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NsGrow.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsGrow.MS_Change_Border_Color_On_Enter = false;
			this.NsGrow.MS_Change_Color_On_Checked = false;
			this.NsGrow.MS_Change_Color_On_Enter = false;
			this.NsGrow.MS_Checked_Color = System.Drawing.Color.Empty;
			this.NsGrow.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsGrow.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsGrow.MS_Exit_By_Down = false;
			this.NsGrow.MS_Exit_By_Enter = false;
			this.NsGrow.MS_Exit_By_Up = false;
			this.NsGrow.MS_Last_Control = null;
			this.NsGrow.MS_Next_Control = null;
			this.NsGrow.MS_UnChecked_Color = System.Drawing.Color.Empty;
			this.NsGrow.Name = "NsGrow";
			this.NsGrow.Size = new System.Drawing.Size(201, 23);
			this.NsGrow.TabIndex = 8;
			this.NsGrow.Text = " متن در چند خط شکسته شود";
			// 
			// Form_List
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1026, 634);
			this.Controls.Add(this.superTabControl2);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Form_List";
			this.Text = "تهیـه چـاپ گزارش";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_List_FormClosed);
			this.Shown += new System.EventHandler(this.Form_List_Shown);
			((System.ComponentModel.ISupportInitialize)(this.superTabControl2)).EndInit();
			this.superTabControl2.ResumeLayout(false);
			this.superTabControlPanel3.ResumeLayout(false);
			this.mS_Panel1.ResumeLayout(false);
			this.mS_Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ms_GridColumns)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
			this.uiGroupBox1.ResumeLayout(false);
			this.uiGroupBox1.PerformLayout();
			this.superTabControlPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ms_grid)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControl2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem superTabItem3;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabItem superTabItem4;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private MS_Control.Controls.MS_Panel mS_Panel1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private MS_Control.Controls.MS_ComboBox_Janus ms_landscape;
        private MS_Control.Controls.MS_ComboBox_Janus ms_paper_size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ms_header_Color;
        private System.Windows.Forms.CheckBox ms_alternative;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
        public MS_Control.Controls.MS_GridX ms_grid;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private Janus.Windows.EditControls.UIButton ms_RefreshReport;
        private System.Windows.Forms.CheckBox ms_fix_Col;
        private System.Windows.Forms.CheckBox ms_page_segment;
        private MS_Control.Controls.MS_GridX ms_GridColumns;
        private System.Windows.Forms.CheckBox NzSelectorRows;
		private MS_Control.Controls.MS_RadioBox NsShrink;
		private MS_Control.Controls.MS_RadioBox NsGrow;
	}
}