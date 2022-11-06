using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.EditControls;

namespace MS_Control.Controls
{
    public class MS_Font_ComboBox: Janus.Windows.EditControls.UIComboBox
    {
        #region فیلد
        Color _Back_Color;
        private Color _borderColor = Color.Silver, _old_border_color;
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        private static int WM_PAINT = 0x000F;
        private bool _clicked = false, _droped = false, _mouse_enter;
        private Dictionary<string, Font> _fontCache;
        private int _itemHeight;
        private int _previewFontSize=10;
        private StringFormat _stringFormat;
        public int PreviewFontSize
        {
            get { return _previewFontSize; }
            set
            {
                _previewFontSize = value;
                Refresh_Font_Preview();
            }
        }
        #endregion
        #region پراپرتی
        public bool MS_Exit_By_Enter { get; set; }
        public bool MS_Exit_By_Down { get; set; }
        public bool MS_Exit_By_Up { get; set; }
        public Control MS_Next_Control { get; set; }
        public Control MS_Last_Control { get; set; }

        public bool MS_Change_Color_On_Enter { set; get; }
        public bool MS_Change_Border_Color_On_Enter { set; get; }
        [DefaultValue(false)]
        public bool MS_Draw_Border { get; set; }
        public Color MS_Enter_Color { get; set; }
        public Color MS_Enter_Border_Color { get; set; }
        public Color MS_BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                if (MS_Draw_Border)
                    Invalidate(); // causes control to be redrawn
            }
        }
        public ButtonBorderStyle MS_BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                if (MS_Draw_Border)
                    Invalidate();
            }
        }
        #endregion
        #region متد
        protected override void WndProc(ref Message m)
        {
            if (_droped && (
                m.Msg == 0x201 || // WM_LBUTTONDOWN
                m.Msg == 0x203)) // WM_LBUTTONDBLCLK
            {
                _clicked = true;
                _droped = true;
                return;
            }

            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                Graphics g = Graphics.FromHwnd(Handle);
                Rectangle bounds = new Rectangle(0, 0, Width, Height);
                ControlPaint.DrawBorder(g, bounds, _borderColor, _borderStyle);
            }
        }
        private void Refresh_Font_Preview() { }
        public void LoadFontFamilies()
        {
            if (this.Items.Count == 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                
                //Items.Clear();

                //Items.AddRange(
                    //FontFamily.Families.Select(x => new UIComboBoxItem()
                    //{
                    //    DataRow = x,
                    //    FormatStyle = {Font =new Font(x,_previewFontSize,GraphicsUnit.Pixel)},
                    //    Text = x.Name,
                    //    Value = x,
                    //}).ToArray());

                this.DataSource = FontFamily.Families;
                //DataMember = "Name";
                //DisplayMember = "Name";
                //foreach (UIComboBoxItem item in Items.OfType<UIComboBoxItem>())
                //{
                //    item.FormatStyle.Font = new Font((item.DataRow as FontFamily).Name, _previewFontSize,
                //        GraphicsUnit.Pixel);
                //}
                Cursor.Current = Cursors.Default;
            }
        }
        
        public Font GetFont()
        {
            if (this.Items.Count == 0)
            {
                LoadFontFamilies();
            }
            //===========================
            if (SelectedIndex < 0)
                return null;
            return  SelectedItem.DataRow as Font;
        }
        public void SetFont(string Name)
        {
            if (this.Items.Count == 0)
            {
                LoadFontFamilies();
            }
            //===========================
            var item=
                Items
                .OfType<UIComboBoxItem>()
                .FirstOrDefault(x => (x.DataRow as FontFamily).Name == Name?.Trim());
            if (item != null)
            {
                var index=
                    Items
                    .OfType<UIComboBoxItem>()
                    .ToList()
                    .IndexOf(item);
                this.SelectedIndex = index;
            }

        }
        public void SetFont(Font FontName)
        {
            SetFont(FontName.Name);
        }
        #endregion
        public MS_Font_ComboBox()
        {
            
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (this.Items.Count == 0)
            {
                LoadFontFamilies();
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            DroppedDown = true;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && MS_Exit_By_Down && !DroppedDown)
            {
                if (MS_Next_Control != null && MS_Next_Control.Enabled && MS_Next_Control.Visible)
                    MS_Next_Control.Focus();
                else
                    SendKeys.Send("{TAB}");
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up && MS_Exit_By_Up && !DroppedDown)
            {
                if (MS_Last_Control != null && MS_Last_Control.Enabled && MS_Last_Control.Visible)
                    MS_Last_Control.Focus();
                else
                    SendKeys.Send("+{TAB}");
                e.Handled = true;
            }

            base.OnKeyUp(e);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && MS_Exit_By_Enter && !DroppedDown)
            {
                e.Handled = true;
                if (MS_Next_Control != null && MS_Next_Control.Enabled && MS_Next_Control.Visible)
                    MS_Next_Control.Focus();
                else
                    SendKeys.Send("{TAB}");
                base.OnKeyPress(e);
            }
        }

        protected override void OnEnter(EventArgs e)
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
            if (!DroppedDown && !_mouse_enter)
            {
                DroppedDown = _droped = true;
            }
            base.OnEnter(e);

            if (this.Items.Count == 0)
            {
                LoadFontFamilies();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MS_Font_ComboBox
            // 
            this.MaxDropDownItems = 12;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void OnLeave(EventArgs e)
        {
            //=====================================
            if (MS_Change_Color_On_Enter && MS_Enter_Color != null)
            {
                this.BackColor = _Back_Color;
            }
            if (MS_Change_Border_Color_On_Enter && MS_Enter_Border_Color != null)
            {
                MS_BorderColor = _old_border_color;
            }
            _clicked = _droped = false;
            base.OnLeave(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _clicked = _droped = _mouse_enter = false;
            base.OnMouseLeave(e);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            _mouse_enter = true;
            base.OnMouseEnter(e);
        }


    }
}
