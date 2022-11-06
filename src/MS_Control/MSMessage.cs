using System.Collections.Generic;
using System.ComponentModel;
using MS_Control.Properties;
using System.Windows.Forms;
using System.Net.Mail;
using System.Security;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System;

namespace MS_Control
{
    public partial class MSMessage : MS_Mother
    {
        //MS_Wait _Wait = new MS_Wait();
        //int Model;
        //bool _Detile = false;

        //public MSMessage()
        //{
        //    //InitializeComponent();
        //    //this.Height = 215;
        //}

        //private void DropDownMenu()
        //{
        //    switch (Model)
        //    {
        //        case 1:
        //            {
        //                for (int i = 0; i < 177; i++)
        //                {
        //                    this.Height += 1;
        //                }
        //                Timer_Up_Down.Enabled = false;
        //                this.btn_Detiles.Image = Properties.Resources._Up;
        //                break;
        //            }
        //        case 2:
        //            {
        //                Application.DoEvents();
        //                for (int i = 0; i < 177; i++)
        //                {
        //                    this.Height -= 1;
        //                }
        //                Timer_Up_Down.Enabled = false;
        //                this.btn_Detiles.Image = Properties.Resources._Down;
        //                break;
        //            }
        //        case 3:
        //            {
        //                Application.DoEvents();
        //                for (int i = 0; i < 317; i++)
        //                {
        //                    this.Height -= 1;
        //                }
        //                Timer_Up_Down.Enabled = false;
        //                this.btn_Detiles.Image = Properties.Resources._Down;
        //                break;
        //            }
        //        case 4:
        //            {
        //                Application.DoEvents();
        //                for (int i = 0; i < 140; i++)
        //                {
        //                    this.Height += 1;
        //                }
        //                Timer_Up_Down.Enabled = false;
        //                break;
        //            }
        //        case 5:
        //            {
        //                Application.DoEvents();
        //                for (int i = 0; i < 140; i++)
        //                {
        //                    this.Height -= 1;
        //                }
        //                Timer_Up_Down.Enabled = false;
        //                break;
        //            }
        //    }
        //    lblDetiles.Refresh();
        //    this.Refresh();
        //}

        public enum FarsiDialogResault
        {
            بله, خیر, تایید
        }
        public enum FarsiMessageBoxButton
        {
            بله_خیر, تایید
        }
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
        
        //FarsiDialogResault _FarsiDialogResault;

        //public FarsiDialogResault FarsDialogResault
        //{
        //    get { return _FarsiDialogResault; }
        //    set { _FarsiDialogResault = value; }
        //}
        //private System.Drawing.Image GetIcon(FarsiMessageBoxIcon ficon)
        //{
        //    switch (ficon)
        //    {
        //        case FarsiMessageBoxIcon.اخطار:
        //            return Resources.i;

        //        case FarsiMessageBoxIcon.تنظیمات:
        //            return Resources.settings;

        //        case FarsiMessageBoxIcon.تایید:
        //            return Resources.save;

        //        case FarsiMessageBoxIcon.ویرایش:
        //            return Resources.save;

        //        case FarsiMessageBoxIcon.چاپ:
        //            return Resources.Print;

        //        case FarsiMessageBoxIcon.حذف:
        //            return Resources.delete;

        //        case FarsiMessageBoxIcon.خطا:
        //            return Resources.minus;

        //        case FarsiMessageBoxIcon.جستجو:
        //            return Resources.search;

        //        case FarsiMessageBoxIcon.سوال:
        //            return Resources.questionmark;

        //        case FarsiMessageBoxIcon.اضافه:
        //            return Resources.add;
        //            case FarsiMessageBoxIcon.چـک_باکس:
        //            return Resources.checkmark;
        //    }
        //    this.StartPosition = FormStartPosition.CenterScreen;
        //    return Resources.minus;
        //}
        //private void SetButton(FarsiMessageBoxButton MessageButton)
        //{
        //    switch (MessageButton)
        //    {
        //        case FarsiMessageBoxButton.تایید:
        //            btnKheir.Visible = false;
        //            btnBale.Visible = false;
        //            break;
        //        case FarsiMessageBoxButton.بله_خیر:
        //            btnTaeid.Visible = false;
        //            break;
        //    }
        //    this.StartPosition = FormStartPosition.CenterScreen;
        //}
        
