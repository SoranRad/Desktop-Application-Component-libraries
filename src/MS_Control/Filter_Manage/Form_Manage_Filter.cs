using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Janus.Windows.GridEX;
using MS_Control.Controls;

namespace MS_Control.Filter_Manage
{
    public partial class Form_Manage_Filter : MS_Mother
    {
        #region فیلد
        private MS_GridX _Grid;
        #endregion
        #region متد
        
        #endregion
        #region سـازنده
        public Form_Manage_Filter(MS_GridX DataGrid)
        {
            InitializeComponent();
            _Grid = DataGrid;
            if (_Grid.RootTable != null)
            {
                ms_filter.MS_Refresh_Kardan_Control(_Grid.RootTable.Columns);
                //var dtr = (Janus.Windows.GridEX.IFilterCondition) _Grid.RootTable.FilterApplied;
                //dtr.FilterCondition.
                if(_Grid.RootTable.FilterCondition!=null)
                    ms_filter.MS_Load_Filter_Dar_Control(_Grid.RootTable.FilterCondition.FilterCondition);
            }
           
        } 
        #endregion

        private void ms_apply_Click(object sender, EventArgs e)
        {
            _Grid.RootTable.ApplyFilter(MS_Filter_Condition.Get_Filter_Condition( ms_filter));
        }

        private void ms_remove_Click(object sender, EventArgs e)
        {
            _Grid.RootTable.RemoveFilter();
        }

        private void ms_load_Filter_Click(object sender, EventArgs e)
        {
            ms_filter.MS_Clear_Condition();
            ms_filter.MS_Load_Filter_Dar_Control(_Grid.RootTable.FilterCondition.FilterCondition);
        }
    }
}
