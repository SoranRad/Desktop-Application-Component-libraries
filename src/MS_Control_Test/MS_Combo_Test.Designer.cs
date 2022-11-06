namespace MS_Control_Test
{
    partial class MS_Combo_Test
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
            this.ms_list = new MS_Control_Test.GridTest();
            this.SuspendLayout();
            // 
            // ms_list
            // 
            this.ms_list.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_list.Location = new System.Drawing.Point(0, 0);
            this.ms_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ms_list.Name = "ms_list";
            this.ms_list.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_list.Size = new System.Drawing.Size(378, 316);
            this.ms_list.TabIndex = 0;
            this.ms_list.MS_On_Row_Selected += new MS_Control.TSDD.Row_Seleced(this.MS_On_Selected);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GridTest ms_list;
    }
}
