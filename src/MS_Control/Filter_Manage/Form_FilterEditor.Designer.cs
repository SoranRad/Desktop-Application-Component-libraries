namespace MS_Control.Filter_Manage
{
    partial class Form_FilterEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FilterEditor));
            this.filterEditor1 = new Janus.Windows.FilterEditor.FilterEditor();
            this.SuspendLayout();
            // 
            // filterEditor1
            // 
            this.filterEditor1.AllowFilterByFieldValue = true;
            this.filterEditor1.AllowNegateRootCondition = true;
            this.filterEditor1.AutoApply = true;
            this.filterEditor1.AutomaticHeightResize = true;
            this.filterEditor1.BackColor = System.Drawing.Color.Transparent;
            this.filterEditor1.BuiltInTextsData = resources.GetString("filterEditor1.BuiltInTextsData");
            this.filterEditor1.DefaultConditionOperator = Janus.Data.ConditionOperator.Contains;
            this.filterEditor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterEditor1.EditControlWidth = 200;
            this.filterEditor1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.filterEditor1.FormatStyle.BackColor = System.Drawing.Color.LightBlue;
            this.filterEditor1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.UseFormatStyle;
            this.filterEditor1.Location = new System.Drawing.Point(0, 0);
            this.filterEditor1.MinimumSize = new System.Drawing.Size(767, 59);
            this.filterEditor1.MinSize = new System.Drawing.Size(0, 0);
            this.filterEditor1.Name = "filterEditor1";
            this.filterEditor1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Default;
            this.filterEditor1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.filterEditor1.ScrollMode = Janus.Windows.UI.Dock.ScrollMode.Both;
            this.filterEditor1.ScrollStep = 15;
            this.filterEditor1.Size = new System.Drawing.Size(813, 59);
            // 
            // Form_FilterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(813, 80);
            this.Controls.Add(this.filterEditor1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(829, 119);
            this.Name = "Form_FilterEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "                                                                              فیـ" +
    "لـتـر پیشــرفتـه";
            this.TopLeftCornerSize = 10;
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.FilterEditor.FilterEditor filterEditor1;
    }
}