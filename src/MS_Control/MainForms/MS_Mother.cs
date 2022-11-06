using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Control
{
    public partial class MS_Mother : Form
    {
        #region فـــیلد
        public static int MS_Salmali;
        public static System.Drawing.Image MS_Icon_Form = null;
        private Color _Color = Color.DodgerBlue;
        private bool _Do_Drag = false, _Is_Maximaiz = false;
        private Point _Start_Point;
        private const int CS_DROPSHADOW = 0x00020000;

        private bool _Show_Close = true, _Show_Minimize = true, _Show_Maximize = true, _Show_Salmali = false, _Show_Icon = true,
            _Move_Window=true,_Resize_Window=true,_Exit_Escape=false;
        
        #endregion
        #region پـراپــرتی
        [Category("MS_Properties")]
        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        [Category("MS_Properties")]
        public Color MS_Color
        {
            get { return _Color; }
            set
            {
                _Color = value;
                Avaz_Kardan_Title();
            }
        }
        [Category("MS_Properties")]
        public bool MS_Maximize {
            get { return _Show_Maximize; }
            set
            {
                _Show_Maximize = value;
                Validate();
                lbl_Restore_Form.Visible = value;
            }
        }
        [Category("MS_Properties")]
        public bool MS_Minimize
        {
            get { return _Show_Minimize; }
            set
            {
                _Show_Minimize = value;
                Validate();
                lbl_Minimize_Form.Visible = value;
            }
        }
        [Category("MS_Properties")]
        public bool MS_Close
        {
            get { return _Show_Close; }
            set { _Show_Close = value;
                Validate();
                lbl_Close_Form.Visible = _Show_Close;
            }
        }
        [Category("MS_Properties")]
        public bool MS_Icon
        {
            get { return _Show_Icon; }
            set
            {
                _Show_Icon = value;
                Validate();
                lbl_Icon_Form.Visible = value;
            }
        }
        [Category("MS_Properties"), DefaultValue(true)]
        public bool MS_Move_Window {
            get { return _Move_Window; }
            set { _Move_Window = value; }
        }
        [Category("MS_Properties"), DefaultValue(true)]
        public bool MS_Resize_Window
        {
            get { return _Resize_Window; }
            set { _Resize_Window = value; }
        }
        [Category("MS_Properties"), DefaultValue(true)]
        public bool MS_Exit_Escape
        {
            get { return _Exit_Escape; }
            set { _Exit_Escape = value; }
        }
         [Category("MS_Properties"), DefaultValue(true)]
        public bool MS_Salmali_Show
        {
            get { return _Show_Salmali; }
            set
            {
                _Show_Salmali = value;
                Validate();
                lbl_salmali.Visible = value;
            }
        }

        [Category("MS_Properties")]
        [Browsable(true)]
        public System.Drawing.Image MS_Icon_Main
        {
            get { return MS_Icon_Form; }
            set
            {
                MS_Icon_Form = value;
                lbl_Icon_Form.Image = MS_Icon_Main;
            }
        }
        #endregion
        #region متد
        protected void Avaz_Kardan_Title()
        {
            ms_Title_Header_Form.BackColor = lbl_Close_Form.BackColor = lbl_Minimize_Form.BackColor =
            lbl_Restore_Form.BackColor = _Color =
            lbl_Right_Border.BackColor = lbl_Left_Border.BackColor =
            lbl_Down_Dorder.BackColor = lbl_Icon_Form.BackColor =panel1.BackColor=  _Color;

        }
        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
            lbl_Close_Form.Visible = _Show_Close;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            lbl_Close_Form.Visible = _Show_Close;
            lbl_Icon_Form.Visible = _Show_Icon;
            lbl_Minimize_Form.Visible = _Show_Minimize;
            lbl_Restore_Form.Visible = _Show_Maximize;
            lbl_salmali.Visible = _Show_Salmali;
        }
        #endregion

        public MS_Mother()
        {
            InitializeComponent();
            lbl_salmali.Text ="سال مالی " + MS_Salmali.ToString();
            if (MS_Icon_Main != null)
                lbl_Icon_Form.Image = MS_Icon_Main;
        }

        #region رویداد برچســب ها
        private void lbl_close_MouseEnter(object sender, EventArgs e)
        {
            ToolTip x = new ToolTip();
            x.SetToolTip(lbl_Close_Form, "بــســتــن فــرم  »  [Esc]");
            lbl_Close_Form.Image = global::MS_Control.Properties.Resources._MS_Form_Close_Focus;
        }
        private void lbl_close_MouseLeave(object sender, EventArgs e)
        {
            lbl_Close_Form.Image = global::MS_Control.Properties.Resources._MS_Form_Close;
        }
        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_restore_MouseEnter(object sender, EventArgs e)
        {
            ToolTip x = new ToolTip();
            x.SetToolTip(lbl_Restore_Form, "تـغـیـیـر انـدازه فــرم");

            if (this.WindowState == FormWindowState.Maximized)
            {
                lbl_Restore_Form.Image = global::MS_Control.Properties.Resources._MS_Form_Max_Normal_Focus;
            }
            else
            {
                lbl_Restore_Form.Image = global::MS_Control.Properties.Resources._MS_Form_Max_Full_Focus;
            }
        }
        private void lbl_restore_MouseLeave(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                lbl_Restore_Form.Image = global::MS_Control.Properties.Resources._MS_Form_Max_Normal;
            }
            else
            {
                lbl_Restore_Form.Image = global::MS_Control.Properties.Resources._MS_Form_Max_Full;
            }
        }
        private void lbl_restore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) _Is_Maximaiz = true;

            if (_Is_Maximaiz == false)
            {
                if (!DesignMode)
                {
                    var x = Screen.PrimaryScreen.Bounds;
                    this.MaximumSize = x.Size;
                }
                this.WindowState = FormWindowState.Maximized;
                _Is_Maximaiz = true;
                lbl_Restore_Form.Image = global::MS_Control.Properties.Resources._MS_Form_Max_Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.MaximumSize = new Size(0,0);
                _Is_Maximaiz = false;
                lbl_Restore_Form.Image = global::MS_Control.Properties.Resources._MS_Form_Max_Full;
            }
        }

        private void lbl_minimize_MouseEnter(object sender, EventArgs e)
        {
            ToolTip x = new ToolTip();
            x.SetToolTip(lbl_Minimize_Form, "کــوچــک کــردن فــرم");
            lbl_Minimize_Form.Image = global::MS_Control.Properties.Resources._MS_Form_Min_Focus;
        }
        private void lbl_minimize_MouseLeave(object sender, EventArgs e)
        {
            lbl_Minimize_Form.Image = global::MS_Control.Properties.Resources._MS_Form_Min;
        }
        private void lbl_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_right_border_MouseDown(object sender, MouseEventArgs e)
        {
            _Do_Drag = true;
            _Start_Point = e.Location;
        }
        private void lbl_right_border_MouseMove(object sender, MouseEventArgs e)
        {
            if (_Do_Drag && MS_Resize_Window)
            {
                int w = this.Size.Width;
                this.Size = new Size(w + (e.Location.X - this._Start_Point.X), this.Height);
            }
        }
        private void lbl_right_border_MouseUp(object sender, MouseEventArgs e)
        {
            _Do_Drag = false;
        }

        private void lbl_down_border_MouseDown(object sender, MouseEventArgs e)
        {
            _Do_Drag = true;
            _Start_Point = e.Location;
        }
        private void lbl_down_border_MouseMove(object sender, MouseEventArgs e)
        {
            if (_Do_Drag && MS_Resize_Window)
                this.Size = new Size(Width, Height + (e.Location.Y - _Start_Point.Y));
        }
        private void lbl_down_border_MouseUp(object sender, MouseEventArgs e)
        {
            _Do_Drag = false;
        }

        private void ms_title_MouseDown(object sender, MouseEventArgs e)
        {
            _Do_Drag = true;
            _Start_Point = new Point(e.X, e.Y);
        }
        private void ms_title_MouseMove(object sender, MouseEventArgs e)
        {
            if (_Do_Drag && MS_Move_Window)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - _Start_Point.X, p2.Y - _Start_Point.Y);
                this.Location = p3;
            }
        }
        private void ms_title_MouseUp(object sender, MouseEventArgs e)
        {
            _Do_Drag = false;
        }
        #endregion
        #region رویدادهای فـرم
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            ms_Title_Header_Form.Text = this.Text;
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyCode == Keys.Escape && MS_Exit_Escape)
                this.Close();
            //e.Handled = true;
        }
        private void MS_Mother_Activated(object sender, EventArgs e)
        {
            Avaz_Kardan_Title();
            lbl_Restore_Form.Image = this.WindowState == FormWindowState.Maximized ?
                global::MS_Control.Properties.Resources._MS_Form_Max_Normal :
                global::MS_Control.Properties.Resources._MS_Form_Max_Full;
        }
        private void MS_Mother_Deactivate(object sender, EventArgs e)
        {
            ms_Title_Header_Form.BackColor = lbl_Close_Form.BackColor = lbl_Minimize_Form.BackColor =
            lbl_Restore_Form.BackColor =
            lbl_Right_Border.BackColor = lbl_Left_Border.BackColor = lbl_Down_Dorder.BackColor = lbl_Icon_Form.BackColor = Color.Gainsboro;
        } 
        #endregion

        private void MS_Mother_Shown(object sender, EventArgs e)
        {
            if(DesignMode)
                return;
            var x = Screen.PrimaryScreen.WorkingArea;
            this.MaximumSize = x.Size;
        }
    }
}
