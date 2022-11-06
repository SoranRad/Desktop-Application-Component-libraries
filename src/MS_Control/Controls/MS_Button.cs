using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Control.Controls
{
    public partial class MS_Button : Button
    {
        #region فیلد
        Color _Back_Color;
        private Color _borderColor = Color.Silver, _old_border_color;
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        private static int WM_PAINT = 0x000F;

        private bool _Move_over = false, _Mouse_Down = false;

        public Color MS_Color_Start { get; set; }
        public Color MS_Color_End { get; set; }
        #endregion
        #region پراپرتی
        public bool MS_Change_Color_On_Enter { set; get; }
        public bool MS_Change_Border_Color_On_Enter { set; get; }

        [DefaultValue(false)]
        public bool MS_Draw_Border { get; set; }
        public Color MS_Enter_Color { get; set; }
        public Color MS_Enter_Border_Color { get; set; }
        public Color MS_BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                if (MS_Draw_Border)
                    Invalidate(); // causes control to be redrawn
            }
        }
        public ButtonBorderStyle MS_BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                if (MS_Draw_Border)
                    Invalidate();
            }
        }
        #endregion
        #region متد
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
        #endregion
        public MS_Button()
        {
            InitializeComponent();
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
                if (!MS_Draw_Border)
                    Invalidate();
            }
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
                if (!MS_Draw_Border)
                    Invalidate();
            }
            base.OnLeave(e);
        }


    }
}
