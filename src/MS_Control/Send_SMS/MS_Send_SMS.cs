using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace MS_Control.Send_SMS
{
    public class MS_Send_SMS
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Matn_Payamak">متن پیام جهت69 ارسال پیامک</param>
        /// <param name="Shomare_Mobiles">شماره موبایل یا موبایل های دریافت کننده پیام، برای ارسال به چند شماره آن ها را با اینتر جدا کنید</param>
        /// <returns></returns>
        public static string Send_SMS(string Matn_Payamak, string Shomare_Mobiles)
        {
            Ping ping = new Ping();
            PingReply pingStatus = ping.Send("google.com");
            if (pingStatus.Status == IPStatus.Success)
            {
                WebService.SmsV1 sms = new WebService.SmsV1();
                Application.DoEvents();
                long[] retval = sms.SendMessage("ashil20", "mohsen1324", Matn_Payamak,
                    Shomare_Mobiles.Split(new char[] { '\n' }), "50002030909090", 1, 5);

                if (retval[0] > 0)
                {
                    return "پــیــغــام بــه بــرنــامــه نــویــس ارســال شـــد . . .";
                }
            }
            else
            {
                return "بــه دلــیــل خــطـــا در ایـــنــتـــرنـــت !!! \n\nپـــیـــغـــام بــه بــرنــامــه نــویــس ارســـال نـــشـــد . . .";
            }
            return "";
        }
    }
}
