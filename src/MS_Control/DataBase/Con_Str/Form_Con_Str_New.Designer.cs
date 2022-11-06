namespace MS_Control.DataBase.Con_Str
{
    partial class Form_Con_Str_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Con_Str_New));
            this.btnOk = new MS_Control.Controls.MS_Button_GridX();
            this.btnLogin = new MS_Control.Controls.MS_Button_GridX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Group2 = new Janus.Windows.EditControls.UIGroupBox();
            this.cmbListDBs = new MS_Control.Controls.MS_ComboBox_Janus();
            this.Check_Server = new MS_Control.Controls.MS_CheckBox();
            this.txtPassword = new MS_Control.Controls.MS_TextBox();
            this.txtUserName = new MS_Control.Controls.MS_TextBox();
            this.txtServerName = new MS_Control.Controls.MS_TextBox();
            this.txtConStr = new MS_Control.Controls.MS_TextBox();
            this.btnExit = new MS_Control.Controls.MS_Button_GridX();
            this.lbl_Lock = new System.Windows.Forms.Label();
            this.ms_lock_address = new MS_Control.Controls.MS_TextBox();
            this.NzMutipleDb = new MS_Control.Controls.MS_CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group2)).BeginInit();
            this.Group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Image = global::MS_Control.Properties.Resources.check1;
            this.btnOk.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.btnOk.Location = new System.Drawing.Point(84, 193);
            this.btnOk.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.btnOk.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.btnOk.MS_Change_Border_Color_On_Enter = false;
            this.btnOk.MS_Change_Color_On_Enter = false;
            this.btnOk.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.btnOk.MS_Enter_Color = System.Drawing.Color.Empty;
            this.btnOk.Name = "btnOk";
            this.btnOk.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.btnOk.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOk.ShowFocusRectangle = false;
            this.btnOk.Size = new System.Drawing.Size(78, 30);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "تایید";
            this.btnOk.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.btnOk.UseThemes = false;
            this.btnOk.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnOk.WordWrap = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogin.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.btnLogin.Location = new System.Drawing.Point(12, 70);
            this.btnLogin.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.btnLogin.MS_Change_Border_Color_On_Enter = false;
            this.btnLogin.MS_Change_Color_On_Enter = false;
            this.btnLogin.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.btnLogin.MS_Enter_Color = System.Drawing.Color.Empty;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.btnLogin.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLogin.ShowFocusRectangle = false;
            this.btnLogin.Size = new System.Drawing.Size(146, 51);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "اتصال به بانک اطلاعاتی";
            this.btnLogin.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.btnLogin.UseThemes = false;
            this.btnLogin.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnLogin.WordWrap = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "آدرس سـرور :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "نـام کـاربـری :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "پـسـورد :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "انـتخاب بــانــک :";
            // 
            // Group2
            // 
            this.Group2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Group2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Group2.Controls.Add(this.cmbListDBs);
            this.Group2.Controls.Add(this.Check_Server);
            this.Group2.Controls.Add(this.txtPassword);
            this.Group2.Controls.Add(this.txtUserName);
            this.Group2.Controls.Add(this.btnLogin);
            this.Group2.Controls.Add(this.txtServerName);
            this.Group2.Controls.Add(this.label3);
            this.Group2.Controls.Add(this.label4);
            this.Group2.Controls.Add(this.label1);
            this.Group2.Controls.Add(this.label2);
            this.Group2.Location = new System.Drawing.Point(167, 31);
            this.Group2.Name = "Group2";
            this.Group2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Group2.Size = new System.Drawing.Size(426, 160);
            this.Group2.TabIndex = 0;
            // 
            // cmbListDBs
            // 
            this.cmbListDBs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbListDBs.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cmbListDBs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbListDBs.Location = new System.Drawing.Point(12, 132);
            this.cmbListDBs.MaxDropDownItems = 13;
            this.cmbListDBs.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.cmbListDBs.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbListDBs.MS_Change_Border_Color_On_Enter = true;
            this.cmbListDBs.MS_Change_Color_On_Enter = true;
            this.cmbListDBs.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbListDBs.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.cmbListDBs.MS_Exit_By_Down = false;
            this.cmbListDBs.MS_Exit_By_Enter = true;
            this.cmbListDBs.MS_Exit_By_Up = false;
            this.cmbListDBs.MS_Last_Control = null;
            this.cmbListDBs.MS_Next_Control = null;
            this.cmbListDBs.Name = "cmbListDBs";
            this.cmbListDBs.Size = new System.Drawing.Size(318, 23);
            this.cmbListDBs.TabIndex = 5;
            this.cmbListDBs.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.cmbListDBs.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cmbListDBs.SelectedIndexChanged += new System.EventHandler(this.cmbListDBs_SelectedIndexChanged);
            // 
            // Check_Server
            // 
            this.Check_Server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Check_Server.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Check_Server.Location = new System.Drawing.Point(164, 39);
            this.Check_Server.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.Check_Server.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.Check_Server.MS_Change_Border_Color_On_Enter = true;
            this.Check_Server.MS_Change_Color_On_Checked = true;
            this.Check_Server.MS_Change_Color_On_Enter = true;
            this.Check_Server.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Check_Server.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Check_Server.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.Check_Server.MS_Exit_By_Down = true;
            this.Check_Server.MS_Exit_By_Enter = true;
            this.Check_Server.MS_Exit_By_Up = true;
            this.Check_Server.MS_Last_Control = null;
            this.Check_Server.MS_Next_Control = null;
            this.Check_Server.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.Check_Server.Name = "Check_Server";
            this.Check_Server.Padding = new System.Windows.Forms.Padding(3);
            this.Check_Server.ShowFocusRectangle = false;
            this.Check_Server.Size = new System.Drawing.Size(166, 25);
            this.Check_Server.TabIndex = 1;
            this.Check_Server.Text = "اعتبار سنجی ویندوز";
            this.Check_Server.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.Check_Server.ToolTipText = "شمـاره خـودکـار";
            this.Check_Server.CheckedChanged += new System.EventHandler(this.Check_Server_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPassword.Location = new System.Drawing.Point(164, 97);
            this.txtPassword.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPassword.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.txtPassword.MS_Change_Border_Color_On_Enter = true;
            this.txtPassword.MS_Change_Color_On_Enter = true;
            this.txtPassword.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtPassword.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.txtPassword.MS_Exit_By_Down = true;
            this.txtPassword.MS_Exit_By_Enter = true;
            this.txtPassword.MS_Exit_By_Up = true;
            this.txtPassword.MS_Last_Control = null;
            this.txtPassword.MS_Next_Control = null;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(166, 24);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtUserName.Enabled = false;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUserName.Location = new System.Drawing.Point(164, 70);
            this.txtUserName.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.txtUserName.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.txtUserName.MS_Change_Border_Color_On_Enter = true;
            this.txtUserName.MS_Change_Color_On_Enter = true;
            this.txtUserName.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtUserName.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.txtUserName.MS_Exit_By_Down = true;
            this.txtUserName.MS_Exit_By_Enter = true;
            this.txtUserName.MS_Exit_By_Up = true;
            this.txtUserName.MS_Last_Control = null;
            this.txtUserName.MS_Next_Control = null;
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserName.Size = new System.Drawing.Size(166, 24);
            this.txtUserName.TabIndex = 2;
            // 
            // txtServerName
            // 
            this.txtServerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtServerName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtServerName.Location = new System.Drawing.Point(12, 11);
            this.txtServerName.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.txtServerName.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.txtServerName.MS_Change_Border_Color_On_Enter = true;
            this.txtServerName.MS_Change_Color_On_Enter = true;
            this.txtServerName.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtServerName.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.txtServerName.MS_Exit_By_Down = true;
            this.txtServerName.MS_Exit_By_Enter = true;
            this.txtServerName.MS_Exit_By_Up = true;
            this.txtServerName.MS_Last_Control = null;
            this.txtServerName.MS_Next_Control = null;
            this.txtServerName.Multiline = true;
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServerName.Size = new System.Drawing.Size(318, 24);
            this.txtServerName.TabIndex = 0;
            // 
            // txtConStr
            // 
            this.txtConStr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConStr.BorderStyle = Janus.Windows.GridEX.BorderStyle.None;
            this.txtConStr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtConStr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtConStr.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtConStr.Location = new System.Drawing.Point(0, 229);
            this.txtConStr.MS_BorderColor = System.Drawing.Color.Transparent;
            this.txtConStr.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.txtConStr.MS_Change_Border_Color_On_Enter = false;
            this.txtConStr.MS_Change_Color_On_Enter = false;
            this.txtConStr.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtConStr.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.txtConStr.MS_Exit_By_Down = true;
            this.txtConStr.MS_Exit_By_Enter = true;
            this.txtConStr.MS_Exit_By_Up = true;
            this.txtConStr.MS_Last_Control = null;
            this.txtConStr.MS_Next_Control = null;
            this.txtConStr.Multiline = true;
            this.txtConStr.Name = "txtConStr";
            this.txtConStr.Size = new System.Drawing.Size(599, 19);
            this.txtConStr.TabIndex = 52;
            this.txtConStr.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.Image = global::MS_Control.Properties.Resources.close_16;
            this.btnExit.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.btnExit.Location = new System.Drawing.Point(3, 193);
            this.btnExit.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.btnExit.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.btnExit.MS_Change_Border_Color_On_Enter = false;
            this.btnExit.MS_Change_Color_On_Enter = false;
            this.btnExit.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.btnExit.MS_Enter_Color = System.Drawing.Color.Empty;
            this.btnExit.Name = "btnExit";
            this.btnExit.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.btnExit.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.ShowFocusRectangle = false;
            this.btnExit.Size = new System.Drawing.Size(78, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "انصراف";
            this.btnExit.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.btnExit.UseThemes = false;
            this.btnExit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnExit.WordWrap = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbl_Lock
            // 
            this.lbl_Lock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Lock.AutoSize = true;
            this.lbl_Lock.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Lock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Lock.Location = new System.Drawing.Point(500, 0);
            this.lbl_Lock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lock.Name = "lbl_Lock";
            this.lbl_Lock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Lock.Size = new System.Drawing.Size(80, 28);
            this.lbl_Lock.TabIndex = 43;
            this.lbl_Lock.Text = "آدرس قفل \r\nسخت افزاری :";
            // 
            // ms_lock_address
            // 
            this.ms_lock_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_lock_address.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_lock_address.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ms_lock_address.Location = new System.Drawing.Point(175, 5);
            this.ms_lock_address.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_lock_address.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_lock_address.MS_Change_Border_Color_On_Enter = true;
            this.ms_lock_address.MS_Change_Color_On_Enter = true;
            this.ms_lock_address.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ms_lock_address.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.ms_lock_address.MS_Exit_By_Down = true;
            this.ms_lock_address.MS_Exit_By_Enter = true;
            this.ms_lock_address.MS_Exit_By_Up = true;
            this.ms_lock_address.MS_Last_Control = null;
            this.ms_lock_address.MS_Next_Control = null;
            this.ms_lock_address.Multiline = true;
            this.ms_lock_address.Name = "ms_lock_address";
            this.ms_lock_address.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ms_lock_address.Size = new System.Drawing.Size(322, 24);
            this.ms_lock_address.TabIndex = 53;
            // 
            // NzMutipleDb
            // 
            this.NzMutipleDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzMutipleDb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NzMutipleDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzMutipleDb.Location = new System.Drawing.Point(167, 198);
            this.NzMutipleDb.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzMutipleDb.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzMutipleDb.MS_Change_Border_Color_On_Enter = true;
            this.NzMutipleDb.MS_Change_Color_On_Checked = true;
            this.NzMutipleDb.MS_Change_Color_On_Enter = true;
            this.NzMutipleDb.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzMutipleDb.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzMutipleDb.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.NzMutipleDb.MS_Exit_By_Down = true;
            this.NzMutipleDb.MS_Exit_By_Enter = true;
            this.NzMutipleDb.MS_Exit_By_Up = true;
            this.NzMutipleDb.MS_Last_Control = null;
            this.NzMutipleDb.MS_Next_Control = null;
            this.NzMutipleDb.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzMutipleDb.Name = "NzMutipleDb";
            this.NzMutipleDb.Padding = new System.Windows.Forms.Padding(3);
            this.NzMutipleDb.ShowFocusRectangle = false;
            this.NzMutipleDb.Size = new System.Drawing.Size(426, 25);
            this.NzMutipleDb.TabIndex = 54;
            this.NzMutipleDb.Text = "امکان اتصال به چند بانک اطلاعاتی را داشته باشد ";
            this.NzMutipleDb.TextAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.NzMutipleDb.ToolTipText = "شمـاره خـودکـار";
            // 
            // Form_Con_Str_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 248);
            this.Controls.Add(this.NzMutipleDb);
            this.Controls.Add(this.ms_lock_address);
            this.Controls.Add(this.txtConStr);
            this.Controls.Add(this.Group2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbl_Lock);
            this.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Con_Str_New";
            this.Text = "                                                           آدرس بانک اطلاعاتی";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group2)).EndInit();
            this.Group2.ResumeLayout(false);
            this.Group2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MS_Button_GridX btnOk;
        private Controls.MS_Button_GridX btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Janus.Windows.EditControls.UIGroupBox Group2;
        private Controls.MS_TextBox txtServerName;
        private Controls.MS_CheckBox Check_Server;
        private Controls.MS_TextBox txtPassword;
        private Controls.MS_TextBox txtUserName;
        private Controls.MS_ComboBox_Janus cmbListDBs;
        private Controls.MS_TextBox txtConStr;
        private Controls.MS_Button_GridX btnExit;
        private System.Windows.Forms.Label lbl_Lock;
        private Controls.MS_TextBox ms_lock_address;
        private Controls.MS_CheckBox NzMutipleDb;
    }
}