namespace MS_Control_Test
{
    partial class Form_Startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Startup));
            this.mS_Menu1 = new MS_Control.Controls.MS_Menu();
            this.ms_baseinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.personalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NzReports = new System.Windows.Forms.ToolStripMenuItem();
            this.roleOfAPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personsInARolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsStrartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.setBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NzAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_MdiTab = new MdiTabStrip.MdiTabStrip();
            this.mS_Menu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ms_MdiTab)).BeginInit();
            this.SuspendLayout();
            // 
            // mS_Menu1
            // 
            this.mS_Menu1.AutoSize = false;
            this.mS_Menu1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mS_Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_baseinfo,
            this.NzReports,
            this.ms_settings,
            this.NzAbout});
            this.mS_Menu1.Location = new System.Drawing.Point(0, 0);
            this.mS_Menu1.MS_BorderColor = System.Drawing.Color.CornflowerBlue;
            this.mS_Menu1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Menu1.MS_Color_End = System.Drawing.Color.LightSteelBlue;
            this.mS_Menu1.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_Menu1.Name = "mS_Menu1";
            this.mS_Menu1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mS_Menu1.Size = new System.Drawing.Size(920, 30);
            this.mS_Menu1.TabIndex = 8;
            this.mS_Menu1.Text = "mS_Menu1";
            // 
            // ms_baseinfo
            // 
            this.ms_baseinfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalsToolStripMenuItem,
            this.addPersonToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.addRoleToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.ms_baseinfo.Image = ((System.Drawing.Image)(resources.GetObject("ms_baseinfo.Image")));
            this.ms_baseinfo.Name = "ms_baseinfo";
            this.ms_baseinfo.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ms_baseinfo.Size = new System.Drawing.Size(55, 24);
            this.ms_baseinfo.Tag = "1";
            this.ms_baseinfo.Text = "File";
            // 
            // personalsToolStripMenuItem
            // 
            this.personalsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personalsToolStripMenuItem.Image")));
            this.personalsToolStripMenuItem.Name = "personalsToolStripMenuItem";
            this.personalsToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.personalsToolStripMenuItem.Text = "Personals";
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addPersonToolStripMenuItem.Image")));
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.addPersonToolStripMenuItem.Text = "Add Person";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rolesToolStripMenuItem.Image")));
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // addRoleToolStripMenuItem
            // 
            this.addRoleToolStripMenuItem.Name = "addRoleToolStripMenuItem";
            this.addRoleToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.addRoleToolStripMenuItem.Text = "Add Role";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // NzReports
            // 
            this.NzReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roleOfAPersonToolStripMenuItem,
            this.personsInARolesToolStripMenuItem});
            this.NzReports.Image = ((System.Drawing.Image)(resources.GetObject("NzReports.Image")));
            this.NzReports.Name = "NzReports";
            this.NzReports.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.NzReports.Size = new System.Drawing.Size(82, 24);
            this.NzReports.Tag = "180";
            this.NzReports.Text = "Reports";
            // 
            // roleOfAPersonToolStripMenuItem
            // 
            this.roleOfAPersonToolStripMenuItem.Name = "roleOfAPersonToolStripMenuItem";
            this.roleOfAPersonToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.roleOfAPersonToolStripMenuItem.Text = "Role of a person";
            // 
            // personsInARolesToolStripMenuItem
            // 
            this.personsInARolesToolStripMenuItem.Name = "personsInARolesToolStripMenuItem";
            this.personsInARolesToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.personsInARolesToolStripMenuItem.Text = "Persons in a roles";
            // 
            // ms_settings
            // 
            this.ms_settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.setAsStrartupToolStripMenuItem,
            this.toolStripSeparator2,
            this.setBackgroundToolStripMenuItem});
            this.ms_settings.Image = ((System.Drawing.Image)(resources.GetObject("ms_settings.Image")));
            this.ms_settings.Name = "ms_settings";
            this.ms_settings.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ms_settings.Size = new System.Drawing.Size(84, 24);
            this.ms_settings.Tag = "180";
            this.ms_settings.Text = "Settings";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // setAsStrartupToolStripMenuItem
            // 
            this.setAsStrartupToolStripMenuItem.Name = "setAsStrartupToolStripMenuItem";
            this.setAsStrartupToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.setAsStrartupToolStripMenuItem.Text = "Set as strartup";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // setBackgroundToolStripMenuItem
            // 
            this.setBackgroundToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("setBackgroundToolStripMenuItem.Image")));
            this.setBackgroundToolStripMenuItem.Name = "setBackgroundToolStripMenuItem";
            this.setBackgroundToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.setBackgroundToolStripMenuItem.Text = "Set background";
            // 
            // NzAbout
            // 
            this.NzAbout.Name = "NzAbout";
            this.NzAbout.Size = new System.Drawing.Size(59, 24);
            this.NzAbout.Text = "About";
            // 
            // ms_MdiTab
            // 
            this.ms_MdiTab.ActiveTabBorderColor = System.Drawing.Color.RoyalBlue;
            this.ms_MdiTab.ActiveTabFont = new System.Drawing.Font("Segoe UI", 9F);
            this.ms_MdiTab.ActiveTabForeColor = System.Drawing.Color.MidnightBlue;
            this.ms_MdiTab.AllowDrop = true;
            this.ms_MdiTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.ms_MdiTab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_MdiTab.InactiveTabBorderColor = System.Drawing.Color.LightSteelBlue;
            this.ms_MdiTab.InactiveTabColor = System.Drawing.Color.Lavender;
            this.ms_MdiTab.InactiveTabFont = new System.Drawing.Font("Segoe UI", 9F);
            this.ms_MdiTab.InactiveTabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ms_MdiTab.Location = new System.Drawing.Point(0, 30);
            this.ms_MdiTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ms_MdiTab.MaxTabWidth = 300;
            this.ms_MdiTab.MdiNewTabImage = null;
            this.ms_MdiTab.MdiWindowState = MdiTabStrip.MdiChildWindowState.Maximized;
            this.ms_MdiTab.MinimumSize = new System.Drawing.Size(58, 40);
            this.ms_MdiTab.MinTabWidth = 50;
            this.ms_MdiTab.MouseOverTabColor = System.Drawing.Color.SteelBlue;
            this.ms_MdiTab.MouseOverTabFont = new System.Drawing.Font("Segoe UI", 9F);
            this.ms_MdiTab.MouseOverTabForeColor = System.Drawing.Color.White;
            this.ms_MdiTab.Name = "ms_MdiTab";
            this.ms_MdiTab.NewTabToolTipText = "";
            this.ms_MdiTab.Padding = new System.Windows.Forms.Padding(2, 5, 12, 3);
            this.ms_MdiTab.ShowTabToolTip = false;
            this.ms_MdiTab.Size = new System.Drawing.Size(920, 40);
            this.ms_MdiTab.TabIndex = 12;
            this.ms_MdiTab.TabPermanence = MdiTabStrip.MdiTabPermanence.First;
            // 
            // Form_Startup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 396);
            this.Controls.Add(this.ms_MdiTab);
            this.Controls.Add(this.mS_Menu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "Form_Startup";
            this.Text = "Portfolio";
            this.mS_Menu1.ResumeLayout(false);
            this.mS_Menu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ms_MdiTab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Control.Controls.MS_Menu mS_Menu1;
        private System.Windows.Forms.ToolStripMenuItem ms_baseinfo;
        private System.Windows.Forms.ToolStripMenuItem NzReports;
        private System.Windows.Forms.ToolStripMenuItem ms_settings;
        private System.Windows.Forms.ToolStripMenuItem NzAbout;
        private System.Windows.Forms.ToolStripMenuItem personalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleOfAPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personsInARolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAsStrartupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem setBackgroundToolStripMenuItem;
        private MdiTabStrip.MdiTabStrip ms_MdiTab;
    }
}