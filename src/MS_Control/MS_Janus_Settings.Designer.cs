namespace MS_Control
{
    partial class MS_Janus_Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ms_max = new MS_Control.Controls.MS_Button();
            this.ms_min = new MS_Control.Controls.MS_Button();
            this.SuspendLayout();
            // 
            // ms_max
            // 
            this.ms_max.BackColor = System.Drawing.Color.White;
            this.ms_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ms_max.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_max.Location = new System.Drawing.Point(30, 2);
            this.ms_max.MS_BorderColor = System.Drawing.Color.Teal;
            this.ms_max.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_max.MS_Change_Border_Color_On_Enter = true;
            this.ms_max.MS_Change_Color_On_Enter = true;
            this.ms_max.MS_Color_End = System.Drawing.Color.Empty;
            this.ms_max.MS_Color_Start = System.Drawing.Color.Empty;
            this.ms_max.MS_Draw_Border = true;
            this.ms_max.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_max.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ms_max.Name = "ms_max";
            this.ms_max.Size = new System.Drawing.Size(26, 26);
            this.ms_max.TabIndex = 7;
            this.ms_max.Text = "F";
            this.ms_max.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ms_max.UseVisualStyleBackColor = false;
            this.ms_max.Click += new System.EventHandler(this.ms_max_Click);
            // 
            // ms_min
            // 
            this.ms_min.BackColor = System.Drawing.Color.White;
            this.ms_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ms_min.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_min.Location = new System.Drawing.Point(2, 2);
            this.ms_min.MS_BorderColor = System.Drawing.Color.Teal;
            this.ms_min.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_min.MS_Change_Border_Color_On_Enter = true;
            this.ms_min.MS_Change_Color_On_Enter = true;
            this.ms_min.MS_Color_End = System.Drawing.Color.Empty;
            this.ms_min.MS_Color_Start = System.Drawing.Color.Empty;
            this.ms_min.MS_Draw_Border = true;
            this.ms_min.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_min.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ms_min.Name = "ms_min";
            this.ms_min.Size = new System.Drawing.Size(26, 26);
            this.ms_min.TabIndex = 6;
            this.ms_min.Text = "G";
            this.ms_min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ms_min.UseVisualStyleBackColor = false;
            this.ms_min.Click += new System.EventHandler(this.ms_min_Click);
            // 
            // MS_Janus_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ms_max);
            this.Controls.Add(this.ms_min);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MS_Janus_Settings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(58, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MS_Button ms_max;
        private Controls.MS_Button ms_min;
    }
}
