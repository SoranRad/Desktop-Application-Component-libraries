namespace MS_Control.TSDD
{
    partial class MS_TextBox_ADC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MS_TextBox_ADC));
            this.ms_clear = new Janus.Windows.EditControls.UIButton();
            this.SuspendLayout();
            // 
            // ms_clear
            // 
            this.ms_clear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ms_clear.Image = ((System.Drawing.Image)(resources.GetObject("ms_clear.Image")));
            this.ms_clear.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center;
            this.ms_clear.ImageSize = new System.Drawing.Size(12, 12);
            this.ms_clear.Location = new System.Drawing.Point(0, 0);
            this.ms_clear.Name = "ms_clear";
            this.ms_clear.ShowFocusRectangle = false;
            this.ms_clear.Size = new System.Drawing.Size(14, 14);
            this.ms_clear.TabIndex = 0;
            this.ms_clear.ToolTipText = "حذف مورد انتخابی";
            this.ms_clear.Click += new System.EventHandler(this.ms_clear_Click);
            // 
            // MS_TextBox_ADC
            // 
            this.ThemedAreasChanged += new System.EventHandler(this.MS_TextBox_ADC_ThemedAreasChanged);
            this.ButtonClick += new System.EventHandler(this.MS_TextBox_ADC_ButtonClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.EditControls.UIButton ms_clear;
    }
}
