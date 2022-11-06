using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using MS_Control.Controls;

namespace MS_Control.Filter_Manage
{
    public partial class Form_Chart_GridEX : MS_Mother_Two
    {
        private MS_GridX _Grid;
        private Form_Select_Column _Form;

        private void Draw_Chart()
        {
            if(ms_X_Axis.SelectedItem==null)
                return;
            if(_Form.MS_Get_Select_List==null|| !_Form.MS_Get_Select_List.Any())
                return;
            var ch = ms_chart.ChartAreas.Last();
            ch.AxisX.MajorGrid.Enabled = false;
            ch.AxisY.MajorGrid.Enabled = false;
            foreach (GridEXColumn column in _Form.MS_Get_Select_List)
            {
                if (!string.IsNullOrWhiteSpace(column.FormatString))
                {
                    ch.AxisY.LabelStyle.Format = column.FormatString;
                    break;
                }
            }
            //================================
            ms_chart.Series.Clear();
            _Form.MS_Get_Select_List
                .MSZ_ForEach(x =>
                {
                    var new_serie = new Series(x.Caption)
                    {
                        Label = string.IsNullOrWhiteSpace(x.FormatString)
                        ? "#VALY"
                        : "#VALY{" + x.FormatString + "}",
                        ToolTip = x.Caption,
                    };
                    ms_chart.Series.Add(new_serie);
                });
            var xcol = ms_X_Axis.SelectedItem.DataRow as GridEXColumn;
            if (ms_show_select.Checked)
            {
                _Grid.SelectedItems.OfType<GridEXSelectedItem>()
                    .MSZ_ForEach(x =>
                    {
                        var row = x.GetRow();
                        double tmp;
                        //=========سطرهـا
                        _Form.MS_Get_Select_List
                            .MSZ_ForEach(y =>
                            {
                                //=========ستون
                                if (double.TryParse((row.Cells[y].Value??0).ToString(), out tmp))
                                {
                                    var dp = new DataPoint();
                                    dp.AxisLabel = row.Cells[xcol].Text;
                                    dp.LabelForeColor = Color.Black;
                                    dp.SetValueY(tmp);
                                    ms_chart.Series[y.Caption].Points.Add(dp);
                                    dp.IsValueShownAsLabel = true;
                                }
                            });
                    });
                    
            }
            else
            {
                _Grid.GetDataRows()
                    .MSZ_ForEach(x =>
                    {
                        var row = x;
                        double tmp;
                        //=========سطرهـا
                        _Form.MS_Get_Select_List
                            .MSZ_ForEach(y =>
                            {
                                //=========ستون
                                if (double.TryParse((row.Cells[y].Value??0).ToString(), out tmp))
                                {
                                    var dp = new DataPoint();
                                    dp.AxisLabel = row.Cells[xcol].Text;
                                    dp.LabelForeColor = Color.Black;
                                    dp.SetValueY(tmp);
                                    ms_chart.Series[y.Caption].Points.Add(dp);
                                    dp.IsValueShownAsLabel = true;
                                }
                            });
                    });
            }
        }

        private void Load_Cols()
        {
            var arr=_Grid.RootTable.Columns.OfType<GridEXColumn>()
                .Where(x => x.ShowInFieldChooser && x.Visible)
                .Select(x=>new UIComboBoxItem()
                {
                    Text = x.Caption,
                    DataRow = x
                }).ToArray();
            ms_X_Axis.Items.AddRange(arr);
        }

        public Form_Chart_GridEX(MS_GridX Grid)
        {
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(178)));
            InitializeComponent();
            _Grid = Grid;
            Load_Cols();
            _Form=new Form_Select_Column(Grid);
        }

        private void ms_save_Click(object sender, EventArgs e)
        {
            //_Form=new Form_Select_Column(_Grid);
            var r = _Form.ShowDialog(this);
            if(r!=DialogResult.OK)
                return;
            Draw_Chart();
        }

        private void ms_X_Axis_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw_Chart();
        }
    }
}
