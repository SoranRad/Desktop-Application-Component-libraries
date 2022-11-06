using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Control
{
    public static class MS_Message
    {
        public static DialogResult Show(string text)
        {

            return new Msg_Box(text).ShowDialog();
        }
        public static DialogResult Show(string text, string caption)
        {
            return new Msg_Box(text, caption).ShowDialog();
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return new Msg_Box(text, caption,buttons).ShowDialog();
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MSMessage.FarsiMessageBoxIcon icon)
        {
            return new Msg_Box(text, caption, buttons,icon).ShowDialog();
        }

        public static DialogResult Show(string text, string caption, string detail,MessageBoxButtons buttons)
        {

            return new Msg_Box(text, caption,detail,buttons).ShowDialog();
        }
        public static DialogResult Show(string text, string caption, string detail, MessageBoxButtons buttons,MSMessage.FarsiMessageBoxIcon icon)
        {

            return new Msg_Box(text, caption, detail, buttons, icon ).ShowDialog();       
        }
        public static DialogResult Show(string text, string caption, string detail, MessageBoxButtons buttons,MSMessage.FarsiMessageBoxIcon icon, MessageBoxDefaultButton default_button)
        {
            return new Msg_Box(text, caption, detail, buttons, icon, default_button).ShowDialog();
        }

        public static DialogResult Show(IWin32Window Owner, string text)
        {

            return new Msg_Box(text).ShowDialog(Owner);
        }
        public static DialogResult Show(IWin32Window Owner, string text, string caption, string detail, MessageBoxButtons buttons)
        {

            return new Msg_Box(text, caption, detail, buttons).ShowDialog(Owner);
        }
        public static DialogResult Show(IWin32Window Owner, string text, string caption, string detail, MessageBoxButtons buttons, MSMessage.FarsiMessageBoxIcon icon)
        {

            return new Msg_Box(text, caption, detail, buttons, icon).ShowDialog(Owner);
        }
        public static DialogResult Show(IWin32Window Owner, string text, string caption, string detail, MessageBoxButtons buttons, MSMessage.FarsiMessageBoxIcon icon, MessageBoxDefaultButton default_button)
        {
            return new Msg_Box(text, caption, detail, buttons, icon, default_button).ShowDialog(Owner);
        }
        public static DialogResult Show(IWin32Window Owner, string text, string caption)
        {
            return new Msg_Box(text, caption).ShowDialog(Owner);
        }
        public static DialogResult Show(IWin32Window Owner, string text, string caption, MessageBoxButtons buttons)
        {
            return new Msg_Box(text, caption, buttons).ShowDialog(Owner);
        }
        public static DialogResult Show(IWin32Window Owner, string text, string caption, MessageBoxButtons buttons, MSMessage.FarsiMessageBoxIcon icon)
        {
            return new Msg_Box(text, caption, buttons, icon).ShowDialog(Owner);
        }
    }
}
