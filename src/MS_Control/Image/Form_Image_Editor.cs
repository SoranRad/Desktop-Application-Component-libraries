using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cyotek.Windows.Forms;
using Cyotek.Windows.Forms.Demo;

namespace MS_Control.Image
{
    public partial class Form_Image_Editor : MS_Mother_Two
    {
        private System.Drawing.Image    _Original_Image,
                                        _Edited_Image;
        private Size                    _Fit_Size;

        public System.Drawing.Image     MS_Image
        {
            get { return _Original_Image; }
            set
            {
                _Original_Image = value;
                _Edited_Image = value;
                Refresh_Image();
            }
        }
        public Size                     MS_Size_Crop
        {
            get
            {
                return _Fit_Size;
            }
            set { _Fit_Size = value; }
        }

        private void    Refresh_Image           ()
        {
            ms_image_Box.Image = _Original_Image;
        }

        public          Form_Image_Editor       ()
        {
            InitializeComponent();
        }
        public          Form_Image_Editor       (Size Fit_Size)
        {
            InitializeComponent();
            _Fit_Size = Fit_Size;
        }

        private void Form_Image_Editor_Load     (object sender, EventArgs e)
        {
            //if (ms_image_Box.Image == null)
            //    return;
            
        }
        private void Form_Image_Editor_Shown    (object sender, EventArgs e)
        {
            if (_Fit_Size != null)
            {
                ms_image_Box.SelectionRegion = new RectangleF(0, 0, _Fit_Size.Width, _Fit_Size.Height);
                ms_image_Box.MinimumSelectionSize = _Fit_Size;
                ms_image_Box.SelectionMode = ImageBoxSelectionMode.Rectangle;
                foreach (DragHandle handle in ms_image_Box.DragHandles)
                    handle.Visible = false;
            }
        }

        private void ms_image_Box_Selecting     (object sender, ImageBoxCancelEventArgs e)
        {
            e.Cancel = true;
        }
       
        private void ms_rotate_right_Click      (object sender, EventArgs e)
        {
            if (ms_image_Box.Image == null) return;
            ms_image_Box.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            ms_image_Box.Update();
            ms_image_Box.Refresh();
        }
        private void ms_rotate_left_Click       (object sender, EventArgs e)
        {
            if (ms_image_Box.Image == null) return;

            ms_image_Box.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            ms_image_Box.Update();
            ms_image_Box.Refresh();
        }

        private void ms_zoom_out_Click          (object sender, EventArgs e)
        {
            ms_image_Box.ZoomOut();
        }
        private void ms_zoom_in_Click           (object sender, EventArgs e)
        {
            ms_image_Box.ZoomIn();

        }
        private void ms_horizental_rotate_Click (object sender, EventArgs e)
        {
            if (ms_image_Box.Image == null) return;

            ms_image_Box.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            ms_image_Box.Update();
            ms_image_Box.Refresh();
        }
        private void ms_vertical_rotate_Click   (object sender, EventArgs e)
        {
            if (ms_image_Box.Image == null) return;

            ms_image_Box.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            ms_image_Box.Update();
            ms_image_Box.Refresh();
        }

        private void ms_crop_Click              (object sender, EventArgs e)
        {
            if (ms_image_Box.Image == null) return;
            var img = MS_Util.Copy(ms_image_Box.Image, ms_image_Box.SelectionRegion);
            _Edited_Image = img;
            ms_image_Box.Image = img;
            ms_image_Box.Refresh();
            ms_image_Box.SelectionRegion = new RectangleF(0, 0, _Fit_Size.Width, _Fit_Size.Height);
            ms_image_Box.Update();
            ms_image_Box.Refresh();
        }
        private void ms_undo_Click              (object sender, EventArgs e)
        {
            _Edited_Image = _Original_Image;
            ms_image_Box.Image = _Original_Image;
            ms_image_Box.Refresh();

        }

        private void ms_ok_Click                (object sender, EventArgs e)
        {
            _Original_Image = ms_image_Box.Image;
            DialogResult=DialogResult.OK;
        }
        private void ms_cancel_Click            (object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ms_fit_image_Click         (object sender, EventArgs e)
        {
            if (ms_image_Box.Image == null) return;
            var img = MS_Util.ResizeImage(ms_image_Box.Image,
                _Fit_Size.Width,
                _Fit_Size.Height);
            _Edited_Image = img;
            ms_image_Box.Image = img;
            ms_image_Box.SelectionRegion = new RectangleF(0, 0, _Fit_Size.Width, _Fit_Size.Height);
            ms_image_Box.Update();
        }




    }
}
