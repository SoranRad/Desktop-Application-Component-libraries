namespace MS_Control.DataBase
{
    partial class Form_CMD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CMD));
            this.ms_Timer = new System.Windows.Forms.Timer(this.components);
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.ms_Result = new System.Windows.Forms.RichTextBox();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.ms_RunCommand = new MS_Control.Controls.MS_Button_GridX();
            this.ms_Command = new MS_Control.Controls.MS_TextBox();
            this.ms_ResetResult = new MS_Control.Controls.MS_Button_GridX();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Timer
            // 
            this.ms_Timer.Tick += new System.EventHandler(this.ms_Timer_Tick);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.BorderColor = System.Drawing.Color.RoyalBlue;
            this.uiGroupBox2.Controls.Add(this.ms_Result);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox2.Location = new System.Drawing.Point(0, 93);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiGroupBox2.Size = new System.Drawing.Size(746, 368);
            this.uiGroupBox2.TabIndex = 8;
            this.uiGroupBox2.Text = "نـتـیـجــه اجــرای فـرمــان";
            // 
            // ms_Result
            // 
            this.ms_Result.BackColor = System.Drawing.Color.Black;
            this.ms_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ms_Result.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_Result.ForeColor = System.Drawing.Color.White;
            this.ms_Result.Location = new System.Drawing.Point(3, 19);
            this.ms_Result.Name = "ms_Result";
            this.ms_Result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ms_Result.Size = new System.Drawing.Size(740, 346);
            this.ms_Result.TabIndex = 0;
            this.ms_Result.Text = "";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.uiGroupBox1.Controls.Add(this.ms_ResetResult);
            this.uiGroupBox1.Controls.Add(this.ms_RunCommand);
            this.uiGroupBox1.Controls.Add(this.ms_Command);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiGroupBox1.Size = new System.Drawing.Size(746, 93);
            this.uiGroupBox1.TabIndex = 7;
            this.uiGroupBox1.Text = "وارد کـردن فـرمـان";
            // 
            // ms_RunCommand
            // 
            this.ms_RunCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ms_RunCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_RunCommand.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_RunCommand.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_RunCommand.Image = ((System.Drawing.Image)(resources.GetObject("ms_RunCommand.Image")));
            this.ms_RunCommand.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_RunCommand.Location = new System.Drawing.Point(9, 60);
            this.ms_RunCommand.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_RunCommand.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_RunCommand.MS_Change_Border_Color_On_Enter = false;
            this.ms_RunCommand.MS_Change_Color_On_Enter = false;
            this.ms_RunCommand.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_RunCommand.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_RunCommand.Name = "ms_RunCommand";
            this.ms_RunCommand.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_RunCommand.Office2007CustomColor = System.Drawing.Color.LightBlue;
            this.ms_RunCommand.ShowFocusRectangle = false;
            this.ms_RunCommand.Size = new System.Drawing.Size(120, 27);
            this.ms_RunCommand.TabIndex = 50;
            this.ms_RunCommand.Text = "اجــرای دســتــور";
            this.ms_RunCommand.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.ms_RunCommand.UseThemes = false;
            this.ms_RunCommand.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_RunCommand.WordWrap = false;
            this.ms_RunCommand.Click += new System.EventHandler(this.ms_RunCommand_Click);
            // 
            // ms_Command
            // 
            this.ms_Command.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_Command.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Command.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ms_Command.Location = new System.Drawing.Point(10, 28);
            this.ms_Command.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_Command.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_Command.MS_Change_Border_Color_On_Enter = true;
            this.ms_Command.MS_Change_Color_On_Enter = true;
            this.ms_Command.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ms_Command.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.ms_Command.MS_Exit_By_Down = true;
            this.ms_Command.MS_Exit_By_Enter = true;
            this.ms_Command.MS_Exit_By_Up = true;
            this.ms_Command.MS_Last_Control = null;
            this.ms_Command.MS_Next_Control = null;
            this.ms_Command.Multiline = true;
            this.ms_Command.Name = "ms_Command";
            this.ms_Command.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ms_Command.Size = new System.Drawing.Size(724, 24);
            this.ms_Command.TabIndex = 3;
            this.ms_Command.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.ms_Command.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // ms_ResetResult
            // 
            this.ms_ResetResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ms_ResetResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_ResetResult.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_ResetResult.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_ResetResult.Image = ((System.Drawing.Image)(resources.GetObject("ms_ResetResult.Image")));
            this.ms_ResetResult.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_ResetResult.Location = new System.Drawing.Point(595, 60);
            this.ms_ResetResult.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_ResetResult.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_ResetResult.MS_Change_Border_Color_On_Enter = false;
            this.ms_ResetResult.MS_Change_Color_On_Enter = false;
            this.ms_ResetResult.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_ResetResult.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_ResetResult.Name = "ms_ResetResult";
            this.ms_ResetResult.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_ResetResult.Office2007CustomColor = System.Drawing.Color.LightBlue;
            this.ms_ResetResult.ShowFocusRectangle = false;
            this.ms_ResetResult.Size = new System.Drawing.Size(139, 27);
            this.ms_ResetResult.TabIndex = 51;
            this.ms_ResetResult.Text = "پـاک کـردن نـتیـجـه";
            this.ms_ResetResult.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.ms_ResetResult.UseThemes = false;
            this.ms_ResetResult.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_ResetResult.WordWrap = false;
            this.ms_ResetResult.Click += new System.EventHandler(this.ms_ResetResult_Click);
            // 
            // Form_CMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 461);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimizeBox = false;
            this.MS_Escap = MS_Control.MS_Mother_Mali.Escap_Exit.Yes;
            this.Name = "Form_CMD";
            this.Text = "CMD   اجـرای دسـتـورات خــط فـرمــان";
            this.Shown += new System.EventHandler(this.Form_CMD_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Controls.MS_Button_GridX ms_RunCommand;
        private Controls.MS_TextBox ms_Command;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.RichTextBox ms_Result;
        private System.Windows.Forms.Timer ms_Timer;
        private Controls.MS_Button_GridX ms_ResetResult;
    }
}