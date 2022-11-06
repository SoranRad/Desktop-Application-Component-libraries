namespace MS_Control_Test
{
    partial class Form_Two
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Two));
            Janus.Windows.GridEX.GridEXLayout ms_grid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mS_GridX_Setting1 = new MS_Control.Controls.MS_GridX_Setting();
            this.ms_grid = new MS_Control.Controls.MS_GridX();
            this.mS_NumericTextBox1 = new MS_Control.Controls.MS_NumericTextBox();
            this.mS_NumericTextBox2 = new MS_Control.Controls.MS_NumericTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mS_Tarikh_TextBox2 = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.mS_Tarikh_TextBox1 = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.mS_Combo_Test3 = new MS_Control_Test.MS_Combo_Test();
            this.mS_Combo_Test1 = new MS_Control_Test.MS_Combo_Test();
            this.mS_Combo_Test2 = new MS_Control_Test.MS_Combo_Test();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ms_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "filter.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(792, -6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(792, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button2_KeyUp);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // mS_GridX_Setting1
            // 
            this.mS_GridX_Setting1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mS_GridX_Setting1.Location = new System.Drawing.Point(0, 525);
            this.mS_GridX_Setting1.MS_BorderColor = System.Drawing.Color.Blue;
            this.mS_GridX_Setting1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_GridX_Setting1.MS_Color_End = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mS_GridX_Setting1.MS_Color_Start = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mS_GridX_Setting1.MS_GridX = this.ms_grid;
            this.mS_GridX_Setting1.Name = "mS_GridX_Setting1";
            this.mS_GridX_Setting1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_GridX_Setting1.Size = new System.Drawing.Size(879, 25);
            this.mS_GridX_Setting1.TabIndex = 7;
            this.mS_GridX_Setting1.Text = "mS_GridX_Setting1";
            this.mS_GridX_Setting1.MS_On_Print_Clicked += new System.EventHandler(this.mS_GridX_Setting1_MS_On_Print_Clicked);
            // 
            // ms_grid
            // 
            this.ms_grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.ms_grid.AlternatingColors = true;
            this.ms_grid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.ms_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_grid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ms_grid.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.ms_grid.BuiltInTextsData = resources.GetString("ms_grid.BuiltInTextsData");
            this.ms_grid.ColumnAutoResize = true;
            this.ms_grid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.ms_grid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ms_grid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            this.ms_grid.DefaultForeColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Opaque;
            ms_grid_DesignTimeLayout.LayoutString = resources.GetString("ms_grid_DesignTimeLayout.LayoutString");
            this.ms_grid.DesignTimeLayout = ms_grid_DesignTimeLayout;
            this.ms_grid.DynamicFiltering = true;
            this.ms_grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.ms_grid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.ms_grid.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.ms_grid.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_grid.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.ms_grid.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
            this.ms_grid.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.ms_grid.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.ms_grid.GridLineColor = System.Drawing.Color.Black;
            this.ms_grid.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
            this.ms_grid.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.ms_grid.GroupByBoxFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_grid.GroupByBoxInfoFormatStyle.BackColor = System.Drawing.Color.Maroon;
            this.ms_grid.GroupByBoxVisible = false;
            this.ms_grid.GroupRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ms_grid.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ms_grid.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.ms_grid.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.ms_grid.LinkFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.ms_grid.Location = new System.Drawing.Point(0, 234);
            this.ms_grid.Name = "ms_grid";
            this.ms_grid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.ms_grid.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
            this.ms_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_grid.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.ms_grid.RowHeaderFormatStyle.Font = new System.Drawing.Font("B Yekan", 9.5F, System.Drawing.FontStyle.Italic);
            this.ms_grid.RowHeaderFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.True;
            this.ms_grid.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ms_grid.ScrollBarWidth = 17;
            this.ms_grid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ms_grid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.ms_grid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ms_grid.SelectOnExpand = false;
            this.ms_grid.Size = new System.Drawing.Size(879, 288);
            this.ms_grid.TabIndex = 8;
            this.ms_grid.TabStop = false;
            this.ms_grid.ThemedAreas = ((Janus.Windows.GridEX.ThemedArea)((((((((Janus.Windows.GridEX.ThemedArea.ScrollBars | Janus.Windows.GridEX.ThemedArea.EditControls) 
            | Janus.Windows.GridEX.ThemedArea.Headers) 
            | Janus.Windows.GridEX.ThemedArea.TreeGliphs) 
            | Janus.Windows.GridEX.ThemedArea.ControlBorder) 
            | Janus.Windows.GridEX.ThemedArea.Cards) 
            | Janus.Windows.GridEX.ThemedArea.Gridlines) 
            | Janus.Windows.GridEX.ThemedArea.CheckBoxes)));
            this.ms_grid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_grid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.ms_grid.TreeLineColor = System.Drawing.Color.Black;
            this.ms_grid.UseCompatibleTextRendering = false;
            this.ms_grid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // mS_NumericTextBox1
            // 
            this.mS_NumericTextBox1.Location = new System.Drawing.Point(448, 88);
            this.mS_NumericTextBox1.MS_BorderColor = System.Drawing.Color.Silver;
            this.mS_NumericTextBox1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_NumericTextBox1.MS_Change_Border_Color_On_Enter = false;
            this.mS_NumericTextBox1.MS_Change_Color_On_Enter = false;
            this.mS_NumericTextBox1.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.mS_NumericTextBox1.MS_Enter_Color = System.Drawing.Color.Empty;
            this.mS_NumericTextBox1.MS_Exit_By_Down = false;
            this.mS_NumericTextBox1.MS_Exit_By_Enter = false;
            this.mS_NumericTextBox1.MS_Exit_By_Up = false;
            this.mS_NumericTextBox1.MS_Is_Negative = false;
            this.mS_NumericTextBox1.MS_Last_Control = null;
            this.mS_NumericTextBox1.MS_Next_Control = null;
            this.mS_NumericTextBox1.Name = "mS_NumericTextBox1";
            this.mS_NumericTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_NumericTextBox1.Size = new System.Drawing.Size(347, 24);
            this.mS_NumericTextBox1.TabIndex = 9;
            this.mS_NumericTextBox1.Text = "0";
            this.mS_NumericTextBox1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
            // 
            // mS_NumericTextBox2
            // 
            this.mS_NumericTextBox2.Location = new System.Drawing.Point(573, 33);
            this.mS_NumericTextBox2.MS_BorderColor = System.Drawing.Color.Silver;
            this.mS_NumericTextBox2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_NumericTextBox2.MS_Change_Border_Color_On_Enter = false;
            this.mS_NumericTextBox2.MS_Change_Color_On_Enter = false;
            this.mS_NumericTextBox2.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.mS_NumericTextBox2.MS_Enter_Color = System.Drawing.Color.Empty;
            this.mS_NumericTextBox2.MS_Exit_By_Down = false;
            this.mS_NumericTextBox2.MS_Exit_By_Enter = false;
            this.mS_NumericTextBox2.MS_Exit_By_Up = false;
            this.mS_NumericTextBox2.MS_Is_Negative = false;
            this.mS_NumericTextBox2.MS_Last_Control = null;
            this.mS_NumericTextBox2.MS_Next_Control = null;
            this.mS_NumericTextBox2.Name = "mS_NumericTextBox2";
            this.mS_NumericTextBox2.Size = new System.Drawing.Size(145, 24);
            this.mS_NumericTextBox2.TabIndex = 12;
            this.mS_NumericTextBox2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(465, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 24);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // mS_Tarikh_TextBox2
            // 
            this.mS_Tarikh_TextBox2.AllowInternalTab = false;
            this.mS_Tarikh_TextBox2.AllowResizeDropDown = false;
            this.mS_Tarikh_TextBox2.AutoHeight = true;
            this.mS_Tarikh_TextBox2.BackColor = System.Drawing.Color.White;
            this.mS_Tarikh_TextBox2.ControlSize = new System.Drawing.Size(0, 0);
            this.mS_Tarikh_TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mS_Tarikh_TextBox2.DropSize = new System.Drawing.Size(0, 0);
            this.mS_Tarikh_TextBox2.Location = new System.Drawing.Point(448, 199);
            this.mS_Tarikh_TextBox2.MinimumSize = new System.Drawing.Size(97, 22);
            this.mS_Tarikh_TextBox2.MS_BorderColor = System.Drawing.Color.Black;
            this.mS_Tarikh_TextBox2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Tarikh_TextBox2.MS_Change_Border_Color_On_Enter = true;
            this.mS_Tarikh_TextBox2.MS_Change_Color_On_Enter = true;
            this.mS_Tarikh_TextBox2.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mS_Tarikh_TextBox2.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mS_Tarikh_TextBox2.MS_Exit_By_Down = true;
            this.mS_Tarikh_TextBox2.MS_Exit_By_Enter = true;
            this.mS_Tarikh_TextBox2.MS_Exit_By_Up = true;
            this.mS_Tarikh_TextBox2.MS_Last_Control = null;
            this.mS_Tarikh_TextBox2.MS_Next_Control = null;
            this.mS_Tarikh_TextBox2.MS_Separation = '/';
            this.mS_Tarikh_TextBox2.MS_Tarikh = null;
            this.mS_Tarikh_TextBox2.Name = "mS_Tarikh_TextBox2";
            this.mS_Tarikh_TextBox2.ReadOnly = false;
            this.mS_Tarikh_TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mS_Tarikh_TextBox2.Size = new System.Drawing.Size(105, 22);
            this.mS_Tarikh_TextBox2.TabIndex = 1;
            this.mS_Tarikh_TextBox2.Text = "//";
            // 
            // mS_Tarikh_TextBox1
            // 
            this.mS_Tarikh_TextBox1.AllowInternalTab = false;
            this.mS_Tarikh_TextBox1.AllowResizeDropDown = false;
            this.mS_Tarikh_TextBox1.AutoHeight = true;
            this.mS_Tarikh_TextBox1.BackColor = System.Drawing.Color.White;
            this.mS_Tarikh_TextBox1.ControlSize = new System.Drawing.Size(0, 0);
            this.mS_Tarikh_TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mS_Tarikh_TextBox1.DropSize = new System.Drawing.Size(0, 0);
            this.mS_Tarikh_TextBox1.Location = new System.Drawing.Point(573, 199);
            this.mS_Tarikh_TextBox1.MinimumSize = new System.Drawing.Size(97, 22);
            this.mS_Tarikh_TextBox1.MS_BorderColor = System.Drawing.Color.Black;
            this.mS_Tarikh_TextBox1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Tarikh_TextBox1.MS_Change_Border_Color_On_Enter = true;
            this.mS_Tarikh_TextBox1.MS_Change_Color_On_Enter = true;
            this.mS_Tarikh_TextBox1.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mS_Tarikh_TextBox1.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mS_Tarikh_TextBox1.MS_Exit_By_Down = true;
            this.mS_Tarikh_TextBox1.MS_Exit_By_Enter = true;
            this.mS_Tarikh_TextBox1.MS_Exit_By_Up = true;
            this.mS_Tarikh_TextBox1.MS_Last_Control = null;
            this.mS_Tarikh_TextBox1.MS_Next_Control = null;
            this.mS_Tarikh_TextBox1.MS_Separation = '/';
            this.mS_Tarikh_TextBox1.MS_Tarikh = null;
            this.mS_Tarikh_TextBox1.Name = "mS_Tarikh_TextBox1";
            this.mS_Tarikh_TextBox1.ReadOnly = false;
            this.mS_Tarikh_TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mS_Tarikh_TextBox1.Size = new System.Drawing.Size(105, 22);
            this.mS_Tarikh_TextBox1.TabIndex = 0;
            this.mS_Tarikh_TextBox1.Text = "//";
            // 
            // mS_Combo_Test3
            // 
            this.mS_Combo_Test3.Location = new System.Drawing.Point(237, 33);
            this.mS_Combo_Test3.MS_BorderColor = System.Drawing.Color.Silver;
            this.mS_Combo_Test3.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Combo_Test3.MS_Change_Border_Color_On_Enter = false;
            this.mS_Combo_Test3.MS_Change_Color_On_Enter = false;
            this.mS_Combo_Test3.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.mS_Combo_Test3.MS_Enter_Color = System.Drawing.Color.Empty;
            this.mS_Combo_Test3.MS_Exit_By_Down = false;
            this.mS_Combo_Test3.MS_Exit_By_Enter = false;
            this.mS_Combo_Test3.MS_Exit_By_Up = false;
            this.mS_Combo_Test3.MS_Last_Control = null;
            this.mS_Combo_Test3.MS_Next_Control = null;
            this.mS_Combo_Test3.Name = "mS_Combo_Test3";
            this.mS_Combo_Test3.Size = new System.Drawing.Size(139, 24);
            this.mS_Combo_Test3.TabIndex = 11;
            this.mS_Combo_Test3.Visible = false;
            // 
            // mS_Combo_Test1
            // 
            this.mS_Combo_Test1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mS_Combo_Test1.Location = new System.Drawing.Point(92, 3);
            this.mS_Combo_Test1.MS_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mS_Combo_Test1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Combo_Test1.MS_Change_Border_Color_On_Enter = true;
            this.mS_Combo_Test1.MS_Change_Color_On_Enter = true;
            this.mS_Combo_Test1.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mS_Combo_Test1.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mS_Combo_Test1.MS_Exit_By_Down = true;
            this.mS_Combo_Test1.MS_Exit_By_Enter = true;
            this.mS_Combo_Test1.MS_Exit_By_Up = true;
            this.mS_Combo_Test1.MS_Last_Control = null;
            this.mS_Combo_Test1.MS_Next_Control = null;
            this.mS_Combo_Test1.Name = "mS_Combo_Test1";
            this.mS_Combo_Test1.Size = new System.Drawing.Size(284, 24);
            this.mS_Combo_Test1.TabIndex = 10;
            this.mS_Combo_Test1.Visible = false;
            // 
            // mS_Combo_Test2
            // 
            this.mS_Combo_Test2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mS_Combo_Test2.Location = new System.Drawing.Point(432, 2);
            this.mS_Combo_Test2.MS_BorderColor = System.Drawing.Color.Silver;
            this.mS_Combo_Test2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Combo_Test2.MS_Change_Border_Color_On_Enter = false;
            this.mS_Combo_Test2.MS_Change_Color_On_Enter = false;
            this.mS_Combo_Test2.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.mS_Combo_Test2.MS_Enter_Color = System.Drawing.Color.Empty;
            this.mS_Combo_Test2.MS_Exit_By_Down = false;
            this.mS_Combo_Test2.MS_Exit_By_Enter = false;
            this.mS_Combo_Test2.MS_Exit_By_Up = false;
            this.mS_Combo_Test2.MS_Last_Control = null;
            this.mS_Combo_Test2.MS_Next_Control = null;
            this.mS_Combo_Test2.Name = "mS_Combo_Test2";
            this.mS_Combo_Test2.Size = new System.Drawing.Size(243, 24);
            this.mS_Combo_Test2.TabIndex = 6;
            this.mS_Combo_Test2.Visible = false;
            this.mS_Combo_Test2.MS_On_Row_Selected += new System.EventHandler<MS_Control.TSDD.On_Selected>(this.mS_Combo_Test2_MS_On_Row_Selected);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(156, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 45);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form_Two
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 550);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mS_Tarikh_TextBox1);
            this.Controls.Add(this.mS_Tarikh_TextBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.mS_NumericTextBox2);
            this.Controls.Add(this.mS_Combo_Test3);
            this.Controls.Add(this.mS_Combo_Test1);
            this.Controls.Add(this.mS_NumericTextBox1);
            this.Controls.Add(this.ms_grid);
            this.Controls.Add(this.mS_GridX_Setting1);
            this.Controls.Add(this.mS_Combo_Test2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form_Two";
            this.RightToLeftLayout = true;
            this.Text = "                                                                                 " +
    "   تست فرم مادر دوم";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_Two_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_Two_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ms_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MS_Combo_Test mS_Combo_Test2;
        private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting1;
        private MS_Control.Controls.MS_NumericTextBox mS_NumericTextBox1;
        private MS_Combo_Test mS_Combo_Test1;
        private MS_Combo_Test mS_Combo_Test3;
        private MS_Control.Controls.MS_NumericTextBox mS_NumericTextBox2;
        protected MS_Control.Controls.MS_GridX ms_grid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MS_Control.Tarikh.MS_Tarikh_TextBox mS_Tarikh_TextBox2;
        private MS_Control.Tarikh.MS_Tarikh_TextBox mS_Tarikh_TextBox1;
        private System.Windows.Forms.Button button3;
    }
}