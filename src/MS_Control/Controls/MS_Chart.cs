using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MS_Control.Controls
{
    public partial class MS_Chart : System.Windows.Forms.DataVisualization.Charting.Chart
    {
        public MS_Chart()
        {
            InitializeComponent();
            int top = 3, left = 3;
            mp_export_picture.BringToFront();
            mp_menu.BringToFront();
            mp_full_screen.BringToFront();
            //==============================
            mp_export_picture.Left = left;
            mp_export_picture.Top = top;

            mp_menu.Left = left;
            mp_menu.Top = mp_export_picture.Top + mp_export_picture.Height;

            mp_full_screen.Left = left;
            mp_full_screen.Top = mp_menu.Top + mp_menu.Height;
        }
        private void mp_menu_MouseUp(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show(sender as Control, e.X, e.Y);
        }
        private void mp_export_picture_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            ImageFormat format;
            switch (Path.GetExtension(saveFileDialog1.FileName).ToLower())
            {
                case ".bmp":
                    format = ImageFormat.Bmp;
                    break;
                case ".emf":
                    format = ImageFormat.Emf;
                    break;
                case ".exif":
                    format = ImageFormat.Exif;
                    break;
                case ".gif":
                    format = ImageFormat.Gif;
                    break;
                case ".jpeg":
                    format = ImageFormat.Jpeg;
                    break;
                case ".png":
                    format = ImageFormat.Png;
                    break;
                case ".tiff":
                    format = ImageFormat.Tiff;
                    break;
                case ".wmf":
                    format = ImageFormat.Wmf;
                    break;
                default:
                    format = ImageFormat.Bmp;
                    break;
            }
            this.SaveImage(saveFileDialog1.FileName, format);
            Process.Start(saveFileDialog1.FileName);
        }
        private void mp_full_screen_Click(object sender, EventArgs e)
        {
            //MP_Chart temp = new MP_Chart();
            ////copyControl(this, temp);
            //temp = (MP_Chart)CloneObject(this as System.Windows.Forms.DataVisualization.Charting.Chart);
            new Form_Full_Screen_Image(this).Show();
        }
        private void ms_Ofoghi_Click(object sender, EventArgs e)
        {
            this.ChartAreas.First().AxisX.MajorGrid.Enabled = false;
            this.ChartAreas.First().AxisY.MajorGrid.Enabled = false;
            var seri = Series.FirstOrDefault();
            if(seri==null)
                return;
            seri.IsVisibleInLegend = false;
            seri.ChartType = SeriesChartType.Column;
        }

        private void ms_Dayere_Click(object sender, EventArgs e)
        {
            var seri = Series.FirstOrDefault();
            if (seri == null)
                return;
            seri.IsVisibleInLegend = true;
            seri.ChartType = SeriesChartType.Pie;
        }
        private void ms_Herami_Click(object sender, EventArgs e)
        {
            var seri = Series.FirstOrDefault();
            if (seri == null)
                return;
            seri.IsVisibleInLegend = true;
            seri.ChartType = SeriesChartType.Pyramid;
        }
        private void mp_export_picture_MouseEnter(object sender, EventArgs e)
        {
            ToolTip x = new ToolTip();
            x.SetToolTip(mp_export_picture, "ذخـیـره چـارت");
        }
        private void mp_menu_MouseEnter(object sender, EventArgs e)
        {
            ToolTip x = new ToolTip();
            x.SetToolTip(mp_menu, "تـغـیـیـر چـارت");
        }
        private void mp_full_screen_MouseEnter(object sender, EventArgs e)
        {
            ToolTip x = new ToolTip();
            x.SetToolTip(mp_full_screen, "تـمـام صـفـحـه");
        }
    }
}
