using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using MS_Control.Controls;
using MS_Control.CustomCombo;
using MS_Control.KeyBoardMouseHook;
using MS_Control.TSDD;

namespace MS_Control.TSDD
{
    public partial class MS_TextBox_ADC : EditBox, IMessageFilter
    {
        private static int InstanceCount = 0;
        #region کلیک
        private static IKeyboardMouseEvents m_GlobalHook;
        private const int WM_LBUTTONDOWN    = 0x0201;
        private const int WM_RBUTTONDOWN    = 0x0204;
        private const int WM_MBUTTONDOWN    = 0x0207;
        private const int WM_NCLBUTTONDOWN  = 0x00A1;
        private const int WM_NCRBUTTONDOWN  = 0x00A4;
        private const int WM_NCMBUTTONDOWN  = 0x00A7;

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        [ResourceExposure(ResourceScope.None)]
        public static extern int    MapWindowPoints     (IntPtr hWndFrom, IntPtr hWndTo, [In, Out] ref Point pt, int cPoints);


        public bool                 PreFilterMessage    (ref Message m)
        {
            if (_DropDown.IsDropDown)
            {
                switch (m.Msg)
                {
                    case WM_LBUTTONDOWN:
                    case WM_RBUTTONDOWN:
                    case WM_MBUTTONDOWN:
                    case WM_NCLBUTTONDOWN:
                    case WM_NCRBUTTONDOWN:
                    case WM_NCMBUTTONDOWN:
                        //
                        // When a mouse button is pressed, we should determine if it is within the client coordinates
                        // of the active dropdown.  If not, we should dismiss it.
                        //
                        int i = unchecked((int)(long)m.LParam);
                        short x = (short)(i & 0xFFFF);
                        short y = (short)((i >> 16) & 0xffff);
                        Point pt = new Point(x, y);
                        MapWindowPoints(m.HWnd, _DropDown.Handle, ref pt, 1);
                        if (!_DropDown.ClientRectangle.Contains(pt))
                        {
                            // the user has clicked outside the dropdown
                            pt = new Point(x, y);
                            MapWindowPoints(m.HWnd, Handle, ref pt, 1);
                            if (!ClientRectangle.Contains(pt))
                            {
                                // the user has clicked outside the combo
                                //HideMenu();
                            }
                            else
                            {
                                
                            }
                        }
                        break;
                }
            }
            return false;
        }
        #endregion

        #region فیلد
        private     SizeMode            m_sizeMode      = SizeMode.Control_Size;
        protected   Size                m_sizeCombo     = new Size(150, 200);
        protected   Popup_ToolStrip     _DropDown;
        protected   bool                _CaptureFocus   = false,
                                        _Do_Refresh     =true,
                                        _Inside=false;
        protected   IGridPopup          _Grid;
        protected   KindShow            _Popup_Direction;
        protected   Control             _Control;
        private     Color               _Back_Color,
                                        _borderColor    = Color.Silver, 
                                        _old_border_color;
        public event EventHandler <On_Selected>         MS_On_Row_Selected;
        public event EventHandler <EventArgs>           MS_On_BeNull;
        protected object                                _Selected_Item;
        private IKeyboardMouseEvents    _Hooking;
        private ButtonBorderStyle       _borderStyle    = ButtonBorderStyle.Solid;
        private static int              WM_PAINT        = 0x000F;
        #endregion

