namespace MS_Control.Filter_Manage
{
    partial class Form_Chart_GridEX
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ms_chart = new MS_Control.Controls.MS_Chart();
            this.ms_X_Axis = new MS_Control.Controls.MS_ComboBox_Janus();
            this.ms_select_columns = new MS_Control.Controls.MS_Button_GridX();
            this.ms_show_select = new MS_Control.Controls.MS_CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ms_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_chart
            // 
            this.ms_chart.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.ms_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_chart.BorderlineColor = System.Drawing.Color.Black;
            this.ms_chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.ms_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ms_chart.Legends.Add(legend1);
            this.ms_chart.Location = new System.Drawing.Point(1, 0);
            this.ms_chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ms_chart.Name = "ms_chart";
            this.ms_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.ms_chart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ms_chart.Series.Add(series1);
            this.ms_chart.Size = new System.Drawing.Size(690, 395);
            this.ms_chart.TabIndex = 0;
            this.ms_chart.Text = "mS_Chart1";
            // 
            // ms_X_Axis
            // 
            this.ms_X_Axis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ms_X_Axis.BorderStyle = Janus.Windows.UI.BorderStyle.Flat;
            this.ms_X_Axis.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.ms_X_Axis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_X_Axis.Location = new System.Drawing.Point(0, 373);
            this.ms_X_Axis.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_X_Axis.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_X_Axis.MS_Change_Border_Color_On_Enter = false;
            this.ms_X_Axis.MS_Change_Color_On_Enter = false;
            this.ms_X_Axis.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_X_Axis.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_X_Axis.MS_Exit_By_Down = false;
            this.ms_X_Axis.MS_Exit_By_Enter = false;
            this.ms_X_Axis.MS_Exit_By_Up = false;
            this.ms_X_Axis.MS_Last_Control = null;
            this.ms_X_Axis.MS_Next_Control = null;
            this.ms_X_Axis.Name = "ms_X_Axis";
            this.ms_X_Axis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_X_Axis.Size = new System.Drawing.Size(116, 22);
            this.ms_X_Axis.TabIndex = 1;
            this.ms_X_Axis.SelectedIndexChanged += new System.EventHandler(this.ms_X_Axis_SelectedIndexChanged);
            // 
            // ms_select_columns
            // 
            this.ms_select_columns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ms_select_columns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_select_columns.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_select_columns.Image = global::MS_Control.Properties.Resources.table_select_column;
            this.ms_select_columns.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center;
            this.ms_select_columns.Location = new System.Drawing.Point(138, 373);
            this.ms_select_columns.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_select_columns.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_select_columns.MS_Change_Border_Color_On_Enter = false;
            this.ms_select_columns.MS_Change_Color_On_Enter = false;
            this.ms_select_columns.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_select_columns.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_select_columns.Name = "ms_select_columns";
            this.ms_select_columns.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_select_columns.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_select_columns.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_select_columns.ShowFocusRectangle = false;
            this.ms_select_columns.Size = new System.Drawing.Size(22, 22);
            this.ms_select_columns.TabIndex = 7;
            this.ms_select_columns.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.ms_select_columns.UseThemes = false;
            this.ms_select_columns.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
            this.ms_select_columns.WordWrap = false;
            this.ms_select_columns.Click += new System.EventHandler(this.ms_save_Click);
            // 
            // ms_show_select
            // 
            this.ms_show_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ms_show_select.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ms_show_select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_show_select.Location = new System.Drawing.Point(115, 373);
            this.ms_show_select.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_show_select.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_show_select.MS_Change_Border_Color_On_Enter = false;
            this.ms_show_select.MS_Change_Color_On_Checked = false;
            this.ms_show_select.MS_Change_Color_On_Enter = false;
            this.ms_show_select.MS_Checked_Color = System.Drawing.Color.Empty;
            this.ms_show_select.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_show_select.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_show_select.MS_Exit_By_Down = false;
            this.ms_show_select.MS_Exit_By_Enter = false;
            this.ms_show_select.MS_Exit_By_Up = false;
            this.ms_show_select.MS_Last_Control = null;
            this.ms_show_select.MS_Next_Control = null;
            this.ms_show_select.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.ms_show_select.Name = "ms_show_select";
            this.ms_show_select.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_show_select.Size = new System.Drawing.Size(24, 22);
            this.ms_show_select.TabIndex = 8;
            this.ms_show_select.ToolTipText = "فقط دریف های انتخــابی نمایش داده شود";
            // 
            // Form_Chart_GridEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 395);
            this.Controls.Add(this.ms_show_select);
            this.Controls.Add(this.ms_select_columns);
            this.Controls.Add(this.ms_X_Axis);
            this.Controls.Add(this.ms_chart);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Chart_GridEX";
            this.Text = "                                                                        ساخت نمود" +
    "ار برای مقادیر";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ms_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MS_Chart ms_chart;
        private Controls.MS_ComboBox_Janus ms_X_Axis;
        private Controls.MS_Button_GridX ms_select_columns;
        private Controls.MS_CheckBox ms_show_select;
    }
}