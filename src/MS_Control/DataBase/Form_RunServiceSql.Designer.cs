namespace MS_Control.DataBase
{
    partial class Form_RunServiceSql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RunServiceSql));
            this.CmbServerName = new MS_Control.Controls.MS_ComboBox_Janus();
            this.ms_Start = new MS_Control.Controls.MS_Button_GridX();
            this.label1 = new System.Windows.Forms.Label();
            this.ms_Stop = new MS_Control.Controls.MS_Button_GridX();
            this.ms_Vaziat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbServerName
            // 
            this.CmbServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbServerName.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.CmbServerName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbServerName.Location = new System.Drawing.Point(12, 38);
            this.CmbServerName.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.CmbServerName.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.CmbServerName.MS_Change_Border_Color_On_Enter = true;
            this.CmbServerName.MS_Change_Color_On_Enter = true;
            this.CmbServerName.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CmbServerName.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CmbServerName.MS_Exit_By_Down = true;
            this.CmbServerName.MS_Exit_By_Enter = true;
            this.CmbServerName.MS_Exit_By_Up = true;
            this.CmbServerName.MS_Last_Control = null;
            this.CmbServerName.MS_Next_Control = null;
            this.CmbServerName.Name = "CmbServerName";
            this.CmbServerName.Size = new System.Drawing.Size(318, 23);
            this.CmbServerName.TabIndex = 7;
            this.CmbServerName.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.CmbServerName.SelectedIndexChanged += new System.EventHandler(this.CmbServerName_SelectedIndexChanged);
            // 
            // ms_Start
            // 
            this.ms_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Start.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Start.Image = ((System.Drawing.Image)(resources.GetObject("ms_Start.Image")));
            this.ms_Start.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_Start.Location = new System.Drawing.Point(228, 85);
            this.ms_Start.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_Start.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_Start.MS_Change_Border_Color_On_Enter = false;
            this.ms_Start.MS_Change_Color_On_Enter = false;
            this.ms_Start.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_Start.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_Start.Name = "ms_Start";
            this.ms_Start.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_Start.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_Start.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_Start.ShowFocusRectangle = false;
            this.ms_Start.Size = new System.Drawing.Size(214, 30);
            this.ms_Start.TabIndex = 6;
            this.ms_Start.Text = "شـروع سـرویـس مـورد نـظر  Start";
            this.ms_Start.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.ms_Start.UseThemes = false;
            this.ms_Start.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_Start.WordWrap = false;
            this.ms_Start.Click += new System.EventHandler(this.ms_Start_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 17);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "انـتـخاب سـرویـس";
            // 
            // ms_Stop
            // 
            this.ms_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Stop.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Stop.Image = ((System.Drawing.Image)(resources.GetObject("ms_Stop.Image")));
            this.ms_Stop.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_Stop.Location = new System.Drawing.Point(12, 85);
            this.ms_Stop.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_Stop.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_Stop.MS_Change_Border_Color_On_Enter = false;
            this.ms_Stop.MS_Change_Color_On_Enter = false;
            this.ms_Stop.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_Stop.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_Stop.Name = "ms_Stop";
            this.ms_Stop.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_Stop.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_Stop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_Stop.ShowFocusRectangle = false;
            this.ms_Stop.Size = new System.Drawing.Size(210, 30);
            this.ms_Stop.TabIndex = 9;
            this.ms_Stop.Text = "قـطــع سـرویـس مـورد نـظر   Stop";
            this.ms_Stop.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.ms_Stop.UseThemes = false;
            this.ms_Stop.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_Stop.WordWrap = false;
            this.ms_Stop.Click += new System.EventHandler(this.ms_Stop_Click);
            // 
            // ms_Vaziat
            // 
            this.ms_Vaziat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_Vaziat.BackColor = System.Drawing.Color.Gainsboro;
            this.ms_Vaziat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ms_Vaziat.Location = new System.Drawing.Point(336, 38);
            this.ms_Vaziat.Name = "ms_Vaziat";
            this.ms_Vaziat.Size = new System.Drawing.Size(104, 23);
            this.ms_Vaziat.TabIndex = 10;
            this.ms_Vaziat.Text = "...";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 17);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "وضـعـیـت";
            // 
            // Form_RunServiceSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 127);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ms_Vaziat);
            this.Controls.Add(this.ms_Stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbServerName);
            this.Controls.Add(this.ms_Start);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MS_Escap = MS_Control.MS_Mother_Mali.Escap_Exit.Yes;
            this.Name = "Form_RunServiceSql";
            this.Text = "SQL راه انــدازی سـرویـس";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MS_ComboBox_Janus CmbServerName;
        private Controls.MS_Button_GridX ms_Start;
        private System.Windows.Forms.Label label1;
        private Controls.MS_Button_GridX ms_Stop;
        private System.Windows.Forms.Label ms_Vaziat;
        private System.Windows.Forms.Label label3;
    }
}