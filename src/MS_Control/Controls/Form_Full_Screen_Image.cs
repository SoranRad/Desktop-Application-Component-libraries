using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Control.Controls
{
    public partial class Form_Full_Screen_Image : MS_Mother_Two
    {
        public Form_Full_Screen_Image(MS_Chart Chart)
        {
            InitializeComponent();
            System.IO.MemoryStream myStream = new System.IO.MemoryStream();
            Chart.Serializer.Save(myStream);
            mp_chart.Serializer.Load(myStream);
            //=================
            mp_chart.Anchor = AnchorStyles.None;
            mp_chart.Top = 0;
            mp_chart.Left = 0;
            mp_chart.Size = new System.Drawing.Size(this.Width - 17, this.Height - 39);
            mp_chart.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top;
            mp_chart.mp_full_screen.Enabled = false;
        }

    }
}
