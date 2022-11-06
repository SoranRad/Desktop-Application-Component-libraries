namespace MS_Control.Filter_Manage
{
    partial class Form_Manage_Filter
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ms_load_Filter = new MS_Control.Controls.MS_Button();
            this.mS_Button1 = new MS_Control.Controls.MS_Button();
            this.ms_is_public = new MS_Control.Controls.MS_CheckBox();
            this.ms_name = new MS_Control.Controls.MS_TextBox();
            this.ms_save = new MS_Control.Controls.MS_Button();
            this.ms_remove = new MS_Control.Controls.MS_Button();
            this.ms_apply = new MS_Control.Controls.MS_Button();
            this.ms_filter = new MS_Control.MS_Filter_Condition();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Down_Dorder
            // 
            this.lbl_Down_Dorder.Location = new System.Drawing.Point(4, 495);
            this.lbl_Down_Dorder.Size = new System.Drawing.Size(1025, 5);
            // 
            // lbl_Left_Border
            // 
            this.lbl_Left_Border.Size = new System.Drawing.Size(4, 500);
            // 
            // lbl_Right_Border
            // 
            this.lbl_Right_Border.Location = new System.Drawing.Point(1029, 0);
            this.lbl_Right_Border.Size = new System.Drawing.Size(4, 500);
            // 
            // ms_Title_Header_Form
            // 
            this.ms_Title_Header_Form.ForeColor = System.Drawing.Color.White;
            this.ms_Title_Header_Form.Size = new System.Drawing.Size(1025, 31);
            this.ms_Title_Header_Form.Text = "فیلــتر پیشـرفته اطــلاعـات";
            // 
            // lbl_Minimize_Form
            // 
            this.lbl_Minimize_Form.Location = new System.Drawing.Point(935, 0);
            this.lbl_Minimize_Form.Size = new System.Drawing.Size(20, 31);
            // 
            // lbl_Restore_Form
            // 
            this.lbl_Restore_Form.Location = new System.Drawing.Point(955, 0);
            this.lbl_Restore_Form.Size = new System.Drawing.Size(24, 31);
            // 
            // lbl_Close_Form
            // 
            this.lbl_Close_Form.Location = new System.Drawing.Point(979, 0);
            this.lbl_Close_Form.Size = new System.Drawing.Size(46, 31);
            // 
            // lbl_Icon_Form
            // 
            this.lbl_Icon_Form.Size = new System.Drawing.Size(31, 31);
            // 
            // lbl_du
            // 
            this.lbl_du.Location = new System.Drawing.Point(31, 0);
            // 
            // lbl_yek
            // 
            this.lbl_yek.Location = new System.Drawing.Point(31, 0);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1025, 31);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.ms_load_Filter);
            this.panel2.Controls.Add(this.mS_Button1);
            this.panel2.Controls.Add(this.ms_is_public);
            this.panel2.Controls.Add(this.ms_name);
            this.panel2.Controls.Add(this.ms_save);
            this.panel2.Controls.Add(this.ms_remove);
            this.panel2.Controls.Add(this.ms_apply);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 37);
            this.panel2.TabIndex = 28;
            // 
            // ms_load_Filter
            // 
            this.ms_load_Filter.BackColor = System.Drawing.SystemColors.Control;
            this.ms_load_Filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_load_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ms_load_Filter.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_load_Filter.Image = global::MS_Control.Properties.Resources.refresh;
            this.ms_load_Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ms_load_Filter.Location = new System.Drawing.Point(353, 3);
            this.ms_load_Filter.MS_BorderColor = System.Drawing.Color.DarkGray;
            this.ms_load_Filter.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_load_Filter.MS_Change_Border_Color_On_Enter = true;
            this.ms_load_Filter.MS_Change_Color_On_Enter = true;
            this.ms_load_Filter.MS_Color_End = System.Drawing.Color.Empty;
            this.ms_load_Filter.MS_Color_Start = System.Drawing.Color.Empty;
            this.ms_load_Filter.MS_Draw_Border = true;
            this.ms_load_Filter.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ms_load_Filter.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_load_Filter.Name = "ms_load_Filter";
            this.ms_load_Filter.Size = new System.Drawing.Size(26, 26);
            this.ms_load_Filter.TabIndex = 6;
            this.ms_load_Filter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ms_load_Filter.UseVisualStyleBackColor = false;
            this.ms_load_Filter.Click += new System.EventHandler(this.ms_load_Filter_Click);
            // 
            // mS_Button1
            // 
            this.mS_Button1.BackColor = System.Drawing.SystemColors.Control;
            this.mS_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mS_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mS_Button1.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mS_Button1.Image = global::MS_Control.Properties.Resources.table_filter;
            this.mS_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mS_Button1.Location = new System.Drawing.Point(3, 2);
            this.mS_Button1.MS_BorderColor = System.Drawing.Color.DarkGray;
            this.mS_Button1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Button1.MS_Change_Border_Color_On_Enter = true;
            this.mS_Button1.MS_Change_Color_On_Enter = true;
            this.mS_Button1.MS_Color_End = System.Drawing.Color.Empty;
            this.mS_Button1.MS_Color_Start = System.Drawing.Color.Empty;
            this.mS_Button1.MS_Draw_Border = true;
            this.mS_Button1.MS_Enter_Border_Color = System.Drawing.Color.Red;
            this.mS_Button1.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mS_Button1.Name = "mS_Button1";
            this.mS_Button1.Size = new System.Drawing.Size(91, 26);
            this.mS_Button1.TabIndex = 5;
            this.mS_Button1.Text = "مـدیریت";
            this.mS_Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mS_Button1.UseVisualStyleBackColor = false;
            // 
            // ms_is_public
            // 
            this.ms_is_public.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_is_public.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_is_public.Location = new System.Drawing.Point(727, 4);
            this.ms_is_public.MS_BorderColor = System.Drawing.Color.DimGray;
            this.ms_is_public.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_is_public.MS_Change_Border_Color_On_Enter = true;
            this.ms_is_public.MS_Change_Color_On_Checked = false;
            this.ms_is_public.MS_Change_Color_On_Enter = false;
            this.ms_is_public.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_is_public.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ms_is_public.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.ms_is_public.MS_Exit_By_Down = true;
            this.ms_is_public.MS_Exit_By_Enter = true;
            this.ms_is_public.MS_Exit_By_Up = true;
            this.ms_is_public.MS_Last_Control = null;
            this.ms_is_public.MS_Next_Control = null;
            this.ms_is_public.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.ms_is_public.Name = "ms_is_public";
            this.ms_is_public.Padding = new System.Windows.Forms.Padding(2, 0, 2, 3);
            this.ms_is_public.Size = new System.Drawing.Size(74, 24);
            this.ms_is_public.TabIndex = 1;
            this.ms_is_public.Text = " عمومی";
            // 
            // ms_name
            // 
            this.ms_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_name.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_name.Location = new System.Drawing.Point(806, 3);
            this.ms_name.MS_BorderColor = System.Drawing.Color.Gray;
            this.ms_name.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_name.MS_Change_Border_Color_On_Enter = true;
            this.ms_name.MS_Change_Color_On_Enter = true;
            this.ms_name.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ms_name.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.ms_name.MS_Exit_By_Down = true;
            this.ms_name.MS_Exit_By_Enter = true;
            this.ms_name.MS_Exit_By_Up = true;
            this.ms_name.MS_Last_Control = null;
            this.ms_name.MS_Next_Control = null;
            this.ms_name.Name = "ms_name";
            this.ms_name.Size = new System.Drawing.Size(211, 27);
            this.ms_name.TabIndex = 0;
            // 
            // ms_save
            // 
            this.ms_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_save.BackColor = System.Drawing.SystemColors.Control;
            this.ms_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ms_save.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_save.Image = global::MS_Control.Properties.Resources.check;
            this.ms_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ms_save.Location = new System.Drawing.Point(608, 3);
            this.ms_save.MS_BorderColor = System.Drawing.Color.DarkGray;
            this.ms_save.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_save.MS_Change_Border_Color_On_Enter = true;
            this.ms_save.MS_Change_Color_On_Enter = true;
            this.ms_save.MS_Color_End = System.Drawing.Color.Empty;
            this.ms_save.MS_Color_Start = System.Drawing.Color.Empty;
            this.ms_save.MS_Draw_Border = true;
            this.ms_save.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ms_save.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_save.Name = "ms_save";
            this.ms_save.Size = new System.Drawing.Size(114, 25);
            this.ms_save.TabIndex = 2;
            this.ms_save.Text = "ذخـیـره فیلـتر";
            this.ms_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ms_save.UseVisualStyleBackColor = false;
            // 
            // ms_remove
            // 
            this.ms_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_remove.BackColor = System.Drawing.SystemColors.Control;
            this.ms_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ms_remove.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_remove.Image = global::MS_Control.Properties.Resources.filter_clear;
            this.ms_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ms_remove.Location = new System.Drawing.Point(384, 3);
            this.ms_remove.MS_BorderColor = System.Drawing.Color.DarkGray;
            this.ms_remove.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_remove.MS_Change_Border_Color_On_Enter = true;
            this.ms_remove.MS_Change_Color_On_Enter = true;
            this.ms_remove.MS_Color_End = System.Drawing.Color.Empty;
            this.ms_remove.MS_Color_Start = System.Drawing.Color.Empty;
            this.ms_remove.MS_Draw_Border = true;
            this.ms_remove.MS_Enter_Border_Color = System.Drawing.Color.Red;
            this.ms_remove.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ms_remove.Name = "ms_remove";
            this.ms_remove.Size = new System.Drawing.Size(107, 25);
            this.ms_remove.TabIndex = 4;
            this.ms_remove.Text = "حــذف فیـلتر";
            this.ms_remove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ms_remove.UseVisualStyleBackColor = false;
            this.ms_remove.Click += new System.EventHandler(this.ms_remove_Click);
            // 
            // ms_apply
            // 
            this.ms_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_apply.BackColor = System.Drawing.SystemColors.Control;
            this.ms_apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_apply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ms_apply.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_apply.Image = global::MS_Control.Properties.Resources.filter_reapply;
            this.ms_apply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ms_apply.Location = new System.Drawing.Point(496, 3);
            this.ms_apply.MS_BorderColor = System.Drawing.Color.DarkGray;
            this.ms_apply.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_apply.MS_Change_Border_Color_On_Enter = true;
            this.ms_apply.MS_Change_Color_On_Enter = true;
            this.ms_apply.MS_Color_End = System.Drawing.Color.Empty;
            this.ms_apply.MS_Color_Start = System.Drawing.Color.Empty;
            this.ms_apply.MS_Draw_Border = true;
            this.ms_apply.MS_Enter_Border_Color = System.Drawing.Color.Blue;
            this.ms_apply.MS_Enter_Color = System.Drawing.Color.SkyBlue;
            this.ms_apply.Name = "ms_apply";
            this.ms_apply.Size = new System.Drawing.Size(107, 25);
            this.ms_apply.TabIndex = 3;
            this.ms_apply.Text = "اعمـال فیـلتر";
            this.ms_apply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ms_apply.UseVisualStyleBackColor = false;
            this.ms_apply.Click += new System.EventHandler(this.ms_apply_Click);
            // 
            // ms_filter
            // 
            this.ms_filter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ms_filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.ms_filter.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_filter.Location = new System.Drawing.Point(4, 68);
            this.ms_filter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ms_filter.MS_Is_Mother = true;
            this.ms_filter.Name = "ms_filter";
            this.ms_filter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_filter.Size = new System.Drawing.Size(1025, 46);
            this.ms_filter.TabIndex = 29;
            // 
            // Form_Manage_Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 500);
            this.Controls.Add(this.ms_filter);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1366, 707);
            this.Name = "Form_Manage_Filter";
            this.Text = "فیلــتر پیشـرفته اطــلاعـات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.lbl_Right_Border, 0);
            this.Controls.SetChildIndex(this.lbl_Left_Border, 0);
            this.Controls.SetChildIndex(this.lbl_Down_Dorder, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.ms_filter, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Controls.MS_Button mS_Button1;
        private Controls.MS_CheckBox ms_is_public;
        private Controls.MS_TextBox ms_name;
        private Controls.MS_Button ms_save;
        private Controls.MS_Button ms_remove;
        private Controls.MS_Button ms_apply;
        private MS_Filter_Condition ms_filter;
        private Controls.MS_Button ms_load_Filter;
    }
}