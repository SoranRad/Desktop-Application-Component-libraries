using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

namespace MS_Control.Controls
{
    public class MS_NumericTextBox : Janus.Windows.GridEX.EditControls.EditBox
    {
        public enum TextBoxMode { IntNumber, DecNumber, Text }
        #region فیلد
        private TextBoxMode     mode = TextBoxMode.DecNumber;
        private bool            digitGroup = true;
        private string          simpleText = string.Empty;
        Color                   _Back_Color;
        int                     _Pos = 0;
        int                     _Len = 0;
        private Color _borderColor = Color.Silver,_old_border_color;
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        private static int WM_PAINT = 0x000F;
        private bool _Is_Delete_Key = false;
        #endregion
        #region پراپرتی
        public bool MS_Exit_By_Enter { get; set; }
        public bool MS_Exit_By_Down { get; set; }
        public bool MS_Exit_By_Up { get; set; }
        public Control MS_Next_Control { get; set; }
        public Control MS_Last_Control { get; set; }

        public bool  MS_Change_Color_On_Enter { set; get; }
        public Color MS_Enter_Color { get; set; }

        public bool  MS_Change_Border_Color_On_Enter { set; get; }
        public Color MS_Enter_Border_Color { get; set; }
        public Color MS_BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate(); // causes control to be redrawn
            }
        }
        public ButtonBorderStyle MS_BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                Invalidate();
            }
        }     


        public bool     MS_Is_Negative { get; set; }

        [Category("Mode"), DefaultValue(TextBoxMode.DecNumber), Description("حالت ورودی : ارقام صحیح و ارقام اعشاری")]
        public TextBoxMode Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        [Category("Mode"), DefaultValue(true), Description("جدا سازی ارقام به صورت سه تایی")]
        public bool DigitGroup
        {
            get { return digitGroup; }
            set { digitGroup = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string SimpleText
        {
            get { return simpleText; }
            private set
            {
                if (mode == TextBoxMode.Text)
                    simpleText = value;
                else
                    simpleText = value.Replace(",", string.Empty);
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public decimal MS_Decimal
        {
            get
            {
                try
                {
                    bool has_dash = simpleText.Contains("-");
                    string temp;
                    if (has_dash)
                        temp = simpleText.Remove(simpleText.IndexOf("-"), 1);
                    else
                        temp = simpleText;
                    //==============
                    if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator != ".")
                        temp = temp.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                    //==============
                    decimal temp_decimal = Convert.ToDecimal(temp);
                    if (has_dash) temp_decimal *= -1;

                    return temp_decimal;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set
            {
                this.Text = value.ToString();
            }
        }

        #endregion

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                Graphics g = Graphics.FromHwnd(Handle);
                Rectangle bounds = new Rectangle(0, 0, Width, Height);
                ControlPaint.DrawBorder(g, bounds, _borderColor, _borderStyle);
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            _Pos = base.SelectionStart+base.SelectionLength;
            _Len = base.Text.Length;
            _Is_Delete_Key = e.KeyCode == Keys.Delete;
            //if (e.KeyCode == Keys.Back && base.SelectionStart - 1 > 0 
            //    && this.Text[base.SelectionStart - 1] == (char) 44)
            //{
            //    _Pos--;
            //    base.SelectionStart--;
            //}
            base.OnKeyDown(e);
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
            //Set_Cursor_Location();
            base.OnKeyUp(e);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            char key = e.KeyChar;

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
            if (key == '+')
            {
                this.Text = simpleText + @"000";
                e.Handled = true;
                base.OnKeyPress(e);
                return;
            }
            if (key == '-' && !MS_Is_Negative)
            {
                this.Text = simpleText + @"00";
                e.Handled = true;
                base.OnKeyPress(e);
                return;
            }
            if (key == '-' && MS_Is_Negative)
            {
                if (this.RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    if (this.Text.Contains("-"))
                        this.Text = this.Text.Remove(this.Text.IndexOf('-', 0), 1);
                    else
                        this.Text = this.Text.Insert(this.Text.Length == 0 ? 0 : this.Text.Length - 1, "-");
                }
                else
                {
                    if (this.Text.Contains("-"))
                        this.Text = this.Text.Remove(this.Text.IndexOf('-', 0), 1);
                    else
                        this.Text = this.Text.Insert(0, "-");
                }
                e.Handled = true;
            }
            switch (mode)
            {
                case TextBoxMode.IntNumber:
                    if (!(char.IsDigit(key) || key == '\b'))
                        e.Handled = true;
                    break;
                case TextBoxMode.DecNumber:
                    if (!(char.IsDigit(key) || key == '\b' || key == '.'))
                        e.Handled = true;
                    else if (key == '.' && simpleText.Contains("."))
                        e.Handled = true;
                    break;
            }

            base.OnKeyPress(e);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            SimpleText = this.Text;
            string str = simpleText;

            switch (mode)
            {
                case TextBoxMode.IntNumber:
                    #region , Handel
                    if (digitGroup)
                    {
                        bool has_dash = simpleText.Contains("-");
                        if (has_dash)
                        {
                            simpleText = simpleText.Remove(simpleText.IndexOf("-"), 1);
                            str = str.Remove(str.IndexOf("-"), 1);
                        }

                        for (int i = simpleText.Length - 3; i > 0; i -= 3)
                            str = str.Insert(i, ",");

                        if (has_dash)
                        {
                            if (this.RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                            {
                                simpleText += "-";
                                str += "-";
                            }
                            else
                            {
                                simpleText = simpleText.Insert(0, "-");
                                str = str.Insert(0, "-");
                            }
                        }
                    }
                    #endregion
                    break;
                case TextBoxMode.DecNumber:
                    #region 0. Handel
                    //if (str.StartsWith("0"))
                    //{
                    //    str = str.Replace(".", string.Empty);
                    //    str = str.Insert(1, ".");
                    //}
                    //if (str.IndexOf('.') == 0)
                    //    str = str.Insert(0, "0");
                    #endregion
                    #region , Handel
                    if (simpleText.Contains("/"))
                        simpleText = simpleText.Replace('/', '.');

                    if (digitGroup)
                    {
                        bool has_dash = simpleText.Contains("-");
                        if (has_dash)
                        {
                            simpleText = simpleText.Remove(simpleText.IndexOf("-"), 1);
                            str = str.Remove(str.IndexOf("-"), 1);
                        }

                        if (simpleText.Contains("."))
                            for (int i = simpleText.IndexOf('.') - 3; i > 0; i -= 3)
                                str = str.Insert(i, ",");
                        else
                            for (int i = simpleText.Length - 3; i > 0; i -= 3)
                                str = str.Insert(i, ",");

                        if (has_dash)
                        {
                            if (this.RightToLeft == RightToLeft.Yes)
                            {
                                simpleText += "-"; //simpleText.Insert(simpleText.Length - 1, "-");
                                str += "-";// str.Insert(str.Length - 1, "-");
                            }
                            else
                            {
                                simpleText = simpleText.Insert(0, "-");
                                str = str.Insert(0, "-");
                            }
                        }
                    }
                    #endregion
                    break;
            }

            this.Text = str.Replace('.', '/');
            base.OnTextChanged(e);
            Set_Cursor_Location();
        }
        private void Set_Cursor_Location()
        {
            int tm = base.Text.Length - _Len;
            
            int x = _Pos + tm;
            x = x < 0 ? 0 : x;
            if (tm > 0)// طول زیاد شده باشد
            {
                base.Select(_Pos+tm, 0);
            }
            else if (tm < 0) //  اگر طول کم شده باشد
            {
                var i = Math.Max(0, _Pos + tm);
                base.Select(i, 0);
            }
            else // طول 
            {
                base.Select(_Pos,0);
            }
                //if (tm < 0 && TextLength == 1)
                //    base.Select(TextLength, 0);
                //else if(TextLength>0 && tm==0)
                //    base.Select(TextLength, 0);
                //else
                //    base.Select(x, 0);
            //_Len = TextLength;
        }
        protected override void OnEnter(EventArgs e)
        {
            if (MS_Change_Color_On_Enter && MS_Enter_Color != null)
            {
                _Back_Color = this.BackColor;
                this.BackColor = MS_Enter_Color;
            }
            if (MS_Change_Border_Color_On_Enter && MS_Enter_Border_Color != null)
            {
                _old_border_color = MS_BorderColor;
                MS_BorderColor = MS_Enter_Border_Color;
            }
            SelectAll();
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            if (MS_Change_Color_On_Enter && MS_Enter_Color != null)
            {
                this.BackColor = _Back_Color;
            }
            if (MS_Change_Border_Color_On_Enter && MS_Enter_Border_Color != null)
            {
                MS_BorderColor = _old_border_color;
            }
            base.OnLeave(e);
        }
        protected override void OnClick(EventArgs e)
        {
            SelectAll();
            base.OnClick(e);
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // MS_NumericTextBox
        //    // 
        //    this.Cursor = System.Windows.Forms.Cursors.Hand;
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}
    }
}