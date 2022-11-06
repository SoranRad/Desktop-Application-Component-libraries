using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Control.Controls
{
    public partial class MS_Decimal_Label : Label
    {
        #region فیلد
        Color _Back_Color;
        bool _Do_Refresh = true;
        private Color _borderColor = Color.Silver, _old_border_color;
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        private static int WM_PAINT = 0x000F;
        private decimal? _Number;
        private string _Format_String = "N";
        #endregion
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

        public decimal? MS_Decimal
        {
            get { return _Number??0; }
            set { _Number = value;Set_Text(); }
        }

        public string MS_Format_String
        {
            get { return _Format_String; }
            set { _Format_String = value;Set_Text(); }
        }
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
        private void Set_Text()
        {
            if (_Number.HasValue)
                this.Text = _Number.Value.ToString(_Format_String);
            else this.Text = "";
        }

        public MS_Decimal_Label()
        {
            InitializeComponent();
        }
      
    }
}
