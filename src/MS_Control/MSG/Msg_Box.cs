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
    internal partial class Msg_Box : MS_Mother_Two
    {
        private bool _DropedDown = false;

        private void    Set_Buttons        (MessageBoxButtons buttons)
        {
            ms_ok_cancel.Hide();
            ms_yes_no_cancel.Hide();
            ms_retry_cancel.Hide();
            ms_abort_retry_ignore.Hide();
            
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    ms_ok_cancel.Show();
                    ms_cancel4.Hide();
                    break;
                case MessageBoxButtons.OKCancel:
                    ms_ok_cancel.Show();
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    ms_abort_retry_ignore.Show();
                    break;
                case MessageBoxButtons.YesNoCancel:
                    ms_yes_no_cancel.Show();
                    break;
                case MessageBoxButtons.YesNo:
                    ms_yes_no_cancel.Show();
                    ms_cancel3.Hide();
                    break;
                case MessageBoxButtons.RetryCancel:
                    ms_retry_cancel.Show();
                    break;
            }
        }
        private void    Set_Icon           (MSMessage.FarsiMessageBoxIcon icon)
        {
            switch (icon)
            {
                case MSMessage.FarsiMessageBoxIcon.اخطار:
                    picMessage.Image= Resources.i;
                    break;
                case MSMessage.FarsiMessageBoxIcon.تنظیمات:
                      picMessage.Image= Resources.settings;
                      break;

                case MSMessage.FarsiMessageBoxIcon.تایید:
                      picMessage.Image= Resources.save;
                      break;

                case MSMessage.FarsiMessageBoxIcon.ویرایش:
                      picMessage.Image= Resources.save;
                      break;

                case MSMessage.FarsiMessageBoxIcon.چاپ:
                      picMessage.Image= Resources.Print;
                      break;

                case MSMessage.FarsiMessageBoxIcon.حذف:
                      picMessage.Image= Resources.delete;
                      break;

                case MSMessage.FarsiMessageBoxIcon.خطا:
                      picMessage.Image= Resources.minus;
                      break;

                case MSMessage.FarsiMessageBoxIcon.جستجو:
                      picMessage.Image= Resources.search;
                      break;

                case MSMessage.FarsiMessageBoxIcon.سوال:
                      picMessage.Image= Resources.questionmark;
                      break;

                case MSMessage.FarsiMessageBoxIcon.اضافه:
                      picMessage.Image= Resources.add;
                      break;
                case MSMessage.FarsiMessageBoxIcon.چـک_باکس:
                      picMessage.Image= Resources.checkmark;
                      break;
                default:
                    picMessage.Hide();
                    break;
            }
        }
        private void    Set_Detail         (string detail)
        {
            btn_Detiles.Visible = !string.IsNullOrWhiteSpace(detail);
            ms_detail.Text = detail;
        }
        private void    Set_Buttons        (MessageBoxButtons buttons, MessageBoxDefaultButton def)
        {
            ms_ok_cancel.Hide();
            ms_yes_no_cancel.Hide();
            ms_retry_cancel.Hide();
            ms_abort_retry_ignore.Hide();

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    ms_ok_cancel.Show();
                    ms_cancel4.Hide();
                    ms_ok.Focus();
                    ms_ok.TabIndex = 0;
                    break;
                case MessageBoxButtons.OKCancel:
                    ms_ok_cancel.Show();
                    switch (def)
                    {
                        case MessageBoxDefaultButton.Button1:
                            ms_ok.Focus();
                            ms_ok.TabIndex = 0;
                            break;
                        case MessageBoxDefaultButton.Button2:
                            ms_cancel4.Focus();
                            ms_cancel4.TabIndex = 0;
                            break;
                    }
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    ms_abort_retry_ignore.Show();
                    switch (def)
                    {
                        case MessageBoxDefaultButton.Button1:
                            ms_abort.Focus();
                            ms_abort.TabIndex = 0;
                            break;
                        case MessageBoxDefaultButton.Button2:
                              ms_retry3.Focus();
                              ms_retry3.TabIndex = 0;
                            break;
                        case MessageBoxDefaultButton.Button3:
                              ms_ignore.Focus();
                              ms_ignore.TabIndex = 0;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("def", def, null);
                    }
                    break;
                case MessageBoxButtons.YesNoCancel:
                    ms_yes_no_cancel.Show();
                    switch (def)
                    {
                        case MessageBoxDefaultButton.Button1:
                            ms_yes2.Focus();
                            ms_yes2.TabIndex = 0;
                            break;
                        case MessageBoxDefaultButton.Button2:
                            ms_no2.Focus();
                            ms_no2.TabIndex = 0;
                            break;
                        case MessageBoxDefaultButton.Button3:
                            ms_cancel3.Focus();
                            ms_cancel3.TabIndex = 0;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("def", def, null);
                    }
                    break;
                case MessageBoxButtons.YesNo:
                    ms_yes_no_cancel.Show();
                    ms_cancel3.Hide();
                    switch (def)
                    {
                        case MessageBoxDefaultButton.Button1:
                            ms_yes2.Focus();
                            ms_yes2.TabIndex = 0;
                            break;
                        case MessageBoxDefaultButton.Button2:
                            ms_no2.Focus();
                            ms_no2.TabIndex = 0;
                            break;
                    }
                    break;
                case MessageBoxButtons.RetryCancel:
                    ms_retry_cancel.Show();
                    switch (def)
                    {
                        case MessageBoxDefaultButton.Button1:
                            ms_retry2.Focus();
                            ms_retry2.TabIndex = 0;
                            break;
                        case MessageBoxDefaultButton.Button2:
                            ms_cancel2.Focus();
                            ms_cancel2.TabIndex = 0;
                            break;
                    }
                    break;
            }
        }

        public          Msg_Box             (string text)
        {
            this.Font = new Font("Tahoma", 9.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte) (178)));
            InitializeComponent();
            lblMessage.Text = text;
            Set_Buttons(MessageBoxButtons.OK);
            picMessage.Hide();
            Set_Detail(string.Empty);
        }
        public          Msg_Box             (string text, string caption)
        {
            this.Font = new Font("Tahoma", 9.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte) (178)));
            InitializeComponent();
            lblMessage.Text = text;
            Set_Buttons(MessageBoxButtons.OK);
            picMessage.Hide();
            Set_Detail(string.Empty);
            Text = caption;
        }
        public          Msg_Box             (string text, string caption, MessageBoxButtons buttons)
        {
            this.Font = new Font("Tahoma", 9.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(178)));
            InitializeComponent();
            lblMessage.Text = text;
            Set_Buttons(buttons);
            picMessage.Hide();
            Text = caption;
        }
        public          Msg_Box             (string text, string caption, MessageBoxButtons buttons, MSMessage.FarsiMessageBoxIcon icon)
        {
            this.Font = new Font("Tahoma", 9.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(178)));
            InitializeComponent();
            lblMessage.Text = text;
            Set_Buttons(buttons);
            Set_Icon(icon);
            Text = caption;
        }
        public          Msg_Box             (string text, string caption, string detail, MessageBoxButtons buttons)
        {
            this.Font = new Font("Tahoma", 9.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte) (178)));
            InitializeComponent();
            lblMessage.Text = text;
            Set_Buttons(buttons);
            picMessage.Hide();
            Set_Detail(detail);
            Text = caption;
        }
        public          Msg_Box             (string text, string caption, string detail, MessageBoxButtons buttons, MSMessage.FarsiMessageBoxIcon icon)
        {
            this.Font = new Font("Tahoma", 9.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte) (178)));
            InitializeComponent();
            lblMessage.Text = text;
            Set_Buttons(buttons);
            Set_Icon(icon);
            Set_Detail(detail);
            Text = caption;
        }
        public          Msg_Box             (string text, string caption, string detail, MessageBoxButtons buttons, MSMessage.FarsiMessageBoxIcon icon, MessageBoxDefaultButton default_button)
        {
            Font = new Font("Tahoma", 9.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte) (178)));
            InitializeComponent();
            lblMessage.Text = text;
            Set_Buttons(buttons,default_button);
            Set_Icon(icon);
            Set_Detail(detail);
            Text = caption;
        }

        private void timer1_Tick            (object sender, EventArgs e)
        {
            if (this.Height < 420)
            {
                Height+=5;
                Validate();
            }
            else timer1.Stop();
        }
        private void btn_Detiles_Click      (object sender, EventArgs e)
        {
            if (!_DropedDown)
                timer1.Start();
            else Height = 230;
            _DropedDown = !_DropedDown;

            btn_Detiles.Image = _DropedDown
                ? Resources._Down
                : Resources._Up;
        }

        private void ms_yes2_Click          (object sender, EventArgs e)
        {
            DialogResult=DialogResult.Yes;
        }
        private void ms_no2_Click           (object sender, EventArgs e)
        {
            DialogResult=DialogResult.No;
        }
        private void ms_cancel3_Click       (object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
        private void ms_retry2_Click        (object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;

        }
        private void ms_cancel2_Click       (object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
        private void ms_abort_Click         (object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;

        }
        private void ms_retry3_Click        (object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;

        }
        private void ms_ignore_Click        (object sender, EventArgs e)
        {
            DialogResult = DialogResult.Ignore;

        }
        private void ms_ok_Click            (object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }
        private void ms_cancel4_Click       (object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }



    }
}
