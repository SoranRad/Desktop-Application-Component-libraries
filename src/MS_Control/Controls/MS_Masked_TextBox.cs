using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Control.Controls
{
    public partial class MS_Masked_TextBox : Janus.Windows.GridEX.EditControls.MaskedEditBox
    {
        #region فیلد
        Color _Back_Color;
        bool _Do_Refresh = true;
        private Color _borderColor = Color.Silver, _old_border_color;
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        private static int WM_PAINT = 0x000F;
        #endregion
        #region پراپرتی
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
        #endregion
        #region متد
        public string SafeFarsiStr(string input)
        {
            return input.Replace("ی", "ی").Replace("ک", "ک");
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                Graphics g = Graphics.FromHwnd(Handle);
                var bounds = new Rectangle(0, 0, Width, Height);
                ControlPaint.DrawBorder(g, bounds, _borderColor, _borderStyle);
            }
        }
        #endregion

        public MS_Masked_TextBox()
        {
            InitializeComponent();
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
            }
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
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            //=====================================

            //=====================================
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

        protected override void OnTextBoxTextChanged(EventArgs e)
        {
            if (!_Do_Refresh) return;
            _Do_Refresh = false;
            var sel = this.SelectionStart;
            this.Text = SafeFarsiStr(this.Text);
            SelectionStart = sel;
            _Do_Refresh = true;
            base.OnTextBoxTextChanged(e);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            if (!_Do_Refresh) return;
            _Do_Refresh = false;
            var sel = this.SelectionStart;
            this.Text = SafeFarsiStr(this.Text);
            SelectionStart = sel;
            _Do_Refresh = true;
            base.OnTextChanged(e);
        }

    }
}
