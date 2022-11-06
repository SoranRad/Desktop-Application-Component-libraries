using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Janus.Windows.GridEX;

namespace MS_Control
{
    public class MS_Tanzim_Janus_Grid
    {
        public static void Tanzim_Format_String(string Format_String, Janus.Windows.GridEX.GridEX DataGrid,
            params object[] List_Columns)
        {
            foreach (var col in List_Columns)
                if (col is string)
                    DataGrid.RootTable.Columns[(string)col].FormatString = Format_String;
                else if (col is int)
                    DataGrid.RootTable.Columns[(int)col].FormatString = Format_String;
        }

        public static void Tanzim_Format_String_Total_Row(string Format_String, Janus.Windows.GridEX.GridEX DataGrid,
            params object[] List_Columns)
        {
            foreach (var col in List_Columns)
                if (col is string)
                    DataGrid.RootTable.Columns[(string)col].TotalFormatString = Format_String;
                else if (col is int)
                    DataGrid.RootTable.Columns[(int)col].TotalFormatString = Format_String;
        }

        public static void Tanzim_Aggregation_Total_Row(Janus.Windows.GridEX.AggregateFunction Aggregation,
            Janus.Windows.GridEX.GridEX DataGrid, params object[] List_Columns)
        {
            foreach (var col in List_Columns)
                if (col is string)
                    DataGrid.RootTable.Columns[(string)col].AggregateFunction = Aggregation;
                else if (col is int)
                    DataGrid.RootTable.Columns[(int)col].AggregateFunction = Aggregation;
        }

        public static void Tanzim_Text_Align_Columns(Janus.Windows.GridEX.TextAlignment Alignment,
            Janus.Windows.GridEX.GridEX DataGrid, params object[] List_Columns)
        {
            foreach (var col in List_Columns)
                if (col is string)
                    DataGrid.RootTable.Columns[(string)col].TextAlignment = Alignment;
                else if (col is int)
                    DataGrid.RootTable.Columns[(int)col].TextAlignment = Alignment;
        }

        public static void Tanzim_Hide_Kardan_Columns(Janus.Windows.GridEX.GridEX DataGrid, params object[] List_Columns)
        {
            foreach (var col in List_Columns)
                if (col is string)
                    DataGrid.RootTable.Columns[(string)col].Visible = false;
                else if (col is int)
                    DataGrid.RootTable.Columns[(int)col].Visible = false;
        }

        public static void Move_To_Last_Row(Janus.Windows.GridEX.GridEX DataGrid)
        {
            if (DataGrid.RowCount <= 0) return;
            DataGrid.Row = DataGrid.RowCount - 1 < 0 ? 0 : DataGrid.RowCount - 1;
            DataGrid.Col = 0;
        }

        public static void Move_To_Row(Janus.Windows.GridEX.GridEX DataGrid, int Row_Index)
        {
            if (DataGrid.RowCount <= 0) return;
            DataGrid.Row = DataGrid.RowCount > Row_Index ? (Row_Index < 0 ? 0 : Row_Index) : DataGrid.RowCount - 1;
            DataGrid.Col = 0;
        }

        public static void Active_Kardan_Filter(GridEX DataGrid)
        {
            if(DataGrid.RootTable==null)return;
            foreach (GridEXColumn col in DataGrid.RootTable.Columns)
            {
                col.EditType = EditType.TextBox;
                col.FilterRowComparison=ConditionOperator.Contains;
            }
        }
    }
}
