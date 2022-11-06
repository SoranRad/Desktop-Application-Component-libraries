using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MS_Control.Image
{
    /// <summary>
    /// برا ی مشاهده تصویر 
    /// </summary>
    public partial class Form_Image_Viewer : MS_Mother_Two
    {
        public Form_Image_Viewer()
        {
            InitializeComponent();
        }

        public Form_Image_Viewer(byte[] Buffer)
        {
            InitializeComponent();

            MemoryStream ms = new MemoryStream(Buffer);
            ms_image_Box.Image = System.Drawing.Image.FromStream(ms);
        }

        public Form_Image_Viewer(System.Drawing.Image Image)
        {
            InitializeComponent();
            ms_image_Box.Image = Image;
        }
    }
}
