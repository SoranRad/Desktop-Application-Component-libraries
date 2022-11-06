namespace MS_Control.Controls.Forms
{
    partial class Form_ColumnSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ColumnSetting));
            Janus.Windows.GridEX.GridEXLayout mS_GridX1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.advPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.mS_GridX1 = new MS_Control.Controls.MS_GridX();
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mS_GridX1)).BeginInit();
            this.SuspendLayout();
            // 
            // advPropertyGrid1
            // 
            this.advPropertyGrid1.BackColor = System.Drawing.Color.Gainsboro;
            this.advPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.advPropertyGrid1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.advPropertyGrid1.GridLinesColor = System.Drawing.Color.DimGray;
            this.advPropertyGrid1.HelpType = DevComponents.DotNetBar.ePropertyGridHelpType.Panel;
            this.advPropertyGrid1.IgnoredCategories = new string[] {
        "Behavior",
        "BoundImage Settings",
        "Button Style",
        "Card View",
        "CheckBox Settings",
        "ColumnSet",
        "Combo Settings",
        "Data",
        "Edit",
        "Integer UpDown Settings",
        "Misc",
        "Groups"};
            this.advPropertyGrid1.IgnoredProperties = new string[] {
        "Key",
        "Caption",
        "ColumnType",
        "EditButtonDisplayMode"};
            this.advPropertyGrid1.Location = new System.Drawing.Point(143, 0);
            this.advPropertyGrid1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.advPropertyGrid1.Name = "advPropertyGrid1";
            this.advPropertyGrid1.PropertySort = DevComponents.DotNetBar.ePropertySort.Categorized;
            this.advPropertyGrid1.Size = new System.Drawing.Size(217, 421);
            this.advPropertyGrid1.SystemText.AlphabeticalToolbarTooltip = "مرتب سازی با حروف";
            this.advPropertyGrid1.SystemText.CategorizeToolbarTooltip = "مرتب سازی با گروه بندی";
            this.advPropertyGrid1.SystemText.ErrorSettingPropertyValueTooltip = "خطا در تنظیم مقدار";
            this.advPropertyGrid1.SystemText.SearchBoxWatermarkText = "جستجوی سریع";
            this.advPropertyGrid1.TabIndex = 0;
            this.advPropertyGrid1.ToolbarVisible = false;
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(146)))), ((int)(((byte)(226)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.expandableSplitter1.ExpandableControl = this.advPropertyGrid1;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(146)))), ((int)(((byte)(226)))));
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(168)))));
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(168)))));
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(149)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(183)))));
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(146)))), ((int)(((byte)(226)))));
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(168)))));
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(146)))), ((int)(((byte)(226)))));
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(137, 0);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(6, 421);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 2;
            this.expandableSplitter1.TabStop = false;
            // 
            // mS_GridX1
            // 
            this.mS_GridX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.mS_GridX1.AlternatingColors = true;
            this.mS_GridX1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.mS_GridX1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mS_GridX1.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
            this.mS_GridX1.BuiltInTextsData = resources.GetString("mS_GridX1.BuiltInTextsData");
            this.mS_GridX1.ColumnAutoResize = true;
            this.mS_GridX1.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            mS_GridX1_DesignTimeLayout.LayoutString = resources.GetString("mS_GridX1_DesignTimeLayout.LayoutString");
            this.mS_GridX1.DesignTimeLayout = mS_GridX1_DesignTimeLayout;
            this.mS_GridX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mS_GridX1.DynamicFiltering = true;
            this.mS_GridX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.mS_GridX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.mS_GridX1.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.mS_GridX1.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mS_GridX1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.mS_GridX1.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mS_GridX1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mS_GridX1.GroupByBoxVisible = false;
            this.mS_GridX1.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.mS_GridX1.Location = new System.Drawing.Point(0, 0);
            this.mS_GridX1.Name = "mS_GridX1";
            this.mS_GridX1.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.mS_GridX1.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.mS_GridX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_GridX1.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.mS_GridX1.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mS_GridX1.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mS_GridX1.Size = new System.Drawing.Size(137, 421);
            this.mS_GridX1.TabIndex = 3;
            this.mS_GridX1.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mS_GridX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.mS_GridX1.SelectionChanged += new System.EventHandler(this.mS_GridX1_SelectionChanged);
            // 
            // Form_ColumnSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 421);
            this.Controls.Add(this.mS_GridX1);
            this.Controls.Add(this.expandableSplitter1);
            this.Controls.Add(this.advPropertyGrid1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ColumnSetting";
            this.Text = "ویرایش مشخصـات ستون هــا";
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mS_GridX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.AdvPropertyGrid advPropertyGrid1;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private MS_GridX mS_GridX1;
    }
}