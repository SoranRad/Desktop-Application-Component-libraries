using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MS_Control.Tarikh
{
    public partial class MS_TarixBox : Control
    {
        enum Selected_Part
        {
            Year=0,
            Month=1,
            Day=2,
        }

        private TextBox _referenceTextBox = new TextBox();
        private char _Separator_char = '/';
        private Selected_Part _Selection=Selected_Part.Day;
        Janus.Windows.EditControls.UIButton MS_Calender_Button;
        private bool _autoHeight = false;
        private Size FixedSingleOffset = new Size(2, 2);
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        

        #region پراپرتی
        [Browsable(true)]
        public bool AutoHeight
        {
            get { return _autoHeight; }
            set
            {
                _autoHeight = value;

                if (_autoHeight)
                {
                    AdjustSize();
                }
            }
        }
        [Browsable(true)]
        public override Size MinimumSize
        {
            get { return CalculateMinimumSize(); }
        }
        [Browsable(true)]
        public ButtonBorderStyle MS_BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                Invalidate();
            }
        }
        #endregion

        public MS_TarixBox()
        {
            InitializeComponent();
            this.Capture = true;
            this.RightToLeft = RightToLeft.No;
            BackColor = Color.White;

            Add_Controls();


            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ContainerControl, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);

            Size = CalculateMinimumSize();

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }

        private void AdjustSize()
        {
            Size newSize = MinimumSize;

            if (Width > newSize.Width)
            {
                newSize.Width = Width;
            }

            if (Height > newSize.Height)
            {
                newSize.Height = Height;
            }

            if (AutoHeight)
            {
                Size = new Size(newSize.Width, MinimumSize.Height);
            }
            else
            {
                Size = newSize;
            }

            LayoutControls();
        }
        private int GetSuggestedHeight()
        {
            _referenceTextBox.BorderStyle = BorderStyle.FixedSingle;
            _referenceTextBox.Font = Font;
            _referenceTextBox.Refresh();
            return _referenceTextBox.Height - 2;
        }

        private int Calculate_Width(string str)
        {
            System.Drawing.Image fakeImage = new Bitmap(1, 1); //As we cannot use CreateGraphics() in a class library, so the fake image is used to load the Graphics.
            Graphics graphics = Graphics.FromImage(fakeImage);
            SizeF size = graphics.MeasureString(str, this.Font);

            return Convert.ToInt32(size.Width);
        }
        private Size CalculateMinimumSize()
        {
            Size minimumSize = new Size(0, 0);
            minimumSize.Width = MS_Calender_Button.Width;

            System.Drawing.Image fakeImage = new Bitmap(1, 1); //As we cannot use CreateGraphics() in a class library, so the fake image is used to load the Graphics.
            Graphics graphics = Graphics.FromImage(fakeImage);

            SizeF size = graphics.MeasureString("/", this.Font);
            minimumSize.Width+= 2* Convert.ToInt32(size.Width);
            //==========================
            size = graphics.MeasureString("55", this.Font);
            minimumSize.Width += 2 * Convert.ToInt32(size.Width);
            //==========================
            size = graphics.MeasureString("5555", this.Font);
            minimumSize.Width += Convert.ToInt32(size.Width);
            

            minimumSize.Height = GetSuggestedHeight();
            //=====================
            return minimumSize;
        }
        private void LayoutControls()
        {
            SuspendLayout();

            int difference = Width - MinimumSize.Width;

            Debug.Assert(difference >= 0);

            int numOffsets =6;// 1 button + 3 numeric lable +2 separate label

            int div = difference / (numOffsets);
            int mod = difference % (numOffsets);

            int[] offsets = new int[numOffsets];

            for (int index = 0; index < numOffsets; ++index)
            {
                offsets[index] = div;

                if (index < mod)
                {
                    ++offsets[index];
                }
            }

            int x = 0;
            int y = 0;

            x = FixedSingleOffset.Width;
            y = FixedSingleOffset.Height;

            int offsetIndex = 0;

            MS_Calender_Button.Location = new Point(x, y);
            this.MS_Calender_Button.Size = new Size(20, this.Height - 2 * y);

            x += offsets[offsetIndex++];
            x += MS_Calender_Button.Width;

            Controls
                .OfType<Label>()
                .MSZ_ForEach_With_Index((label ,index)=>
                {
                    label.Location = new Point(x, y);

                    x += label.Width;
                    x += offsets[index+1];
                });
            ResumeLayout(false);
        }
        private void Add_Controls()
        {
            #region Button
            MS_Calender_Button = new Janus.Windows.EditControls.UIButton();
            MS_Calender_Button.CreateControl();
            MS_Calender_Button.Appearance = Janus.Windows.UI.Appearance.FlatBorderless;
            MS_Calender_Button.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
            MS_Calender_Button.Cursor = Cursors.Hand;
            MS_Calender_Button.FlatBorderColor = Color.Transparent;
            MS_Calender_Button.Font = Font;
            MS_Calender_Button.HighlightActiveButton = false;
            MS_Calender_Button.ShowFocusRectangle = false;
            MS_Calender_Button.Image = global::MS_Control.Properties.Resources.calendar_2;
            MS_Calender_Button.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center;
            MS_Calender_Button.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.Center;
            MS_Calender_Button.ImageSize = new Size(14, 14);
            MS_Calender_Button.Name = "uiButton1";
            MS_Calender_Button.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            MS_Calender_Button.Office2007CustomColor = Color.Transparent;
            MS_Calender_Button.Size = new Size(20, 18);
            MS_Calender_Button.TabIndex = 1;
            MS_Calender_Button.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Empty;
            MS_Calender_Button.TextVerticalAlignment = Janus.Windows.EditControls.TextAlignment.Empty;
            MS_Calender_Button.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            MS_Calender_Button.TabStop = false;
            //this.MS_Calender_Button.Click += MS_Calender_Button_Click;
            this.Controls.Add(this.MS_Calender_Button);
            #endregion
            #region Lables
            
            for (int i = 0; i < 3; i++)
            {
                var lable=new Label();
                lable.CreateControl();

                lable.AutoSize = false;

                lable.TabIndex = i+1;
                lable.Name = "Num" + i;
                lable.Parent = this;
                lable.RightToLeft = RightToLeft.No;
                lable.TextAlign =ContentAlignment.MiddleCenter;
                lable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                lable.Click += Lable_Click;
                lable.TabIndex = i;
                lable.TabStop = false;
                switch (i)
                {
                    case 0:
                        lable.Width = Calculate_Width("5555");
                        break;
                    case 2:
                    case 1:
                        lable.Width = Calculate_Width("55");
                        break;
                }
                Controls.Add(lable);
                //=============================
                if (i < 2)
                {
                    var lable_sperate=new Label();
                    lable_sperate.CreateControl();
                    lable_sperate.AutoSize=true;
                    lable_sperate.TextAlign=ContentAlignment.MiddleCenter;
                    lable_sperate.Text=_Separator_char.ToString();
                    lable_sperate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                    lable_sperate.Name="Seperator"+i;
                    lable_sperate.Parent=this;
                    lable_sperate.TabIndex = i;
                    lable_sperate.TabStop = false;
                    lable_sperate.Tag = lable;
                    lable_sperate.Click += Lable_sperate_Click;
                    this.Controls.Add(lable_sperate);
                }
            }

            #endregion
        }

        private void Reset_BackGroundColor_Lables()
        {
            Controls
               .OfType<Label>()
               .MSZ_ForEach(label =>
               {
                   label.BackColor=Color.Transparent;
               });
        }
        private void Lable_Click(object sender, EventArgs e)
        {
            Reset_BackGroundColor_Lables();
            (sender as Label).BackColor = Color.DodgerBlue;
            (sender as Label).ForeColor = Color.White;
        }
        private void Lable_sperate_Click(object sender, EventArgs e)
        {
            var tag=((sender as Label).Tag as Label);
            Lable_Click(tag, e);
        }
        private void Set_Selection_Highlight()
        {
            Reset_BackGroundColor_Lables();
            var label=Controls
              .OfType<Label>()
              .ToList()
              .Single(x=>x.Name.StartsWith("Num") && x.TabIndex==(byte)_Selection);

            label.BackColor = Color.DodgerBlue;
            label.ForeColor = Color.White;

        }
        #region Override Methods
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            AdjustSize();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            AdjustSize();
        }
        protected override void OnEnter(EventArgs e)
        {
            _Selection=Selected_Part.Day;
            Set_Selection_Highlight();
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            Reset_BackGroundColor_Lables();
            base.OnLeave(e);
        }
        #endregion
    }
}
