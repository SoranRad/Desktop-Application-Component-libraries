using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Janus.Windows.GridEX;
using MS_Control.TSDD;

namespace MS_Control_Test
{
    public partial class MS_Combo_Test : MS_TextBox_ADC
    {
        public MS_Combo_Test()
        {
            InitializeComponent();
            //if (!DesignMode)
                MS_List_Control = ms_list;
           
        }
        

        protected override void MS_On_Selected(On_Item_Selected e)
        {
            _Do_Refresh = false;
            var row = e.Data_Row as GridEXRow;
            if (row != null)
            {
                var item = row.DataRow as test;
                Text = item.code.ToString() + ")" + item.name;
                _Selected_Item = item;
                e.Data_Row = item;
            }
            _Do_Refresh = true;
            base.MS_On_Selected(e);
        }
        
    }
}
