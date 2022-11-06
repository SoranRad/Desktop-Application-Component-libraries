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
    public partial class MS_Aggregation_GrideX : UserControl
    {
        #region فیلد
        private MS_GridX _Grid;
        private GridEXColumn _Prior_Column = null;
        List<string> _List_Value = new List<string>();
        #endregion
        #region پراپرتی
        public MS_GridX MS_GrideX
        {
            get { return _Grid; }
            set { _Grid = value; }
        }
        #endregion
        #region متد
        public void MS_Set_String()
        {
        }
        private bool Etebar_Sanji()
        {
            return (_Grid != null && _Grid.RootTable != null && _Grid.CurrentColumn != null);
        }
        #endregion
        public MS_Aggregation_GrideX()
        {
            InitializeComponent();
        }
        private void ms_sum_Click(object sender, EventArgs e)
        {
            if (Etebar_Sanji())
            {
                _Grid.TotalRow=InheritableBoolean.True;
                _Grid.TotalRowPosition=TotalRowPosition.BottomFixed;
                _Grid.CurrentColumn.AggregateFunction=AggregateFunction.Sum;
            }
        }

        private void ms_count_Click(object sender, EventArgs e)
        {
            if (Etebar_Sanji())
            {
                _Grid.TotalRow = InheritableBoolean.True;
                _Grid.TotalRowPosition = TotalRowPosition.BottomFixed;
                _Grid.CurrentColumn.AggregateFunction = AggregateFunction.Count;
            }
        }

        private void ms_max_Click(object sender, EventArgs e)
        {
            if (Etebar_Sanji())
            {
                _Grid.TotalRow = InheritableBoolean.True;
                _Grid.TotalRowPosition = TotalRowPosition.BottomFixed;
                _Grid.CurrentColumn.AggregateFunction = AggregateFunction.Max;
            }
        }

        private void ms_min_Click(object sender, EventArgs e)
        {
            if (Etebar_Sanji())
            {
                _Grid.TotalRow = InheritableBoolean.True;
                _Grid.TotalRowPosition = TotalRowPosition.BottomFixed;
                _Grid.CurrentColumn.AggregateFunction = AggregateFunction.Min;
            }
        }

        private void ms_avg_Click(object sender, EventArgs e)
        {
            if (Etebar_Sanji())
            {
                _Grid.TotalRow = InheritableBoolean.True;
                _Grid.TotalRowPosition = TotalRowPosition.BottomFixed;
                _Grid.CurrentColumn.AggregateFunction = AggregateFunction.Average;
            }
        }

        private void ms_none_Click(object sender, EventArgs e)
        {
            if (Etebar_Sanji())
            {
                _Grid.TotalRow = InheritableBoolean.True;
                _Grid.TotalRowPosition = TotalRowPosition.BottomFixed;
                _Grid.CurrentColumn.AggregateFunction = AggregateFunction.None;
            }
        }
    }
}
