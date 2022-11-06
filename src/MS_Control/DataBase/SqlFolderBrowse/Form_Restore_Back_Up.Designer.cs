namespace MS_Control.DataBase.SqlFolderBrowse
{
    partial class Form_Restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Restore));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnOk = new MS_Control.Controls.MS_Button_GridX();
            this.btnCancel = new MS_Control.Controls.MS_Button_GridX();
            this.lblPath = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView_Files = new System.Windows.Forms.TreeView();
            this.lblNothing = new System.Windows.Forms.Label();
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnOk);
            this.panelEx1.Controls.Add(this.btnCancel);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 313);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(624, 48);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 20;
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Image = global::MS_Control.Properties.Resources.check1;
            this.btnOk.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.btnOk.ImageSize = new System.Drawing.Size(18, 18);
            this.btnOk.Location = new System.Drawing.Point(117, 9);
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
            this.btnOk.Size = new System.Drawing.Size(103, 30);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "انـتـخــاب";
            this.btnOk.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.btnOk.UseThemes = false;
            this.btnOk.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnOk.WordWrap = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancel.Image = global::MS_Control.Properties.Resources.close_16;
            this.btnCancel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.btnCancel.Location = new System.Drawing.Point(8, 9);
            this.btnCancel.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.btnCancel.MS_Change_Border_Color_On_Enter = false;
            this.btnCancel.MS_Change_Color_On_Enter = false;
            this.btnCancel.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.btnCancel.MS_Enter_Color = System.Drawing.Color.Empty;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.btnCancel.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.ShowFocusRectangle = false;
            this.btnCancel.Size = new System.Drawing.Size(103, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "انــصــراف";
            this.btnCancel.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.btnCancel.UseThemes = false;
            this.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnCancel.WordWrap = false;
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPath.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPath.Location = new System.Drawing.Point(1, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(622, 26);
            this.lblPath.TabIndex = 19;
            this.lblPath.Text = "...";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.ilIcons;
            this.treeView1.Location = new System.Drawing.Point(1, 27);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(297, 285);
            this.treeView1.TabIndex = 17;
            this.treeView1.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCollapse);
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // treeView_Files
            // 
            this.treeView_Files.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_Files.Location = new System.Drawing.Point(299, 27);
            this.treeView_Files.Margin = new System.Windows.Forms.Padding(4);
            this.treeView_Files.Name = "treeView_Files";
            this.treeView_Files.Size = new System.Drawing.Size(324, 285);
            this.treeView_Files.TabIndex = 21;
            this.treeView_Files.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Files_AfterSelect);
            // 
            // lblNothing
            // 
            this.lblNothing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNothing.BackColor = System.Drawing.Color.White;
            this.lblNothing.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNothing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNothing.Location = new System.Drawing.Point(300, 28);
            this.lblNothing.Name = "lblNothing";
            this.lblNothing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNothing.Size = new System.Drawing.Size(321, 283);
            this.lblNothing.TabIndex = 22;
            this.lblNothing.Text = "هـیچ فـایل پشـتیبـانـی یـافت نـشـد";
            this.lblNothing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNothing.Visible = false;
            // 
            // ilIcons
            // 
            this.ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcons.ImageStream")));
            this.ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIcons.Images.SetKeyName(0, "hard-drive-windows-1 (1).png");
            this.ilIcons.Images.SetKeyName(1, "folder_closed.png");
            this.ilIcons.Images.SetKeyName(2, "folder_open.png");
            // 
            // Form_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.lblNothing);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.treeView_Files);
            this.Controls.Add(this.lblPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 400);
            this.Name = "Form_Restore";
            this.Text = "انـتـخـاب فـایل پـشتـیبـان";
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Controls.MS_Button_GridX btnOk;
        private Controls.MS_Button_GridX btnCancel;
        private System.Windows.Forms.Label lblPath;
        internal System.Windows.Forms.TreeView treeView1;
        internal System.Windows.Forms.TreeView treeView_Files;
        private System.Windows.Forms.Label lblNothing;
        internal System.Windows.Forms.ImageList ilIcons;
    }
}