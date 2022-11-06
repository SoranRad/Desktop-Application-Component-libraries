using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;

namespace MS_Control.Tarikh
{
    public partial class MS_Tatikh_View : UserControl
    {

        #region فیــلد

        public static List<int> MS_List_Years = null;
            
        ///=== _Current_Tarikh      ماهی که الان در صفحه است
        /// ===_Selected_tarikh     ماهی که انتخـاب شده
        /// ===_Returned_tarikh     ماهی که برگردانده می شود
        MS_Structure_Shamsi _Current_Tarikh = new MS_Structure_Shamsi(DateTime.Now);
        MS_Structure_Shamsi _Selected_Tarikh , _Returned_Tarikh;
        int _Selected_Day ,_Current_Day;
        private Color _Selected_Color = Color.DarkOrange, _Current_Color = Color.Red;
        private bool _Do_Refresh = true;

        public delegate void MS_On_Button_Click();
        public event MS_On_Button_Click MS_On_OK_Clicked, MS_On_Cancel_Clicked;
        public event EventHandler NzDateChanged;
        #endregion
        #region پراپــرتی
        public MS_Structure_Shamsi MS_Tarikh
        {
            get { return _Returned_Tarikh; }
            set
            {
                _Selected_Tarikh =_Current_Tarikh= value; 
                Refresh_Kardan_Status_Ber();
                Load_Tarikh_Dar_Form();
            }
        } 
        public MS_Structure_Shamsi MS_CurrentTarikh
        {
            get { return _Selected_Tarikh; }
            set
            {
                _Selected_Tarikh = _Current_Tarikh = value;
                Refresh_Kardan_Status_Ber();
                Load_Tarikh_Dar_Form();
            }
        }
        #endregion
        #region متــد
        private void Load_Tarikh_Dar_Form()
        {
            _Do_Refresh = false;
            
            ms_month_list.SelectedIndex = _Selected_Tarikh._Mah <= 12
                                        ? _Selected_Tarikh._Mah - 1
                                        :0;
            var sal =
                ms_year_list
                .Items
                .OfType<UIComboBoxItem>()
                .SingleOrDefault(x => (int) x.Value == _Selected_Tarikh._Sal);
            ms_year_list.SelectedItem = sal;

            _Do_Refresh = true;
            Refresh_Kardan_Grid_Days();
        }
        public void MS_Refresh_Kardan_Form()
        {
            //====پرکردن لیست ســالها
            ms_year_list.Items.Clear();
            if (MS_List_Years != null && MS_List_Years.Any())
                MS_List_Years.MSZ_ForEach((x) =>
                {
                    var new_one = new UIComboBoxItem()
                    {
                        Text = x.ToString(),
                        Value = x,

                    };
                    ms_year_list.Items.Add(new_one);
                });
            else
                for (int i = 1300; i <= 1499; i++)
                {
                    var new_one = new UIComboBoxItem()
                    {
                        Text = i.ToString(),
                        Value = i,
                    
                    };
                    ms_year_list.Items.Add(new_one);
                }
            //=========================
        }
        public void MS_Refresh_Kardan_Form(List<int> _List_Year )
        {
            //====پرکردن لیست ســالها
            ms_year_list.Items.Clear();
            _List_Year.MSZ_ForEach((x) =>
            {
                var new_one = new UIComboBoxItem()
                {
                    Text = x.ToString(),
                    Value = x,

                };
                ms_year_list.Items.Add(new_one);
            });
        }
        public void Refresh_Kardan_Grid_Days()
        {
            //================================
               ms_day_1.Visible =   ms_day_2.Visible = ms_day_3.Visible = ms_day_4.Visible = ms_day_5.Visible =
               ms_day_6.Visible =  ms_day_29.Visible = ms_day_30.Visible = ms_day_31.Visible =
               ms_day_32.Visible = ms_day_33.Visible = ms_day_34.Visible = ms_day_35.Visible = 
               ms_day_36.Visible = ms_day_37.Visible = false;
            //================================
            var tedad_roz_mah = _Current_Tarikh.DaysOfMonthShamsi();
            var roz_hafteh_start_mah =
                new MS_Structure_Shamsi(_Current_Tarikh._Sal, _Current_Tarikh._Mah, 1).DayofWeekNUMBER();
            //================================
            var selected_day = 0;var current_day=0;
            if (_Selected_Tarikh._Sal == _Current_Tarikh._Sal && _Selected_Tarikh._Mah == _Current_Tarikh._Mah)
                selected_day = _Selected_Tarikh._Roz;
            var now = new MS_Structure_Shamsi(DateTime.Now);
            if (_Current_Tarikh._Sal == now._Sal && _Current_Tarikh._Mah == now._Mah)
                current_day = now._Roz;
            //===============================
            _Do_Refresh = false;
            var roz = 1;
            for (int i = 1; i <= 37; i++)
            {
                var control_name = "ms_day_" + i.ToString();
                var control = Controls[control_name] as UIRadioButton;
                int tag = 0;
                if (!int.TryParse(control.Tag.ToString(), out tag)) continue;
                if (tag >= roz_hafteh_start_mah+1 && roz <= tedad_roz_mah)
                {
                    control.Show();
                    control.Text = roz.ToString();
                    control.Office2007CustomColor = Color.Transparent;
                    control.Checked = roz == selected_day;
                    if (roz == current_day)
                        control.Office2007CustomColor = _Current_Color;
                    roz++;
                }
            }
            _Do_Refresh = true;
            //================================
        }
        private void Refresh_Kardan_Status_Ber()
        {
            var date = _Selected_Tarikh.ToDatetime();
            ms_status.Panels[0].Text = "(" + _Selected_Tarikh.ToShamsi() + ")";
            ms_status.Panels[1].Text = "("+(date.Year+"-"+date.Month+"-"+date.Day)+")";
            if(NzDateChanged!=null)
                NzDateChanged(this,null);
        }
        #endregion
        public MS_Tatikh_View()
        {
            InitializeComponent();
            _Selected_Tarikh= _Current_Tarikh = new MS_Structure_Shamsi(DateTime.Now);
            _Selected_Day = _Current_Day = _Current_Tarikh._Roz;
            Refresh_Kardan_Grid_Days();
            MS_Refresh_Kardan_Form();
        }
        #region کنترل مربوط به ســااـهــا
        private void ms_year_Click(object sender, EventArgs e)
        {
            ms_year_list.DroppedDown = true;
        }
        private void ms_year_next_Click(object sender, EventArgs e)
        {
            if(ms_year_list.SelectedIndex<ms_year_list.Items.Count-1)
                ms_year_list.SelectedIndex++;
        }
        private void ms_year_prior_Click(object sender, EventArgs e)
        {
            if (ms_year_list.SelectedIndex >0)
                ms_year_list.SelectedIndex--;
        }
        private void ms_year_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!_Do_Refresh) return;
            ms_year.Text = ms_year_list.SelectedItem.Text;
        }
        private void ms_year_TextChanged(object sender, EventArgs e)
        {
            if(!_Do_Refresh)return;
            var sal= Convert.ToInt32( ms_year_list.SelectedItem.Value);
            _Current_Tarikh=new MS_Structure_Shamsi(sal,_Current_Tarikh._Mah,_Selected_Day);
            Refresh_Kardan_Grid_Days();
        }
        #endregion
        #region کنتــرل مربوط به مــاه هــا
        private void ms_month_prior_Click(object sender, EventArgs e)
        {
            if (ms_month_list.SelectedIndex > 0)
                ms_month_list.SelectedIndex--;
        }
        private void ms_month_next_Click(object sender, EventArgs e)
        {
            if (ms_month_list.SelectedIndex < ms_month_list.Items.Count - 1)
                ms_month_list.SelectedIndex++;
        }
        private void ms_month_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(!_Do_Refresh)return; 
            ms_month.Text = ms_month_list.SelectedItem.Text;
        }
        private void ms_month_button_Click(object sender, EventArgs e)
        {
            ms_month_list.DroppedDown = true;
        }
        private void ms_month_TextChanged(object sender, EventArgs e)
        {
            if(!_Do_Refresh)return;
            var month = Convert.ToInt32(ms_month_list.SelectedItem.Value);
            _Current_Tarikh = new MS_Structure_Shamsi(_Current_Tarikh._Sal,month, _Selected_Day);
            Refresh_Kardan_Grid_Days();
        }
        #endregion
        #region انتـخـاب روژ
        private void ms_day_CheckedChanged(object sender, EventArgs e)
        {
            if(!(sender is UIRadioButton))return;
            var control = sender as UIRadioButton;
            if(!control.Checked)return;
            
            _Selected_Day = Convert.ToInt32(control.Text);
            _Selected_Tarikh=new MS_Structure_Shamsi(_Current_Tarikh._Sal,_Current_Tarikh._Mah,_Selected_Day);
            Refresh_Kardan_Status_Ber();
            //============
        }
        private void ms_day_DoubleClick(object sender, EventArgs e)
        {
            ms_ok.PerformClick();
        }
        #endregion
        #region دکمه های کوچک
        private void ms_now_Click(object sender, EventArgs e)
        {
            _Selected_Tarikh = _Current_Tarikh = new MS_Structure_Shamsi(DateTime.Now);
            Refresh_Kardan_Status_Ber();
            Load_Tarikh_Dar_Form();
        }
        private void ms_ok_Click(object sender, EventArgs e)
        {
            _Returned_Tarikh = _Selected_Tarikh;
            if (MS_On_OK_Clicked != null)
                MS_On_OK_Clicked();
        }
        private void ms_cancel_Click(object sender, EventArgs e)
        {
            if (MS_On_Cancel_Clicked != null)
                MS_On_Cancel_Clicked();
        } 
        #endregion
    }
}