        public static FarsiDialogResault Show(string Message)
        {
            //MSMessage box = new MSMessage();
            //box.Text = "پیغام ...";
            //box.lblMessage.Text = Message;
            //box.lblDetiles.Text = "";
            //box.SetButton(FarsiMessageBoxButton.تایید);
            //box.picMessage.Image = box.GetIcon(FarsiMessageBoxIcon.تایید);

            //box.StartPosition = FormStartPosition.CenterScreen;
            //box.ShowDialog();
            //return box._FarsiDialogResault;

            var result = MS_Message.Show(Message);

            if (result == DialogResult.OK)
                return FarsiDialogResault.تایید;
            else return FarsiDialogResault.خیر;


        }
        public static FarsiDialogResault Show(string Message, string _Detiles, string Title, FarsiMessageBoxButton MessageButton, FarsiMessageBoxIcon MessageIcon)
        {
            MessageBoxButtons Buttons = MessageBoxButtons.OK;
            if (MessageButton == FarsiMessageBoxButton.بله_خیر)
                Buttons = MessageBoxButtons.YesNo;
            else if (MessageButton == FarsiMessageBoxButton.تایید)
                Buttons = MessageBoxButtons.OK;

            DialogResult result = string.IsNullOrWhiteSpace(_Detiles)

                ?   MS_Message.Show(Message,Title,Buttons, MessageIcon)
                :   MS_Message.Show(Message, Title, _Detiles ,Buttons, MessageIcon);

            if (result == DialogResult.OK)
                return FarsiDialogResault.تایید;
            else if (result == DialogResult.Yes)
                return FarsiDialogResault.بله;
            return FarsiDialogResault.خیر;
            //MSMessage box = new MSMessage();
            //box.Text = Title;
            //box.lblDetiles.Text = _Detiles;
            //if (string.IsNullOrWhiteSpace(_Detiles))
            //    box.btn_Detiles.Visible = false;
            //else
            //    box.btn_Detiles.Visible = true;
            //box.lblMessage.Text = Message;
            //box.SetButton(MessageButton);
            //box.picMessage.Image = box.GetIcon(MessageIcon);
            ////==============================================
            //if (MessageIcon == FarsiMessageBoxIcon.اخطار || MessageIcon == FarsiMessageBoxIcon.حذف || MessageIcon == FarsiMessageBoxIcon.خطا)
            //    box.MS_Color = Color.IndianRed;
            //else if (MessageIcon == FarsiMessageBoxIcon.اضافه || MessageIcon == FarsiMessageBoxIcon.تنظیمات)
            //    box.MS_Color = Color.YellowGreen;
            //else if (MessageIcon == FarsiMessageBoxIcon.چاپ || MessageIcon == FarsiMessageBoxIcon.جستجو || MessageIcon == FarsiMessageBoxIcon.ویرایش)
            //    box.MS_Color = Color.SkyBlue;
            //else if (MessageIcon == FarsiMessageBoxIcon.تایید || MessageIcon == FarsiMessageBoxIcon.سوال)
            //    box.MS_Color = Color.DarkKhaki;
            ////==============================================
            //box.StartPosition = FormStartPosition.CenterScreen;
            //box.ShowDialog();
            //return box._FarsiDialogResault;
        }

        //private void btnBale_Click(object sender, EventArgs e)
        //{
        //    FarsDialogResault = FarsiDialogResault.بله;
        //    this.Close();
        //}
        //private void btnKheir_Click(object sender, EventArgs e)
        //{
        //    FarsDialogResault = FarsiDialogResault.خیر;
        //    this.Close();
        //}
        //private void btnTaeid_Click(object sender, EventArgs e)
        //{
        //    FarsDialogResault = FarsiDialogResault.تایید;
        //    this.Close();
        //}
        //private void btn_Detiles_Click(object sender, EventArgs e)
        //{
        //    if (Model == 4)
        //    {
        //        Application.DoEvents();
        //        Timer_Up_Down.Enabled = true;
        //        _Detile = false;
        //        Model = 3;
        //        return;
        //    }
        //    Application.DoEvents();
        //    if (_Detile == false)
        //    {
        //        Application.DoEvents();
        //        Timer_Up_Down.Enabled = true;
        //        Model = 1;
        //        _Detile = true;
        //    }
        //    else
        //    {
        //        Application.DoEvents();
        //        Timer_Up_Down.Enabled = true;
        //        _Detile = false;
        //        Model = 2;
        //    }
        //}
        //private void btn_Email_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
        //        _Wait.Show(this);
        //        Application.DoEvents();
        //        MailMessage mail = new MailMessage();
        //        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
        //        mail.From = new MailAddress("mohsenhormozi91@gmail.com");
        //        mail.To.Add("mohsenhormozi91@yahoo.com");
        //        mail.Subject = "خــطــای نــرم افــزاری در تــاریــخ » " + DateTime.Now + "و ســاعــت » " + p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString("0#") + p.GetDayOfMonth(DateTime.Now).ToString("0#");
        //        mail.Body = lblDetiles.Text;
        //        SmtpServer.Port = 587;
        //        SmtpServer.Credentials = new System.Net.NetworkCredential("mohsenhormozi91@gmail.com", "42095631");
        //        SmtpServer.EnableSsl = true;
        //        SmtpServer.Send(mail);
        //        _Wait.Close();

        //        MSMessage.FarsiDialogResault mSend =
        //          MSMessage.Show("پــیــغــام بــه بــرنــامــه نــویــس ارســال شـــد . . .",
        //          "", "ارســــال پــیــغــام خــطـــا",
        //          MSMessage.FarsiMessageBoxButton.تایید, MSMessage.FarsiMessageBoxIcon.تایید);
        //    }
        //    catch (Exception ex)
        //    {
        //        MSMessage.FarsiDialogResault mErrore =
        //                        MSMessage.Show("بــه دلــیــل خــطـــا در ایـــنــتـــرنـــت !!! \n\nپـــیـــغـــام بــه بــرنــامــه نــویــس ارســـال نـــشـــد . . .",
        //                        ex.Message, "لــغــو ارســــال خــطـــا",
        //                        MSMessage.FarsiMessageBoxButton.تایید, MSMessage.FarsiMessageBoxIcon.خطا);
        //    }

        //    _Wait.Close();
        //    FarsDialogResault = FarsiDialogResault.خیر;
        //}
        //private void Timer_Up_Down_Tick(object sender, EventArgs e)
        //{
        //    DropDownMenu();
        //}

        //private void lbl_Close_Form_Click(object sender, EventArgs e)
        //{
        //    btnKheir_Click(null, null);
        //}

        //private void MSMessage_KeyDown(object sender, KeyEventArgs e)
        //{
          
        //}

        //private void MSMessage_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Escape)
        //    {
        //        e.Handled = true;
        //        btnKheir_Click(null, null);
        //    }
        //    e.Handled = true;
        //}
    }
}