        #region پراپرتی
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool         MS_Auto_Popup
        {
            get;set;
        }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool         MS_CaptureFocus
        {
            get
            { return _CaptureFocus; }
            set { _CaptureFocus = value; }
        }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public SizeMode     MS_DropDownSizeMode
        {
            get { return this.m_sizeMode; }
            set
            {
                //if(DesignMode)
                //    return;
                    this.m_sizeMode = value;
                    AutoSizeDropDown();
            }
        }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Size         DropSize
        {
            get { return this.Size; }
            set
            {
                m_sizeCombo = value;
                if (m_sizeMode == SizeMode.Custome_Size)
                    AutoSizeDropDown();
            }
        }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public KindShow     MS_Drop_Direction
        {
            get { return _Popup_Direction; }
            set { _Popup_Direction = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Control      MS_List_Control {
            get { return _Control; }
            set
            {
                //if(DesignMode || (LicenseManager.UsageMode == LicenseUsageMode.Designtime))
                //    return;
                _Control = value;
                Set_Control(value);
            }
        }


        public bool         MS_Exit_By_Enter                { get; set; }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool         MS_Exit_By_Down                 { get; set; }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool         MS_Exit_By_Up                   { get; set; }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Control      MS_Next_Control                 { get; set; }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Control      MS_Last_Control                 { get; set; }

        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool         MS_Change_Color_On_Enter        { set; get; }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color        MS_Enter_Color                  { get; set; }

        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool         MS_Change_Border_Color_On_Enter { set; get; }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color        MS_Enter_Border_Color           { get; set; }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color        MS_BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate(); // causes control to be redrawn
            }
        }

        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ButtonBorderStyle MS_BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                Invalidate();
            }
        }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.)]
        public UIButton ClearButton { get { return ms_clear; } }
        #endregion

        #region متد
        protected virtual void      _Grid_MS_On_BeNull      (object sender, EventArgs e)
        {
            _Do_Refresh = false;
            _Selected_Item = null;
            Text = String.Empty;
            if (MS_On_BeNull != null)
                MS_On_BeNull(sender, e);
            HideMenu();
            _Do_Refresh = true;
        }
        protected virtual void      MS_On_Selected          (On_Item_Selected e)
        {
            if (MS_On_Row_Selected != null)
                MS_On_Row_Selected(null, new On_Selected() { Index = e.Index_Row, Item = e.Data_Row });
            HideMenu();
        }
        public void                 AutoSizeDropDown        ()
        {
            if (_Control != null)
            {
                switch (m_sizeMode)
                {
                    case SizeMode.Custome_Size:
                        _DropDown.Size = new Size(m_sizeCombo.Width, m_sizeCombo.Height);
                        break;

                    case SizeMode.Control_Size:
                        _DropDown.Size = new Size(_Control.Width+3, _Control.Height+3);
                        _Control.Size = new Size(_Control.Width , _Control.Height );
                        break;

                    case SizeMode.Mixed_Size:
                        _DropDown.Size  = new Size(this.Width+3, _Control.Height+3);
                        _Control.Size   = _DropDown.Size;
                        break;
                }
               
                _DropDown.InitializeTableLayoutSettings();
            
            }
        }
        public Point                Calculate_Location      ()
        {
            if (_Control == null)
                return this.Location;

            int w = Width - (_DropDown.Width );
            
            w = w > 0 ? Width - _DropDown.Width -4 : w;

            Point p;
                switch (_Popup_Direction)
                {
                    case KindShow.Right:
                        p = PointToScreen(new Point(w, Height));
                        break;
                    case KindShow.Middle:
                        var azaf = Math.Abs((Width - (_Control?.Width ?? 0)) / 2);
                        p = PointToScreen(new Point(w + azaf, Height));
                        break;
                    case KindShow.Left:
                        p = PointToScreen(new Point(0, Height));
                        break;
                    default:
                        p = PointToScreen(new Point(0, Height));
                        break;
                }
            //}
            if (p.Y + _DropDown.Height >= Screen.PrimaryScreen.WorkingArea.Height)
                p.Y -= (Height + _DropDown.Height);
            //if (p.Y + _Control.Height >= Screen.PrimaryScreen.WorkingArea.Height)
            //    p.Y -= (Height + _Control.Height);
            return p;

        }
        public void                 Set_Control             (Control Control_For_Popup)
        {
            if(Control_For_Popup==null)
                return;
            _DropDown = _DropDown ?? new Popup_ToolStrip();
            _DropDown.Set_Control(Control_For_Popup);
            _Grid = Control_For_Popup as IGridPopup;
            if (_Grid != null)
            {
                _Grid.Set_Parent(this);
                _Grid.MS_On_Row_Selected += MS_On_Selected;
                _Grid.MS_On_BeNull += _Grid_MS_On_BeNull;
            }
        }

        public void                 ShowMenu                ()
        {
            if (_DropDown != null && !_DropDown.Visible)
            {
                //Application.AddMessageFilter(this);
                

                AutoSizeDropDown();
                SubscribeForm();
                _DropDown.Show(Calculate_Location());
                _Control.Refresh();

                _Hooking.MouseDown += HookingOnMouseDown;
                _Hooking.MouseDoubleClick += HookingDoubleClick;
            }
            //else 
            //    HideMenu();
        }
        public void                 HideMenu                ()
        {
            if (_DropDown != null && _DropDown.Visible)
            {
                //Application.RemoveMessageFilter(this);
                _DropDown.Close();
                UnsubscribeForm();
                _Grid?.Reset_DB_Click();
            }
            _Hooking.MouseDown          -= HookingOnMouseDown;
            _Hooking.MouseDoubleClick   -= HookingDoubleClick;
            
        }

        private void                HookingOnMouseDown      (object sender, MouseEventArgs mouseEventArgs)
        {
            if (_DropDown.IsDropDown && !_DropDown.IsDisposed)
            {
                var rec = _DropDown.RectangleToScreen(_DropDown.ClientRectangle);
                _Inside = rec.Contains(new Point(mouseEventArgs.X, mouseEventArgs.Y));
                if (_Inside)
                {
                    if (!_DropDown.ContainsFocus)
                    {
                        var Item = _Grid.MS_Get_Grid();
                        var rec2 = Item.RectangleToScreen(Item.ClientRectangle);
                        var R = rec2.Contains(mouseEventArgs.X, mouseEventArgs.Y);
                        if (R)
                        {
                            var Coordinate = Item.PointToClient(Cursor.Position);
                            //Item.Select();
                            //MS_INPUT.SendMessage(Item.Handle, (int)MS_INPUT.WMessages.WM_LBUTTONDOWN, (IntPtr)0,
                            //    MS_INPUT.MakeLParam(Coordinate.X, Coordinate.Y));

                            //MS_INPUT.SendMessage(Item.Handle, (int)MS_INPUT.WMessages.WM_LBUTTONUP, (IntPtr)0,
                            //    MS_INPUT.MakeLParam(Coordinate.X, Coordinate.Y));
                        }
                        //_Grid.Process_Mouse(MS_INPUT.WMessages.WM_LBUTTONDOWN,
                        //    new Point(mouseEventArgs.X, mouseEventArgs.Y));
                    }
                }
                else
                {
                    rec = this.RectangleToScreen(this.ClientRectangle);
                    _Inside = rec.Contains(new Point(mouseEventArgs.X, mouseEventArgs.Y));
                    if (!_Inside)
                        HideMenu();
                }

            }
        }
        private void                HookingDoubleClick      (object sender, MouseEventArgs mouseEventArgs)
        {
            if (_DropDown.IsDropDown && !_DropDown.IsDisposed)
            {
                //Debug.Print("===Double Click hook");

                var rec = _DropDown.RectangleToScreen(_DropDown.ClientRectangle);
                _Inside = rec.Contains(new Point(mouseEventArgs.X, mouseEventArgs.Y));
                if (_Inside)
                {
                    //if (!_DropDown.ContainsFocus)
                    //{
                    //    _Grid.Process_Mouse(MS_INPUT.WMessages.WM_LBUTTONDBLCLK,
                    //        new Point(mouseEventArgs.X, mouseEventArgs.Y));
                    //}
                    var Item    = _Grid.MS_Get_Grid         ();
                    var rec2    = Item.RectangleToScreen    (Item.ClientRectangle);
                    var R       = rec2.Contains             (mouseEventArgs.X, mouseEventArgs.Y);
                    if (R)
                    {
                        var Coordinate = Item.PointToClient (Cursor.Position);
                        //Item.Select();

                        //MS_INPUT.SendMessage(Item.Handle, (int)MS_INPUT.WMessages.WM_NCLBUTTONDBLCLK, (IntPtr)0,
                        //    MS_INPUT.MakeLParam(Coordinate.X, Coordinate.Y));

                    }

                }
                else
                {
                    rec = this.RectangleToScreen(this.ClientRectangle);
                    _Inside = rec.Contains(new Point(mouseEventArgs.X, mouseEventArgs.Y));
                    if (!_Inside)
                        HideMenu();
                }

            }
        }
        private void                PositionButtonClear     ()
        {
            if (this.VisualStyle == VisualStyle.Default || this.VisualStyle == VisualStyle.Standard)
                ms_clear.Left = 18;
            else
                ms_clear.Left = ms_clear.Width+1;
        }

        #endregion

        #region فرم متد
        private void                SubscribeForm           ()
        {
            var form = this.FindForm();
            if (form == null) return;

            form.LocationChanged += new EventHandler(form_LocationChanged);
            form.ResizeBegin += new EventHandler(form_LocationChanged);
            form.FormClosing += new FormClosingEventHandler(form_FormClosing);
            form.LostFocus += new EventHandler(form_Deactived);
            form.Move += new EventHandler(form_LocationChanged);
            form.Deactivate += new EventHandler(form_Deactived);
        }
        private void                UnsubscribeForm         ()
        {
            var form = this.FindForm();
            if (form == null) return;

            form.LocationChanged -= new EventHandler(form_LocationChanged);
            form.ResizeBegin -= new EventHandler(form_LocationChanged);
            form.FormClosing -= new FormClosingEventHandler(form_FormClosing);
            form.LostFocus -= new EventHandler(form_Deactived);
            form.Move -= new EventHandler(form_LocationChanged);
            form.Deactivate -= new EventHandler(form_Deactived);
        }
        private void                form_FormClosing        (object sender, FormClosingEventArgs e)
        {
            //HideMenu();
        }
        private void                form_LocationChanged    (object sender, EventArgs e)
        {
            //HideMenu();
        }
        private void                form_Deactived          (object sender, EventArgs e)
        {
            Application.DoEvents();
            Thread.Sleep(500);
            Debug.Print("OnFormDeactive");

            var form = this.FindForm();
            if (form == null) return;
            if (!form.Focused 
                && !_Inside && !_Grid.Has_Focus())
            {
                HideMenu();
            }
        }
        #endregion

        #region Derived Methods
        public void                 Refresh_Grid            ()
        {
            Set_Control(_Control);
            if (_Grid!=null)
            _Grid.Refresh_Grid();
        }
        public void                 Refresh_Grid            (object Parameter)
        {
            Set_Control(_Control);

            if (_Grid!=null)
            _Grid.Refresh_Grid(Parameter);
        }
        public void                 Refresh_Grid            (params object[] List_Columns)
        {
            Set_Control(_Control);

            if (_Grid!=null)
            _Grid.Refresh_Grid(List_Columns);
        }
        public object               MS_Get_Selected         ()
        {
            return _Selected_Item;
        }
        public virtual void         MS_Set_Select           (object Item_to_Select)
        {
            _Grid.MS_Set_Select(Item_to_Select);
        }
        #endregion

        public MS_TextBox_ADC()
        {
            InitializeComponent();
            InstanceCount++;
            _DropDown = new Popup_ToolStrip();
            this.Controls.Add(ms_clear);
            ms_clear.Location = new Point(ms_clear.Width, (this.Height - ms_clear.Height) / 2);
            ms_clear.BringToFront();
            ms_clear.Hide();
            ms_clear.TabStop = false;
            _Hooking = KM_Hooking.GetHooking(true);
        }

         ~MS_TextBox_ADC()
         {
             InstanceCount--;
             if(InstanceCount<=0)
                KM_Hooking.Destroy();
         }
        #region متد Overrride
        protected override void     Dispose                             (bool disposing)
        {
            if (disposing)
            {
                if (_DropDown != null)
                    _DropDown.Dispose();
                if (_Control != null)
                    _Control.Dispose();
            }
            base.Dispose(disposing);
        }
        protected override void     OnTextChanged                       (EventArgs e)
        {
            base.OnTextChanged(e);

            //if (!_Do_Refresh)
            //    return;

            if (_Do_Refresh)
            {
                ShowMenu();
                _Grid?.Filter_Grid(this.Text.Trim());
            }
            ms_clear.Visible = !string.IsNullOrWhiteSpace(this.Text);
            PositionButtonClear();
        }
        protected override void     OnKeyPress                          (KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 27)
            {
                e.Handled = true;
                HideMenu();
            }
            else if (e.KeyChar == '\r' && MS_Exit_By_Enter)
            {
                if (MS_Next_Control != null && MS_Next_Control.Enabled && MS_Next_Control.Visible)
                    MS_Next_Control.Focus();
                else
                    SendKeys.Send("{TAB}");
                e.Handled = true;
                base.OnKeyPress(e);
                return;
            }
            //else if (char.IsLetterOrDigit(e.KeyChar) || char.IsSymbol(e.KeyChar))
            //{
            //    ShowMenu();
            //    if(_Grid!=null)
            //        _Grid.Filter_Grid(this.Text.Trim());
            //}
            base.OnKeyPress(e);
        }
        protected override void     OnKeyUp                             (KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                if(_DropDown.IsDropDown)
                    HideMenu();
                else 
                    ShowMenu();
                //_DropDown.Focus();
                //_DropDown.Select();
                //_DropDown.Capture = true;
                //(_Grid as Control)?.Focus();
                //_Control.Focus();
                //_DropDown.Host.Focus();
                //_DropDown.Focus();
                //_DropDown.Host.Focus();
                //MS_INPUT.SetForegroundWindow(_DropDown.Handle);
                //MS_INPUT.SetForegroundWindow(_DropDown.MS_Grid_Control.Handle);
                //_Grid.Process_Mouse(MS_INPUT.WMessages.WM_LBUTTONDOWN, new Point(386, 372));

            }
            else if (e.KeyCode == Keys.F12)
            {
                int pos = 0;
                foreach (InputLanguage a in InputLanguage.InstalledInputLanguages)
                {
                    if (InputLanguage.CurrentInputLanguage.LayoutName == a.LayoutName)
                    {
                        try
                        {
                            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[pos + 1];
                        }
                        catch
                        {
                            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[0];
                        }

                        break;
                    }
                    pos++;
                }
            }
            else if (e.KeyCode == Keys.Down && MS_Exit_By_Down && !_DropDown.Visible)
            {
                if (MS_Next_Control != null && MS_Next_Control.Enabled && MS_Next_Control.Visible)
                    MS_Next_Control.Focus();
                else
                    SendKeys.Send("{TAB}");
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up && MS_Exit_By_Up && !_DropDown.Visible)
            {
                if (MS_Last_Control != null && MS_Last_Control.Enabled && MS_Last_Control.Visible)
                    MS_Last_Control.Focus();
                else
                    SendKeys.Send("+{TAB}");
                e.Handled = true;
            }
            base.OnKeyUp(e);
        }
        protected override void     OnLeave                             (EventArgs e)
        {
            if (MS_Change_Color_On_Enter && MS_Enter_Color != null)
            {
                this.BackColor = _Back_Color;
            }
            if (MS_Change_Border_Color_On_Enter && MS_Enter_Border_Color != null)
            {
                MS_BorderColor = _old_border_color;
            }

            if (_DropDown != null && _DropDown.Visible && !_Grid.Has_Focus())
            {
                Debug.Print("OnLeave");
                HideMenu();
            }
            base.OnLeave(e);
        }
        protected override void     OnEnter                             (EventArgs e)
        {
            if (MS_Change_Color_On_Enter && MS_Enter_Color != null)
            {
                _Back_Color = this.BackColor;
                this.BackColor = MS_Enter_Color;
            }
            if (MS_Change_Border_Color_On_Enter && MS_Enter_Border_Color != null)
            {
                _old_border_color = MS_BorderColor;
                MS_BorderColor = MS_Enter_Border_Color;
            }
            if (_Grid != null)
                _Grid.Reset_DB_Click();
            if (MS_Auto_Popup)
                ShowMenu();
            base.OnEnter(e);
            if (!String.IsNullOrEmpty(Text))
            {
                SelectAll();
                Refresh();
            }
        }

        protected override void     OnClick                             (EventArgs e)
        {
            base.OnClick(e);
            _Grid?.Reset_DB_Click();
            SelectAll();
        }
        protected override void     WndProc                             (ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT )
            {
                Graphics g = Graphics.FromHwnd(Handle);
                Rectangle bounds = new Rectangle(0, 0, Width, Height);
                ControlPaint.DrawBorder(g, bounds, _borderColor, _borderStyle);
            }
        }
        private void                MS_TextBox_ADC_ThemedAreasChanged   (object sender, EventArgs e)
        {
            switch (VisualStyle)
            {
                case VisualStyle.Default:
                    ms_clear.VisualStyle = Janus.Windows.UI.VisualStyle.Default;
                    break;
                case VisualStyle.Standard:
                    ms_clear.VisualStyle = Janus.Windows.UI.VisualStyle.Standard;
                    break;
                case VisualStyle.Office2003:
                    ms_clear.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
                    break;
                case VisualStyle.VS2005:
                    ms_clear.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005;
                    break;
                case VisualStyle.Office2007:
                    ms_clear.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
                    break;
            }
        }
        private void                ms_clear_Click                      (object sender, EventArgs e)
        {
            _Do_Refresh = false;

            this.Text=String.Empty;
            _Selected_Item = null;
            ms_clear.Hide();
            base.OnTextChanged(e);
            _Do_Refresh = true;
        }
        protected override bool     ProcessCmdKey                       (ref Message msg, Keys keyData)
        {
            if (_DropDown != null && _DropDown.Visible)
            {
                if (keyData == Keys.Down || keyData == Keys.Up || keyData == Keys.PageDown || keyData == Keys.PageUp || keyData == Keys.Enter || keyData == Keys.Escape)
                {
                    if (keyData != Keys.Escape)
                        _Grid.Process_Key(keyData);
                    else
                        HideMenu();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void                MS_TextBox_ADC_ButtonClick          (object sender, EventArgs e)
        {
            ShowMenu();
            if (_DropDown != null && _DropDown.Visible)
            {
                try
                {
                    Debug.Print("SetFocus");
                    _Inside = true;

                    _DropDown.Focus();
                    //var frm = this.FindForm();
                    //if (frm != null && _DropDown.Visible)
                    //    frm.ActiveControl = _DropDown;
                }
                catch (Exception ex)
                {
                    Debug.Print(ex.Message);
                }
            }
        }

        #endregion
    }
}
