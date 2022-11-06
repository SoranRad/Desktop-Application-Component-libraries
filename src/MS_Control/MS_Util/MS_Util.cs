using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Reflection.Emit;
using System.Reflection;
using System.IO;

namespace MS_Control
{
    public class MS_Util
    {
        #region تاریخ
        private static string[] basex = new string[] { "", "هزار", "میلیون", "میلیارد", "تریلیون" };
        private static string[] dahgan = new string[] { "", "", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود" };
        private static string[] dahyek = new string[] { "ده", "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هفده", "هجده", "نوزده" };
        private static string[] sadgan = new string[] { "", "یکصد", "دویست", "سیصد", "چهارصد", "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد" };
        private static string[] yakan = new string[] { "صفر", "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه" };

        public static string str_cod(int lent, string str, bool inlatin)
        {
            char ch;
            string str2 = "                        ";
            int length = 0;
            int num2 = 0;
            string str3 = str;
            int num3 = lent;
            if (inlatin)
            {
                char ch2;
                if (str3.Length > 0)
                {
                    ch2 = str3[0];
                    str2 = ch2.ToString().ToUpper();
                    if ((((str3[0] < 'A') || (str3[0] > 'Z')) && ((str3[0] < '`') || (str3[0] > 'i'))) &&
                        ((str3[0] < '0') || (str3[0] > '9')))
                    {
                        return "";
                    }
                }
                length = num3 - str3.Trim().Length;
                for (num2 = 1; num2 <= length; num2++)
                {
                    str2 = str2 + "0";
                }
                length = 0;
                for (length = 1; length <= (str3.Length - 1); length++)
                {
                    ch = str3[length];
                    if ((ch >= '0') && (ch <= '9'))
                    {
                        ch2 = str3[length];
                        str2 = str2 + ch2.ToString();
                    }
                    else
                    {
                        length = str3.Length;
                        return "";
                    }
                }
            }
            else
            {
                length = num3 - str3.Trim().Length;
                for (num2 = 1; num2 <= length; num2++)
                {
                    str2 = str2 + "0";
                }
                length = 0;
                for (length = 0; length <= (str3.Length - 1); length++)
                {
                    ch = str3[length];
                    if ((ch >= '0') && (ch <= '9'))
                    {
                        str2 = str2 + str3[length].ToString();
                    }
                    else
                    {
                        length = str3.Length;
                        return "";
                    }
                }
            }
            return str2.Trim();
        }

        public static string num2str(string snum)
        {
            string str = "";
            if (snum == "0")
            {
                return yakan[0];
            }
            snum = snum.PadLeft((((snum.Length - 1) / 3) + 1) * 3, '0');
            int num = (snum.Length / 3) - 1;
            for (int i = 0; i <= num; i++)
            {
                int num3 = int.Parse(snum.Substring(i * 3, 3));
                if (num3 != 0)
                {
                    str = str + getnum3(num3) + " " + basex[num - i] + " و ";
                }
            }
            return str.Substring(0, str.Length - 3);
        }
        public static string getnum3(int num3)
        {
            string str = "";
            int num2 = num3 % 100;
            int index = num3 / 100;
            if (index != 0)
            {
                str = sadgan[index] + " و ";
            }
            if ((num2 >= 10) && (num2 <= 19))
            {
                return (str + dahyek[num2 - 10]);
            }
            int num4 = num2 / 10;
            if (num4 != 0)
            {
                str = str + dahgan[num4] + " و ";
            }
            int num5 = num2 % 10;
            if (num5 != 0)
            {
                str = str + yakan[num5] + " و ";
            }
            return str.Substring(0, str.Length - 3);
        } 
        #endregion
        #region گرافیک و تصویر
        public abstract class RoundedRectangle
        {
            public enum RectangleCorners
            {
                None = 0, TopLeft = 1, TopRight = 2, BottomLeft = 4, BottomRight = 8,
                All = TopLeft | TopRight | BottomLeft | BottomRight
            }
            public static GraphicsPath Create(int x, int y, int width, int height,int radius, RectangleCorners corners)
            {
                int xw = x + width;
                int yh = y + height;
                int xwr = xw - radius;
                int yhr = yh - radius;
                int xr = x + radius;
                int yr = y + radius;
                int r2 = radius * 2;
                int xwr2 = xw - r2;
                int yhr2 = yh - r2;

                GraphicsPath p = new GraphicsPath();
                p.StartFigure();

                //Top Left Corner
                if ((RectangleCorners.TopLeft & corners) == RectangleCorners.TopLeft)
                {
                    p.AddArc(x, y, r2, r2, 180, 90);
                }
                else
                {
                    p.AddLine(x, yr, x, y);
                    p.AddLine(x, y, xr, y);
                }

                //Top Edge
                p.AddLine(xr, y, xwr, y);

                //Top Right Corner
                if ((RectangleCorners.TopRight & corners) == RectangleCorners.TopRight)
                {
                    p.AddArc(xwr2, y, r2, r2, 270, 90);
                }
                else
                {
                    p.AddLine(xwr, y, xw, y);
                    p.AddLine(xw, y, xw, yr);
                }

                //Right Edge
                p.AddLine(xw, yr, xw, yhr);

                //Bottom Right Corner
                if ((RectangleCorners.BottomRight & corners) == RectangleCorners.BottomRight)
                {
                    p.AddArc(xwr2, yhr2, r2, r2, 0, 90);
                }
                else
                {
                    p.AddLine(xw, yhr, xw, yh);
                    p.AddLine(xw, yh, xwr, yh);
                }

                //Bottom Edge
                p.AddLine(xwr, yh, xr, yh);

                //Bottom Left Corner
                if ((RectangleCorners.BottomLeft & corners) == RectangleCorners.BottomLeft)
                {
                    p.AddArc(x, yhr2, r2, r2, 90, 90);
                }
                else
                {
                    p.AddLine(xr, yh, x, yh);
                    p.AddLine(x, yh, x, yhr);
                }

                //Left Edge
                p.AddLine(x, yhr, x, yr);

                p.CloseFigure();
                return p;
            }
            public static GraphicsPath Create(Rectangle rect, int radius, RectangleCorners c)
            { return Create(rect.X, rect.Y, rect.Width, rect.Height, radius, c); }
            public static GraphicsPath Create(int x, int y, int width, int height, int radius)
            { return Create(x, y, width, height, radius, RectangleCorners.All); }
            public static GraphicsPath Create(Rectangle rect, int radius)
            { return Create(rect.X, rect.Y, rect.Width, rect.Height, radius); }
            public static GraphicsPath Create(int x, int y, int width, int height)
            { return Create(x, y, width, height, 5); }
            public static GraphicsPath Create(Rectangle rect)
            { return Create(rect.X, rect.Y, rect.Width, rect.Height); }

        }

        #endregion

        public static string MS_Str_To_Hash(string Str, string Key)
        {
            byte[] buffer = new byte[] { 240, 0x20, 0x2d, 0x1d, 0, 0x4c, 0xad, 0x3b };
            string s = Key;
            string str2 = Str;
            byte[] bytes = Encoding.UTF8.GetBytes(str2);
            TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
            provider.Key = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(s));
            provider.IV = buffer;
            byte[] inArray = provider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
            return Convert.ToBase64String(inArray, 0, inArray.Length);
        }
        public static string MS_Hash_To_Str(string Hash, string Key)
        {
            byte[] buffer = new byte[] { 240, 0x20, 0x2d, 0x1d, 0, 0x4c, 0xad, 0x3b };
            string s = Key;
            string str2 = Hash;
            byte[] inputBuffer = Convert.FromBase64String(str2);
            TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
            provider.Key = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(s));
            provider.IV = buffer;
            byte[] bytes = provider.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
            return Encoding.UTF8.GetString(bytes);
        }
        public static string MS_Get_Shahr_Ostan_Code_Meli(string codeMeli)
        {
            if (codeMeli.Length < 10)
                return "کد ملی باید 10 رقمی باشد";
            string startCodeMeli = codeMeli.Substring(0, 3);
            switch (startCodeMeli)
            {
                //*****************شرقی
                case "169":
                    return "آذربایجان شرقی " + "آذر شهر" ;
                case "170":
                    return "آذربایجان شرقی " + "اسکو";
                case "149":
                case "150":
                    return "آذربایجان شرقی " + "اهر";
                case "171":
                    return "آذربایجان شرقی " + "بستان آباد";
                case "168":
                    return "آذربایجان شرقی " + "بناب";
                case "136":
                case "137":
                case "138":
                    return "آذربایجان شرقی " + "تبریز";
                case "545":
                    return "آذربایجان شرقی " + "ترکمان چای";
                case "505":
                    return "آذربایجان شرقی " + "جلفا";
                case "636":
                    return "آذربایجان شرقی " + "چاروایماق";
                case "164":
                case "165":
                    return "آذربایجان شرقی " + "سراب";
                case "172":
                    return "آذربایجان شرقی " + "شبستر";
                case "623":
                    return "آذربایجان شرقی " + "صوفیان";
                case "506":
                    return "آذربایجان شرقی " + "عجب شیر";
                case "519":
                    return "آذربایجان شرقی " + "کلیبر";
                case "154":
                case "155":
                    return "آذربایجان شرقی " + "مراغه";
                case "567":
                    return "آذربایجان شرقی " + "ورزقان";
                case "173":
                    return "آذربایجان شرقی " + "هریس";
                case "159":
                case "160":
                    return "آذربایجان شرقی " + "هشترود";
                case "604":
                    return "آذربایجان شرقی " + "هوراند";
                //*****************غربی
                case "274":
                case "275":
                    return "آذربایجان غربی " + "ارومیه";
                case "295":
                    return "آذربایجان غربی " + "اشنویه";
                case "637":
                    return "آذربایجان غربی " + "انزل";
                case "292":
                    return "آذربایجان غربی " + "بوکان";
                case "492":
                    return "آذربایجان غربی " + "پلدشت";
                case "289":
                    return "آذربایجان غربی " + "پیرانشهر";
                case "677":
                    return "آذربایجان غربی " + "تخت سلیمان";
                case "294":
                    return "آذربایجان غربی " + "تکاب";
                case "493":
                    return "آذربایجان غربی " + "چایپاره";
                case "279":
                case "280":
                    return "آذربایجان غربی " + "خوی";
                case "288":
                    return "آذربایجان غربی " + "سردشت";
                case "284":
                case "285":
                    return "آذربایجان غربی " + "سلماس";
                case "638":
                    return "آذربایجان غربی " + "سیلوانه";
                case "291":
                    return "آذربایجان غربی " + "چالدران";
                case "640":
                    return "آذربایجان غربی " + "شوط";
                case "293":
                    return "آذربایجان غربی " + "شاهین دژ";
                case "675":
                    return "آذربایجان غربی " + "کشاورز";
                case "282":
                case "283":
                    return "آذربایجان غربی " + "ماکو";
                case "286":
                case "287":
                    return "آذربایجان غربی " + "مهاباد";
                case "296":
                case "297":
                    return "آذربایجان غربی " + "میاندوآب";
                case "290":
                    return "آذربایجان غربی " + "نقده";
                    //************همدان
                case "400":
                case "401":
                    return "همدان " + "اسد آباد";
                case "404":
                case "405":
                    return "همدان " + "بهار";
                case "397":
                    return "همدان " + "تویسرکان";
                case "398":
                case "399":
                    return "همدان " + "رزن";
                case "647":
                    return "همدان " + "شراء و پیشخوار";
                case "502":
                    return "همدان " + "فامنین";
                case "584":
                    return "همدان " + "قلقل رود";
                case "402":
                case "403":
                    return "همدان " + "کبودرآهنگ";
                case "392":
                case "393":
                    return "همدان " + "ملایر";
                case "395":
                case "396":
                    return "همدان " + "نهاوند و جوانرود";
                case "386":
                case "387":
                    return "همدان " + "همدان";
                    //**************یزد
                case "503":
                    return "یزد " + "ابرکوه";
                case "444":
                    return "یزد " + "اردکان";
                case "551":
                    return "یزد " + "اشکذر";
                case "447":
                    return "یزد " + "بافق";
                case "561":
                    return "یزد " + "بهاباد";
                case "445":
                    return "یزد " + "تفت";
                case "718":
                    return "یزد " + "دستگردان";
                case "083":
                    return "یزد " + "طبس";
                case "446":
                    return "یزد " + "مهریز";
                case "448":
                    return "یزد " + "میبد";
                case "552":
                    return "یزد " + "نیر";
                case "543":
                    return "یزد " + "هرات و مروست";
                case "442":
                case "443":
                    return "یزد";
                    //********مرکزی
                case "051":
                    return "مرکزی " + "آشتیان";
                case "052":
                case "053":
                    return "مرکزی " + "اراک";
                case "058":
                    return "مرکزی " + "تفرش";
                case "055":
                    return "مرکزی " + "خمین";
                case "617":
                    return "مرکزی " + "خنداب";
                case "057":
                    return "مرکزی " + "دلیجان";
                case "618":
                    return "مرکزی " + "زرند مرکزی";
                case "059":
                case "060":
                    return "مرکزی " + "ساوه";
                case "061":
                case "062":
                    return "مرکزی " + "سربند";
                case "544":
                    return "مرکزی " + "فراهان";
                case "056":
                    return "مرکزی " + "محلات";
                case "571":
                    return "مرکزی " + "وفس";
                case "593":
                    return "مرکزی " + "هندودر";
                    //***هرمزیگان
                case "667":
                    return "هرمزگان " + "ابوموسی";
                case "348":
                    return "هرمزگان " + "بستک";
                case "586":
                    return "هرمزگان " + "بشاگرد";
                case "338":
                case "339":
                    return "هرمزگان " + "بندرعباس";
                case "343":
                case "344":
                    return "هرمزگان " + "بندرلنگه";
                case "346":
                    return "هرمزگان " + "جاسک";
                case "337":
                    return "هرمزگان " + "حاجی آباد و قصر شیرین";
                case "554":
                    return "هرمزگان " + "خمیر";
                case "469":
                    return "هرمزگان " + "رودان";
                case "537":
                    return "هرمزگان " + "فین";
                case "345":
                    return "هرمزگان " + "قشم";
                case "470":
                    return "هرمزگان " + "گاوبندی";
                case "341":
                case "342":
                    return "هرمزگان " + "میناب";
                    //********لرستان
                case "483":
                case "484":
                    return "لرستان " + "ازنا و چالوس";
                case "557":
                    return "لرستان " + "اشترینان";
                case "418":
                    return "لرستان " + "الشتر";
                case "416":
                case "417":
                    return "لرستان " + "الیگودرز";
                case "412":
                case "413":
                    return "لرستان " + "بروجرد";
                case "592":
                    return "لرستان " + "پاپی";
                case "612":
                    return "لرستان " + "چغلوندی";
                case "613":
                    return "لرستان " + "چگنی";
                case "406":
                case "407":
                    return "لرستان " + "خرم آباد";
                case "421":
                    return "لرستان " + "دورود";
                case "598":
                    return "لرستان " + "رومشکان";
                case "419":
                    return "لرستان " + "کوهدشت";
                case "385":
                    return "لرستان " + "ملاوی»پلدختر";
                case "420":
                    return "لرستان " + "نورآباد»دلفان";
                case "528":
                    return "لرستان " + "ویسیان";
                    //*******مازندران
                case "213":
                case "214":
                    return "مازندزان " + "آمل";
                case "205":
                case "206":
                case "498":
                    return "مازندزان " + "بابل";
                case "568":
                    return "مازندزان " + "بندپی";
                case "711":
                    return "مازندزان " + "بندپی شرقی";
                case "217":
                case "218":
                    return "مازندزان " + "بهشهر";
                case "221":
                    return "مازندزان " + "تنکابن";
                case "582":
                    return "مازندزان " + "جویبار";
                //case "483":
                //    return "چالوس";
                case "625":
                    return "مازندزان " + "چمستان";
                case "576":
                    return "مازندزان " + "چهاردانگه";
                case "578":
                    return "مازندزان " + "دودانگه";
                case "227":
                    return "مازندزان " + "رامسر";
                case "208":
                case "209":
                    return "مازندزان " + "ساری";
                case "225":
                    return "مازندزان " + "سوادکوه";
                case "577":
                    return "مازندزان " + "شیرگاه";
                case "712":
                    return "مازندزان " + "عباس آباد";
                case "215":
                case "216":
                    return "مازندزان " + "قائم شهر";
                case "626":
                    return "مازندزان " + "کجور";
                case "627":
                    return "مازندزان " + "کلاردشت";
                case "579":
                    return "مازندزان " + "گلوگاه";
                case "913":
                    return "مازندزان " + "میاندورود";
                case "499":
                    return "مازندزان " + "نکاء";
                case "222":
                    return "مازندزان " + "نور";
                case "219":
                case "220":
                    return "مازندزان " + "نوشهر";
                case "500":
                case "501":
                    return "مازندزان " + "هراز و محمودآباد";
                    //*****گلستان
                //case "623":
                //    return "آزاد شهر";
                case "497":
                    return "گلستان " + "آق قلا";
                case "223":
                    return "گلستان " + "بندرترکمن";
                case "689":
                    return "گلستان " + "بندرگز";
                case "487":
                    return "گلستان " + "رامیان";
                case "226":
                    return "گلستان " + "علی آباد کتول";
                case "224":
                    return "گلستان " + "کرد کوی";
                //case "386":
                //    return "کلاله";
                case "211":
                case "212":
                    return "گلستان " + "گرگان";
                case "628":
                    return "گلستان " + "گمیشان";
                case "202":
                case "203":
                    return "گلستان " + "گنبدکاووس";
                case "531":
                    return "گلستان " + "مراوه تپه";
                case "488":
                    return "گلستان " + "مینودشت";
                    //*********گیلان
                case "261":
                    return "گیلان " + "آستارا";
                case "273":
                    return "گیلان " + "آستانه";
                case "630":
                    return "گیلان " + "املش";
                case "264":
                    return "گیلان " + "بندرانزلی";
                case "518":
                    return "گیلان " + "خمام";
                case "631":
                    return "گیلان " + "رحیم آباد";
                case "258":
                case "259":
                    return "گیلان " + "رشت";
                case "570":
                    return "گیلان " + "رضوان شهر";
                case "265":
                    return "گیلان " + "رودبار";
                case "268":
                case "269":
                    return "گیلان " + "رودسر";
                case "653":
                    return "گیلان " + "سنگر";
                case "517":
                    return "گیلان " + "سیاهکل";
                case "569":
                    return "گیلان " + "شفت";
                case "267":
                    return "گیلان " + "صومعه سرا";
                case "262":
                case "263":
                    return "گیلان " + "طالش";
                //case "593":
                //    return "عمارلو";
                case "266":
                    return "گیلان " + "فومن";
                case "693":
                    return "گیلان " + "کوچصفهان";
                case "271":
                case "272":
                    return "گیلان " + "لاهیجان";
                case "694":
                    return "گیلان " + "لشت نشاء";
                case "270":
                    return "گیلان " + "لنگرود";
                case "516":
                    return "گیلان " + "ماسال و شاندرمن";
                //*********کرمانشاه
                case "333":
                case "334":
                    return "کرمانشاه " + "اسلام آباد";
                case "691":
                    return "کرمانشاه " + "باینگان";
                case "323":
                case "322":
                    return "کرمانشاه " + "پاوه";
                case "595":
                    return "کرمانشاه " + "ثلاث باباجانی";
                //case "395":
                //    return "جوانرود";
                case "641":
                    return "کرمانشاه " + "حمیل";
                case "596":
                    return "کرمانشاه " + "روانسر";
                case "336":
                    return "کرمانشاه " + "سزپل زهاب";
                case "335":
                    return "کرمانشاه " + "سنقر";
                case "496":
                    return "کرمانشاه " + "صحنه";
                //case "337":
                //    return "قصر شیرین";
                case "324":
                case "325":
                    return "کرمانشاه " + "کرمانشاه";
                case "394":
                    return "کرمانشاه " + "کرند";
                case "330":
                    return "کرمانشاه " + "کنگاور";
                case "332":
                    return "کرمانشاه " + "گیلانغرب";
                case "331":
                    return "کرمانشاه " + "هرسین";
                //**************کخکیلویه و بویراحمد
                case "687":
                    return "کهکیلویه و بویراحمد " + "باشت";
                case "422":
                case "423":
                    return "کهکیلویه و بویراحمد " + "بویراحمو»یاسوج";
                case "599":
                    return "کهکیلویه و بویراحمد " + "بهمنی";
                case "600":
                    return "کهکیلویه و بویراحمد " + "چاروسا";
                case "688":
                    return "کهکیلویه و بویراحمد " + "دروهان";
                case "424":
                case "425":
                    return "کهکیلویه و بویراحمد " + "کهکیلویه»دهدشت";
                case "426":
                    return "کهکیلویه و بویراحمد " + "گچساران»دوگنبدان";
                case "550":
                    return "کهکیلویه و بویراحمد " + "لنده";
                case "697":
                    return "کهکیلویه و بویراحمد " + "مارگون";
                    //****کردستان
                case "384":
                    return "کردستان " + "بانه";
                case "377":
                case "378":
                    return "کردستان " + "بیجار";
                case "558":
                    return "کردستان " + "دهگلان";
                //case "385":
                //    return "دیواندره";
                case "646":
                    return "کردستان " + "سروآباد";
                case "375":
                case "376":
                    return "کردستان " + "سقز";
                case "372":
                case "373":
                    return "کردستان " + "سنندج";
                case "379":
                case "380":
                    return "کردستان " + "قروه";
                case "383":
                    return "کردستان " + "کامیاران";
                case "674":
                    return "کردستان " + "کرانی";
                case "381":
                case "382":
                    return "کردستان " + "مریوان";
                case "676":
                    return "کردستان " + "نمشیر";                
                    //**************کرمان
                case "722":
                    return "کرمان " + "ارزونیه";
                case "542":
                    return "کرمان " + "انار";
                case "312":
                case "313":
                    return "کرمان " + "بافت";
                case "317":
                    return "کرمان " + "بردسیر";
                case "310":
                case "311":
                    return "کرمان " + "بم";
                case "302":
                case "303":
                    return "کرمان " + "جیرفت";
                case "583":
                    return "کرمان " + "رابر";
                case "321":
                    return "کرمان " + "راور";
                //case "382":
                //    return "راین";
                case "304":
                case "305":
                    return "کرمان " + "رفسنجان";
                case "536":
                    return "کرمان " + "رودبارکهنوج";
                case "605":
                    return "کرمان " + "ریگان";
                case "308":
                case "309":
                    return "کرمان " + "زرند";
                case "306":
                case "307":
                    return "کرمان " + "سیرجان";
                case "319":
                    return "کرمان " + "شهداد";
                //case "313":
                case "314":
                    return "کرمان " + "شهر بابک";
                case "606":
                    return "کرمان " + "عنبرآباد";
                case "320":
                    return "کرمان " + "فهرج";
                case "698":
                    return "کرمان " + "قلعه گنج";
                case "298":
                case "299":
                    return "کرمان " + "کرمان";
                case "535":
                    return "کرمان " + "کوهبنان";
                case "315":
                case "316":
                    return "کرمان " + "کهنوج";
                case "318":
                    return "کرمان " + "گلباف";
                case "607":
                    return "کرمان " + "ماهان";
                case "608":
                    return "کرمان " + "منوجان";
                    //*******قزوین
                case "508":
                    return "قزوین " + "آبیک";
                case "538":
                    return "قزوین " + "آوج";
                case "728":
                    return "قزوین " + "البرز";
                case "509":
                    return "قزوین " + "بوئین زهرا";
                case "438":
                case "439":
                    return "قزوین " + "تاکستان";
                case "580":
                    return "قزوین " + "رودبارالموت";
                case "590":
                    return "قزوین " + "رودبارشهرستان";
                case "559":
                    return "قزوین " + "ضیاءآباد";
                case "588":
                    return "قزوین " + "طارم سفلی";
                case "431":
                case "432":
                    return "قزوین " + "قزوین";
                    //*********قم
                case "037":
                case "038":
                    return "قم " + "قم";
                case "702":
                    return "قم " + "کهک";
                    //*******فارس
                case "240":
                case "241":
                    return "فارس " + "آباده";
                case "670":
                    return "فارس " + "آباده طشک";
                case "648":
                    return "فارس " + "ارسنجان";
                case "252":
                    return "فارس " + "استهبان";
                case "678":
                    return "فارس " + "اشکنان";
                case "253":
                    return "فارس " + "اقلید و سپیدان";
                case "649":
                    return "فارس " + "اوز";
                case "513":
                    return "فارس " + "بوانات";
                case "546":
                    return "فارس " + "بیضا";
                case "671":
                    return "فارس " + "جویم";
                case "246":
                case "247":
                    return "فارس " + "جهرم";
                case "654":
                    return "فارس " + "حاجی آباد»زرین دشت";
                case "548":
                    return "فارس " + "خرامه";
                case "547":
                    return "فارس " + "خشت و کمارج";
                case "655":
                    return "فارس " + "خفر";
                case "248":
                case "249":
                    return "فارس " + "داراب";
                case "514":
                    return "فارس " + "سروستان";
                case "665":
                    return "فارس " + "سعادت آباد";
                case "673":
                    return "فارس " + "شیبکوه";
                case "228":
                case "229":
                case "230":
                    return "فارس " + "شیراز";
                case "679":
                    return "فارس " + "فراشبند";
                case "256":
                case "257":
                    return "فارس " + "فسا";
                case "244":
                case "245":
                    return "فارس " + "فیروزآباد";
                case "681":
                    return "فارس " + "قنقری»خرم بید";
                case "723":
                    return "فارس " + "قیروکارزین";
                case "236":
                case "237":
                    return "فارس " + "کازرون";
                case "683":
                    return "فارس " + "کوار";
                case "656":
                    return "فارس " + "کراش";
                case "250":
                case "251":
                    return "فارس " + "لارستان";
                case "515":
                    return "فارس " + "لامرود";
                case "243":
                case "242":
                    return "فارس " + "مرودشت";
                case "238":
                case "239":
                    return "فارس " + "ممسنی";
                case "657":
                    return "فارس " + "مهر";
                case "255":
                    return "فارس " + "نی ریز";
                    //****************سمنان
                case "684":
                    return "سمنان " + "ایوانکی";
                case "700":
                    return "سمنان " + "بسطام";
                case "642":
                    return "سمنان " + "بیارجمند";
                case "457":
                    return "سمنان " + "دامغان";
                case "456":
                    return "سمنان " + "سمنان";
                case "458":
                case "459":
                    return "سمنان " + "شاهرود";
                case "460":
                    return "سمنان " + "گرمسار";
                case "530":
                    return "سمنان " + "مهدیشهر";
                case "520":
                    return "سمنان " + "میامی";
                    //***********سیستان و بلوچستان
                case "358":
                case "359":
                    return "سیستان و بلوچستان " + "ایرانشهر";
                case "682":
                    return "سیستان و بلوچستان " + "بزمان";
                case "703":
                    return "سیستان و بلوچستان " + "بمپور";
                case "364":
                case "365":
                    return "سیستان و بلوچستان " + "چابهر";
                case "371":
                    return "سیستان و بلوچستان " + "خاش";
                case "701":
                    return "سیستان و بلوچستان " + "دشتیاری";
                case "720":
                    return "سیستان و بلوچستان " + "راسک";
                case "366":
                case "367":
                    return "سیستان و بلوچستان " + "زابل";
                case "704":
                    return "سیستان و بلوچستان " + "زابلی";
                case "361":
                case "362":
                    return "سیستان و بلوچستان " + "زاهدان";
                case "369":
                case "370":
                    return "سیستان و بلوچستان " + "سراوان";
                case "635":
                    return "سیستان و بلوچستان " + "سرباز و فاروج";
                case "668":
                    return "سیستان و بلوچستان " + "سیب و سوران";
                case "533":
                    return "سیستان و بلوچستان " + "شهرکی و ناروئی»زهک";
                case "705":
                    return "سیستان و بلوچستان " + "شیب آب";
                case "699":
                    return "سیستان و بلوچستان " + "فنوج";
                case "669":
                    return "سیستان و بلوچستان " + "قصرقند";
                case "725":
                    return "سیستان و بلوچستان " + "کنارک";
                case "597":
                    return "سیستان و بلوچستان " + "لاشار»اسپکه";
                case "611":
                    return "سیستان و بلوچستان " + "میرجاوه";
                case "525":
                    return "سیستان و بلوچستان " + "نیک شهر";
                    //******خوزستان
                case "181":
                    return "خوزستان " + "آبادان";
                case "527":
                    return "خوزستان " + "آغاجاری";
                case "585":
                    return "خوزستان " + "اروندکنار";
                case "685":
                    return "خوزستان " + "امیدیه";
                case "663":
                    return "خوزستان " + "اندیکا";
                case "192":
                case "193":
                    return "خوزستان " + "اندیمشک";
                case "174":
                case "175":
                    return "خوزستان " + "اهواز";
                case "183":
                case "184":
                    return "خوزستان " + "ایذه";
                case "481":
                    return "خوزستان " + "باغ ملک";
                case "706":
                    return "خوزستان " + "بندرامام خمینی";
                case "194":
                case "195":
                    return "خوزستان " + "بندرماهشهر";
                case "185":
                case "186":
                    return "خوزستان " + "بهبهان";
                case "182":
                    return "خوزستان " + "خرمشهر";
                case "199":
                case "200":
                    return "خوزستان " + "دزفول";
                case "198":
                    return "خوزستان " + "دشت آزادگان";
                case "662":
                    return "خوزستان " + "رامشیر";
                case "190":
                case "191":
                    return "خوزستان " + "رهمهرمز";
                case "692":
                    return "خوزستان " + "سردشت";
                case "189":
                    return "خوزستان " + "شادگان";
                case "707":
                    return "خوزستان " + "شاوور";
                case "526":
                    return "خوزستان " + "شوش";
                case "187":
                case "188":
                    return "خوزستان " + "شوشتر";
                case "729":
                    return "خوزستان " + "گتوند";
                case "730":
                    return "خوزستان " + "لالی";
                case "196":
                case "197":
                    return "خوزستان " + "مسجدسلیمان";
                case "661":
                    return "خوزستان " + "هندیجان";
                case "680":
                    return "خوزستان " + "هویزه";
                    //*******خراسان رضوی
                case "643":
                    return "خراسان رضوی " + "احمدآباد";
                case "562":
                    return "خراسان رضوی " + "بجستان";
                case "572":
                    return "خراسان رضوی " + "بردسکن";
                case "074":
                    return "خراسان رضوی " + "تایباد";
                case "644":
                    return "خراسان رضوی " + "تخت جلگه";
                case "072":
                case "073":
                    return "خراسان رضوی " + "تربت جام";
                case "069":
                case "070":
                    return "خراسان رضوی " + "تربت حیدریه";
                case "521":
                    return "خراسان رضوی " + "جغتای";
                case "573":
                    return "خراسان رضوی " + "جوین";
                case "522":
                    return "خراسان رضوی " + "چناران";
                case "724":
                    return "خراسان رضوی " + "خلیل آباد";
                case "076":
                    return "خراسان رضوی " + "خواف";
                case "077":
                    return "خراسان رضوی " + "درگز";
                case "650":
                    return "خراسان رضوی " + "رشتخوار";
                case "574":
                    return "خراسان رضوی " + "زبرخان";
                case "078":
                case "079":
                    return "خراسان رضوی " + "سبزوار";
                case "081":
                    return "خراسان رضوی " + "سرخس";
                case "084":
                    return "خراسان رضوی " + "فریمان";
                case "651":
                    return "خراسان رضوی " + "فیض آباد";
                case "086":
                case "087":
                    return "خراسان رضوی " + "قوچان";
                case "089":
                case "090":
                    return "خراسان رضوی " + "کاشمر";
                case "553":
                    return "خراسان رضوی " + "کلات";
                case "091":
                    return "خراسان رضوی " + "گناباد";
                case "092":
                case "093":
                case "094":
                    return "خراسان رضوی " + "مشهد";
                case "097":
                    return "خراسان رضوی " + "مشهد منطقه 2";
                case "098":
                    return "خراسان رضوی " + "مشهد منطقه 3";
                case "096":
                    return "خراسان رضوی " + "مشهد منطقه 1";
                case "105":
                case "106":
                    return "خراسان رضوی " + "نیشابور";
                    //*******خراسان شمالی
                case "063":
                    return "خراسان شمالی " + "اسفراین";
                case "067":
                case "068":
                    return "خراسان شمالی " + "بجنورد";
                case "075":
                    return "خراسان شمالی " + "جاجرم";
                case "591":
                    return "خراسان شمالی " + "رازوجرکلان";
                case "082":
                    return "خراسان شمالی " + "شیروان";
                //case "635":
                //    return "فاروج";
                case "524":
                    return "خراسان شمالی " + "مانه و سملقان";
                    //********چهارمحال بختیاری
                case "468":
                    return "چهارمحال بختیاری " + "اردل";
                case "465":
                    return "چهارمحال بختیاری " + "برجن";
                case "461":
                case "462":
                    return "چهارمحال بختیاری " + "شهرکرد";
                case "467":
                    return "چهارمحال بختیاری " + "فارس";
                case "632":
                    return "چهارمحال بختیاری " + "فلارد";
                case "555":
                    return "چهارمحال بختیاری " + "کوهرنگ";
                case "633":
                    return "چهارمحال بختیاری " + "کیار";
                case "629":
                    return "چهارمحال بختیاری " + "گندمان";
                case "466":
                    return "چهارمحال بختیاری " + "ارددگان";
                case "696":
                    return "چهارمحال بختیاری " + "میانکوه";
                    //*******************خراسان جنوبی
                case "721":
                    return "خراسان جنوبی " + "بشرویه";
                case "064":
                case "065":
                    return "خراسان جنوبی " + "بیرجند";
                case "523":
                    return "خراسان جنوبی " + "درمیان";
                case "652":
                    return "خراسان جنوبی " + "زیرکوه";
                case "719":
                    return "خراسان جنوبی " + "سرایان";
                case "716":
                    return "خراسان جنوبی " + "سربیشه";
                case "085":
                    return "خراسان جنوبی " + "فردوس";
                case "088":
                    return "خراسان جنوبی " + "قائنات";
                case "563":
                    return "خراسان جنوبی " + "نهبندان";
                    //*********بوشهر
                case "529":
                    return "بوشهر " + "بندردیلم";
                case "353":
                    return "بوشهر " + "بندرگناوه";
                case "349":
                case "350":
                    return "بوشهر " + "بوشهر";
                case "355":
                    return "بوشهر " + "تنگستان";
                case "609":
                    return "بوشهر " + "جم";
                case "351":
                case "352":
                    return "بوشهر " + "دشتستان";
                case "354":
                    return "بوشهر " + "دشتی";
                case "732":
                    return "بوشهر " + "دلوار";
                case "357":
                    return "بوشهر " + "دیر";
                case "532":
                    return "بوشهر " + "سعدآباد";
                case "610":
                    return "بوشهر " + "شبانکاره";
                case "356":
                    return "بوشهر " + "کنگاه";
                    //*********تهران
                case "556":
                    return "تهران " + "اسلامشهر";
                case "658":
                    return "تهران " + "پاکدشت";
                case "001":
                case "002":
                case "003":
                case "004":
                case "005":
                case "006":
                case "007":
                case "008":
                    return "تهران " + "تهران مرکزی";
                case "011":
                    return "تهران " + "تهران جنوب";
                case "020":
                    return "تهران " + "تهران شرق";
                case "025":
                    return "تهران " + "تهران شمال";
                case "015":
                    return "تهران " + "تهران غرب";
                case "043":
                    return "تهران " + "دماوند";
                case "666":
                    return "تهران " + "رباط کریم";
                case "489":
                    return "تهران " + "ساوجبلاغ";
                case "044":
                case "045":
                    return "تهران " + "شمیران";
                case "048":
                case "049":
                    return "تهران " + "شهرری";
                case "490":
                case "491":
                    return "تهران " + "شهریار";
                case "695":
                    return "تهران " + "طالقان";
                case "659":
                    return "تهران " + "فیروزکوه";
                case "031":
                case "032":
                    return "تهران " + "کرج";
                case "664":
                    return "تهران " + "کهریزک";
                case "717":
                    return "تهران " + "نظرآباد";
                case "041":
                case "042":
                    return "تهران " + "ورامین";
                    //**********کشورهای خارجه
                case "471":
                case "472":
                    return "کشورهای خارجه " + "امورخارجه";
                    //********ایلام
                case "454":
                    return "ایلام " + "آبدانان";
                case "581":
                    return "ایلام " + "ارکوازی»ملکشاهی";
                case "449":
                case "450":
                    return "ایلام " + "ایلام";
                case "616":
                    return "ایلام " + "ایوان";
                case "534":
                    return "ایلام " + "بدره";
                case "455":
                    return "ایلام " + "دره شهر";
                case "451":
                    return "ایلام " + "دهلران";
                case "726":
                    return "ایلام " + "زرین آباد";
                case "634":
                    return "ایلام " + "شیروان لومار";
                case "453":
                    return "ایلام " + "شیروان و چرداول";
                case "727":
                    return "ایلام " + "موسیان";
                case "452":
                    return "ایلام " + "مهران";
                    //***************اردبیل
                case "145":
                case "146":
                    return "اردبیل " + "اردبیل";
                case "731":
                    return "اردبیل " + "ارشق";
                case "690":
                    return "اردبیل " + "انگوت";
                case "601":
                    return "اردبیل " + "بیله سوار";
                case "504":
                    return "اردبیل " + "پارس آباد";
                case "163":
                    return "اردبیل " + "خلخال";
                case "714":
                    return "اردبیل " + "خورش رستم";
                case "715":
                    return "اردبیل " + "سرعین";
                case "566":
                    return "اردبیل " + "سنجبد»کوثر";
                case "166":
                case "167":
                    return "اردبیل " + "مشکین شهر";
                case "161":
                case "162":
                    return "اردبیل " + "مغان";
                case "686":
                    return "اردبیل " + "نمین";
                case "603":
                    return "اردبیل " + "نیر";
                //******اصفهان
                case "619":
                    return "اصفهان " + "آران و بیدگل";
                case "118":
                    return "اصفهان " + "اردستان";
                case "127":
                case "128":
                case "129":
                    return "اصفهان " + "اصفهان";
                case "620":
                    return "اصفهان " + "باغ بهادران";
                case "621":
                    return "اصفهان " + "بوئین و میاندشت";
                case "549":
                    return "اصفهان " + "تیران و کرون";
                case "564":
                    return "اصفهان " + "جرقویه";
                case "575":
                    return "اصفهان " + "جادگان";
                case "113":
                case "114":
                    return "اصفهان " + "خمینی شهر";
                case "122":
                    return "اصفهان " + "خوان سار";
                case "540":
                    return "اصفهان " + "خور و بیابانک";
                case "660":
                    return "اصفهان " + "دولت آباد";
                case "120":
                    return "اصفهان " + "سمیرم";
                case "512":
                    return "اصفهان " + "سمیرم سفلی»دهاقان";
                case "510":
                case "511":
                    return "اصفهان " + "شائین شهر";
                case "119":
                    return "اصفهان " + "شهرضا";
                case "115":
                    return "اصفهان " + "فریدن";
                case "112":
                    return "اصفهان " + "فریدون شهر";
                case "110":
                case "111":
                    return "اصفهان " + "فلاورجان";
                case "125":
                case "126":
                    return "اصفهان " + "کاشان";
                case "565":
                    return "اصفهان " + "کوهپایه";
                case "121":
                    return "اصفهان " + "گلپایگان";
                case "116":
                case "117":
                    return "اصفهان " + "لنجان»زرین شهر";
                case "541":
                    return "اصفهان " + "مبارکه";
                case "622":
                    return "اصفهان " + "میمه";
                case "124":
                    return "اصفهان " + "نائین";
                    //*********زنجان
                case "108":
                case "109":
                    return "زنجان " + "نجف آباد";
                case "123":
                    return "زنجان " + "نطنز";
                case "427":
                case "428":
                    return "زنجان " + "زنجان";
                case "507":
                    return "زنجان " + "ملکان";
                case "158":
                    return "زنجان " + "مرند";
                case "615":
                    return "زنجان " + "ابهر و خرمدره";
                case "153":
                case "152":
                    return "زنجان " + "میانه";
            }

            return "موجود نیست!!!؟؟؟";
        }

