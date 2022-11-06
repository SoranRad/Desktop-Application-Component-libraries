using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Stimulsoft.Report;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms.Design;
using MS_Control.Tarikh;

namespace MS_Control.MS_Anchor
{
    [ProvideProperty("MS_Resize_Moving", typeof(Control))]
    [Serializable]
    public class MS_Anchors : Component, IExtenderProvider, ISupportInitialize
    {
        #region فیلد
        private Color _Hover_Border, _Anchor_Color, _Moving_Color, _backcolor;
        private IList<Control> _List_Control;
        private IList<MS_Anchor> _Anchor_List;
        private bool Dragging = false;
        private Point DragStart = Point.Empty;
        public EventHandler On_Control_Click,On_Control_Moving,On_Control_Resize;
        private int _MinX, _MaxX, _MinY, _MaxY;
        #endregion
        #region پراپرتی
        public  Color MS_Hover_Color { get { return _Hover_Border; } set { _Hover_Border = value; } }
        public  Color MS_Anchor_Color { get { return _Anchor_Color; } set { _Anchor_Color = value; } }
        public  Color MS_Moving_Color { get { return _Moving_Color; } set { _Moving_Color = value; } }
        public int MS_Max_X { get { return MS_Anchor.MaxX; } set { MS_Anchor.MaxX = value; } }
        public int MS_Max_Y { get { return MS_Anchor.MaxY; } set { MS_Anchor.MaxY = value; } }
        public int MS_Min_X { get { return MS_Anchor.MinX; } set { MS_Anchor.MinX = value; } }
        public int MS_Min_Y { get { return MS_Anchor.MinY; } set { MS_Anchor.MinY = value; } }
        #endregion
        #region متد
        private void Init()
        {
            if (Container != null &&(Container is Form))
            {
                (Container as Form).Load += On_Form_Load;
            }
        }
        private void On_Form_Load(object sender, EventArgs e)
        {
            //Assign();
        }
        public  void Assign(Control Parent_Control)
        {
            _List_Control
                .MSZ_ForEach(control =>
                {
                    control.Cursor=Cursors.SizeAll;
                    
                    control.MouseDown += Mouse_Down;
                    control.MouseUp += Mouse_Up;
                    control.MouseMove += Mouse_Move;

                    control.Move += Control_Move;
                    control.LocationChanged += Control_Move;
                    control.Resize += Control_Resize;
                    control.SizeChanged += Control_Resize;

                    foreach (MS_Anchor_Enum item in Enum.GetValues(typeof(MS_Anchor_Enum)))
                    {
                        var anchor=new MS_Anchor(control,item,_Anchor_Color);
                        _Anchor_List.Add(anchor);
                        Parent_Control.Controls.Add(anchor);
                        anchor.On_Control_Click += (s, e) =>
                        {
                            On_Control_Click?.Invoke(s,e);
                        };
                    }

                });
        }
        private void Reset(Control e)
        {
            e.Cursor = Cursors.Default;
            e.MouseDown -= Mouse_Down;
            e.MouseUp -= Mouse_Up;
            e.MouseMove -= Mouse_Move;

            e.Move -= Control_Move;
            e.LocationChanged -= Control_Move;
            e.Resize -= Control_Resize;
            e.SizeChanged -= Control_Resize;

            var list=_Anchor_List.Where(x => x.MS_Control == e).ToList();
            foreach (MS_Anchor anchor in list)
            {
                _Anchor_List.Remove(anchor);
                anchor.Dispose();
            }
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragStart = new Point(e.X, e.Y);
            var control = sender as Control;

            control.Capture = true;
            if (!_Moving_Color.IsEmpty)
            {
              
                _backcolor = control.BackColor;
                control.BackColor = Color.FromArgb(120, _Moving_Color.R, _Moving_Color.G, _Moving_Color.B);
                    //_Moving_Color;
            }

            On_Control_Click?.Invoke(control, new EventArgs());
        }
        private void Mouse_Move(object sender, MouseEventArgs e)
        {
           if (Dragging)
            {
                var control = sender as Control;
                control.Left = Math.Max(0, e.X + control.Left - DragStart.X);
                control.Top = Math.Max(0, e.Y + control.Top - DragStart.Y);
                On_Control_Moving?.Invoke(control, new EventArgs());

            }
        }
        private void Mouse_Up(object sender, MouseEventArgs e)
        {
            Dragging = false;
            var control = sender as Control;
            control.Capture = false;
            if (!_Moving_Color.IsEmpty)
                control.BackColor = _backcolor;
        }
        private void Control_Resize(object sender, EventArgs e)
        {
            On_Control_Resize?.Invoke(sender,e);
        }
        private void Control_Move(object sender, EventArgs e)
        {
            On_Control_Moving?.Invoke(sender, e);
        }
        #endregion
        #region سازنده
        public MS_Anchors()
        {
            _List_Control =new List<Control>();
            _Anchor_List=new List<MS_Anchor>();
            Init();
        }
        public MS_Anchors(IContainer container)
        {
            container.Add(this);
            _List_Control = new List<Control>();
            _Anchor_List = new List<MS_Anchor>();
            Init();
        }
        public MS_Anchors(Control container)
        {
            _List_Control = new List<Control>();
            _Anchor_List = new List<MS_Anchor>();
            Init();
            //Parent = container;
        }
        public MS_Anchors(Form Form)
        {
            _List_Control = new List<Control>();
            _Anchor_List = new List<MS_Anchor>();
            Init();
            //Parent = container;
        }
        #endregion


        public void SetMS_Resize_Moving(Control myControl, bool value)
        {
            if (value)
            {
                if(!_List_Control.Contains(myControl))
                    _List_Control.Add(myControl);
            }
            else
            {
                if (_List_Control.Contains(myControl))
                {
                    _List_Control.Remove(myControl);
                    Reset(myControl);
                }
            }
        }
        public bool GetMS_Resize_Moving(Control myControl)
        {
            return _List_Control.Contains(myControl);
        }
        public bool CanExtend(object extendee)
        {
            return extendee is Control;
        }

        public void BeginInit()
        {
        }
        public void EndInit()
        {
        }
    }
}
