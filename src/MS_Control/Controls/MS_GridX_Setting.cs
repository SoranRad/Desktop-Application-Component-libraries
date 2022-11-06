using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control.Controls.Forms;
using MS_Control.Filter_Manage;
using MS_Grid_Print;

//if (_GridX != null && _GridX.RootTable != null && _GridX.CurrentColumn != null)

namespace MS_Control.Controls
{
    public partial class MS_GridX_Setting : ToolStrip
    {
        #region فیلد
        private MS_GridX _GridX;
        public Color MS_Color_Start { get; set; }
        public Color MS_Color_End { get; set; }
        private Color _borderColor = Color.Silver;
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        private static int WM_PAINT = 0x000F;
        public event EventHandler MS_On_Print_Clicked;
        #endregion
        #region پراپرتی
        public MS_GridX MS_GridX
        {
            get { return _GridX; }
            set
            {
                _GridX = value;
                ms_column_filter.MS_GrideX = value;
                ms_ChooseField.Visible = ms_saveSettings.Visible = value?.SaveSettings != false;
            }
        }
        public Color MS_BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate(); 
            }
        }
        public ButtonBorderStyle MS_BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MS_Report_Name { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MS_Company_Name { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MS_User_Name { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MS_Tarix_Report { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MS_Molahezat { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public System.Drawing.Image MS_Logo { get; set; }
        #endregion
        #region متد
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(this.ClientRectangle,
                                                               MS_Color_Start,
                                                               MS_Color_End,
                                                               90F))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                Graphics g = Graphics.FromHwnd(Handle);
                Rectangle bounds = new Rectangle(0, 0, Width, Height);
                ControlPaint.DrawBorder(g, bounds, _borderColor, _borderStyle);
            }
        }
        private bool Etebar_Sanji()
        {
            return (_GridX != null && _GridX.RootTable != null && _GridX.CurrentColumn != null);
        }
        private void SaveSetting()
        {
            if(_GridX==null|| _GridX?.SaveSettings==false)
                return;

            _GridX.RemoveFilters();
            _GridX.SaveComponentSettings();

        }
        #endregion
        public MS_GridX_Setting()
        {
            InitializeComponent();
            ToolStripControlHost host = new ToolStripControlHost(ms_column_filter);
            ms_col_filter.DropDownItems.Add(host);
        }

        private void ms_filter_Click(object sender, EventArgs e)
        {
            if(_GridX==null)return;

            if (_GridX.FilterMode == FilterMode.Automatic || _GridX.FilterMode == FilterMode.Manual)
                _GridX.FilterMode=FilterMode.None;
            else _GridX.FilterMode=FilterMode.Automatic;

            _GridX.Refresh();

        }
        private void ms_total_ButtonClick(object sender, EventArgs e)
        {
            ms_total.ShowDropDown();
        }
        private void ms_col_filter_ButtonClick(object sender, EventArgs e)
        {
            ms_col_filter.ShowDropDown();
        }
        
        private void ms_auto_size_Click(object sender, EventArgs e)
        {
            if(_GridX==null)
                return;
            _GridX.AutoSizeColumns();
            _GridX.Refresh();
        }
        private void ms_filter_advanced_Click(object sender, EventArgs e)
        {
            if (_GridX == null)
                return;
            var frm = new Form_FilterEditor(_GridX);
            frm.Top = 0;
            frm.Left = 0;
            frm.MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width,frm.Height);
            frm.Width = Screen.PrimaryScreen.WorkingArea.Width;
            frm.ShowDialog();
        }
        private void ms_group_Box_Click(object sender, EventArgs e)
        {
            if (_GridX == null)
                return;
            _GridX.GroupByBoxVisible = !_GridX.GroupByBoxVisible;
            _GridX.Refresh();
        }
        private void ms_group_total_Click(object sender, EventArgs e)
        {
            if (_GridX == null)
                return;
            switch (_GridX.GroupTotals)
            {
                case GroupTotals.Default:
                    _GridX.GroupTotals = GroupTotals.Never;
                    break;
                case GroupTotals.Never:
                    _GridX.GroupTotals = GroupTotals.Always;
                    break;
                case GroupTotals.Always:
                    _GridX.GroupTotals = GroupTotals.ExpandedGroup;
                    break;
                case GroupTotals.ExpandedGroup:
                    _GridX.GroupTotals = GroupTotals.Never;
                    break;
            }
            _GridX.Refresh();
        }

        private void ms_sum_Click(object sender, EventArgs e)
        {
            if (Etebar_Sanji())
            {
                _GridX.TotalRow = InheritableBoolean.True;
                _GridX.TotalRowPosition = TotalRowPosition.BottomFixed;
                _GridX.CurrentColumn.AggregateFunction = AggregateFunction.Sum;
                _GridX.Refresh();
            }
        }
        private void ms_max_Click(object sender, EventArgs e)
        {
            if (Etebar_Sanji())
            {
                _GridX.TotalRow = InheritableBoolean.True;
                _GridX.TotalRowPosition = TotalRowPosition.BottomFixed;
                _GridX.CurrentColumn.AggregateFunction = AggregateFunction.Max;
                _GridX.Refresh();

            }
        }
        private void ms_min_Click(object sender, EventArgs e)
        {
            if (Etebar_Sanji())
            {
                _GridX.TotalRow = InheritableBoolean.True;
                _GridX.TotalRowPosition = TotalRowPosition.BottomFixed;
                _GridX.CurrentColumn.AggregateFunction = AggregateFunction.Min;
                _GridX.Refresh();
            }
        }
        private void ms_count_Click(object sender, EventArgs e)
        {
            if (Etebar_Sanji())
            {
                _GridX.TotalRow = InheritableBoolean.True;
                _GridX.TotalRowPosition = TotalRowPosition.BottomFixed;
                _GridX.CurrentColumn.AggregateFunction = AggregateFunction.Count;
                _GridX.Refresh();
            }
        }
        private void ms_avg_Click(object sender, EventArgs e)
        {
            if (Etebar_Sanji())
            {
                _GridX.TotalRow = InheritableBoolean.True;
                _GridX.TotalRowPosition = TotalRowPosition.BottomFixed;
                _GridX.CurrentColumn.AggregateFunction = AggregateFunction.Average;
                _GridX.Refresh();
            }
        }

        private void ms_print_Click(object sender, EventArgs e)
        {
            if (_GridX == null) return;

            if (MS_On_Print_Clicked != null)
                MS_On_Print_Clicked(this,null);

            var frm = new Form_List(this.MS_GridX);

            frm.MS_Company_Name = this.MS_Company_Name;
            frm.MS_Logo = this.MS_Logo;
            frm.MS_Molahezat = this.MS_Molahezat;
            frm.MS_Report_Name = this.MS_Report_Name;
            frm.MS_Tarix_Report = this.MS_Tarix_Report;
            frm.MS_User_Name = this.MS_User_Name;
            frm.ShowDialog(this.FindForm());
        }
        private void ms_excel_Click(object sender, EventArgs e)
        {
            if (_GridX == null) return;
            var r=saveFileDialog1.ShowDialog();
            if (r ==DialogResult.OK)
            {
                var st = new FileStream(saveFileDialog1.FileName+".xls",
                    FileMode.Create, FileAccess.Write, FileShare.None);
                gridEXExporter1.GridEX = _GridX;
                gridEXExporter1.Export(st);
                st.Close();
                saveFileDialog1.OpenFile();
                _GridX.Refresh();
            }
            
        }

        private void ms_col_filter_DropDownOpening(object sender, EventArgs e)
        {
            ms_column_filter.MS_Show_Values();
        }
        private void ms_chart_Click(object sender, EventArgs e)
        {
            if(_GridX==null)
                return;
            new Form_Chart_GridEX(_GridX).Show();
        }

        private void ms_active_total_Click(object sender, EventArgs e)
        {
            if (_GridX == null)
                return;

            if (_GridX.TotalRow == InheritableBoolean.Default || _GridX.TotalRow == InheritableBoolean.False)
            {
                _GridX.TotalRow = InheritableBoolean.True;
                _GridX.TotalRowPosition = TotalRowPosition.BottomFixed;
            }
            else _GridX.TotalRow = InheritableBoolean.False;
            _GridX.Invalidate();
        }

        private void ms_filter_text_Enter(object sender, EventArgs e)
        {
            ms_filter_text.BackColor = Color.Gold;
            ms_filter_text.Width = 120;
            if(_GridX==null)
                return;
            _GridX.FormattingRow += _GridX_FormattingRow;
        }
        private void _GridX_FormattingRow(object sender, RowLoadEventArgs e)
        {
            if (!string.IsNullOrEmpty(ms_filter_text.Text))
            {
                foreach (GridEXCell cell in e.Row.Cells)
                {
                    if (cell.Text.Contains(ms_filter_text.Text))
                    {
                        cell.FormatStyle = new GridEXFormatStyle();
                        cell.FormatStyle.BackColor = Color.Yellow;
                    }
                }
            }
        }
        private void ms_filter_text_Leave(object sender, EventArgs e)
        {
            ms_filter_text.BackColor = Color.White;

            ms_filter_text.Width = 60;
            if (_GridX == null)
                return;
            _GridX.FormattingRow -= _GridX_FormattingRow;

        }

        private void ms_filter_text_TextChanged(object sender, EventArgs e)
        {
            if (_GridX == null)
                return;

            if (_GridX.RootTable == null)
                return;

            if (string.IsNullOrEmpty(ms_filter_text.Text))
            {
                _GridX.RootTable.RemoveFilter();
                return;
            }
            
            GridEXFilterCondition GeneratedFilter=new GridEXFilterCondition();
            int r = 1;
            decimal num=0;

            _GridX.RootTable
                .Columns
                .OfType<GridEXColumn>()
                .Where(x => x.Visible && x.FilterEditType!=FilterEditType.NoEdit)
                .MSZ_ForEach(x =>
                {
                    if (r == 1)
                    {
                        var tmp = IsTypeNumeric(x.DataTypeCode);
                        var check = decimal.TryParse(ms_filter_text.Text, out num);

                        GeneratedFilter = new GridEXFilterCondition(x, ConditionOperator.Contains, ms_filter_text.Text);
                                    

                        r++;

                        if (check && tmp)
                        {
                            x.FilterRowComparison = ConditionOperator.Equal;
                            x.DefaultFilterRowComparison = FilterConditionOperator.Equal;

                            var innerCondition = new GridEXFilterCondition(x, ConditionOperator.Equal, num);
                            GeneratedFilter.AddCondition(LogicalOperator.Or, innerCondition);
                        }


                    }
                    else
                    {

                        var innerCondition =
                            new GridEXFilterCondition(x, ConditionOperator.Contains, ms_filter_text.Text);
                        GeneratedFilter.AddCondition(LogicalOperator.Or, innerCondition);


                        var tmp = IsTypeNumeric(x.DataTypeCode);
                        var check = decimal.TryParse(ms_filter_text.Text, out num);

                        if (check && tmp)
                        {
                            x.FilterRowComparison = ConditionOperator.Equal;
                            x.DefaultFilterRowComparison = FilterConditionOperator.Equal;

                            innerCondition = new GridEXFilterCondition(x, ConditionOperator.Equal, num);
                            GeneratedFilter.AddCondition(LogicalOperator.Or, innerCondition);
                        }


                        


                    }
                });
            MS_GridX.RootTable.ApplyFilter(GeneratedFilter);
            MS_GridX.Refresh();
        }

        private bool IsTypeNumeric(TypeCode Type)
        {
            return Type == TypeCode.Byte || Type == TypeCode.Decimal || Type == TypeCode.Double ||
                   Type == TypeCode.Int16
                   || Type == TypeCode.Int32 || Type == TypeCode.Int64 || Type == TypeCode.SByte ||
                   Type == TypeCode.Single
                   || Type == TypeCode.UInt16 || Type == TypeCode.UInt32 || Type == TypeCode.UInt64;
        }

        private void ms_total_DropDownOpened(object sender, EventArgs e)
        {
            ms_CurrentColumn.Text = _GridX?.CurrentColumn?.Caption;
            if (_GridX?.CurrentColumn == null)
            {
                
            }
        }

        private void ms_ChooseField_Click(object sender, EventArgs e)
        {
            if (_GridX != null && _GridX?.RootTable != null)
            {
                var r=_GridX?.ShowFieldChooser(this.FindForm(), "انتخـاب ستون هــا", _GridX.RootTable,true);
                
                r.Closed += (o, args) =>
                {
                    
                    this.SaveSetting();
                };
            }
            
        }

        private void ms_Settings_Click(object sender, EventArgs e)
        {
            if(_GridX==null)
                return;

            var frm=new Form_ColumnSetting(_GridX);
            frm.TopMost = true;
            frm.Show(this);
            frm.Closed += (o, args) =>
            {
                if(_GridX.SaveSettings)
                    this.SaveSetting();
            };
        }

        private void ms_saveSettings_Click(object sender, EventArgs e)
        {
            this.SaveSetting();

            new Form_Notify2("تنظیمات","تغییرات جدول با موفقیت ذخیره شد.",Form_Notify2.FarsiMessageBoxIcon.چـک_باکس)
                .Popup(Form_Notify2.Direction_Show.Right_To_Left,1500);

        }

        private void ms_ResetSetting_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا برای حذف تنظیمات مطمئنید؟","هشدار حذف",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _GridX?.ResetComponentSettings();
                this.SaveSetting();
            }
        }
    }
}