        public static void MS_Set_Lang_To_Farsi(bool show_msg=false)
        {
            var list = InputLanguage
                .InstalledInputLanguages
                .OfType<InputLanguage>()
                .ToList();

            var fa = list.FirstOrDefault(x => x.Culture.IetfLanguageTag.ToUpper().Contains("FA"));
            if (fa != null)
                InputLanguage.CurrentInputLanguage = fa;
            if (fa == null && show_msg)
                MS_Message.Show("کاربر گرامی زبان فارسی بر روی سیستم شما نصب نیست");

        }
        public static void MS_Set_Currency_Setting()
        {
            try
            {

                var key = Registry.CurrentUser.OpenSubKey("Control Panel\\International", true);
                if (key != null)
                {
                    key.SetValue("iDigits", "0");
                    key.SetValue("iCurrDigits", "0");
                    key.SetValue("sCurrency", " ");
                    key.SetValue("s1159", "AM");
                    key.SetValue("s2359", "PM");
                    key.SetValue("iFirstDayOfWeek", "6");
                    key.SetValue("sDate", "/");
                    key.SetValue("NumShape", "2");
                    key.SetValue("iMeasure", "0");
                    key.SetValue("sNativeDigits", @"۰۱۲۳۴۵۶۷۸۹");
                    key.SetValue("iCalendarType", @"1");

                    key.Flush();
                    key.Close();
                }
            }
            catch 
            {
            }

        }

