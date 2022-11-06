using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.ButtonBar;

namespace MS_Control.Controls
{
    public partial class MS_Label : Label
    {
        private bool _Move_over = false;

        public Color    MS_Color_Start      { get; set; }
        public Color    MS_Color_End        { get; set; }
        public int      MS_Border_Radius    { get; set; }
        public MS_Label()
        {
            MS_Color_End = Color.DodgerBlue;
            MS_Color_Start = Color.LightSkyBlue;
            MS_Border_Radius = 5;
            InitializeComponent();
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _Move_over = true;
            this.Refresh();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _Move_over = false;
            this.Refresh();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            if (!_Move_over)return;
            
            using (var brush = new LinearGradientBrush(this.ClientRectangle,
                                                               MS_Color_Start,
                                                               MS_Color_End,
                                                               90F))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                if (MS_Border_Radius > 0)
                {
                    GraphicsPath path = MS_Util.RoundedRectangle.Create(0, 0, Width, Height, MS_Border_Radius);
                    e.Graphics.SetClip(path);
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
                else
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
        }
    }
}
