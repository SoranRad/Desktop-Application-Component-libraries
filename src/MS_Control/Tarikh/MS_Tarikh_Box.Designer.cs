namespace MS_Control.Tarikh
{
    partial class MS_Tarikh_Box
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MS_Tarikh_Box));
            this.ms_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.ms_tarikh_DropDown = new MS_Control.Tarikh.MS_Tatikh_View();
            ((System.ComponentModel.ISupportInitialize)(this.ms_error)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_error
            // 
            this.ms_error.ContainerControl = this;
            // 
            // ms_tarikh_DropDown
            // 
            this.ms_tarikh_DropDown.BackColor = System.Drawing.Color.White;
            this.ms_tarikh_DropDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ms_tarikh_DropDown.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_tarikh_DropDown.Location = new System.Drawing.Point(0, 0);
            this.ms_tarikh_DropDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ms_tarikh_DropDown.Name = "ms_tarikh_DropDown";
            this.ms_tarikh_DropDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_tarikh_DropDown.Size = new System.Drawing.Size(235, 262);
            this.ms_tarikh_DropDown.TabIndex = 0;
            this.ms_tarikh_DropDown.MS_On_OK_Clicked += new MS_Control.Tarikh.MS_Tatikh_View.MS_On_Button_Click(this.ms_tarikh_DropDown_MS_On_OK_Clicked);
            this.ms_tarikh_DropDown.MS_On_Cancel_Clicked += new MS_Control.Tarikh.MS_Tatikh_View.MS_On_Button_Click(this.ms_tarikh_DropDown_MS_On_Cancel_Clicked);
            // 
            // MS_Tarikh_Box
            // 
            this.BorderStyle = Janus.Windows.GridEX.BorderStyle.Sunken;
            this.ButtonImage = ((System.Drawing.Image)(resources.GetObject("$this.ButtonImage")));
            this.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_error.SetIconAlignment(this, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.Mask = "1300/00/00";
            this.Numeric = true;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(100, 24);
            this.ButtonClick += new System.EventHandler(this.MS_Tarikh_Box_ButtonClick);
            ((System.ComponentModel.ISupportInitialize)(this.ms_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ms_error;
        private MS_Tatikh_View ms_tarikh_DropDown;
    }
}