        public static Cursor myCursor(System.Drawing.Image img)
        {
            Bitmap bmp = (Bitmap)img;
            IntPtr Hicon = bmp.GetHicon();
            Icon icon = Icon.FromHandle(Hicon);
            return new Cursor(Hicon);
        }
        public static Cursor myCursor()
        {
            Bitmap bmp = (Bitmap)Properties.Resources.image_crop;
            IntPtr Hicon = bmp.GetHicon();
            Icon icon = Icon.FromHandle(Hicon);
            return new Cursor(Hicon);
        }
        public static Cursor myCursor(string imgPath)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(imgPath);
            Bitmap bmp = (Bitmap)img;
            IntPtr Hicon = bmp.GetHicon();
            Icon icon = Icon.FromHandle(Hicon);
            return new Cursor(Hicon);
        }

        public static bool Is_File_Image(string File_Extention)
        {
            var formats = new[]
            {
                "bmp", "emf", "exif", "gif",
                "ico", "jpg","jpeg", "png",
                "tiff", "wmf"
            };
            var Ext = Path.GetExtension(File_Extention).Remove(0, 1);
            return formats.Any(x => x.ToString().ToLower() == Ext.ToLower());
        }
        public static string GetImageFilter(bool ShowAll = true)
        {
            StringBuilder allImageExtensions = new StringBuilder();
            string separator = "";
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            Dictionary<string, string> images = new Dictionary<string, string>();
            foreach (ImageCodecInfo codec in codecs)
            {
                allImageExtensions.Append(separator);
                allImageExtensions.Append(codec.FilenameExtension);
                separator = ";";
                images.Add(string.Format("{0} Files: ({1})", codec.FormatDescription, codec.FilenameExtension),
                    codec.FilenameExtension);
            }
            StringBuilder sb = new StringBuilder();
            if (allImageExtensions.Length > 0 && ShowAll)
            {
                sb.AppendFormat("{0}|{1}", "All Images", allImageExtensions.ToString());
            }

            if (ShowAll)
                images.Add("All Files", "*.*");
            foreach (KeyValuePair<string, string> image in images)
            {
                if (ShowAll)
                    sb.AppendFormat("|{0}|{1}", image.Key, image.Value);
                else
                    sb.AppendFormat("{0}|{1}|", image.Key, image.Value);

            }

            var ext = sb.ToString();

            if (!ShowAll)
                ext = ext.Substring(0, ext.Length - 1);

            return ext;
        }

    }
}
