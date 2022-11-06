using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Janus.Windows.GridEX;
using MS_Control.Controls;
namespace MS_Control
{
    public static class MS_Extention
    {
        public static void MS_Tanzim_Format_String(this MS_GridX DataGrid,string Format_String,
            params object[] List_Columns)
        {
            foreach (var col in List_Columns)
                if (col is string)
                    DataGrid.RootTable.Columns[(string)col].FormatString = Format_String;
                else if (col is int)
                    DataGrid.RootTable.Columns[(int)col].FormatString = Format_String;
        }
        
        public static void MS_Tanzim_Format_String_Total_Row(this MS_GridX DataGrid,
            string Format_String, params object[] List_Columns)
        {
            foreach (var col in List_Columns)
                if (col is string)
                    DataGrid.RootTable.Columns[(string)col].TotalFormatString = Format_String;
                else if (col is int)
                    DataGrid.RootTable.Columns[(int)col].TotalFormatString = Format_String;
        }
        
        public static void MS_Tanzim_Aggregation_Total_Row(this MS_GridX DataGrid,
             AggregateFunction Aggregation, params object[] List_Columns)
        {
            foreach (var col in List_Columns)
                if (col is string)
                    DataGrid.RootTable.Columns[(string)col].AggregateFunction = Aggregation;
                else if (col is int)
                    DataGrid.RootTable.Columns[(int)col].AggregateFunction = Aggregation;
        }

        public static void MS_Tanzim_Text_Align_Columns(this MS_GridX DataGrid,
             TextAlignment Alignment,params object[] List_Columns)
        {
            foreach (var col in List_Columns)
                if (col is string)
                    DataGrid.RootTable.Columns[(string)col].TextAlignment = Alignment;
                else if (col is int)
                    DataGrid.RootTable.Columns[(int)col].TextAlignment = Alignment;
        }

        public static void MS_Tanzim_Hide_Kardan_Columns(this MS_GridX DataGrid, params object[] List_Columns)
        {
            foreach (var col in List_Columns)
                if (col is string)
                    DataGrid.RootTable.Columns[(string)col].Visible = false;
                else if (col is int)
                    DataGrid.RootTable.Columns[(int)col].Visible = false;
        }
        public static void MS_Move_To_Last_Row(this MS_GridX DataGrid)
        {
            if (DataGrid.RowCount <= 0) return;
            DataGrid.Row = DataGrid.RowCount - 1 < 0 ? 0 : DataGrid.RowCount - 1;
            DataGrid.Col = 0;
        }

        public static void MS_Move_To_Row(this MS_GridX DataGrid, int Row_Index)
        {
            if (DataGrid.RowCount <= 0) return;
            DataGrid.Row = DataGrid.RowCount > Row_Index ? (Row_Index < 0 ? 0 : Row_Index) : DataGrid.RowCount - 1;
            DataGrid.Col = 0;
        }
        public static void MS_Active_Kardan_Filter(this MS_GridX DataGrid)
        {
            if (DataGrid.RootTable == null) return;
            foreach (GridEXColumn col in DataGrid.RootTable.Columns)
            {
                col.EditType = EditType.TextBox;
                col.FilterRowComparison = ConditionOperator.Contains;
            }
        }



        public static void MSZ_ForEach_With_Index<T>(this IEnumerable<T> My_List, Action<T, int> My_Method)
        {
            int index = 0;
            foreach (T item in My_List)
                My_Method(item, index++);
        }
        public static void MSZ_ForEach_Start_Index<T>(this IEnumerable<T> My_List, int Start_Index, Action<T, int> My_Method)
        {
            int index = 0;
            foreach (T item in My_List)
                if (index < Start_Index)
                    index++;
                else
                    My_Method(item, index++);
        }
        public static void MSZ_ForEach<T>(this IEnumerable<T> My_List, Action<T> My_Method)
        {
            foreach (T item in My_List)
                My_Method(item);
        }

        public static EntitySet<T> MS_To_EntitySet<T>(this IEnumerable<T> My_List) where T : class
        {
            var EntSet = new EntitySet<T>();
            EntSet.AddRange(My_List);
            return EntSet;
        }

        public static DataTable MS_To_DataTable<T>(this IEnumerable<T> source)
        {
            DataTable table = new DataTable();

            //// get properties of T 
            var binding = BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty;
            var options = PropertyReflectionOptions.IgnoreEnumerable | PropertyReflectionOptions.IgnoreIndexer;

            var properties = ReflectionExtensions.GetProperties<T>(binding, options).ToList();

            //// create table schema based on properties 
            foreach (var property in properties)
            {
                //table.Columns.Add(property.Name, property.PropertyType);
                table.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
            }

            //// create table data from T instances 
            object[] values = new object[properties.Count];

            foreach (T item in source)
            {
                for (int i = 0; i < properties.Count; i++)
                {
                    //values[i] = properties[i].GetValue(item, null);
                    values[i] = properties[i].GetValue(item,null )?? DBNull.Value;
                }

                table.Rows.Add(values);
            }

            return table;
        }


    }
}
