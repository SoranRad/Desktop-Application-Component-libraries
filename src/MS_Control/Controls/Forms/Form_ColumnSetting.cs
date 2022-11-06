using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace MS_Control.Controls.Forms
{
    public partial class Form_ColumnSetting : MS_Mother_Mali
    {
        private MS_GridX _Grid;
        public Form_ColumnSetting(MS_GridX Grid)
        {
            InitializeComponent();
            _Grid = Grid;
            mS_GridX1.DataSource = _Grid.RootTable.Columns;
            mS_GridX1.Refetch();
            mS_GridX1.FilterMode = FilterMode.None;
        }

        private void mS_GridX1_SelectionChanged(object sender, EventArgs e)
        {
            advPropertyGrid1.SelectedObject = mS_GridX1.CurrentRow.DataRow;
        }
    }
}
