using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Control.Controls
{
    public partial class MS_Panel : Panel
    {
        #region فیلد
        public Color MS_Color_Start { get; set; }
        public Color MS_Color_End { get; set; }
        private Color _borderColor = Color.Silver;
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        private static int WM_PAINT = 0x000F;
        #endregion
        #region پراپرتی
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
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(this.ClientRectangle,
                                                               MS_Color_Start,
                                                               MS_Color_End,
                                                               90F))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
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
        #endregion
        public MS_Panel()
        {
            InitializeComponent();
        }
    }
}
