namespace MS_Control.DataBase.SqlFolderBrowse
{
    partial class Form_Add_Back_Up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_Back_Up));
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.ms_New_Folder = new MS_Control.Controls.MS_Button_GridX();
            this.btnOk = new MS_Control.Controls.MS_Button_GridX();
            this.btnCancel = new MS_Control.Controls.MS_Button_GridX();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.lblPath = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilIcons
            // 
            this.ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcons.ImageStream")));
            this.ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIcons.Images.SetKeyName(0, "hard-drive-windows-1 (1).png");
            this.ilIcons.Images.SetKeyName(1, "folder_closed.png");
            this.ilIcons.Images.SetKeyName(2, "folder_open.png");
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.ms_New_Folder);
            this.panelEx1.Controls.Add(this.btnOk);
            this.panelEx1.Controls.Add(this.btnCancel);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 347);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(507, 38);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 13;
            // 
            // ms_New_Folder
            // 
            this.ms_New_Folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_New_Folder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_New_Folder.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_New_Folder.Image = ((System.Drawing.Image)(resources.GetObject("ms_New_Folder.Image")));
            this.ms_New_Folder.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center;
            this.ms_New_Folder.Location = new System.Drawing.Point(471, 5);
            this.ms_New_Folder.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_New_Folder.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_New_Folder.MS_Change_Border_Color_On_Enter = false;
            this.ms_New_Folder.MS_Change_Color_On_Enter = false;
            this.ms_New_Folder.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_New_Folder.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_New_Folder.Name = "ms_New_Folder";
            this.ms_New_Folder.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_New_Folder.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_New_Folder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_New_Folder.ShowFocusRectangle = false;
            this.ms_New_Folder.Size = new System.Drawing.Size(29, 29);
            this.ms_New_Folder.TabIndex = 4;
            this.ms_New_Folder.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.ms_New_Folder.ToolTipText = "سـاخت فـولـدر جـدیـد در مـسیـر";
            this.ms_New_Folder.UseThemes = false;
            this.ms_New_Folder.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_New_Folder.WordWrap = false;
            this.ms_New_Folder.Click += new System.EventHandler(this.ms_New_Folder_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.btnOk.Location = new System.Drawing.Point(112, 5);
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
            this.btnOk.Size = new System.Drawing.Size(103, 29);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "انـتـخــاب";
            this.btnOk.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.btnOk.UseThemes = false;
            this.btnOk.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnOk.WordWrap = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.btnCancel.Location = new System.Drawing.Point(3, 5);
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
            this.btnCancel.Size = new System.Drawing.Size(103, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "انــصــراف";
            this.btnCancel.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.btnCancel.UseThemes = false;
            this.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnCancel.WordWrap = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TreeView1
            // 
            this.TreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeView1.ImageIndex = 1;
            this.TreeView1.ImageList = this.ilIcons;
            this.TreeView1.Location = new System.Drawing.Point(0, -1);
            this.TreeView1.Margin = new System.Windows.Forms.Padding(4);
            this.TreeView1.Name = "TreeView1";
            this.TreeView1.SelectedImageIndex = 0;
            this.TreeView1.Size = new System.Drawing.Size(507, 321);
            this.TreeView1.TabIndex = 11;
            this.TreeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.TreeView1_AfterLabelEdit);
            this.TreeView1.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterCollapse);
            this.TreeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterExpand);
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.TreeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TreeView1_KeyDown);
            this.TreeView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TreeView1_KeyUp);
            this.TreeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView1_MouseDown);
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPath.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPath.Location = new System.Drawing.Point(0, 320);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(507, 27);
            this.lblPath.TabIndex = 12;
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Add_Back_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 385);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.TreeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.MS_Escap = MS_Control.MS_Mother_Two.Escap_Exit.No;
            this.Name = "Form_Add_Back_Up";
            this.Text = "انـتـخــاب مـسـیـر پـشـتـیـبـانگـیــری";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_Add_Back_Up_PreviewKeyDown);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList ilIcons;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Controls.MS_Button_GridX ms_New_Folder;
        private Controls.MS_Button_GridX btnOk;
        private Controls.MS_Button_GridX btnCancel;
        internal System.Windows.Forms.TreeView TreeView1;
        private System.Windows.Forms.Label lblPath;
    }
}