using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MS_Control.MS_Anchor
{
    public class MS_Anchor : Label
    {
        #region Static Field
        public static int MinX, MaxX, MinY, MaxY;
        private const int Max_Width = 5, Max_Height = 8;
        #endregion
        #region Field
        private MS_Anchor_Enum _Location;
        private static Size _Size = new Size(8, 8);
        private Control _Control;
        private Color _Hover_Color, _Enter_Color;
        private bool Dragging = false;
        private Point DragStart = Point.Empty; 
        public EventHandler On_Control_Click;
        #endregion
        #region Property
        public MS_Anchor_Enum MS_Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        public Control MS_Control
        {
            get { return _Control; }

        }
        #endregion
        #region Method
        private void Init()
        {
            switch (_Location)
            {
                case MS_Anchor_Enum.Top_Left:
                    this.Cursor = Cursors.SizeNWSE;
                    break;
                case MS_Anchor_Enum.Top_Right:
                    this.Cursor = Cursors.SizeNESW;
                    break;
                case MS_Anchor_Enum.Top_Middle:
                    this.Cursor = Cursors.SizeNS;
                    break;
                case MS_Anchor_Enum.Bottom_Left:
                    this.Cursor = Cursors.SizeNESW;
                    break;
                case MS_Anchor_Enum.Bottom_Right:
                    this.Cursor = Cursors.SizeNWSE;
                    break;
                case MS_Anchor_Enum.Bottom_Middle:
                    this.Cursor = Cursors.SizeNS;
                    break;
                case MS_Anchor_Enum.Left_Middle:
                    this.Cursor = Cursors.SizeWE;
                    break;
                case MS_Anchor_Enum.Right_Middle:
                    this.Cursor = Cursors.SizeWE;
                    break;
            }

            if (_Control != null)
            {
                _Control.Move += Control_Moved;
                _Control.LocationChanged += Control_Moved;

                _Control.SizeChanged += Control_Moved;
                _Control.Resize += Control_Moved;

                Control_Moved(null, null);
                var form = _Control.FindForm();
                form?.Controls.Add(this);
                Application.DoEvents();
            }
        }
        private void Control_Moved(object sender, EventArgs e)
        {
            if(_Control==null)
                return;
            switch (this.MS_Location)
            {
                case MS_Anchor_Enum.Top_Left:
                    this.Left = _Control.Left-this.Width;
                    this.Top = _Control.Top - this.Height;
                    break;
                case MS_Anchor_Enum.Top_Right:
                    this.Left = _Control.Left + _Control.Width;
                    this.Top = _Control.Top - this.Height;
                    break;
                case MS_Anchor_Enum.Top_Middle:
                    this.Left = _Control.Left + (_Control.Width / 2 ) - (this.Width/2);
                    this.Top = _Control.Top - this.Height;
                    break;
                case MS_Anchor_Enum.Bottom_Left:
                    this.Left = _Control.Left - this.Width ;
                    this.Top = _Control.Top +_Control.Height;
                    break;
                case MS_Anchor_Enum.Bottom_Right:
                    this.Left = _Control.Left +_Control.Width;
                    this.Top = _Control.Top + _Control.Height ;
                    break;
                case MS_Anchor_Enum.Bottom_Middle:
                    this.Left = _Control.Left + (_Control.Width / 2) - (this.Width / 2);
                    this.Top = _Control.Top + _Control.Height;
                    break;
                case MS_Anchor_Enum.Right_Middle:
                    this.Left = _Control.Left + _Control.Width   ;
                    this.Top = _Control.Top + (_Control.Height/2 )-(this.Height/2);
                    break;
                case MS_Anchor_Enum.Left_Middle:
                    this.Left = _Control.Left -this.Width;
                    this.Top = _Control.Top + (_Control.Height/2) - (this.Height / 2);
                    break;
            }
        }
        public bool Reset()
        {
            if (_Control != null)
            {
                _Control.Move -= Control_Moved;
                _Control.LocationChanged -= Control_Moved;

                _Control.SizeChanged -= Control_Moved;
                _Control.Resize -= Control_Moved;
            }
            return true;
        }

        #endregion
        #region Constructor
        public MS_Anchor(Control control, MS_Anchor_Enum Location, Color Back_Color)
        {
            _Control = control;
            _Location = Location;
            AutoSize = false;
            Text = "";
            this.Size = _Size;
            BackColor = Back_Color;
            BorderStyle = BorderStyle.Fixed3D;
            Init();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Dragging = true;
            DragStart = new Point(e.X, e.Y);
            this.Capture = true;

            On_Control_Click?.Invoke(_Control, new EventArgs());

        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (Dragging)
            {

                var deltaX = e.X + DragStart.X;
                var deltaY = e.Y + DragStart.Y;

                switch (_Location)
                {
                    case MS_Anchor_Enum.Top_Left:

                        //if (_Control.Top + deltaY >= MinY && _Control.Top + deltaY <= MaxY
                        //    && _Control.Top + _Control.Height - deltaY < MaxY)
                        {
                            _Control.Top += deltaY;
                            _Control.Height -= deltaY;
                        }

                        //if (_Control.Left + deltaX >= MinX && _Control.Left + deltaX <= MaxX
                        //    && _Control.Left + _Control.Width - deltaX <= MaxX)
                        {
                            _Control.Left += deltaX;
                            _Control.Width -= deltaX;
                        }
                        break;
                    case MS_Anchor_Enum.Top_Right:
                        _Control.Top += deltaY;
                        _Control.Height -= deltaY;
                        _Control.Width += deltaX;
                        break;
                    case MS_Anchor_Enum.Top_Middle:
                        _Control.Top += deltaY;
                        _Control.Height -= deltaY;
                        break;
                    case MS_Anchor_Enum.Bottom_Left:
                        _Control.Height += deltaY;

                        _Control.Left += deltaX;
                        _Control.Width -= deltaX;
                        break;
                    case MS_Anchor_Enum.Bottom_Right:
                        _Control.Width += deltaX;
                        _Control.Height += deltaY;
                        break;
                    case MS_Anchor_Enum.Bottom_Middle:
                        _Control.Height +=deltaY;
                        break;
                    case MS_Anchor_Enum.Right_Middle:
                        _Control.Width += deltaX;
                        break;
                    case MS_Anchor_Enum.Left_Middle:
                        _Control.Left += deltaX;
                        _Control.Width -= deltaX;
                        break;
                }

                //_Control.Top = Math.Max(_Control.Top, MinY);
                //if (_Control.Top + _Control.Height > MaxY)
                //    _Control.Height -=(_Control.Top + _Control.Height - MaxY);

                //_Control.Left = Math.Max(_Control.Left, MinX);
                //if (_Control.Left + _Control.Width > MaxX)
                //    _Control.Width -= (_Control.Left + _Control.Width - MaxX);
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Dragging = false;
            this.Capture = false;
        }

        #endregion
    }
}
