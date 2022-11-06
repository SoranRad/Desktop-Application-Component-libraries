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
    public partial class MS_Filter_GrideX : UserControl
    {
        #region فیلد
        private MS_GridX _Grid;
        private GridEXColumn _Prior_Column = null;
        List<string> _List_Value=new List<string>();
        #endregion
        #region پراپرتی
        public MS_GridX MS_GrideX
        {
            get { return _Grid; }
            set { _Grid = value; }
        }
        #endregion
        #region متد
        public void MS_Show_Values()
        {
            ms_tree_View.Nodes.Clear();
            _List_Value.Clear();
            try
            {

                if (_Grid != null && _Grid.RootTable != null && _Grid.CurrentColumn != null)
                {
                    var index = _Grid.CurrentColumn.Index;

                    _Grid.GetDataRows()
                        .Where(x => x.Cells.Count > index && x.Cells[index] != null && x.Cells[index].Value != null)
                        .Select(y => y.Cells[index].Value.ToString())
                        .Distinct()
                        .MSZ_ForEach((x) =>
                        {
                            ms_tree_View.Nodes.Add(x);
                            _List_Value.Add(x);
                        });
                }
            }
            catch {}
        }
        public void MS_Set_Prior_Column()
        {
            if (_Grid != null && _Grid.RootTable != null && _Grid.CurrentColumn != null &&
                _Prior_Column != _Grid.CurrentColumn)
                _Prior_Column = _Grid.CurrentColumn;

        }
        #endregion
        public MS_Filter_GrideX()
        {
            InitializeComponent();
        }

        private void ms_search_TextChanged(object sender, EventArgs e)
        {
            ms_tree_View.Nodes.Clear();
            if(string.IsNullOrEmpty(ms_search.Text.Trim()))
                _List_Value.MSZ_ForEach((x) =>
                {
                    ms_tree_View.Nodes.Add(x);
                });
            else
                _List_Value.Where(x=>x.Contains(ms_search.Text.Trim())).MSZ_ForEach((x) =>
                {
                    ms_tree_View.Nodes.Add(x);
                });
        }
        private void ms_filter_add_Click(object sender, EventArgs e)
        {
            
            var ll = new GridEXFilterCondition();
            if (_Grid != null && _Grid.RootTable != null && _Grid.CurrentColumn != null)
            {
                ms_tree_View
                    .Nodes
                    .Cast<TreeNode>()
                    .Where(x => x.Checked)
                    .MSZ_ForEach((x) =>
                    {
                        var condi = new GridEXFilterCondition(_Grid.CurrentColumn, ConditionOperator.Equal, x.Text);
                        ll.AddCondition(LogicalOperator.Or, condi);
                    });

                _Grid.RootTable.ApplyFilter(ll);
            }
        }
        private void ms_filter_del_Click(object sender, EventArgs e)
        {
            if (_Grid != null && _Grid.RootTable != null && _Grid.CurrentColumn != null)
                _Grid.RootTable.RemoveFilter();
        }
    }
}
