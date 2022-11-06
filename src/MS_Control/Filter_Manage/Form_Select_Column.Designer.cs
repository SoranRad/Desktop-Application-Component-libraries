namespace MS_Control.Filter_Manage
{
    partial class Form_Select_Column
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Select_Column));
            Janus.Windows.GridEX.GridEXLayout mS_GridX1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.mS_GridX1 = new MS_Control.Controls.MS_GridX();
            this.ms_save = new MS_Control.Controls.MS_Button_GridX();
            ((System.ComponentModel.ISupportInitialize)(this.mS_GridX1)).BeginInit();
            this.SuspendLayout();
            // 
            // mS_GridX1
            // 
            this.mS_GridX1.AlternatingColors = true;
            this.mS_GridX1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.Lavender;
            this.mS_GridX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mS_GridX1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mS_GridX1.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
            this.mS_GridX1.BuiltInTextsData = resources.GetString("mS_GridX1.BuiltInTextsData");
            this.mS_GridX1.ColumnAutoResize = true;
            this.mS_GridX1.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            mS_GridX1_DesignTimeLayout.LayoutString = resources.GetString("mS_GridX1_DesignTimeLayout.LayoutString");
            this.mS_GridX1.DesignTimeLayout = mS_GridX1_DesignTimeLayout;
            this.mS_GridX1.DynamicFiltering = true;
            this.mS_GridX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.mS_GridX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.mS_GridX1.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.mS_GridX1.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mS_GridX1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.mS_GridX1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mS_GridX1.GroupByBoxVisible = false;
            this.mS_GridX1.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.mS_GridX1.Location = new System.Drawing.Point(1, -1);
            this.mS_GridX1.Name = "mS_GridX1";
            this.mS_GridX1.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.mS_GridX1.Office2007CustomColor = System.Drawing.Color.SteelBlue;
            this.mS_GridX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_GridX1.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.mS_GridX1.SelectedFormatStyle.BackColor = System.Drawing.Color.LightBlue;
            this.mS_GridX1.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.LightBlue;
            this.mS_GridX1.Size = new System.Drawing.Size(277, 377);
            this.mS_GridX1.TabIndex = 0;
            this.mS_GridX1.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mS_GridX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // ms_save
            // 
            this.ms_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ms_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_save.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_save.Image = global::MS_Control.Properties.Resources.check1;
            this.ms_save.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_save.Location = new System.Drawing.Point(1, 379);
            this.ms_save.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_save.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_save.MS_Change_Border_Color_On_Enter = false;
            this.ms_save.MS_Change_Color_On_Enter = false;
            this.ms_save.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_save.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_save.Name = "ms_save";
            this.ms_save.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_save.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_save.ShowFocusRectangle = false;
            this.ms_save.Size = new System.Drawing.Size(103, 27);
            this.ms_save.TabIndex = 6;
            this.ms_save.Text = "تایـیـد";
            this.ms_save.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.ms_save.UseThemes = false;
            this.ms_save.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_save.WordWrap = false;
            this.ms_save.Click += new System.EventHandler(this.ms_save_Click);
            // 
            // Form_Select_Column
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 408);
            this.Controls.Add(this.ms_save);
            this.Controls.Add(this.mS_GridX1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Select_Column";
            this.Text = "                        انتـخاب ستون عددی";
            ((System.ComponentModel.ISupportInitialize)(this.mS_GridX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MS_GridX mS_GridX1;
        private Controls.MS_Button_GridX ms_save;
    }
}