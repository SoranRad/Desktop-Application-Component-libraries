namespace MS_Control.Controls
{
    partial class MS_GridX_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MS_GridX_Setting));
            this.ms_filter = new System.Windows.Forms.ToolStripButton();
            this.ms_group_Box = new System.Windows.Forms.ToolStripButton();
            this.ms_auto_size = new System.Windows.Forms.ToolStripButton();
            this.ms_total = new System.Windows.Forms.ToolStripSplitButton();
            this.ms_CurrentColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_sum = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_max = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_min = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_avg = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_count = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_filter_advanced = new System.Windows.Forms.ToolStripButton();
            this.ms_col_filter = new System.Windows.Forms.ToolStripSplitButton();
            this.ms_excel = new System.Windows.Forms.ToolStripButton();
            this.ms_print = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gridEXPrintDocument1 = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.gridEXExporter1 = new Janus.Windows.GridEX.Export.GridEXExporter(this.components);
            this.ms_group_total = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_active_total = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ms_chart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_filter_text = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ms_column_filter = new MS_Control.MS_Filter_GrideX();
            this.ms_ChooseField = new System.Windows.Forms.ToolStripButton();
            this.ms_Settings = new System.Windows.Forms.ToolStripButton();
            this.ms_saveSettings = new System.Windows.Forms.ToolStripButton();
            this.ms_ResetSetting = new System.Windows.Forms.ToolStripButton();
            this.SuspendLayout();
            // 
            // ms_filter
            // 
            this.ms_filter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_filter.Image = global::MS_Control.Properties.Resources.btn_Filter;
            this.ms_filter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_filter.Name = "ms_filter";
            this.ms_filter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_filter.Size = new System.Drawing.Size(23, 22);
            this.ms_filter.ToolTipText = "افــزودن حــالـت فیـلتر";
            this.ms_filter.Click += new System.EventHandler(this.ms_filter_Click);
            // 
            // ms_group_Box
            // 
            this.ms_group_Box.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_group_Box.Image = global::MS_Control.Properties.Resources.btn_Group_Box;
            this.ms_group_Box.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_group_Box.Name = "ms_group_Box";
            this.ms_group_Box.Size = new System.Drawing.Size(23, 20);
            this.ms_group_Box.ToolTipText = "فـعـال کـردن گروه بندی سطرهای جـدول";
            this.ms_group_Box.Click += new System.EventHandler(this.ms_group_Box_Click);
            // 
            // ms_auto_size
            // 
            this.ms_auto_size.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_auto_size.Image = global::MS_Control.Properties.Resources.btn_Outo_Resize;
            this.ms_auto_size.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_auto_size.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.ms_auto_size.Name = "ms_auto_size";
            this.ms_auto_size.Size = new System.Drawing.Size(23, 20);
            this.ms_auto_size.Text = "مرتب سازی عرض ستون ها";
            this.ms_auto_size.Click += new System.EventHandler(this.ms_auto_size_Click);
            // 
            // ms_total
            // 
            this.ms_total.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_total.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_CurrentColumn,
            this.toolStripSeparator6,
            this.ms_sum,
            this.ms_max,
            this.ms_min,
            this.ms_avg,
            this.ms_count});
            this.ms_total.Image = global::MS_Control.Properties.Resources.sum;
            this.ms_total.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_total.Name = "ms_total";
            this.ms_total.Size = new System.Drawing.Size(32, 20);
            this.ms_total.ToolTipText = "نمـایش ته جــمع برای سـتون";
            this.ms_total.ButtonClick += new System.EventHandler(this.ms_total_ButtonClick);
            this.ms_total.DropDownOpened += new System.EventHandler(this.ms_total_DropDownOpened);
            // 
            // ms_CurrentColumn
            // 
            this.ms_CurrentColumn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ms_CurrentColumn.Image = global::MS_Control.Properties.Resources.table_select_column;
            this.ms_CurrentColumn.Name = "ms_CurrentColumn";
            this.ms_CurrentColumn.Size = new System.Drawing.Size(152, 22);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // ms_sum
            // 
            this.ms_sum.Image = global::MS_Control.Properties.Resources.sum;
            this.ms_sum.Name = "ms_sum";
            this.ms_sum.Size = new System.Drawing.Size(152, 22);
            this.ms_sum.Text = "مجـمـوع";
            this.ms_sum.Click += new System.EventHandler(this.ms_sum_Click);
            // 
            // ms_max
            // 
            this.ms_max.Image = global::MS_Control.Properties.Resources.max;
            this.ms_max.Name = "ms_max";
            this.ms_max.Size = new System.Drawing.Size(152, 22);
            this.ms_max.Text = "بیـشـترین مقــدار";
            this.ms_max.ToolTipText = "بیـشـترین مقــدار";
            this.ms_max.Click += new System.EventHandler(this.ms_max_Click);
            // 
            // ms_min
            // 
            this.ms_min.Image = global::MS_Control.Properties.Resources.min;
            this.ms_min.Name = "ms_min";
            this.ms_min.Size = new System.Drawing.Size(152, 22);
            this.ms_min.Text = "کــمـتریـن مقـدار";
            this.ms_min.Click += new System.EventHandler(this.ms_min_Click);
            // 
            // ms_avg
            // 
            this.ms_avg.Image = global::MS_Control.Properties.Resources.avg;
            this.ms_avg.Name = "ms_avg";
            this.ms_avg.Size = new System.Drawing.Size(152, 22);
            this.ms_avg.Text = "میانگیـن";
            this.ms_avg.Click += new System.EventHandler(this.ms_avg_Click);
            // 
            // ms_count
            // 
            this.ms_count.Image = global::MS_Control.Properties.Resources.column_single;
            this.ms_count.Name = "ms_count";
            this.ms_count.Size = new System.Drawing.Size(152, 22);
            this.ms_count.Text = "تعداد سطرهـا";
            this.ms_count.Click += new System.EventHandler(this.ms_count_Click);
            // 
            // ms_filter_advanced
            // 
            this.ms_filter_advanced.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_filter_advanced.Image = global::MS_Control.Properties.Resources.table_filter;
            this.ms_filter_advanced.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_filter_advanced.Name = "ms_filter_advanced";
            this.ms_filter_advanced.Size = new System.Drawing.Size(23, 22);
            this.ms_filter_advanced.ToolTipText = "فیـلـتر کردن پیشــرفـته";
            this.ms_filter_advanced.Click += new System.EventHandler(this.ms_filter_advanced_Click);
            // 
            // ms_col_filter
            // 
            this.ms_col_filter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_col_filter.DropDownButtonWidth = 13;
            this.ms_col_filter.Image = global::MS_Control.Properties.Resources.table_sort_filter;
            this.ms_col_filter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_col_filter.Name = "ms_col_filter";
            this.ms_col_filter.Size = new System.Drawing.Size(34, 20);
            this.ms_col_filter.ToolTipText = "فیـلـتر کردن مقـادیر سـتون";
            this.ms_col_filter.ButtonClick += new System.EventHandler(this.ms_col_filter_ButtonClick);
            this.ms_col_filter.DropDownOpening += new System.EventHandler(this.ms_col_filter_DropDownOpening);
            // 
            // ms_excel
            // 
            this.ms_excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_excel.Image = ((System.Drawing.Image)(resources.GetObject("ms_excel.Image")));
            this.ms_excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_excel.Name = "ms_excel";
            this.ms_excel.Size = new System.Drawing.Size(23, 20);
            this.ms_excel.ToolTipText = "ارسـال خروجی به اکسل";
            this.ms_excel.Click += new System.EventHandler(this.ms_excel_Click);
            // 
            // ms_print
            // 
            this.ms_print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_print.Image = global::MS_Control.Properties.Resources.printer;
            this.ms_print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_print.Name = "ms_print";
            this.ms_print.Size = new System.Drawing.Size(23, 20);
            this.ms_print.Text = "چـاپ لیسـت به صورت دلخواه";
            this.ms_print.Click += new System.EventHandler(this.ms_print_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.gridEXPrintDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // gridEXPrintDocument1
            // 
            this.gridEXPrintDocument1.ExpandFarColumn = false;
            this.gridEXPrintDocument1.OriginAtMargins = true;
            // 
            // gridEXExporter1
            // 
            this.gridEXExporter1.SheetName = "نگین زاگرس";
            // 
            // ms_group_total
            // 
            this.ms_group_total.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_group_total.Image = global::MS_Control.Properties.Resources.category_group;
            this.ms_group_total.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_group_total.Name = "ms_group_total";
            this.ms_group_total.Size = new System.Drawing.Size(23, 20);
            this.ms_group_total.Text = "افزودن ته جمع به گروه سطرهـا";
            this.ms_group_total.Click += new System.EventHandler(this.ms_group_total_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // ms_active_total
            // 
            this.ms_active_total.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_active_total.Image = global::MS_Control.Properties.Resources.Summary_16x16;
            this.ms_active_total.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_active_total.Name = "ms_active_total";
            this.ms_active_total.Size = new System.Drawing.Size(23, 20);
            this.ms_active_total.Text = "toolStripButton1";
            this.ms_active_total.ToolTipText = "فعال کردن ته جمع";
            this.ms_active_total.Click += new System.EventHandler(this.ms_active_total_Click);
            // 
            // ms_chart
            // 
            this.ms_chart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_chart.Image = global::MS_Control.Properties.Resources.chart_bar;
            this.ms_chart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_chart.Name = "ms_chart";
            this.ms_chart.Size = new System.Drawing.Size(23, 20);
            this.ms_chart.ToolTipText = "رسـم نمـودار برای داده های جـدول";
            this.ms_chart.Click += new System.EventHandler(this.ms_chart_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
            // 
            // ms_filter_text
            // 
            this.ms_filter_text.AutoSize = false;
            this.ms_filter_text.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ms_filter_text.Name = "ms_filter_text";
            this.ms_filter_text.Size = new System.Drawing.Size(50, 20);
            this.ms_filter_text.Enter += new System.EventHandler(this.ms_filter_text_Enter);
            this.ms_filter_text.Leave += new System.EventHandler(this.ms_filter_text_Leave);
            this.ms_filter_text.TextChanged += new System.EventHandler(this.ms_filter_text_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::MS_Control.Properties.Resources.btn_Search;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 16);
            // 
            // ms_column_filter
            // 
            this.ms_column_filter.BackColor = System.Drawing.Color.White;
            this.ms_column_filter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_column_filter.Location = new System.Drawing.Point(0, 0);
            this.ms_column_filter.MS_GrideX = null;
            this.ms_column_filter.Name = "ms_column_filter";
            this.ms_column_filter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_column_filter.Size = new System.Drawing.Size(247, 262);
            this.ms_column_filter.TabIndex = 0;
            // 
            // ms_ChooseField
            // 
            this.ms_ChooseField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_ChooseField.Image = global::MS_Control.Properties.Resources.table_select_column;
            this.ms_ChooseField.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_ChooseField.Name = "ms_ChooseField";
            this.ms_ChooseField.Size = new System.Drawing.Size(23, 20);
            this.ms_ChooseField.Text = "انتخـاب ستون";
            this.ms_ChooseField.Click += new System.EventHandler(this.ms_ChooseField_Click);
            // 
            // ms_Settings
            // 
            this.ms_Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_Settings.Image = global::MS_Control.Properties.Resources.setting_tools;
            this.ms_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_Settings.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.ms_Settings.Name = "ms_Settings";
            this.ms_Settings.Size = new System.Drawing.Size(23, 20);
            this.ms_Settings.Text = "تنظیمات";
            this.ms_Settings.Click += new System.EventHandler(this.ms_Settings_Click);
            // 
            // ms_saveSettings
            // 
            this.ms_saveSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_saveSettings.Image = global::MS_Control.Properties.Resources.save;
            this.ms_saveSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_saveSettings.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.ms_saveSettings.Name = "ms_saveSettings";
            this.ms_saveSettings.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ms_saveSettings.Size = new System.Drawing.Size(23, 20);
            this.ms_saveSettings.Text = "ذخیره تغییرات";
            this.ms_saveSettings.Click += new System.EventHandler(this.ms_saveSettings_Click);
            // 
            // ms_ResetSetting
            // 
            this.ms_ResetSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_ResetSetting.Image = global::MS_Control.Properties.Resources.cog_delete;
            this.ms_ResetSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_ResetSetting.Margin = new System.Windows.Forms.Padding(0, 1, 8, 2);
            this.ms_ResetSetting.Name = "ms_ResetSetting";
            this.ms_ResetSetting.Size = new System.Drawing.Size(23, 20);
            this.ms_ResetSetting.Text = "برگشت به تنظیمات اولیه";
            this.ms_ResetSetting.Click += new System.EventHandler(this.ms_ResetSetting_Click);
            // 
            // MS_GridX_Setting
            // 
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_filter,
            this.ms_filter_advanced,
            this.ms_col_filter,
            this.toolStripSeparator2,
            this.ms_group_Box,
            this.ms_group_total,
            this.toolStripSeparator3,
            this.ms_active_total,
            this.ms_total,
            this.toolStripSeparator1,
            this.ms_excel,
            this.ms_print,
            this.ms_chart,
            this.toolStripSeparator4,
            this.ms_auto_size,
            this.ms_ChooseField,
            this.ms_Settings,
            this.ms_saveSettings,
            this.ms_ResetSetting,
            this.toolStripSeparator5,
            this.ms_filter_text,
            this.toolStripLabel1});
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ToolStripButton ms_filter;
        private System.Windows.Forms.ToolStripButton ms_group_Box;
        private System.Windows.Forms.ToolStripButton ms_auto_size;
        private System.Windows.Forms.ToolStripSplitButton ms_total;
        private System.Windows.Forms.ToolStripMenuItem ms_sum;
        private System.Windows.Forms.ToolStripMenuItem ms_max;
        private System.Windows.Forms.ToolStripMenuItem ms_min;
        private System.Windows.Forms.ToolStripMenuItem ms_avg;
        private System.Windows.Forms.ToolStripButton ms_filter_advanced;
        private System.Windows.Forms.ToolStripSplitButton ms_col_filter;
        private System.Windows.Forms.ToolStripButton ms_excel;
        private System.Windows.Forms.ToolStripButton ms_print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private MS_Filter_GrideX ms_column_filter;
        private System.Windows.Forms.ToolStripMenuItem ms_count;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Janus.Windows.GridEX.GridEXPrintDocument gridEXPrintDocument1;
        private Janus.Windows.GridEX.Export.GridEXExporter gridEXExporter1;
        private System.Windows.Forms.ToolStripButton ms_group_total;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ms_active_total;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton ms_chart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox ms_filter_text;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem ms_CurrentColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton ms_ChooseField;
        private System.Windows.Forms.ToolStripButton ms_Settings;
        private System.Windows.Forms.ToolStripButton ms_saveSettings;
        private System.Windows.Forms.ToolStripButton ms_ResetSetting;
    }
}
