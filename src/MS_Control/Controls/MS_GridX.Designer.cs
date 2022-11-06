namespace MS_Control.Controls
{
    partial class MS_GridX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MS_GridX));
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MS_GridX
            // 
            this.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
            this.BuiltInTextsData = resources.GetString("$this.BuiltInTextsData");
            this.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            this.DynamicFiltering = true;
            this.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.Font = new System.Drawing.Font("B Nazanin", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.SelectedFormatStyle.BackColor = System.Drawing.Color.LightBlue;
            this.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.LightBlue;
            this.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ColumnVisibleChanged += new Janus.Windows.GridEX.ColumnActionEventHandler(this.MS_GridX_ColumnVisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

    }
}
