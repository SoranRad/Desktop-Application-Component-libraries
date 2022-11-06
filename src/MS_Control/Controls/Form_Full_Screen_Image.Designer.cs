namespace MS_Control.Controls
{
    partial class Form_Full_Screen_Image
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mp_chart = new MS_Control.Controls.MS_Chart();
            ((System.ComponentModel.ISupportInitialize)(this.mp_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // mp_chart
            // 
            this.mp_chart.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.mp_chart.BorderlineColor = System.Drawing.Color.Black;
            this.mp_chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.mp_chart.ChartAreas.Add(chartArea2);
            this.mp_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.mp_chart.Legends.Add(legend2);
            this.mp_chart.Location = new System.Drawing.Point(0, 0);
            this.mp_chart.Name = "mp_chart";
            this.mp_chart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.mp_chart.Series.Add(series2);
            this.mp_chart.Size = new System.Drawing.Size(634, 461);
            this.mp_chart.TabIndex = 0;
            // 
            // Form_Full_Screen_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.mp_chart);
            this.MinimizeBox = false;
            this.Name = "Form_Full_Screen_Image";
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.mp_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Chart mp_chart;
    }
}