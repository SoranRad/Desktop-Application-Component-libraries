using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX.EditControls;
using MS_Control.CustomCombo;

namespace MS_Control.Tarikh
{
    [Designer(typeof(MS_Tarikh_TextBox_Designer))]
    [SecurityPermissionAttribute(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public class MS_Tarikh_TextBox: Control
    {
        #region فیلد هــا
        public const int FieldCount = 3;
        private bool _Do_Spread = true,_Is_First_Time=true;
        public event EventHandler<FieldChangedEventArgs> MS_FieldChangedEvent;
        private Popup_Tarix _DropDown;
        private bool _autoHeight = true;
        private bool _backColorChanged;
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        private DotControl[] _dotControls = new DotControl[FieldCount - 1];
        private FieldControl[] _fieldControls = new FieldControl[FieldCount];
        private bool _focused;
        private bool _hasMouse;
        private bool _readOnly;
        private Size FixedSingleOffset = new Size(2, 2);
        private TextBox _referenceTextBox = new TextBox();
        private char _Separator_char = '/';
        private Janus.Windows.EditControls.UIButton MS_Calender_Button;
        CustomComboBox.SizeMode m_sizeMode = CustomComboBox.SizeMode.UseControlSize;
        bool  DroppedDown = false;
        Color _Back_Color;
        bool m_bIsResizable=false, _Do_Refresh = true;
        Size m_sizeCombo=new Size(1,1);
        private MS_Tatikh_View ms_tarikh_DropDown;
        private Color _borderColor = Color.Silver, _Main_Border_Color;
        private static int WM_PAINT = 0x000F;
        #endregion
        #region پراپرتی هـا
        //================Tarix Properties
        [Browsable(true)]
        public bool AllowInternalTab
        {
            get
            {
                foreach (FieldControl fc in _fieldControls)
                {
                    return fc.TabStop;
                }

                return false;
            }
            set
            {
                foreach (FieldControl fc in _fieldControls)
                {
                    fc.TabStop = value;
                }
            }
        }
        [Browsable(true)]
        public bool AnyBlank
        {
            get
            {
                foreach (FieldControl fc in _fieldControls)
                {
                    if (fc.Blank)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
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
        [Browsable(false)]
        public int Baseline
        {
            get
            {
                NativeMethods.TEXTMETRIC textMetric = GetTextMetrics(Handle, Font);

                int offset = textMetric.tmAscent + 1;
                offset += FixedSingleOffset.Height;
                return offset;
            }
        }
        [Browsable(true)]
        public bool Blank
        {
            get
            {
                foreach (FieldControl fc in _fieldControls)
                {
                    if (!fc.Blank)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
        [Browsable(true)]
        public ButtonBorderStyle MS_BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                AdjustSize();
                Invalidate();
            }
        }
        [Browsable(false)]
        public override bool Focused
        {
            get
            {
                foreach (FieldControl fc in _fieldControls)
                    if (fc.Focused)
                        return true;

                return false;
            }
        }
        [Browsable(true)]
        public override Size MinimumSize
        {
            get { return CalculateMinimumSize(); }
        }
        [Browsable(true)]
        public bool ReadOnly
        {
            get { return _readOnly; }
            set
            {
                _readOnly = value;

                foreach (FieldControl fc in _fieldControls)
                {
                    fc.ReadOnly = _readOnly;
                }

                foreach (DotControl dc in _dotControls)
                {
                    dc.ReadOnly = _readOnly;
                }

                Invalidate();
            }
        }
        [Browsable(true)]
        public char MS_Separation
        {
            get { return _Separator_char; }
            set
            {
                _Separator_char = value;
                foreach (DotControl dotControl in _dotControls)
                    dotControl.Text = value.ToString();
            }
        }
        [Bindable(true)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                StringBuilder sb = new StringBuilder(); ;

                for (int index = 0; index < _fieldControls.Length; ++index)
                {
                    sb.Append(_fieldControls[index].Text);

                    if (index < _dotControls.Length)
                    {
                        sb.Append(_dotControls[index].Text);
                    }
                }

                return sb.ToString();
            }
            set
            {
                Parse(value);
            }
        }
        [Category("Custom Drop-Down"), Description("Indicates if drop-down is resizable.")]
        public bool AllowResizeDropDown
        {
            get { return this.m_bIsResizable; }
            set { this.m_bIsResizable = value; }
        }
        [Category("Custom Drop-Down")]
        public Size DropSize
        {
            get { return m_sizeCombo; }
            set
            {
                m_sizeCombo = value;
            }
        }
        [Category("Custom Drop-Down"), Browsable(false)]
        public Size ControlSize
        {
            get { return m_sizeCombo; }
            set
            {
                m_sizeCombo = value;
            }
        }

        //=======================
        //=======================MS_Prpperties
        //=======================
        public bool MS_Exit_By_Enter { get; set; }
        public bool MS_Exit_By_Down { get; set; }
        public bool MS_Exit_By_Up { get; set; }
        public Control MS_Next_Control { get; set; }
        public Control MS_Last_Control { get; set; }
        public bool MS_Change_Color_On_Enter { set; get; }
        public Color MS_Enter_Color { get; set; }
        public bool MS_Change_Border_Color_On_Enter { set; get; }
        public Color MS_Enter_Border_Color { get; set; }
        public Color MS_BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                _Main_Border_Color = value;
                Invalidate(); // causes control to be redrawn
            }
        }
        public MS_Structure_Shamsi? MS_Tarikh
        {
            get
            {
                if (string.IsNullOrEmpty(Text))
                    return null;
                if (!string.IsNullOrEmpty(Text) && !MS_Structure_Shamsi.Is_Tarikh_True(Text))
                    return null;
                return ms_tarikh_DropDown.MS_Tarikh = new MS_Structure_Shamsi(Text);
            }
            set
            {
                if (value == null)
                {
                    Text = "";
                    ms_tarikh_DropDown.MS_Tarikh = new MS_Structure_Shamsi(DateTime.Now);
                }
                else
                {
                    ms_tarikh_DropDown.MS_Tarikh = value.Value;
                    Text = value.Value.ToShamsi();
                }
            }
        }
        #endregion
        //=======================================Methods======================
        #region متدهـا
        public void Clear()
        {
            foreach (FieldControl fc in _fieldControls)
            {
                fc.Clear();
                fc.Text = string.Empty;
            }
        }
        private bool HasMouse
        {
            get
            {
                return DisplayRectangle.Contains(PointToClient(MousePosition));
            }
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
        private Size CalculateMinimumSize()
        {
            Size minimumSize = new Size(0, 0);
            minimumSize.Width = MS_Calender_Button.Width;


            foreach (FieldControl fc in _fieldControls)
            {
                minimumSize.Width += fc.Width;
                minimumSize.Height = Math.Max(minimumSize.Height, fc.Height);
            }

            foreach (DotControl dc in _dotControls)
            {
                minimumSize.Width += dc.Width;
                minimumSize.Height = Math.Max(minimumSize.Height, dc.Height);
            }

            minimumSize.Width += 3;
            minimumSize.Height += (GetSuggestedHeight() - minimumSize.Height);

            //switch (MS_BorderStyle)
            //{
            //    case BorderStyle.Fixed3D:
            //        minimumSize.Width += 5;
            //        minimumSize.Height += (GetSuggestedHeight() - minimumSize.Height);
            //        break;
            //    case BorderStyle.FixedSingle:
            //        minimumSize.Width += 3;
            //        minimumSize.Height += (GetSuggestedHeight() - minimumSize.Height);
            //        break;
            //}
            //minimumSize.Height +=1;
            return minimumSize;
        }
        private int GetSuggestedHeight()
        {
            _referenceTextBox.BorderStyle = BorderStyle.FixedSingle;
            _referenceTextBox.Font = Font;
            _referenceTextBox.Refresh();
            return _referenceTextBox.Height - 2;
        }
        private void Parse(String text)
        {
            Clear();

            if (string.IsNullOrWhiteSpace(text) || text.Length <= 5 || null == text)
            {
                return;
            }

            int textIndex = 0;

            int index = 0;
            text = text.Trim();
            for (index = 0; index < _dotControls.Length; ++index)
            {
                int findIndex = text.IndexOf(_dotControls[index].Text, textIndex, StringComparison.Ordinal);

                if (findIndex >= 0)
                {
                    _fieldControls[index].Text = text.Substring(textIndex, findIndex - textIndex);
                    textIndex = findIndex + _dotControls[index].Text.Length;
                }
                else
                {
                    break;
                }
            }

            _fieldControls[index].Text = text.Substring(textIndex);
        }
        private void ResetBackColorChanged()
        {
            _backColorChanged = false;
        }
        private void Add_Controls()
        {
            this.MS_Calender_Button = new Janus.Windows.EditControls.UIButton();
            this.MS_Calender_Button.Appearance = Janus.Windows.UI.Appearance.FlatBorderless;
            this.MS_Calender_Button.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
            this.MS_Calender_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MS_Calender_Button.FlatBorderColor = System.Drawing.Color.Transparent;
            this.MS_Calender_Button.Font = Font;
            this.MS_Calender_Button.HighlightActiveButton = false;
            this.MS_Calender_Button.ShowFocusRectangle = false;
            this.MS_Calender_Button.Image = global::MS_Control.Properties.Resources.calendar_2;
            this.MS_Calender_Button.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center;
            this.MS_Calender_Button.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.Center;
            this.MS_Calender_Button.ImageSize = new System.Drawing.Size(14, 14);
            this.MS_Calender_Button.Name = "uiButton1";
            this.MS_Calender_Button.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.MS_Calender_Button.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.MS_Calender_Button.Size = new System.Drawing.Size(20, 18);
            this.MS_Calender_Button.TabIndex = 38;
            this.MS_Calender_Button.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Empty;
            this.MS_Calender_Button.TextVerticalAlignment = Janus.Windows.EditControls.TextAlignment.Empty;
            this.MS_Calender_Button.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.MS_Calender_Button.Click += MS_Calender_Button_Click;

            this.Controls.Add(this.MS_Calender_Button);

            for (int index = 0; index < _fieldControls.Length; ++index)
            {
                _fieldControls[index] = new FieldControl();
                _fieldControls[index].CreateControl();

                _fieldControls[index].FieldIndex = index;
                _fieldControls[index].Name = "FieldControl" + index.ToString(CultureInfo.InvariantCulture);
                _fieldControls[index].Parent = this;
                _fieldControls[index].MaxLength = 2;
                _fieldControls[index].RightToLeft = RightToLeft.No;
                _fieldControls[index].TextAlign = HorizontalAlignment.Center;



                switch (index)
                {
                    case 0:
                        _fieldControls[index].RangeUpper = 1500;
                        _fieldControls[index].RangeLower = 1300;
                        _fieldControls[index].MaxLength = 4;
                        _fieldControls[index].Width *= 2;

                        break;
                    case 1:
                        _fieldControls[index].RangeUpper = 12;
                        _fieldControls[index].RangeLower = 1;
                        break;
                    case 2:
                        _fieldControls[index].RangeUpper = 31;
                        _fieldControls[index].RangeLower = 1;
                        break;
                }

                _fieldControls[index].CedeFocusEvent += new EventHandler<CedeFocusEventArgs>(OnCedeFocus);
                _fieldControls[index].Click += new EventHandler(OnSubControlClicked);
                _fieldControls[index].DoubleClick += new EventHandler(OnSubControlDoubleClicked);
                _fieldControls[index].GotFocus += new EventHandler(OnFieldGotFocus);
                _fieldControls[index].KeyDown += new KeyEventHandler(OnFieldKeyDown);
                _fieldControls[index].KeyPress += new KeyPressEventHandler(OnFieldKeyPressed);
                _fieldControls[index].KeyUp += new KeyEventHandler(OnFieldKeyUp);
                _fieldControls[index].LostFocus += new EventHandler(OnFieldLostFocus);
                _fieldControls[index].MouseClick += new MouseEventHandler(OnSubControlMouseClicked);
                _fieldControls[index].MouseDoubleClick += new MouseEventHandler(OnSubControlMouseDoubleClicked);
                _fieldControls[index].MouseEnter += new EventHandler(OnSubControlMouseEntered);
                _fieldControls[index].MouseHover += new EventHandler(OnSubControlMouseHovered);
                _fieldControls[index].MouseLeave += new EventHandler(OnSubControlMouseLeft);
                _fieldControls[index].MouseMove += new MouseEventHandler(OnSubControlMouseMoved);
                _fieldControls[index].PreviewKeyDown += new PreviewKeyDownEventHandler(OnFieldPreviewKeyDown);
                _fieldControls[index].TextChangedEvent += new EventHandler<TextChangedEventArgs>(OnFieldTextChanged);
                _fieldControls[index].Click += MS_Tarikh_TextBox_Click;
                _fieldControls[index].Text = "";
                _fieldControls[index].Clear();

                Controls.Add(_fieldControls[index]);

                if (index < (FieldCount - 1))
                {
                    _dotControls[index] = new DotControl();

                    _dotControls[index].CreateControl();

                    _dotControls[index].Name = "DotControl" + index.ToString(CultureInfo.InvariantCulture);
                    _dotControls[index].Parent = this;

                    _dotControls[index].Click += new EventHandler(OnSubControlClicked);
                    _dotControls[index].DoubleClick += new EventHandler(OnSubControlDoubleClicked);
                    _dotControls[index].MouseClick += new MouseEventHandler(OnSubControlMouseClicked);
                    _dotControls[index].MouseDoubleClick += new MouseEventHandler(OnSubControlMouseDoubleClicked);
                    _dotControls[index].MouseEnter += new EventHandler(OnSubControlMouseEntered);
                    _dotControls[index].MouseHover += new EventHandler(OnSubControlMouseHovered);
                    _dotControls[index].MouseLeave += new EventHandler(OnSubControlMouseLeft);
                    _dotControls[index].MouseMove += new MouseEventHandler(OnSubControlMouseMoved);

                    Controls.Add(_dotControls[index]);

                }
            }
        }
        public Point Calculate_Location()
        {
            
            int w = Width - (ms_tarikh_DropDown.Width);

            w = w > 0 ? Width - ms_tarikh_DropDown.Width - 4 : w;

            var azaf = Math.Abs((Width - (ms_tarikh_DropDown.Width)) / 2);
                    return PointToScreen(new Point(w + azaf, Height));
        }
        public void ShowMenu()
        {
            if (_DropDown != null && !_DropDown.Visible)
            {
                _DropDown.Size=new Size(ms_tarikh_DropDown.Width+2,ms_tarikh_DropDown.Height+3);
                _DropDown.Show(Calculate_Location());
                ms_tarikh_DropDown.Refresh();
            }
        }
        public void HideMenu()
        {
            if (_DropDown != null && _DropDown.Visible)
            {
                _DropDown.Close();
               
            }
        }
        protected bool IsControlValid(Control controlToValidate)
        {
            Debug.Assert(controlToValidate != null, "Control to validate is null");

            Type t = typeof(Control);

            MethodInfo mi = t.GetMethod("NotifyValidating", BindingFlags.Instance |
            BindingFlags.NonPublic);

            Debug.Assert(mi != null, "Could not get method information.");

            if (((Boolean)mi.Invoke(controlToValidate, null)))
                return false;
            else
                return true;
        }
        #endregion
        #region Override Methods & Natives
        //=======================================Protected Methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int index = 0; index < FieldCount; ++index)
            {
                sb.Append(_fieldControls[index].ToString());

                if (index < _dotControls.Length)
                {
                    sb.Append(_dotControls[index].ToString());
                }
            }

            return sb.ToString();
        }
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            if (this.BackColor != Color.Transparent)
            {
                foreach (DotControl item in _dotControls)
                    if (item != null)
                        item.BackColor = this.BackColor;
            }
            _backColorChanged = true;
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            AdjustSize();
        }
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            _focused = true;
            _fieldControls[2].TakeFocus(Direction.Forward, Selection.All);
            _fieldControls[2].SelectAll();
        }
        protected override void OnLostFocus(EventArgs e)
        {
            if (!Focused)
            {
                _focused = false;
                base.OnLostFocus(e);
            }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            if (!_hasMouse)
            {
                _hasMouse = true;
                base.OnMouseEnter(e);
            }
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            if (!HasMouse)
            {
                base.OnMouseLeave(e);
                _hasMouse = false;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            AdjustSize();
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && MS_Exit_By_Down)
            {
                if (MS_Next_Control != null && MS_Next_Control.Enabled && MS_Next_Control.Visible)
                    MS_Next_Control.Focus();
                else
                    SendKeys.Send("{TAB}");
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up && MS_Exit_By_Up)
            {
                if (MS_Last_Control != null && MS_Last_Control.Enabled && MS_Last_Control.Visible)
                    MS_Last_Control.Focus();
                else
                    SendKeys.Send("+{TAB}");
                e.Handled = true;
            }

            base.OnKeyUp(e);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && MS_Exit_By_Enter)
            {
                if (MS_Next_Control != null && MS_Next_Control.Enabled && MS_Next_Control.Visible)
                    MS_Next_Control.Focus();
                else
                    SendKeys.Send("{TAB}");
                e.Handled = true;
                base.OnKeyPress(e);
                return;
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            _focused = true;
            _fieldControls[2].TakeFocus(Direction.Forward, Selection.All);
            _fieldControls[2].SelectAll();
            //=======================
            if (MS_Change_Color_On_Enter && !MS_Enter_Color.IsEmpty)
            {
                if (!AnyBlank)
                {
                    if(BackColor != Color.Red)
                        _Back_Color = this.BackColor;
                    this.BackColor = MS_Enter_Color;
                }
                else
                {
                    if(MS_Structure_Shamsi.Is_Tarikh_True(Text) && BackColor != Color.Red)
                        _Back_Color = this.BackColor;
                    this.BackColor = MS_Enter_Color;
                }

                //if (!AnyBlank && MS_Structure_Shamsi.Is_Tarikh_True(Text) && BackColor != Color.Red)
                //{
                //    _Back_Color = this.BackColor;
                //    this.BackColor = MS_Enter_Color;
                //}
            }
            if (MS_Change_Border_Color_On_Enter && !MS_Enter_Border_Color.IsEmpty)
            {
                _Main_Border_Color = MS_Enter_Border_Color;
                //_borderColor = MS_Enter_Border_Color;
            }
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            //foreach (FieldControl fieldControl in _fieldControls)
            //    IsControlValid(fieldControl);
            //Application.DoEvents();
            //=======================
            if (!AnyBlank && !MS_Structure_Shamsi.Is_Tarikh_True(Text))
            {
                this.BackColor = Color.Red;
            }
            else if (MS_Change_Color_On_Enter && !MS_Enter_Color.IsEmpty)
            {
                this.BackColor = _Back_Color;
            }
            if (MS_Change_Border_Color_On_Enter && !MS_Enter_Border_Color.IsEmpty)
            {
                _Main_Border_Color = MS_BorderColor;
                //MS_BorderColor = _old_border_color;
            }
            base.OnLeave(e);
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                Graphics g = Graphics.FromHwnd(Handle);
                Rectangle bounds = new Rectangle(0, 0, Width, Height);
                ControlPaint.DrawBorder(g, bounds, _Main_Border_Color, _borderStyle);
            }
        }
        //====================== Native Methods
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1806",
            Justification = "What should be done if ReleaseDC() doesn't work?")]
        private static NativeMethods.TEXTMETRIC GetTextMetrics(IntPtr hwnd, Font font)
        {
            IntPtr hdc = NativeMethods.GetWindowDC(hwnd);

            NativeMethods.TEXTMETRIC textMetric;
            IntPtr hFont = font.ToHfont();

            try
            {
                IntPtr hFontPrevious = NativeMethods.SelectObject(hdc, hFont);
                NativeMethods.GetTextMetrics(hdc, out textMetric);
                NativeMethods.SelectObject(hdc, hFontPrevious);
            }
            finally
            {
                NativeMethods.ReleaseDC(hwnd, hdc);
                NativeMethods.DeleteObject(hFont);
            }

            return textMetric;
        }
        #endregion
        #region رویدادهای Field
        private void IPAddressControl_DragDrop(object sender, DragEventArgs e)
        {
            Text = e.Data.GetData(DataFormats.Text).ToString();
        }
        private void IPAddressControl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void LayoutControls()
        {
            SuspendLayout();

            int difference = Width - MinimumSize.Width;

            Debug.Assert(difference >= 0);

            int numOffsets = _fieldControls.Length + _dotControls.Length + 1;

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

            //switch (MS_BorderStyle)
            //{
            //    case BorderStyle.Fixed3D:
            //        x = Fixed3DOffset.Width;
            //        y = Fixed3DOffset.Height;
            //        break;
            //    case BorderStyle.FixedSingle:
            //        x = FixedSingleOffset.Width;
            //        y = FixedSingleOffset.Height;
            //        break;
            //}

            int offsetIndex = 0;

            MS_Calender_Button.Location = new Point(x, y);
            this.MS_Calender_Button.Size = new System.Drawing.Size(20, this.Height - 2 * y);

            x += offsets[offsetIndex++];
            x += MS_Calender_Button.Width;

            for (int i = 0; i < _fieldControls.Length; ++i)
            {
                _fieldControls[i].Location = new Point(x, y);

                x += _fieldControls[i].Width;

                if (i < _dotControls.Length)
                {
                    x += offsets[offsetIndex++];
                    _dotControls[i].Location = new Point(x, y);
                    x += _dotControls[i].Width;
                    x += offsets[offsetIndex++];
                }
            }

            ResumeLayout(false);
        }
        private void OnCedeFocus(Object sender, CedeFocusEventArgs e)
        {
            switch (e.Action)
            {
                case Action.Home:

                    _fieldControls[0].TakeFocus(Action.Home);
                    return;

                case Action.End:

                    _fieldControls[FieldCount - 1].TakeFocus(Action.End);
                    return;

                case Action.Trim:

                    if (e.FieldIndex == 0)
                    {
                        return;
                    }

                    _fieldControls[e.FieldIndex - 1].TakeFocus(Action.Trim);
                    return;
            }

            if ((e.Direction == Direction.Reverse && e.FieldIndex == 0) ||
                (e.Direction == Direction.Forward && e.FieldIndex == (FieldCount - 1)))
            {
                return;
            }

            int fieldIndex = e.FieldIndex;

            if (e.Direction == Direction.Forward)
            {
                ++fieldIndex;
            }
            else
            {
                --fieldIndex;
            }

            _fieldControls[fieldIndex].TakeFocus(e.Direction, e.Selection);
        }
        private void OnFieldGotFocus(Object sender, EventArgs e)
        {
            if (!_focused)
            {
                _focused = true;
                base.OnGotFocus(EventArgs.Empty);
            }
        }
        private void OnFieldKeyDown(Object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }
        private void OnFieldKeyPressed(Object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }
        private void OnFieldPreviewKeyDown(Object sender, PreviewKeyDownEventArgs e)
        {
            OnPreviewKeyDown(e);
        }
        private void OnFieldKeyUp(Object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }
        private void OnFieldLostFocus(Object sender, EventArgs e)
        {
            if (!Focused)
            {
                _focused = false;
                base.OnLostFocus(EventArgs.Empty);
            }
        }
        private void OnFieldTextChanged(Object sender, TextChangedEventArgs e)
        {
            if (null != MS_FieldChangedEvent)
            {
                FieldChangedEventArgs args = new FieldChangedEventArgs();
                args.FieldIndex = e.FieldIndex;
                args.Text = e.Text;
                MS_FieldChangedEvent(this, args);
            }
            if (_Do_Spread)
                OnTextChanged(EventArgs.Empty);
        }
        private void OnSubControlClicked(object sender, EventArgs e)
        {
            OnClick(e);
        }
        private void OnSubControlDoubleClicked(object sender, EventArgs e)
        {
            OnDoubleClick(e);
        }
        private void OnSubControlMouseClicked(object sender, MouseEventArgs e)
        {
            OnMouseClick(e);
        }
        private void OnSubControlMouseDoubleClicked(object sender, MouseEventArgs e)
        {
            OnMouseDoubleClick(e);
        }
        private void OnSubControlMouseEntered(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }
        private void OnSubControlMouseHovered(object sender, EventArgs e)
        {
            OnMouseHover(e);
        }
        private void OnSubControlMouseLeft(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }
        private void OnSubControlMouseMoved(object sender, MouseEventArgs e)
        {
            OnMouseMove(e);
        }
        private void MS_Tarikh_TextBox_Click(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        #endregion
        #region سازنده
        public MS_Tarikh_TextBox()
        {
            InitializeComponent();

            BackColor = Color.White;
            ResetBackColorChanged();

            Add_Controls();
            _DropDown=new Popup_Tarix();
            _DropDown.Set_Control(ms_tarikh_DropDown);
            ms_tarikh_DropDown.BorderStyle=BorderStyle.None;

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ContainerControl, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);

            _referenceTextBox.AutoSize = true;

            Cursor = Cursors.IBeam;
            this.RightToLeft = RightToLeft.No;
            Size = MinimumSize;

            DragEnter += new DragEventHandler(IPAddressControl_DragEnter);
            DragDrop += new DragEventHandler(IPAddressControl_DragDrop);
            Clear();
        }
        private void InitializeComponent()
        {
            this.ms_tarikh_DropDown = new MS_Control.Tarikh.MS_Tatikh_View();
            this.SuspendLayout();
            // 
            // ms_tarikh_DropDown
            // 
            this.ms_tarikh_DropDown.BackColor = System.Drawing.Color.White;
            this.ms_tarikh_DropDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ms_tarikh_DropDown.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_tarikh_DropDown.Location = new System.Drawing.Point(0, 0);
            this.ms_tarikh_DropDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ms_tarikh_DropDown.Name = "ms_tarikh_DropDown";
            this.ms_tarikh_DropDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_tarikh_DropDown.Size = new System.Drawing.Size(208, 252);
            this.ms_tarikh_DropDown.TabIndex = 0;
            this.ms_tarikh_DropDown.MS_On_OK_Clicked += new MS_Control.Tarikh.MS_Tatikh_View.MS_On_Button_Click(this.ms_tarikh_DropDown_MS_On_OK_Clicked);
            this.ms_tarikh_DropDown.MS_On_Cancel_Clicked += new MS_Control.Tarikh.MS_Tatikh_View.MS_On_Button_Click(this.ms_tarikh_DropDown_MS_On_Cancel_Clicked);
            // 
            // MS_Tarikh_TextBox
            // 
            this.ResumeLayout(false);

        }
        #endregion
        #region رویدادهـا
        private void MS_Calender_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Text) && MS_Structure_Shamsi.Is_Tarikh_True(Text))
                ms_tarikh_DropDown.MS_Tarikh = new MS_Structure_Shamsi(Text);
            else
                ms_tarikh_DropDown.MS_Tarikh = this.MS_Tarikh ?? new MS_Structure_Shamsi(DateTime.Now);
            ShowMenu();
        }
        private void ms_tarikh_DropDown_MS_On_Cancel_Clicked()
        {
            HideMenu();
        }
        private void ms_tarikh_DropDown_MS_On_OK_Clicked()
        {
            HideMenu();
            _Do_Spread = false;

            _fieldControls[0].Text = ms_tarikh_DropDown.MS_Tarikh._Sal.ToString();
            _fieldControls[1].Text = ms_tarikh_DropDown.MS_Tarikh._Mah.ToString("D2");
            _fieldControls[2].Text = ms_tarikh_DropDown.MS_Tarikh._Roz.ToString("D2");

            _Do_Spread = true;
            OnTextChanged(EventArgs.Empty);
        }
        #endregion
    }
}
