using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
namespace MS_Control.Tarikh
{
    public class Persian_DateTime_Check
    {
        public static string _Month;
        public static string _Day;

        public static string Milady_To_Shamsi (DateTime Date)
        {
            switch (Date.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    _Day = "جمعه";
                    break;
                case DayOfWeek.Sunday:
                    _Day = "شنبه";
                    break;
                case DayOfWeek.Saturday:
                    _Day = "یکشنبه";
                    break;
                case DayOfWeek.Monday:
                    _Day = "دوشنبه";
                    break;
                case DayOfWeek.Tuesday:
                    _Day = "سه شنبه";
                    break;
                case DayOfWeek.Wednesday:
                    _Day = "چهارشنبه";
                    break;
                case DayOfWeek.Thursday:
                    _Day = "پنج شنبه";
                    break;
            }
            
            var calendar = new PersianCalendar();
            var builder = new  StringBuilder();

            //builder.Append(calendar.GetYear(Date).ToString("0000"));
            builder.Append(calendar.GetYear(Date).ToString("D4"));
            builder.Append("/");
            //builder.Append(calendar.GetMonth(Date).ToString("00"));
            //builder.Append(calendar.GetMonth(Date).ToString("D2"));
            var month = calendar.GetMonth(Date).ToString("D2");
            builder.Append(month);

            switch (month)
            {
                case "01":
                    _Month = "  فروردین  ";
                    break;

                case "02":
                    _Month = "  اردیبهشت  ";
                    break;

                case "03":
                    _Month = "  خرداد  ";
                    break;

                case "04":
                    _Month = " تیر   ";
                    break;

                case "05":
                    _Month = "  مرداد  ";
                    break;

                case "06":
                    _Month = "  شهریور  ";
                    break;

                case "07":
                    _Month = "  مهر  ";
                    break;

                case "08":
                    _Month = "  آبان  ";
                    break;

                case "09":
                    _Month = "  آذر  ";
                    break;

                case "10":
                    _Month = "  دی  ";
                    break;

                case "11":
                    _Month = "  بهمن  ";
                    break;

                case "12":
                    _Month = "  اسفند  ";
                    break;
            }
            builder.Append("/");
            builder.Append(calendar.GetDayOfMonth(Date).ToString("D2"));
            return builder.ToString();
        }
        public static bool   Is_Tarikh_True   (string tarikh)
        {
            string[] strArray = tarikh.Trim().Split(new char[] { '/' });
            int sal = 0;
            int mah = 0;
            int roz = 0;
            try
            {
                sal = Convert.ToInt32(strArray[0]);
                mah = Convert.ToInt32(strArray[1]);
                roz = Convert.ToInt32(strArray[2]);
            }
            catch
            {
                return false;
            }
            return (((((sal > 1000) && (sal < 3000)) && ((mah > 0) && (mah < 13))) && (roz > 0)) && (roz < 32));
        }

        //public static DateTime Shamsi2Miladi(string _date)
        //{
        //    //_date = tarikh_sahat.date(_date.ToString());
        //    //MpShamsiStruct struct2 = new MpShamsiStruct(_date);
        //    //return struct2.ToDatetime();
        //    return DateTime.Now;
        //}
    }
}
