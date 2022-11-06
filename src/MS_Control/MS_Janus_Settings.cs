using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control.Controls;

namespace MS_Control
{
    public partial class MS_Janus_Settings : UserControl
    {
        #region فیلد
        private MS_GridX _Grid;
        #endregion
        #region پراپرتی
        public MS_GridX MS_GrideX
        {
            get { return _Grid; }
            set { _Grid = value; }
        }
        #endregion
        public MS_Janus_Settings()
        {
            InitializeComponent();
        }

        private void ms_max_Click(object sender, EventArgs e)
        {
            if (_Grid == null) return;
            _Grid.FilterMode=FilterMode.Automatic;
            if(_Grid.RootTable==null)return;
            _Grid.RootTable.Columns.Cast<GridEXColumn>().ToList()
                .MSZ_ForEach((x) =>
                {
                    x.EditType=EditType.TextBox;
                    x.FilterEditType=FilterEditType.SameAsEditType;
                    x.FilterRowButtonStyle=FilterRowButtonStyle.ConditionOperatorDropDown;
                    x.FilterRowComparison=ConditionOperator.Contains;
                });

        }

        private void ms_min_Click(object sender, EventArgs e)
        {
            if (_Grid == null) return;
            _Grid.FilterMode = FilterMode.Automatic;
            if (_Grid.RootTable == null) return;
            _Grid.GroupByBoxVisible = !_Grid.GroupByBoxVisible;
        }
    }
}
