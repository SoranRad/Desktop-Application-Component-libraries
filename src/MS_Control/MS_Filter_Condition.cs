using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using MS_Control;


namespace MS_Control
{
    public partial class MS_Filter_Condition : UserControl
    {
        #region فیلد
        private static int Height_Increase = -1;
        private List<GridEXColumn> _Column_List;
        private GridEXColumnCollection _Column_Colection;
        #endregion
        #region پراپرتی
        [Browsable(true)]
        public bool MS_Is_Last
        {
            set
            {
                if (value)
                {
                    ms_horiz_line.Height = 27;
                    ms_horiz_line.Top = -1;
                    ms_horiz_line.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                }
                else
                {
                    ms_horiz_line.Height = this.Height + 10;
                    ms_horiz_line.Top = 0;
                    ms_horiz_line.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                }
            }
        }
        [Browsable(true)]
        public bool MS_Is_Mother
        {
            get { return !ms_horiz_line.Visible; }
            set
            {
                if (value)
                {
                    ms_horiz_line.Visible = ms_ver_line.Visible =
                        pictureBox1.Visible = ms_logical_operate.Visible =
                            ms_remove_filter.Visible = false;
                    ms_Group_Control.Width = this.Width - 10;
                }
                else
                {
                    ms_horiz_line.Visible = ms_ver_line.Visible =
                        pictureBox1.Visible = ms_logical_operate.Visible =
                            ms_remove_filter.Visible = true;
                    ms_Group_Control.Width = ms_logical_operate.Left - 4;
                }
            }
        }
        #endregion
        #region متد
        //=======static
        public void MS_Load_Column(GridEXColumnCollection Col_List)
        {
            if(Col_List!=null)
                _Column_List = Col_List.OfType<GridEXColumn>().Where(x => x.Visible).ToList();
            _Column_Colection = Col_List;
        }
        public static bool Is_Type_Numeric(TypeCode Col_Type)
        {
            switch (Col_Type)
            {
                case TypeCode.SByte:
                case TypeCode.Byte:
                case TypeCode.Int16:
                case TypeCode.UInt16:
                case TypeCode.Int32:
                case TypeCode.UInt32:
                case TypeCode.Int64:
                case TypeCode.UInt64:
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Decimal:
                    return true;
                default:
                    return false;
            }
        }
        public static GridEXFilterCondition Get_Filter_Condition(MS_Filter_Condition Filter_Control)
        {
            if (Filter_Control == null) return null;
            var filter = new GridEXFilterCondition();

            filter.Column = ((GridEXColumn)Filter_Control.ms_columns.SelectedItem.DataRow);
            //===============================
            //if (!Filter_Control.MS_Is_Mother)
            //    filter.LogicalOperator=Filter_Control.ms_logical_operate.SelectedIndex==0
            //        ?LogicalOperator.And
            //        : LogicalOperator.Or;
            //else filter.LogicalOperator=LogicalOperator.None;

            //===============================
            if (Filter_Control.ms_operate_numeric.Visible)
            {
                switch (Filter_Control.ms_operate_numeric.SelectedIndex)
                {
                    case 0:
                        filter.ConditionOperator = ConditionOperator.Equal;
                        break;
                    case 1:
                        filter.ConditionOperator = ConditionOperator.NotEqual;
                        break;
                    case 2:
                        filter.ConditionOperator = ConditionOperator.GreaterThan;
                        break;
                    case 3:
                        filter.ConditionOperator = ConditionOperator.GreaterThanOrEqualTo;
                        break;
                    case 4:
                        filter.ConditionOperator = ConditionOperator.LessThan;
                        break;
                    case 5:
                        filter.ConditionOperator = ConditionOperator.LessThanOrEqualTo;
                        break;
                    case 6:
                        filter.ConditionOperator = ConditionOperator.Between;
                        filter.Value2 = Filter_Control.ms_val_or_col.Checked
                    ? null
                    : (object)Filter_Control.ms_number_2.MS_Decimal;

                        filter.ValueColumn2 = Filter_Control.ms_val_or_col.Checked
                    ? ((GridEXColumn)Filter_Control.ms_col_2.SelectedItem.DataRow)
                    : null;
                        break;
                }

                filter.Value1 = Filter_Control.ms_val_or_col.Checked
                    ? null
                    : (object)Filter_Control.ms_number_1.MS_Decimal;

                filter.ValueColumn1 = Filter_Control.ms_val_or_col.Checked
                    ? ((GridEXColumn)Filter_Control.ms_col_1.SelectedItem.DataRow)
                    : null;
            }
            else if (Filter_Control.ms_operate_string.Visible)
            {
                switch (Filter_Control.ms_operate_string.SelectedIndex)
                {
                    case 0:
                        filter.ConditionOperator = ConditionOperator.Contains;
                        break;
                    case 1:
                        filter.ConditionOperator = ConditionOperator.NotContains;
                        break;
                    case 2:
                        filter.ConditionOperator = ConditionOperator.Equal;
                        break;
                    case 3:
                        filter.ConditionOperator = ConditionOperator.NotEqual;
                        break;
                    case 4:
                        filter.ConditionOperator = ConditionOperator.BeginsWith;
                        break;
                    case 5:
                        filter.ConditionOperator = ConditionOperator.EndsWith;
                        break;
                    case 6:
                        filter.ConditionOperator = ConditionOperator.IsEmpty;
                        break;
                    case 7:
                        filter.ConditionOperator = ConditionOperator.NotIsEmpty;
                        break;
                }
                filter.Value1 = Filter_Control.ms_val_or_col.Checked
                    ? null
                    : (object)Filter_Control.ms_text_val1.Text;

                filter.ValueColumn1 = Filter_Control.ms_val_or_col.Checked
                    ? ((GridEXColumn)Filter_Control.ms_col_1.SelectedItem.DataRow)
                    : null;
            }
            else if (Filter_Control.ms_operate_bool.Visible)
            {
                switch (Filter_Control.ms_operate_string.SelectedIndex)
                {
                    case 0:
                        filter.ConditionOperator = ConditionOperator.Equal;
                        break;
                    case 1:
                        filter.ConditionOperator = ConditionOperator.NotEqual;
                        break;
                }
                filter.Value1 = Filter_Control.ms_val_or_col.Checked
                    ? null
                    : (object)Filter_Control.ms_tick_1.Checked;

                filter.ValueColumn1 = Filter_Control.ms_val_or_col.Checked
                    ? ((GridEXColumn)Filter_Control.ms_col_1.SelectedItem.DataRow)
                    : null;
            }
            //===============================================================

            Filter_Control.ms_Group_Control.Controls.OfType<MS_Filter_Condition>()
                .MSZ_ForEach(sub_filter =>
                {
                    filter.AddCondition(
                        sub_filter.ms_logical_operate
                            .SelectedIndex == 0
                                ? LogicalOperator.And
                                    : LogicalOperator.Or,
                                        Get_Filter_Condition(sub_filter));
                });

            return filter;
        }
        //========private
        private void Increase_Parents(Control Parent_Controls, MS_Filter_Condition Current)
        {
            if (Parent_Controls == null || Parent_Controls is Form)
                return;

            Parent_Controls.Parent.Height += Height_Increase;

            var list = Parent_Controls.Controls.OfType<MS_Filter_Condition>().ToList();
            var start = list.IndexOf(Current);
            if (start + 1 < list.Count)
                list.MSZ_ForEach_Start_Index(start + 1, (x, item) =>
                {
                    x.Top += Height_Increase;

                });

            if (Parent_Controls is UIGroupBox && Parent_Controls.Parent != null)
                Increase_Parents(Parent_Controls.Parent.Parent, Parent_Controls.Parent as MS_Filter_Condition);
        }
        private void Decrease_Parents(Control Parent_Controls, MS_Filter_Condition Current_Del, int Height_Decrease)
        {
            if (Parent_Controls == null || Parent_Controls is Form)
                return;

            Parent_Controls.Parent.Height -= Height_Decrease;
            var list = Parent_Controls.Controls.OfType<MS_Filter_Condition>().ToList();
            var start = list.IndexOf(Current_Del);
            if (start + 1 < list.Count)
                list.MSZ_ForEach_Start_Index(start + 1, (x, item) =>
                {
                    x.Top -= Height_Decrease;
                });
            if (Parent_Controls is UIGroupBox && Parent_Controls.Parent != null)
                Decrease_Parents(Parent_Controls.Parent.Parent, Parent_Controls.Parent as MS_Filter_Condition, Height_Decrease);
        }
        private void Load_Columns_In_Comboes()
        {
            if(_Column_List==null)
                return;
            var list = _Column_List.Select(x => new UIComboBoxItem()
            {
                DataRow = x,
                Text = x.Caption,
                Value = x.Key,
            });
            //===================
            ms_columns.Items.Clear();
            ms_col_1.Items.Clear();
            ms_col_2.Items.Clear();


            ms_columns.Items.AddRange(list.ToArray());
            ms_col_1.Items.AddRange(list.ToArray());
            ms_col_2.Items.AddRange(list.ToArray());
        }
        private void Refresh_Control_Columns()
        {
            if (ms_columns.SelectedItem == null)
                return;
            var type = ((GridEXColumn)ms_columns.SelectedItem.DataRow).DataTypeCode;

            ms_operate_bool.Hide();
            ms_operate_numeric.Hide();
            ms_operate_string.Hide();

            ms_text_val1.Hide();
            ms_number_1.Hide();
            ms_number_2.Hide();
            ms_tick_1.Hide();
            ms_col_1.Hide();
            ms_col_2.Hide();


            if (Is_Type_Numeric(type))
            {
                ms_operate_numeric.Show();
                ms_number_1.Visible = !ms_val_or_col.Checked;
                ms_col_1.Visible = ms_val_or_col.Checked;

                if (ms_operate_numeric.Visible && ms_operate_numeric.SelectedIndex == 6)
                {
                    ms_col_1.Left = ms_number_1.Left = 193;
                    ms_col_1.Width = ms_number_1.Width = 114;
                    ms_col_2.Visible = ms_val_or_col.Checked;
                    ms_number_2.Visible = !ms_val_or_col.Checked;
                }
                else
                {
                    ms_col_1.Left = ms_number_1.Left = 69;
                    ms_col_1.Width = ms_number_1.Width = 238;
                    ms_col_2.Visible = false;
                    ms_number_2.Visible = false;
                }
            }
            else if (type == TypeCode.Char || type == TypeCode.String || type == TypeCode.DBNull
                || type == TypeCode.DateTime || type == TypeCode.Empty || type == TypeCode.Object)
            {
                ms_operate_string.Show();
                ms_text_val1.Visible = !ms_val_or_col.Checked;
                ms_col_1.Visible = ms_val_or_col.Checked;

                if (type == TypeCode.Char)
                    ms_text_val1.MaxLength = 1;
                else
                    ms_text_val1.MaxLength = 32767;
            }
            else if (type == TypeCode.Boolean)
            {
                ms_operate_bool.Show();
                ms_tick_1.Visible = !ms_val_or_col.Checked;
                ms_col_1.Visible = ms_val_or_col.Checked;
            }

        }
        //========public
        public void MS_Refresh_Kardan_Control(GridEXColumnCollection Col_List)
        {
            MS_Load_Column(Col_List);
            Load_Columns_In_Comboes();

            ms_logical_operate.SelectedIndex = ms_operate_numeric.SelectedIndex =
                ms_operate_bool.SelectedIndex = ms_operate_string.SelectedIndex
                    = 0;
        }
        public void MS_Load_Filter_Dar_Control(GridEXFilterCondition Filter)
        {
            ms_columns.SelectedIndex = _Column_List.IndexOf(Filter.Column);
            
            
            ms_logical_operate.SelectedIndex = Filter.LogicalOperator == LogicalOperator.And ? 0 : 1;
            switch (Filter.ConditionOperator)
            {
                case ConditionOperator.Equal:
                    ms_operate_numeric.SelectedIndex =
                    ms_operate_bool.SelectedIndex = 0;
                    ms_operate_string.SelectedIndex = 2;
                    break;
                case ConditionOperator.NotEqual:
                    ms_operate_numeric.SelectedIndex = 1;
                    ms_operate_bool.SelectedIndex = 1;
                    ms_operate_string.SelectedIndex = 3;
                    break;
                case ConditionOperator.GreaterThan:
                    ms_operate_numeric.SelectedIndex = 2;
                    ms_operate_bool.SelectedIndex = -1;
                    ms_operate_string.SelectedIndex = -1;
                    break;
                case ConditionOperator.LessThan:
                    ms_operate_numeric.SelectedIndex = 4;
                    ms_operate_bool.SelectedIndex = -1;
                    ms_operate_string.SelectedIndex = -1;
                    break;
                case ConditionOperator.GreaterThanOrEqualTo:
                    ms_operate_numeric.SelectedIndex = 3;
                    ms_operate_bool.SelectedIndex = -1;
                    ms_operate_string.SelectedIndex = -1;
                    break;
                case ConditionOperator.LessThanOrEqualTo:
                    ms_operate_numeric.SelectedIndex = 5;
                    ms_operate_bool.SelectedIndex = -1;
                    ms_operate_string.SelectedIndex = -1;
                    break;
                case ConditionOperator.Between:
                    ms_operate_numeric.SelectedIndex = 4;
                    ms_operate_bool.SelectedIndex = -1;
                    ms_operate_string.SelectedIndex = -1;
                    break;
                case ConditionOperator.NotBetween:
                    break;
                case ConditionOperator.Contains:
                    ms_operate_numeric.SelectedIndex = -1;
                    ms_operate_bool.SelectedIndex = -1;
                    ms_operate_string.SelectedIndex = 0;
                    break;
                case ConditionOperator.NotContains:
                    break;
                case ConditionOperator.BeginsWith:
                    ms_operate_numeric.SelectedIndex = -1;
                    ms_operate_bool.SelectedIndex = -1;
                    ms_operate_string.SelectedIndex = 4;
                    break;
                case ConditionOperator.EndsWith:
                    ms_operate_numeric.SelectedIndex = -1;
                    ms_operate_bool.SelectedIndex = -1;
                    ms_operate_string.SelectedIndex = 5;
                    break;
                case ConditionOperator.IsNull:
                    ms_operate_numeric.SelectedIndex = -1;
                    ms_operate_bool.SelectedIndex = -1;
                    ms_operate_string.SelectedIndex = 6;
                    break;
                case ConditionOperator.NotIsNull:
                    break;
                case ConditionOperator.IsEmpty:
                    ms_operate_numeric.SelectedIndex = -1;
                    ms_operate_bool.SelectedIndex = -1;
                    ms_operate_string.SelectedIndex = 6;
                    break;
                case ConditionOperator.NotIsEmpty:
                    break;
                case ConditionOperator.In:
                    break;
                case ConditionOperator.NotIn:
                    break;
            }
            if (Filter.Value1 != null)
            {
                if (Is_Type_Numeric(Filter.Column.DataTypeCode))
                {
                    decimal tmp;
                    ms_number_1.MS_Decimal = decimal.TryParse(Filter.Value1.ToString(), out tmp) ? tmp : 0;
                    if (Filter.Value2 != null)
                        ms_number_2.MS_Decimal = decimal.TryParse(Filter.Value2.ToString(), out tmp) ? tmp : 0;
                }
                else if (Filter.Column.DataTypeCode == TypeCode.Char || Filter.Column.DataTypeCode == TypeCode.String
                    || Filter.Column.DataTypeCode == TypeCode.Object)
                    ms_text_val1.Text = Filter.Value1.ToString();
                else if (Filter.Column.DataTypeCode == TypeCode.Boolean)
                {
                    bool tmp;
                    ms_tick_1.Checked = bool.TryParse(Filter.Value1.ToString(), out tmp) ? tmp : false;
                }
            }
            else if (Filter.ValueColumn1 != null)
            {
                ms_col_1.SelectedIndex = _Column_List.IndexOf(Filter.ValueColumn1);
                ms_col_2.SelectedIndex = Filter.ValueColumn2 != null
                    ? _Column_List.IndexOf(Filter.ValueColumn2)
                    : -1;
            }
            //================ Add Control
            Filter.Conditions.Cast<GridEXFilterCondition>()
                .MSZ_ForEach(x =>
                {
                    ms_add_filter.PerformClick();
                });
            //================ Load Filter
            var list_filter = Filter.Conditions.Cast<GridEXFilterCondition>().ToList();
            ms_Group_Control.Controls.OfType<MS_Filter_Condition>()
                .MSZ_ForEach_With_Index((item, index) =>
                {
                    item.MS_Load_Filter_Dar_Control(list_filter[index]);
                });
        }
        public void MS_Clear_Condition()
        {
            ms_Group_Control.Controls.OfType<MS_Filter_Condition>()
                .MSZ_ForEach(x =>
                {
                    x.ms_remove_filter.PerformClick();
                });
        }
        #endregion
        public MS_Filter_Condition()
        {
            InitializeComponent();
            Height_Increase = Height_Increase <= 0 ? Height : Height_Increase;
        }
        //=======================Events
        private void ms_add_filter_Click(object sender, EventArgs e)
        {
            Increase_Parents(this.Parent, this);
            Height += Height_Increase;

            var last = ms_Group_Control.Controls.OfType<MS_Filter_Condition>().LastOrDefault();

            var new_one = new MS_Filter_Condition();
            new_one.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            new_one.Width = ms_Group_Control.Width - 10;
            new_one.Left = 3;
            ms_Group_Control.Controls.Add(new_one);

            new_one.Top = last == null ? 45 : last.Top + last.Height;
            new_one.MS_Refresh_Kardan_Control(_Column_Colection);

            ms_Group_Control.Controls.OfType<MS_Filter_Condition>().MSZ_ForEach(item => { item.MS_Is_Last = false; });
            new_one.MS_Is_Last = true;
        }
        private void ms_columns_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh_Control_Columns();
        }
        private void ms_operate_numeric_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh_Control_Columns();
        }
        private void ms_val_or_col_CheckedChanged(object sender, EventArgs e)
        {
            Refresh_Control_Columns();
        }
        private void ms_remove_filter_Click(object sender, EventArgs e)
        {
            if (this.MS_Is_Mother)
                return;

            if (Parent == null)
                return;
            Decrease_Parents(this.Parent, this, this.Height);
            Parent.Controls.Remove(this);
        }
        private void ms_Group_Control_ControlRemoved(object sender, ControlEventArgs e)
        {
            ms_Group_Control.Controls.OfType<MS_Filter_Condition>().MSZ_ForEach(item => { item.MS_Is_Last = false; });
            var last = ms_Group_Control.Controls.OfType<MS_Filter_Condition>().LastOrDefault();
            if (last != null)
                last.MS_Is_Last = true;
        }
    }
}
