namespace MS_Control
{
    internal partial class Msg_Box
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Msg_Box));
            this.lblMessage = new System.Windows.Forms.Label();
            this.picMessage = new System.Windows.Forms.PictureBox();
            this.btn_Detiles = new System.Windows.Forms.Label();
            this.ms_ok_cancel = new System.Windows.Forms.Panel();
            this.ms_cancel4 = new MS_Control.Controls.MS_Button_GridX();
            this.ms_ok = new MS_Control.Controls.MS_Button_GridX();
            this.ms_retry_cancel = new System.Windows.Forms.Panel();
            this.ms_cancel2 = new MS_Control.Controls.MS_Button_GridX();
            this.ms_retry2 = new MS_Control.Controls.MS_Button_GridX();
            this.ms_yes_no_cancel = new System.Windows.Forms.Panel();
            this.ms_cancel3 = new MS_Control.Controls.MS_Button_GridX();
            this.ms_no2 = new MS_Control.Controls.MS_Button_GridX();
            this.ms_yes2 = new MS_Control.Controls.MS_Button_GridX();
            this.ms_detail = new System.Windows.Forms.TextBox();
            this.ms_abort_retry_ignore = new System.Windows.Forms.Panel();
            this.ms_ignore = new MS_Control.Controls.MS_Button_GridX();
            this.ms_retry3 = new MS_Control.Controls.MS_Button_GridX();
            this.ms_abort = new MS_Control.Controls.MS_Button_GridX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).BeginInit();
            this.ms_ok_cancel.SuspendLayout();
            this.ms_retry_cancel.SuspendLayout();
            this.ms_yes_no_cancel.SuspendLayout();
            this.ms_abort_retry_ignore.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleForm
            // 
            this.styleForm.ManagerColorTint = System.Drawing.Color.SteelBlue;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMessage.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblMessage.Location = new System.Drawing.Point(-1, -1);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessage.Size = new System.Drawing.Size(457, 141);
            this.lblMessage.TabIndex = 213;
            this.lblMessage.Text = "بررسی کنید.";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.UseCompatibleTextRendering = true;
            // 
            // picMessage
            // 
            this.picMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMessage.BackColor = System.Drawing.Color.Transparent;
            this.picMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMessage.Image = global::MS_Control.Properties.Resources.i;
            this.picMessage.Location = new System.Drawing.Point(459, 30);
            this.picMessage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.picMessage.Name = "picMessage";
            this.picMessage.Size = new System.Drawing.Size(76, 81);
            this.picMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMessage.TabIndex = 214;
            this.picMessage.TabStop = false;
            // 
            // btn_Detiles
            // 
            this.btn_Detiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Detiles.Image = ((System.Drawing.Image)(resources.GetObject("btn_Detiles.Image")));
            this.btn_Detiles.Location = new System.Drawing.Point(5, 162);
            this.btn_Detiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_Detiles.Name = "btn_Detiles";
            this.btn_Detiles.Size = new System.Drawing.Size(29, 27);
            this.btn_Detiles.TabIndex = 202;
            this.btn_Detiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Detiles.Visible = false;
            this.btn_Detiles.Click += new System.EventHandler(this.btn_Detiles_Click);
            // 
            // ms_ok_cancel
            // 
            this.ms_ok_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_ok_cancel.Controls.Add(this.ms_cancel4);
            this.ms_ok_cancel.Controls.Add(this.ms_ok);
            this.ms_ok_cancel.Location = new System.Drawing.Point(40, 145);
            this.ms_ok_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.ms_ok_cancel.Name = "ms_ok_cancel";
            this.ms_ok_cancel.Size = new System.Drawing.Size(495, 43);
            this.ms_ok_cancel.TabIndex = 0;
            // 
            // ms_cancel4
            // 
            this.ms_cancel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_cancel4.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_cancel4.Image = global::MS_Control.Properties.Resources.close_16;
            this.ms_cancel4.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near;
            this.ms_cancel4.Location = new System.Drawing.Point(262, 5);
            this.ms_cancel4.MS_BorderColor = System.Drawing.Color.Transparent;
            this.ms_cancel4.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_cancel4.MS_Change_Border_Color_On_Enter = false;
            this.ms_cancel4.MS_Change_Color_On_Enter = false;
            this.ms_cancel4.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_cancel4.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_cancel4.Name = "ms_cancel4";
            this.ms_cancel4.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_cancel4.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_cancel4.ShowFocusRectangle = false;
            this.ms_cancel4.Size = new System.Drawing.Size(109, 33);
            this.ms_cancel4.TabIndex = 1;
            this.ms_cancel4.Text = "انصـراف";
            this.ms_cancel4.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.ms_cancel4.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_cancel4.Click += new System.EventHandler(this.ms_cancel4_Click);
            // 
            // ms_ok
            // 
            this.ms_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_ok.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_ok.Image = global::MS_Control.Properties.Resources.check1;
            this.ms_ok.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near;
            this.ms_ok.Location = new System.Drawing.Point(377, 5);
            this.ms_ok.MS_BorderColor = System.Drawing.Color.Transparent;
            this.ms_ok.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_ok.MS_Change_Border_Color_On_Enter = false;
            this.ms_ok.MS_Change_Color_On_Enter = false;
            this.ms_ok.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_ok.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_ok.Name = "ms_ok";
            this.ms_ok.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_ok.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_ok.ShowFocusRectangle = false;
            this.ms_ok.Size = new System.Drawing.Size(109, 33);
            this.ms_ok.TabIndex = 0;
            this.ms_ok.Text = "تایــیـد ";
            this.ms_ok.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.ms_ok.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_ok.Click += new System.EventHandler(this.ms_ok_Click);
            // 
            // ms_retry_cancel
            // 
            this.ms_retry_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_retry_cancel.Controls.Add(this.ms_cancel2);
            this.ms_retry_cancel.Controls.Add(this.ms_retry2);
            this.ms_retry_cancel.Location = new System.Drawing.Point(40, 145);
            this.ms_retry_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.ms_retry_cancel.Name = "ms_retry_cancel";
            this.ms_retry_cancel.Size = new System.Drawing.Size(495, 43);
            this.ms_retry_cancel.TabIndex = 0;
            // 
            // ms_cancel2
            // 
            this.ms_cancel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_cancel2.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_cancel2.Image = global::MS_Control.Properties.Resources.close_16;
            this.ms_cancel2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near;
            this.ms_cancel2.Location = new System.Drawing.Point(262, 5);
            this.ms_cancel2.MS_BorderColor = System.Drawing.Color.Transparent;
            this.ms_cancel2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_cancel2.MS_Change_Border_Color_On_Enter = false;
            this.ms_cancel2.MS_Change_Color_On_Enter = false;
            this.ms_cancel2.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_cancel2.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_cancel2.Name = "ms_cancel2";
            this.ms_cancel2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_cancel2.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_cancel2.ShowFocusRectangle = false;
            this.ms_cancel2.Size = new System.Drawing.Size(109, 33);
            this.ms_cancel2.StateStyles.HotFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ms_cancel2.StateStyles.PressedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ms_cancel2.StateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ms_cancel2.TabIndex = 1;
            this.ms_cancel2.Text = "انصـراف";
            this.ms_cancel2.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.ms_cancel2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_cancel2.Click += new System.EventHandler(this.ms_cancel2_Click);
            // 
            // ms_retry2
            // 
            this.ms_retry2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_retry2.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_retry2.Image = global::MS_Control.Properties.Resources.refresh;
            this.ms_retry2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near;
            this.ms_retry2.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.Empty;
            this.ms_retry2.Location = new System.Drawing.Point(377, 5);
            this.ms_retry2.MS_BorderColor = System.Drawing.Color.Transparent;
            this.ms_retry2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_retry2.MS_Change_Border_Color_On_Enter = false;
            this.ms_retry2.MS_Change_Color_On_Enter = false;
            this.ms_retry2.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_retry2.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_retry2.Name = "ms_retry2";
            this.ms_retry2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_retry2.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_retry2.ShowFocusRectangle = false;
            this.ms_retry2.Size = new System.Drawing.Size(109, 33);
            this.ms_retry2.StateStyles.HotFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ms_retry2.StateStyles.PressedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ms_retry2.StateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ms_retry2.TabIndex = 0;
            this.ms_retry2.Text = "تلاش مجدد";
            this.ms_retry2.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.ms_retry2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_retry2.Click += new System.EventHandler(this.ms_retry2_Click);
            // 
            // ms_yes_no_cancel
            // 
            this.ms_yes_no_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_yes_no_cancel.Controls.Add(this.ms_cancel3);
            this.ms_yes_no_cancel.Controls.Add(this.ms_no2);
            this.ms_yes_no_cancel.Controls.Add(this.ms_yes2);
            this.ms_yes_no_cancel.Location = new System.Drawing.Point(40, 145);
            this.ms_yes_no_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.ms_yes_no_cancel.Name = "ms_yes_no_cancel";
            this.ms_yes_no_cancel.Size = new System.Drawing.Size(495, 43);
            this.ms_yes_no_cancel.TabIndex = 0;
            // 
            // ms_cancel3
            // 
            this.ms_cancel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_cancel3.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_cancel3.Image = global::MS_Control.Properties.Resources.arrow_undo;
            this.ms_cancel3.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near;
            this.ms_cancel3.Location = new System.Drawing.Point(147, 6);
            this.ms_cancel3.MS_BorderColor = System.Drawing.Color.Transparent;
            this.ms_cancel3.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_cancel3.MS_Change_Border_Color_On_Enter = false;
            this.ms_cancel3.MS_Change_Color_On_Enter = false;
            this.ms_cancel3.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_cancel3.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_cancel3.Name = "ms_cancel3";
            this.ms_cancel3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_cancel3.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_cancel3.ShowFocusRectangle = false;
            this.ms_cancel3.Size = new System.Drawing.Size(109, 33);
            this.ms_cancel3.StateStyles.HotFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ms_cancel3.StateStyles.PressedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ms_cancel3.StateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ms_cancel3.TabIndex = 2;
            this.ms_cancel3.Text = "انــصــراف";
            this.ms_cancel3.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.ms_cancel3.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_cancel3.Click += new System.EventHandler(this.ms_cancel3_Click);
            // 
            // ms_no2
            // 
            this.ms_no2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_no2.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_no2.Image = global::MS_Control.Properties.Resources.close_16;
            this.ms_no2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near;
            this.ms_no2.Location = new System.Drawing.Point(262, 6);
            this.ms_no2.MS_BorderColor = System.Drawing.Color.Transparent;
            this.ms_no2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_no2.MS_Change_Border_Color_On_Enter = false;
            this.ms_no2.MS_Change_Color_On_Enter = false;
            this.ms_no2.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_no2.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_no2.Name = "ms_no2";
            this.ms_no2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_no2.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_no2.ShowFocusRectangle = false;
            this.ms_no2.Size = new System.Drawing.Size(109, 33);
            this.ms_no2.StateStyles.HotFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ms_no2.StateStyles.PressedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ms_no2.StateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ms_no2.TabIndex = 1;
            this.ms_no2.Text = "خـیــر";
            this.ms_no2.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.ms_no2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_no2.Click += new System.EventHandler(this.ms_no2_Click);
            // 
            // ms_yes2
            // 
            this.ms_yes2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_yes2.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_yes2.Image = global::MS_Control.Properties.Resources.check1;
            this.ms_yes2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near;
            this.ms_yes2.Location = new System.Drawing.Point(377, 6);
            this.ms_yes2.MS_BorderColor = System.Drawing.Color.Transparent;
            this.ms_yes2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_yes2.MS_Change_Border_Color_On_Enter = false;
            this.ms_yes2.MS_Change_Color_On_Enter = false;
            this.ms_yes2.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_yes2.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_yes2.Name = "ms_yes2";
            this.ms_yes2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_yes2.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_yes2.ShowFocusRectangle = false;
            this.ms_yes2.Size = new System.Drawing.Size(109, 33);
            this.ms_yes2.StateStyles.HotFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ms_yes2.StateStyles.PressedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ms_yes2.StateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ms_yes2.TabIndex = 0;
            this.ms_yes2.Text = "بـلــی";
            this.ms_yes2.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.ms_yes2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_yes2.Click += new System.EventHandler(this.ms_yes2_Click);
            // 
            // ms_detail
            // 
            this.ms_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_detail.BackColor = System.Drawing.Color.White;
            this.ms_detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ms_detail.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_detail.Location = new System.Drawing.Point(1, 195);
            this.ms_detail.Multiline = true;
            this.ms_detail.Name = "ms_detail";
            this.ms_detail.ReadOnly = true;
            this.ms_detail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ms_detail.Size = new System.Drawing.Size(534, 0);
            this.ms_detail.TabIndex = 219;
            this.ms_detail.TabStop = false;
            this.ms_detail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ms_abort_retry_ignore
            // 
            this.ms_abort_retry_ignore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_abort_retry_ignore.Controls.Add(this.ms_ignore);
            this.ms_abort_retry_ignore.Controls.Add(this.ms_retry3);
            this.ms_abort_retry_ignore.Controls.Add(this.ms_abort);
            this.ms_abort_retry_ignore.Location = new System.Drawing.Point(40, 145);
            this.ms_abort_retry_ignore.Margin = new System.Windows.Forms.Padding(4);
            this.ms_abort_retry_ignore.Name = "ms_abort_retry_ignore";
            this.ms_abort_retry_ignore.Size = new System.Drawing.Size(495, 43);
            this.ms_abort_retry_ignore.TabIndex = 0;
            // 
            // ms_ignore
            // 
            this.ms_ignore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_ignore.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_ignore.Image = global::MS_Control.Properties.Resources.check1;
            this.ms_ignore.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near;
            this.ms_ignore.Location = new System.Drawing.Point(147, 5);
            this.ms_ignore.MS_BorderColor = System.Drawing.Color.Transparent;
            this.ms_ignore.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_ignore.MS_Change_Border_Color_On_Enter = false;
            this.ms_ignore.MS_Change_Color_On_Enter = false;
            this.ms_ignore.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_ignore.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_ignore.Name = "ms_ignore";
            this.ms_ignore.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_ignore.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_ignore.ShowFocusRectangle = false;
            this.ms_ignore.Size = new System.Drawing.Size(109, 33);
            this.ms_ignore.StateStyles.HotFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ms_ignore.StateStyles.PressedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ms_ignore.StateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ms_ignore.TabIndex = 2;
            this.ms_ignore.Text = "پذیرش";
            this.ms_ignore.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.ms_ignore.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_ignore.Click += new System.EventHandler(this.ms_ignore_Click);
            // 
            // ms_retry3
            // 
            this.ms_retry3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_retry3.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_retry3.Image = global::MS_Control.Properties.Resources.refresh;
            this.ms_retry3.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near;
            this.ms_retry3.Location = new System.Drawing.Point(262, 5);
            this.ms_retry3.MS_BorderColor = System.Drawing.Color.Transparent;
            this.ms_retry3.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_retry3.MS_Change_Border_Color_On_Enter = false;
            this.ms_retry3.MS_Change_Color_On_Enter = false;
            this.ms_retry3.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_retry3.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_retry3.Name = "ms_retry3";
            this.ms_retry3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_retry3.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_retry3.ShowFocusRectangle = false;
            this.ms_retry3.Size = new System.Drawing.Size(109, 33);
            this.ms_retry3.StateStyles.HotFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ms_retry3.StateStyles.PressedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ms_retry3.StateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ms_retry3.TabIndex = 1;
            this.ms_retry3.Text = "تلاش مجدد";
            this.ms_retry3.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.ms_retry3.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_retry3.Click += new System.EventHandler(this.ms_retry3_Click);
            // 
            // ms_abort
            // 
            this.ms_abort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_abort.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_abort.Image = global::MS_Control.Properties.Resources.close_16;
            this.ms_abort.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near;
            this.ms_abort.Location = new System.Drawing.Point(377, 5);
            this.ms_abort.MS_BorderColor = System.Drawing.Color.Transparent;
            this.ms_abort.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_abort.MS_Change_Border_Color_On_Enter = false;
            this.ms_abort.MS_Change_Color_On_Enter = false;
            this.ms_abort.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_abort.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_abort.Name = "ms_abort";
            this.ms_abort.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_abort.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_abort.ShowFocusRectangle = false;
            this.ms_abort.Size = new System.Drawing.Size(109, 33);
            this.ms_abort.StateStyles.HotFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ms_abort.StateStyles.PressedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ms_abort.StateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ms_abort.TabIndex = 0;
            this.ms_abort.Text = "قطع عملیات";
            this.ms_abort.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.ms_abort.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_abort.Click += new System.EventHandler(this.ms_abort_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Msg_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 195);
            this.Controls.Add(this.ms_detail);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.picMessage);
            this.Controls.Add(this.btn_Detiles);
            this.Controls.Add(this.ms_abort_retry_ignore);
            this.Controls.Add(this.ms_ok_cancel);
            this.Controls.Add(this.ms_yes_no_cancel);
            this.Controls.Add(this.ms_retry_cancel);
            this.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MS_Color = System.Drawing.Color.SteelBlue;
            this.Name = "Msg_Box";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "                                                              پیـغام";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).EndInit();
            this.ms_ok_cancel.ResumeLayout(false);
            this.ms_retry_cancel.ResumeLayout(false);
            this.ms_yes_no_cancel.ResumeLayout(false);
            this.ms_abort_retry_ignore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox picMessage;
        private System.Windows.Forms.Label btn_Detiles;
        private System.Windows.Forms.Panel ms_ok_cancel;
        private System.Windows.Forms.Panel ms_yes_no_cancel;
        private System.Windows.Forms.Panel ms_retry_cancel;
        private System.Windows.Forms.TextBox ms_detail;
        private Controls.MS_Button_GridX ms_cancel2;
        private Controls.MS_Button_GridX ms_retry2;
        private Controls.MS_Button_GridX ms_cancel3;
        private Controls.MS_Button_GridX ms_no2;
        private Controls.MS_Button_GridX ms_yes2;
        private Controls.MS_Button_GridX ms_cancel4;
        private Controls.MS_Button_GridX ms_ok;
        private System.Windows.Forms.Panel ms_abort_retry_ignore;
        private Controls.MS_Button_GridX ms_retry3;
        private Controls.MS_Button_GridX ms_abort;
        private Controls.MS_Button_GridX ms_ignore;
        private System.Windows.Forms.Timer timer1;
    }
}