namespace MS_Control
{
    partial class MS_Mother
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MS_Mother));
            this.lbl_Down_Dorder = new System.Windows.Forms.Label();
            this.lbl_Left_Border = new System.Windows.Forms.Label();
            this.lbl_Right_Border = new System.Windows.Forms.Label();
            this.ms_Title_Header_Form = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_du = new System.Windows.Forms.Label();
            this.lbl_yek = new System.Windows.Forms.Label();
            this.lbl_salmali = new System.Windows.Forms.Label();
            this.lbl_Icon_Form = new System.Windows.Forms.Label();
            this.lbl_Minimize_Form = new System.Windows.Forms.Label();
            this.lbl_Restore_Form = new System.Windows.Forms.Label();
            this.lbl_Close_Form = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Down_Dorder
            // 
            this.lbl_Down_Dorder.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Down_Dorder.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.lbl_Down_Dorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Down_Dorder.Location = new System.Drawing.Point(4, 476);
            this.lbl_Down_Dorder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Down_Dorder.Name = "lbl_Down_Dorder";
            this.lbl_Down_Dorder.Size = new System.Drawing.Size(876, 4);
            this.lbl_Down_Dorder.TabIndex = 26;
            this.lbl_Down_Dorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_down_border_MouseDown);
            this.lbl_Down_Dorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_down_border_MouseMove);
            this.lbl_Down_Dorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_down_border_MouseUp);
            // 
            // lbl_Left_Border
            // 
            this.lbl_Left_Border.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Left_Border.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lbl_Left_Border.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Left_Border.Location = new System.Drawing.Point(0, 0);
            this.lbl_Left_Border.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Left_Border.Name = "lbl_Left_Border";
            this.lbl_Left_Border.Size = new System.Drawing.Size(4, 480);
            this.lbl_Left_Border.TabIndex = 25;
            // 
            // lbl_Right_Border
            // 
            this.lbl_Right_Border.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Right_Border.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lbl_Right_Border.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Right_Border.Location = new System.Drawing.Point(880, 0);
            this.lbl_Right_Border.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Right_Border.Name = "lbl_Right_Border";
            this.lbl_Right_Border.Size = new System.Drawing.Size(4, 480);
            this.lbl_Right_Border.TabIndex = 24;
            this.lbl_Right_Border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_right_border_MouseDown);
            this.lbl_Right_Border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_right_border_MouseMove);
            this.lbl_Right_Border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_right_border_MouseUp);
            // 
            // ms_Title_Header_Form
            // 
            this.ms_Title_Header_Form.BackColor = System.Drawing.Color.DodgerBlue;
            this.ms_Title_Header_Form.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.ms_Title_Header_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ms_Title_Header_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_Title_Header_Form.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ms_Title_Header_Form.Location = new System.Drawing.Point(0, 0);
            this.ms_Title_Header_Form.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ms_Title_Header_Form.Name = "ms_Title_Header_Form";
            this.ms_Title_Header_Form.Size = new System.Drawing.Size(876, 30);
            this.ms_Title_Header_Form.TabIndex = 19;
            this.ms_Title_Header_Form.Text = "فـرم مــادر";
            this.ms_Title_Header_Form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ms_Title_Header_Form.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ms_title_MouseDown);
            this.ms_Title_Header_Form.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ms_title_MouseMove);
            this.ms_Title_Header_Form.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ms_title_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lbl_du);
            this.panel1.Controls.Add(this.lbl_yek);
            this.panel1.Controls.Add(this.lbl_salmali);
            this.panel1.Controls.Add(this.lbl_Icon_Form);
            this.panel1.Controls.Add(this.lbl_Minimize_Form);
            this.panel1.Controls.Add(this.lbl_Restore_Form);
            this.panel1.Controls.Add(this.lbl_Close_Form);
            this.panel1.Controls.Add(this.ms_Title_Header_Form);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 30);
            this.panel1.TabIndex = 27;
            // 
            // lbl_du
            // 
            this.lbl_du.AutoEllipsis = true;
            this.lbl_du.AutoSize = true;
            this.lbl_du.BackColor = System.Drawing.Color.Transparent;
            this.lbl_du.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_du.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_du.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_du.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_du.ForeColor = System.Drawing.Color.Black;
            this.lbl_du.Location = new System.Drawing.Point(154, 0);
            this.lbl_du.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lbl_du.Name = "lbl_du";
            this.lbl_du.Size = new System.Drawing.Size(0, 24);
            this.lbl_du.TabIndex = 32;
            this.lbl_du.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_yek
            // 
            this.lbl_yek.AutoEllipsis = true;
            this.lbl_yek.AutoSize = true;
            this.lbl_yek.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_yek.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_yek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_yek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_yek.ForeColor = System.Drawing.Color.Black;
            this.lbl_yek.Location = new System.Drawing.Point(154, 0);
            this.lbl_yek.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lbl_yek.Name = "lbl_yek";
            this.lbl_yek.Size = new System.Drawing.Size(0, 24);
            this.lbl_yek.TabIndex = 31;
            this.lbl_yek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_salmali
            // 
            this.lbl_salmali.AutoEllipsis = true;
            this.lbl_salmali.AutoSize = true;
            this.lbl_salmali.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salmali.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_salmali.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_salmali.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_salmali.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_salmali.ForeColor = System.Drawing.Color.Black;
            this.lbl_salmali.Location = new System.Drawing.Point(31, 0);
            this.lbl_salmali.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lbl_salmali.Name = "lbl_salmali";
            this.lbl_salmali.Size = new System.Drawing.Size(123, 24);
            this.lbl_salmali.TabIndex = 30;
            this.lbl_salmali.Text = "سال مالی 1393";
            this.lbl_salmali.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Icon_Form
            // 
            this.lbl_Icon_Form.AutoEllipsis = true;
            this.lbl_Icon_Form.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Icon_Form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Icon_Form.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Icon_Form.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Icon_Form.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Icon_Form.Image")));
            this.lbl_Icon_Form.Location = new System.Drawing.Point(0, 0);
            this.lbl_Icon_Form.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lbl_Icon_Form.Name = "lbl_Icon_Form";
            this.lbl_Icon_Form.Size = new System.Drawing.Size(31, 30);
            this.lbl_Icon_Form.TabIndex = 29;
            // 
            // lbl_Minimize_Form
            // 
            this.lbl_Minimize_Form.AutoEllipsis = true;
            this.lbl_Minimize_Form.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Minimize_Form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Minimize_Form.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Minimize_Form.Image = global::MS_Control.Properties.Resources._MS_Form_Min;
            this.lbl_Minimize_Form.Location = new System.Drawing.Point(786, 0);
            this.lbl_Minimize_Form.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lbl_Minimize_Form.Name = "lbl_Minimize_Form";
            this.lbl_Minimize_Form.Size = new System.Drawing.Size(20, 30);
            this.lbl_Minimize_Form.TabIndex = 28;
            this.lbl_Minimize_Form.Click += new System.EventHandler(this.lbl_minimize_Click);
            this.lbl_Minimize_Form.MouseEnter += new System.EventHandler(this.lbl_minimize_MouseEnter);
            this.lbl_Minimize_Form.MouseLeave += new System.EventHandler(this.lbl_minimize_MouseLeave);
            // 
            // lbl_Restore_Form
            // 
            this.lbl_Restore_Form.AutoEllipsis = true;
            this.lbl_Restore_Form.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Restore_Form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Restore_Form.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Restore_Form.Image = global::MS_Control.Properties.Resources._MS_Form_Max_Normal;
            this.lbl_Restore_Form.Location = new System.Drawing.Point(806, 0);
            this.lbl_Restore_Form.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lbl_Restore_Form.Name = "lbl_Restore_Form";
            this.lbl_Restore_Form.Size = new System.Drawing.Size(24, 30);
            this.lbl_Restore_Form.TabIndex = 27;
            this.lbl_Restore_Form.Click += new System.EventHandler(this.lbl_restore_Click);
            this.lbl_Restore_Form.MouseEnter += new System.EventHandler(this.lbl_restore_MouseEnter);
            this.lbl_Restore_Form.MouseLeave += new System.EventHandler(this.lbl_restore_MouseLeave);
            // 
            // lbl_Close_Form
            // 
            this.lbl_Close_Form.AutoEllipsis = true;
            this.lbl_Close_Form.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Close_Form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Close_Form.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Close_Form.Image = global::MS_Control.Properties.Resources._MS_Form_Close;
            this.lbl_Close_Form.Location = new System.Drawing.Point(830, 0);
            this.lbl_Close_Form.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lbl_Close_Form.Name = "lbl_Close_Form";
            this.lbl_Close_Form.Size = new System.Drawing.Size(46, 30);
            this.lbl_Close_Form.TabIndex = 26;
            this.lbl_Close_Form.Click += new System.EventHandler(this.lbl_close_Click);
            this.lbl_Close_Form.MouseEnter += new System.EventHandler(this.lbl_close_MouseEnter);
            this.lbl_Close_Form.MouseLeave += new System.EventHandler(this.lbl_close_MouseLeave);
            // 
            // MS_Mother
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Down_Dorder);
            this.Controls.Add(this.lbl_Left_Border);
            this.Controls.Add(this.lbl_Right_Border);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MS_Mother";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MS_Mother";
            this.Activated += new System.EventHandler(this.MS_Mother_Activated);
            this.Deactivate += new System.EventHandler(this.MS_Mother_Deactivate);
            this.Shown += new System.EventHandler(this.MS_Mother_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lbl_Down_Dorder;
        protected System.Windows.Forms.Label lbl_Left_Border;
        protected System.Windows.Forms.Label lbl_Right_Border;
        protected System.Windows.Forms.Label ms_Title_Header_Form;
        protected System.Windows.Forms.Label lbl_Minimize_Form;
        protected System.Windows.Forms.Label lbl_Restore_Form;
        protected System.Windows.Forms.Label lbl_Close_Form;
        protected System.Windows.Forms.Label lbl_Icon_Form;
        protected System.Windows.Forms.Label lbl_salmali;
        protected System.Windows.Forms.Label lbl_du;
        protected System.Windows.Forms.Label lbl_yek;
        protected System.Windows.Forms.Panel panel1;
    }
}