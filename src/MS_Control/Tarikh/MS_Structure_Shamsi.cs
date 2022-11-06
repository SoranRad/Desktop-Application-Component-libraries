using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Runtime.InteropServices;

namespace MS_Control.Tarikh
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MS_Structure_Shamsi
    {
        #region فیــلد
        private PersianCalendar persian;
        public int _Roz;
        public int _Mah;
        public int _Sal;
        public int _HH;
        public int _MM;
        public int _ss;
        public int _ms;
        public bool _is_Null; 
        #endregion

        public MS_Structure_Shamsi(int Sal, int Mah, int Roz)
        {
            this.persian = new PersianCalendar();
            this._Roz = Roz;
            this._Sal = Sal;
            this._Mah = Mah;
            this._HH =0;
            this._MM =0;
            this._ss =0;
            this._ms = 0;
            this._is_Null = false;
        }
        public MS_Structure_Shamsi(int Sal, int Mah, int Roz, int HH, int MM, int ss, int ms)
        {
            this.persian = new PersianCalendar();
            this._Roz = Roz;
            this._Sal = Sal;
            this._Mah = Mah;
            this._HH = HH;
            this._MM = MM;
            this._ss = ss;
            this._ms = ms;
            this._is_Null = false;
        }
        public MS_Structure_Shamsi(long Long_Shamsi)
        {
            this.persian = new PersianCalendar();
            this._Sal = Convert.ToInt16(Long_Shamsi.ToString().Substring(0, 4));
            this._Mah = Convert.ToInt16(Long_Shamsi.ToString().Substring(4, 2));
            this._Roz = Convert.ToInt16(Long_Shamsi.ToString().Substring(6, 2));

            var now = DateTime.Now;
            this._HH = now.Hour;
            this._MM = now.Minute;
            this._ss = now.Second;
            this._ms = now.Millisecond;
            this._is_Null = false;
        }
        public MS_Structure_Shamsi(long LongShamsi, long HHMMSSms)
        {
            this.persian = new PersianCalendar();
            long num = (LongShamsi * 100000000L) + HHMMSSms;
            this._Sal = Convert.ToInt16(num.ToString().Substring(0, 4));
            this._Mah = Convert.ToInt16(num.ToString().Substring(4, 2));
            this._Roz = Convert.ToInt16(num.ToString().Substring(6, 2));

            this._HH = 0;
            this._MM = 0;
            this._ss = 0;
            this._ms = 0;
            this._is_Null = false;
        }
        public MS_Structure_Shamsi(DateTime? datetime)
        {
            if (!datetime.HasValue)
            {
                this._is_Null = true;
                this.persian = new PersianCalendar();
                this._Roz = 0;
                this._Sal = 0;
                this._Mah = 0;
                this._HH = 0;
                this._MM = 0;
                this._ss = 0;
                this._ms = 0;
            }
            else
            {
                this._is_Null = false;
                this.persian = new PersianCalendar();
                DateTime time = datetime.Value;
                this._Roz = this.persian.GetDayOfMonth(time);
                this._Sal = this.persian.GetYear(time);
                this._Mah = this.persian.GetMonth(time);
                this._HH = this.persian.GetHour(time);
                this._MM = this.persian.GetMinute(time);
                this._ss = this.persian.GetSecond(time);
                this._ms = (int)(this.persian.GetMilliseconds(time) * 100.0);
            }
        }
        public MS_Structure_Shamsi(DateTime  datetime)
        {
            try
            {
                this.persian = new PersianCalendar();
                DateTime time = datetime;

                this._Roz = this.persian.GetDayOfMonth(time);
                this._Sal = this.persian.GetYear(time);
                this._Mah = this.persian.GetMonth(time);
                this._HH = this.persian.GetHour(time);
                this._MM = this.persian.GetMinute(time);
                this._ss = this.persian.GetSecond(time);
                this._ms = (int)(this.persian.GetMilliseconds(time) * 100.0);
                this._is_Null = false;
            }
            catch
            {
                this._is_Null = true;
                this.persian = new PersianCalendar();
                this._Roz = 0;
                this._Sal = 0;
                this._Mah = 0;
                this._HH = 0;
                this._MM = 0;
                this._ss = 0;
                this._ms = 0;
            }
        }
        public MS_Structure_Shamsi(string ShamsiFormatYYYY_MM_DD, string HH_MM_SS_ms)
        {
            this.persian = new PersianCalendar();
            string str = ShamsiFormatYYYY_MM_DD.Trim() + " " + HH_MM_SS_ms.Trim();
            this._Sal = Convert.ToInt16(str.ToString().Substring(0, 4));
            this._Mah = Convert.ToInt16(str.ToString().Substring(5, 2));
            this._Roz = Convert.ToInt16(str.ToString().Substring(8, 2));
            this._HH = Convert.ToInt16(str.ToString().Substring(11, 2));
            this._MM = Convert.ToInt16(str.ToString().Substring(14, 2));
            this._ss = Convert.ToInt16(str.ToString().Substring(17, 2));
            this._ms = Convert.ToInt16(str.ToString().Substring(20, 2));
            this._is_Null = false;
        }
        public MS_Structure_Shamsi(string ShamsiFormatYYYY_MM_DD)
        {
            if (Persian_DateTime_Check.Is_Tarikh_True(ShamsiFormatYYYY_MM_DD))
            {
                this.persian = new PersianCalendar();
                this._Sal = Convert.ToInt16(ShamsiFormatYYYY_MM_DD.ToString().Substring(0, 4));
                this._Mah = Convert.ToInt16(ShamsiFormatYYYY_MM_DD.ToString().Substring(5, 2));
                this._Roz = Convert.ToInt16(ShamsiFormatYYYY_MM_DD.ToString().Substring(8, 2));

                this._HH = 0;
                this._MM = 0;
                this._ss = 0;
                this._ms = 0;
                this._is_Null = false;
            }
            else
            {
                this.persian = new PersianCalendar();
                this._Sal = 0;
                this._Mah = 0;
                this._Roz = 0;
                this._HH = 0;
                this._MM = 0;
                this._ss = 0;
                this._ms = 0;
                this._is_Null = true;
            }
        }

        private void  Is_OK()
        {
            this._HH = ((this._HH < 0) || (this._HH > 24)) ? 0 : this._HH;
            this._MM = ((this._MM < 0) || (this._MM > 59)) ? 0 : this._MM;
            this._ss = ((this._ss < 0) || (this._ss > 59)) ? 0 : this._ss;
            this._ms = ((this._ms < 0) || (this._ms > 99)) ? 0 : this._ms;
            this._Mah = ((this._Mah > 12) || (this._Mah < 1)) ? 1 : this._Mah;
            
            int num = 0;
            num = this._Mah < 7 ? 31 : 30;
            this._Roz = ((this._Roz > num) || (this._Roz < 1)) ? 1 : this._Roz;
            this._Sal = ((this._Sal > 9999) || (this._Sal < 1)) ? 1 : this._Sal;
        }
        public long   ToLongShamsi()
        {
            this.Is_OK();
            return Convert.ToInt64(MS_Util.str_cod(4, this._Sal.ToString(), false) + MS_Util.str_cod(2, this._Mah.ToString(), false) + MS_Util.str_cod(2, this._Roz.ToString(), false));
        }
        public string ToShamsi()
        {
            if (this._is_Null)
            {
                return "";
            }
            this.Is_OK();
            return (MS_Util.str_cod(4, this._Sal.ToString(), false) 
                + "/" + MS_Util.str_cod(2, this._Mah.ToString(), false) 
                + "/" + MS_Util.str_cod(2, this._Roz.ToString(), false));
        }
        public string ToShamsi_Time()
        {
            if (this._is_Null)
            {
                return "";
            }
            this.Is_OK();
            return (MS_Util.str_cod(4, this._Sal.ToString(), false) + "/" + MS_Util.str_cod(2, this._Mah.ToString(), false) + "/" + MS_Util.str_cod(2, this._Roz.ToString(), false) + " " + MS_Util.str_cod(2, this._HH.ToString(), false) + ":" + MS_Util.str_cod(2, this._MM.ToString(), false));
        }
        public string ToShamsi_Time_Long()
        {
            if (this._is_Null)
            {
                return "";
            }
            this.Is_OK();
            return (MS_Util.str_cod(4, this._Sal.ToString(), false) + "/" + MS_Util.str_cod(2, this._Mah.ToString(), false) + "/" + MS_Util.str_cod(2, this._Roz.ToString(), false) + " " + MS_Util.str_cod(2, this._HH.ToString(), false) + ":" + MS_Util.str_cod(2, this._MM.ToString(), false) + "." + MS_Util.str_cod(2, this._ss.ToString(), false) + "." + MS_Util.str_cod(2, this._ms.ToString(), false));
        }
        public DateTime ToDatetime()
        {
            this.Is_OK();
            //var p = new PersianCalendar();
            //var date = p.ToDateTime(this._Sal, this._Mah, this._Roz, this._HH, this._MM, this._ss, this._ms);

            //DateTime d=new DateTime(date.Year,date.Month,date.Day);
            //return d;
            return this.persian.ToDateTime(this._Sal, this._Mah, this._Roz, this._HH, this._MM, this._ss, this._ms);
        }

        public MS_Structure_Shamsi AddDays(double value)
        {
            return new MS_Structure_Shamsi(this.ToDatetime().AddDays(value));
        }
        public MS_Structure_Shamsi AddMonths(int value)
        {
            int num = value / 12;
            int Roz = this._Roz;
            value -= 12 * num;
            this._Sal += num;
            int num3 = this._Mah + value;
            if (num3 > 12)
            {
                this._Sal++;
                this._Mah = num3 - 12;
            }
            else if (num3 < 1)
            {
                this._Sal--;
                this._Mah = num3 + 12;
            }
            else
            {
                this._Mah = num3;
            }
            int num4 = 0;
            switch (this._Mah)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    num4 = 31;
                    break;

                case 12:
                    num4 = 0x1d;
                    break;

                default:
                    num4 = 30;
                    break;
            }
            if (Roz > num4)
            {
                Roz = new MS_Structure_Shamsi(this._Sal, this._Mah, 1).DaysOfMonthShamsi();
            }
            return new MS_Structure_Shamsi(this._Sal, this._Mah, Roz);
        }
        public MS_Structure_Shamsi AddYears(int value)
        {
            return new MS_Structure_Shamsi(this.ToDatetime().AddYears(value));
        }
        public MS_Structure_Shamsi AddHours(double value)
        {
            return new MS_Structure_Shamsi(this.ToDatetime().AddHours(value));
        }
        public MS_Structure_Shamsi AddMinutes(double value)
        {
            return new MS_Structure_Shamsi(this.ToDatetime().AddMinutes(value));
        }
        public MS_Structure_Shamsi AddSeconds(double value)
        {
            return new MS_Structure_Shamsi(this.ToDatetime().AddSeconds(value));
        }
        public MS_Structure_Shamsi AddMilliseconds(double value)
        {
            return new MS_Structure_Shamsi(this.ToDatetime().AddMilliseconds(value));
        }
        public MS_Structure_Shamsi Add(TimeSpan value)
        {
            return new MS_Structure_Shamsi(this.ToDatetime().Add(value));
        }

        public int CompareTo(MS_Structure_Shamsi value)
        {
            return this.ToDatetime().CompareTo(value.ToDatetime());
        }

        public int DayOfYear(MS_Structure_Shamsi value)
        {
            this.persian = new PersianCalendar();
            return this.persian.GetDayOfYear(this.ToDatetime());
        }
        public TimeSpan TimeOfDay()
        {
            return this.ToDatetime().TimeOfDay;
        }
        public DayOfWeek DayofWeek()
        {
            return this.ToDatetime().DayOfWeek;
        }
        public int DayofWeekNUMBER()
        {
            DateTime time = this.ToDatetime();
            if (time.DayOfWeek == DayOfWeek.Saturday)
            {
                return 0;
            }
            if (time.DayOfWeek == DayOfWeek.Sunday)
            {
                return 1;
            }
            if (time.DayOfWeek == DayOfWeek.Monday)
            {
                return 2;
            }
            if (time.DayOfWeek == DayOfWeek.Tuesday)
            {
                return 3;
            }
            if (time.DayOfWeek == DayOfWeek.Wednesday)
            {
                return 4;
            }
            if (time.DayOfWeek == DayOfWeek.Thursday)
            {
                return 5;
            }
            if (time.DayOfWeek == DayOfWeek.Friday)
            {
                return 6;
            }
            return -1;
        }
        public string RozOfHafteh()
        {
            DateTime time = this.ToDatetime();
            string str = "";
            if (time.DayOfWeek == DayOfWeek.Friday)
            {
                str = "جمعه";
            }
            if (time.DayOfWeek == DayOfWeek.Saturday)
            {
                str = "شنبه";
            }
            if (time.DayOfWeek == DayOfWeek.Sunday)
            {
                str = "یکشنبه";
            }
            if (time.DayOfWeek == DayOfWeek.Monday)
            {
                str = "دوشنبه";
            }
            if (time.DayOfWeek == DayOfWeek.Tuesday)
            {
                str = "سه شنبه";
            }
            if (time.DayOfWeek == DayOfWeek.Wednesday)
            {
                str = "چهارشنبه";
            }
            if (time.DayOfWeek == DayOfWeek.Thursday)
            {
                str = "پنج شنبه";
            }
            return str;
        }
        public string Mah_name_persian()
        {
            switch (this._Mah)
            {
                case 1:
                    return "  فروردین  ";

                case 2:
                    return "  اردیبهشت  ";

                case 3:
                    return "  خرداد  ";

                case 4:
                    return " تیر   ";

                case 5:
                    return "  مرداد  ";

                case 6:
                    return "  شهریور  ";

                case 7:
                    return "  مهر  ";

                case 8:
                    return "  آبان  ";

                case 9:
                    return "  آذر  ";

                case 10:
                    return "  دی  ";

                case 11:
                    return "  بهمن  ";

                case 12:
                    return "  اسفند  ";
            }
            return "";
        }
        public string Persion_Long_DatetimeShamsi()
        {
            return (this.RozOfHafteh().Trim() + " " + MS_Util.num2str(this._Roz.ToString()).Trim() + "م " + this.Mah_name_persian().Trim() + " سال " + this._Sal.ToString().Trim() + " شمسی ");
        }
        public string Persion_Short_DatetimeShamsi()
        {
            return (this.RozOfHafteh().Trim() + " " + this.ToShamsi());
        }
        public int DaysOfMonthShamsi()
        {
            PersianCalendar p=new PersianCalendar();
            return p.GetDaysInMonth( _Sal, _Mah, 
                        PersianCalendar.PersianEra);
        }

        public static bool Is_Tarikh_True(string Shamsi_Format_YYYY_MM_DD)
        {
            if (Shamsi_Format_YYYY_MM_DD.Length < 10)
                return false;
            var sal = 0;
            var mah = 0;var  roz = 0;
            if (!int.TryParse(Shamsi_Format_YYYY_MM_DD.ToString().Substring(0, 4), out sal))
                return false;
            if (!int.TryParse(Shamsi_Format_YYYY_MM_DD.ToString().Substring(5, 2), out mah))
                return false;
            if (!int.TryParse(Shamsi_Format_YYYY_MM_DD.ToString().Substring(8, 2), out roz))
                return false;
            return Is_Tarikh_True(sal,mah,roz);
        }
        public static bool Is_Tarikh_True(int Sal, int Mah, int Roz)
        {
            var  p = new PersianCalendar();
            bool is_yeser_true=false,is_month_true=false,is_day_true=false;
            is_yeser_true=(Sal>=1000&&Sal<=3000);
            is_month_true = (Mah > 0 && Mah < 13);
            if (!is_month_true) return false;
            var max_day=p.GetDaysInMonth( Sal, Mah, PersianCalendar.PersianEra);
            is_day_true=(Roz>0&&Roz<=max_day);
            return is_yeser_true&&is_month_true&&is_day_true;
        }

    }
}
