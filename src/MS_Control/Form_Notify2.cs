using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control.Properties;

namespace MS_Control
{
    public partial class Form_Notify2 : MS_Mother_Mali
    {
        #region تعریفـات
        public enum FarsiMessageBoxIcon
        {
            تایید,
            ویرایش,
            سوال,
            اخطار,
            حذف,
            چاپ,
            اضافه,
            خطا,
            جستجو,
            تنظیمات,
            چـک_باکس
            
        }
        public enum Direction_Show
        {
            Right_To_Left,
            Down_To_Up
        }
    	#endregion
        #region فیلد
        private Direction_Show _Direction_Show;
        #endregion
        #region متد
        private System.Drawing.Image GetIcon(FarsiMessageBoxIcon ficon)
        {
            switch (ficon)
            {
                case FarsiMessageBoxIcon.اخطار:
                    return Resources.i;

                case FarsiMessageBoxIcon.تنظیمات:
                    return Resources.settings;

                case FarsiMessageBoxIcon.تایید:
                    return Resources.save;

                case FarsiMessageBoxIcon.ویرایش:
                    return Resources.save;

                case FarsiMessageBoxIcon.چاپ:
                    return Resources.Print;

                case FarsiMessageBoxIcon.حذف:
                    return Resources.delete;

                case FarsiMessageBoxIcon.خطا:
                    return Resources.minus;

                case FarsiMessageBoxIcon.جستجو:
                    return Resources.search;

                case FarsiMessageBoxIcon.سوال:
                    return Resources.questionmark;

                case FarsiMessageBoxIcon.اضافه:
                    return Resources.add;
                case FarsiMessageBoxIcon.چـک_باکس:
                    return Resources.checkmark;
            }
            this.StartPosition = FormStartPosition.CenterScreen;
            return Resources.minus;
        }
        private void Init_Form()
        {
            this.Left = Screen.PrimaryScreen.WorkingArea.Width;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height;

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }
        public void Popup(Direction_Show Direction_Show, int Time_To_Live)
        {
            _Direction_Show = Direction_Show;
            timer2.Interval = Time_To_Live;
            if (_Direction_Show == Direction_Show.Right_To_Left)
                this.Top -= Height;
            else
                this.Left -= Width;
            Show();
            timer1.Start();
        }
        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }
        private const int WS_EX_TOPMOST = 0x00000008;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= WS_EX_TOPMOST;
                return createParams;
            }
        }
        #endregion

        #region سازنده
        public Form_Notify2(string Title)
        {
            InitializeComponent();
            Init_Form();
            Text = Title;
            picMessage.Hide();
        }
        public Form_Notify2(string Title, string Message)
        {
            InitializeComponent();
            Init_Form();
            Text = Title;
            picMessage.Hide();
            lblMessage.Text = Message;
        }
        public Form_Notify2(string Title, string Message, FarsiMessageBoxIcon Icon_MSG)
        {
            InitializeComponent();
            Init_Form();
            Text = Title;
            lblMessage.Text = Message;
            picMessage.Image = GetIcon(Icon_MSG);
        }
        public Form_Notify2(string Title, string Message, System.Drawing.Image Icon_MSG)
        {
            InitializeComponent();
            Init_Form();
            Text = Title;
            lblMessage.Text = Message;
            picMessage.Image = Icon_MSG;
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            var increase = 8;
            increase =
                (Screen.PrimaryScreen.WorkingArea.Width - Left) > (3 * Width / 4)
                ? 6
                : increase;
            increase =
                (Screen.PrimaryScreen.WorkingArea.Width - Left) > (4 * Width / 5)
                ? 4
                : increase;
            if (_Direction_Show == Direction_Show.Right_To_Left)
            {

                if (Screen.PrimaryScreen.WorkingArea.Width - Left < Width)
                {
                    Left -= increase;
                    Invalidate();
                }
                else
                {
                    timer1.Stop();
                    timer2.Start();
                }
            }
            else
            {
                if (Screen.PrimaryScreen.WorkingArea.Height - Top < Height)
                {
                    Top -= increase;
                    Invalidate();
                }
                else
                {
                    timer1.Stop();
                    timer2.Start();
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            this.Close();
        }

        private void Form_Notify_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            Hide();
        }
    }
}
