using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using MS_Control;
using MS_Control.Controls;
using Stimulsoft.Base;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Events;
using System.Reflection;
using MS_Control.MS_Print_GridEX;

namespace MS_Grid_Print
{
    public partial class Form_List : MS_Mother_Two
    {
        public Form_List(MS_GridX Grid)
        {
            InitializeComponent();
            _GridEX = Grid;
            ms_GridColumns.FilterMode = FilterMode.None;
            NzSelectorRows.Visible = _GridEX.RootTable.Columns.OfType<GridEXColumn>().Any(x => x.ActAsSelector);
        }

        #region فیلد
        private double          _Width          = 0, 
                                _Height         = 0, 
                                _Margin         = 5;
        private const double    PIXEL_TO_MM     = 0.264583;
        private DataTable       _DataTable      = null;
        private MS_GridX        _GridEX;
        private bool            _Do_Refresh     = true;
        private 
          IEnumerable<NzColumn> _ListColumns    = new List<NzColumn>();
        private StiReport       Report;
        private string          _TempFile;
        #endregion      
        #region پراپرتی
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
        public Image MS_Logo { get; set; }
        #endregion
        #region متد

        private static DataTable     ToDataTable<T>         (List<T> items, List<string> ColListDatamember)
        {
            var tt = items.First().GetType();
            DataTable dataTable = new DataTable(tt.Name);

            //Get all the properties
            PropertyInfo[] Props = tt
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(x => ColListDatamember.Contains(x.Name))
                .ToArray();
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
        private StiTextHorAlignment  Cell_Text_Aligment     (GridEXColumn Col)
        {
            var align = Col.CellStyle.TextAlignment == TextAlignment.Empty
                            ? Col.TextAlignment
                            : Col.CellStyle.TextAlignment;

           
            switch (align)
            {
                case TextAlignment.Empty:
                    return StiTextHorAlignment.Left;
                case TextAlignment.Near:
                    return StiTextHorAlignment.Left;
                case TextAlignment.Center:
                    return StiTextHorAlignment.Center;
                case TextAlignment.Far:
                    return StiTextHorAlignment.Right;
            }
            return StiTextHorAlignment.Left;
        }
        private StiVertAlignment     Cell_Line_Alignment    (GridEXColumn Col)
        {
            if (Col.CellStyle.LineAlignment==TextAlignment.Empty)
                return StiVertAlignment.Center;
            switch (Col.CellStyle.LineAlignment)
            {
                case TextAlignment.Empty:
                    return StiVertAlignment.Center;
                case TextAlignment.Near:
                    return StiVertAlignment.Top;
                case TextAlignment.Center:
                    return StiVertAlignment.Center;
                case TextAlignment.Far:
                    return StiVertAlignment.Bottom;
            }
            return StiVertAlignment.Center;
        }

        private void    RefetchGrid                         ()
        {
            var listChecked = ms_GridColumns
                .GetCheckedRows()
                .Select(x => x.DataRow as NzColumn)
                .ToList();

            ms_GridColumns.Refetch();

            ms_GridColumns
                .GetDataRows()
                .MSZ_ForEach(x =>
                {
                    x.IsChecked = listChecked.Contains(x.DataRow);
                });
        }

        private string  Get_Col_Aggregation                 (GridEXColumn Col)
        {
            switch (Col.AggregateFunction)
            {
                case AggregateFunction.None:
                    return string.Empty;
                case AggregateFunction.Count:
                    return "Count";
                case AggregateFunction.Sum:
                    return "Sum";
                case AggregateFunction.Average:
                    return "Avg";
                case AggregateFunction.Min:
                    return "Min";
                case AggregateFunction.Max:
                    return "Max";
                case AggregateFunction.StdDeviation:
                    return "Median";
                case AggregateFunction.ValueCount:
                    return "CountDistinct";
                default:
                    return string.Empty;
            }
        }
        private string  Get_Head_Aggregation                (GridEXGroupHeaderTotal Head)
        {
            switch (Head.AggregateFunction)
            {
                case AggregateFunction.None:
                    return string.Empty;
                case AggregateFunction.Count:
                    return "Count";
                case AggregateFunction.Sum:
                    return "Sum";
                case AggregateFunction.Average:
                    return "Avg";
                case AggregateFunction.Min:
                    return "Min";
                case AggregateFunction.Max:
                    return "Max";
                case AggregateFunction.StdDeviation:
                    return "Median";
                case AggregateFunction.ValueCount:
                    return "CountDistinct";
                default:
                    return string.Empty;
            }
        }
        private void    Set_Page_Size                       ()
        {
            if (ms_paper_size.SelectedIndex == 0)
            {
                if (ms_landscape.SelectedIndex == 0)
                {
                    _Height = 297;
                    _Width = 210;
                }
                else
                {
                    _Height = 210;
                    _Width = 297;
                }
            }
            else
            {
                if (ms_landscape.SelectedIndex == 1)
                {
                    _Height = 148;
                    _Width = 210;
                }
                else
                {
                    _Height = 210;
                    _Width = 148;
                }
            }
            if (ms_page_segment.Checked)
            {
                var item2 = ms_GridColumns
                    .GetCheckedRows()
                    .Select(x => (x.DataRow as NzColumn).Width)
                    .Sum();

                var Grid_Width = Convert.ToInt32(Math.Round(
                    item2
                    * PIXEL_TO_MM)

                    );

                var math = Math.Ceiling(Grid_Width / _Width);
                _Width *= Convert.ToInt32(math);
            }

        }

        private void    Create_Header                       (StiPage Page1)
        {
            #region Header

            var PageHeaderBand1 = new StiPageHeaderBand();
            //PageHeaderBand1.ClientRectangle = new RectangleD(0, 4, _Width - _Margin, 16);
            PageHeaderBand1.Height = 16;
            PageHeaderBand1.Name = "PageHeaderBand1";
            PageHeaderBand1.Border = new StiBorder(StiBorderSides.Bottom, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            PageHeaderBand1.Brush = new StiSolidBrush(Color.WhiteSmoke);
            PageHeaderBand1.Guid = null;
            PageHeaderBand1.Interaction = null;
            PageHeaderBand1.Page = Page1;
            PageHeaderBand1.Parent = Page1;

            Page1.Components.Add(PageHeaderBand1);
            //=========
            var Text8 = new StiText();
            Text8.ClientRectangle = new RectangleD(30, 0, (_Width - _Margin*Page1.SegmentPerWidth) - 80, 6);
            //Text8.Guid = "1830a05120704c0e896aa78ae718ab83";
            Text8.HorAlignment = StiTextHorAlignment.Center;
            Text8.Name = "Text8";
            Text8.Text.Value = MS_Company_Name;
            Text8.Type = StiSystemTextType.Expression;
            Text8.VertAlignment = StiVertAlignment.Center;
            Text8.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            Text8.Brush = new StiSolidBrush(Color.Transparent);
            Text8.Font = new Font("IRANSans(FaNum) Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Text8.Indicator = null;
            Text8.Interaction = null;
            Text8.Margins = new StiMargins(0, 0, 0, 0);
            Text8.TextBrush = new StiSolidBrush(Color.Black);
            Text8.TextOptions = new StiTextOptions(true, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, StringTrimming.None);
            Text8.Page = Page1;
            Text8.Parent = PageHeaderBand1;
            Text8.TextQuality = StiTextQuality.Typographic;
            //===========
            var Text5 = new StiText();
            Text5.ClientRectangle = new RectangleD(30, 6, (_Width - _Margin) - 80, 6);
            //Text5.Guid = "717962600c54406eb7056b09b71d53b6";
            Text5.HorAlignment = StiTextHorAlignment.Center;
            Text5.Name = "Text5";
            Text5.Text.Value = MS_Report_Name;
            Text5.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            Text5.VertAlignment = StiVertAlignment.Center;
            Text5.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            Text5.Brush = new StiSolidBrush(Color.Transparent);
            Text5.Font = new Font("IRANSans(FaNum) Medium", 9F);
            Text5.Indicator = null;
            Text5.Interaction = null;
            Text5.Margins = new StiMargins(0, 0, 0, 0);
            Text5.TextBrush = new StiSolidBrush(Color.Black);
            Text5.TextOptions = new StiTextOptions(true, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, StringTrimming.None);
            Text5.Page = Page1;
            Text5.Parent = PageHeaderBand1;
            Text5.TextQuality = StiTextQuality.Typographic;

            //===========
            var Text1 = new StiText();
            Text1.ClientRectangle = new RectangleD(_Width - (_Margin * Page1.SegmentPerWidth*2) - 10, 0, 10, 6);
            Text1.Guid = "b65ac7fd0ee049b086a08817d4a66bf1";
            Text1.HorAlignment = StiTextHorAlignment.Right;
            Text1.Name = "Text1";
            Text1.OnlyText = true;
            Text1.Text.Value = "تاریخ";
            Text1.Type = StiSystemTextType.Expression;
            Text1.VertAlignment = StiVertAlignment.Center;
            Text1.Border = new StiBorder(((StiBorderSides.None | StiBorderSides.Left) | StiBorderSides.Bottom), Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            Text1.Brush = new StiSolidBrush(Color.Transparent);
            Text1.Font = new Font("IRANSans(FaNum)", 9F);
            Text1.Indicator = null;
            Text1.Interaction = null;
            Text1.Margins = new StiMargins(0, 0, 0, 0);
            Text1.TextBrush = new StiSolidBrush(Color.Black);
            Text1.TextOptions = new StiTextOptions(true, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, StringTrimming.None);
            Text1.Page = Page1;
            Text1.Parent = PageHeaderBand1;
            Text1.TextQuality = StiTextQuality.Typographic;

            //=================
            var Text2 = new StiText();
            Text2.ClientRectangle = new RectangleD(_Width - (_Margin * Page1.SegmentPerWidth * 2) - 10, 6, 10, 6);
            Text2.Guid = "e17602525b134e4ba9aacd25b55dbd24";
            Text2.HorAlignment = StiTextHorAlignment.Right;
            Text2.Name = "Text2";
            Text2.OnlyText = true;
            Text2.Text.Value = "کاربر";
            Text2.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            Text2.VertAlignment = StiVertAlignment.Center;
            Text2.Border = new StiBorder(StiBorderSides.Left, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            Text2.Brush = new StiSolidBrush(Color.Transparent);
            Text2.Font = new Font("IRANSans(FaNum)", 9F);
            Text2.Indicator = null;
            Text2.Interaction = null;
            Text2.Margins = new StiMargins(0, 0, 0, 0);
            Text2.TextBrush = new StiSolidBrush(Color.Black);
            Text2.TextOptions = new StiTextOptions(true, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, StringTrimming.None);
            Text2.Page = Page1;
            Text2.Parent = PageHeaderBand1;
            Text2.TextQuality = StiTextQuality.Typographic;

            //==================
            var Text3 = new StiText();
            Text3.ClientRectangle = new RectangleD(_Width - (_Margin * Page1.SegmentPerWidth * 2) - 44, 0, 34, 6);
            //Text3.Guid = "2e0b5df8431047fe93a6ebe6e86af3c2";
            Text3.Name = "Text3";
            Text3.OnlyText = true;
            Text3.Text.Value = MS_Tarix_Report;
            Text3.Type = StiSystemTextType.Expression;
            Text3.VertAlignment = StiVertAlignment.Center;
            Text3.Border = new StiBorder(StiBorderSides.Bottom, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            Text3.Brush = new StiSolidBrush(Color.Transparent);
            Text3.Font = new Font("IRANSans(FaNum)", 9F);
            Text3.Indicator = null;
            Text3.Interaction = null;
            Text3.Margins = new StiMargins(0, 0, 0, 0);
            Text3.TextBrush = new StiSolidBrush(Color.Black);
            Text3.TextOptions = new StiTextOptions(true, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, StringTrimming.None);
            Text3.Page = Page1;
            Text3.Parent = PageHeaderBand1;
            Text3.TextQuality = StiTextQuality.Typographic;

            //====================
            var Text4 = new StiText();
            Text4.CanShrink = true;
            Text4.ClientRectangle = new RectangleD(_Width - (_Margin * Page1.SegmentPerWidth * 2) - 44, 6, 34, 6);
            //Text4.Guid = "87c2c0b6fb7141d39235b29a235052d4";
            Text4.Name = "Text4";
            Text4.OnlyText = true;
            Text4.Text.Value = MS_User_Name;
            Text4.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            Text4.VertAlignment = StiVertAlignment.Center;
            Text4.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            Text4.Brush = new StiSolidBrush(Color.Transparent);
            Text4.Font = new Font("IRANSans(FaNum)", 9F);
            Text4.Indicator = null;
            Text4.Interaction = null;
            Text4.Margins = new StiMargins(0, 0, 0, 0);
            Text4.TextBrush = new StiSolidBrush(Color.Black);
            Text4.TextOptions = new StiTextOptions(true, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, StringTrimming.None);
            Text4.Page = Page1;
            Text4.Parent = PageHeaderBand1;
            Text4.TextQuality = StiTextQuality.Typographic;

            //=============================
            var Image1 = new StiImage();
            Image1.ClientRectangle = new RectangleD(0, 0, 26, 16);
            if (MS_Logo != null)
                Image1.Image = MS_Logo;
            Image1.Name = "Image1";
            Image1.Border = new StiBorder(((StiBorderSides.None | StiBorderSides.Left) | StiBorderSides.Bottom), Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            Image1.Brush = new StiSolidBrush(Color.Transparent);
            Image1.Margins = new StiMargins(0, 0, 0, 0);
            Image1.AspectRatio = true;
            Image1.Stretch = true;
            Image1.Page = Page1;
            Image1.Parent = PageHeaderBand1;
            //====================
            PageHeaderBand1.Components.Clear();
            PageHeaderBand1.Components.AddRange(new StiComponent[]
            {
                Text8, Text1, Text2, Text3, Text4, Text5, Image1
            });
            #endregion
        }
        private void    Create_Footer                       (StiPage Page1)
        {
            #region Footer

            var PageFooterBand1 = new StiPageFooterBand();
            //PageFooterBand1.ClientRectangle = new RectangleD(0, _Height - (2 * _Margin) - 6, _Width - (2 * _Margin), 6);
            PageFooterBand1.Height = 6;
            PageFooterBand1.Name = "PageFooterBand1";
            PageFooterBand1.Border = new StiBorder(StiBorderSides.Top, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            PageFooterBand1.Brush = new StiSolidBrush(Color.Silver);
            PageFooterBand1.Page = Page1;
            PageFooterBand1.Parent = Page1;
            Page1.Components.Add(PageFooterBand1);
            //==================
            var Text7 = new StiText();
            Text7.ClientRectangle = new RectangleD(0, 0, 38, 6);
            //Text7.Guid = "f9b7c218070d41479497d8d7df536091";
            Text7.HorAlignment = StiTextHorAlignment.Right;
            Text7.Name = "Text7";
            Text7.Text.Value = "صفحه {PageNumber} از {TotalPageCount}";
            Text7.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            Text7.VertAlignment = StiVertAlignment.Center;
            Text7.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            Text7.Brush = new StiSolidBrush(Color.Transparent);
            Text7.Font = new Font("IRANSans(FaNum) Medium", 9F);
            Text7.Indicator = null;
            Text7.Interaction = null;
            Text7.Margins = new StiMargins(0, 0, 0, 0);
            Text7.TextBrush = new StiSolidBrush(Color.Black);
            Text7.TextOptions = new StiTextOptions(true, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, StringTrimming.None);
            Text7.Page = Page1;
            Text7.Parent = PageFooterBand1;
            Text7.TextQuality = StiTextQuality.Typographic;

            //===================
            var Text6 = new StiText();
            Text6.ClientRectangle = new RectangleD(39, 0, _Width - (_Margin * Page1.SegmentPerWidth * 2) - 40, 6);
            //Text6.Guid = "4473a1267715453283751292637a16d3";
            Text6.HorAlignment = StiTextHorAlignment.Center;
            Text6.Name = "Text6";
            Text6.Text.Value = MS_Molahezat;
            Text6.Type = StiSystemTextType.Expression;
            Text6.VertAlignment = StiVertAlignment.Bottom;
            Text6.Border = new StiBorder(StiBorderSides.None, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            Text6.Brush = new StiSolidBrush(Color.Transparent);
            Text6.Font = new Font("IRANSans(FaNum) Medium", 9F);
            Text6.Indicator = null;
            Text6.Interaction = null;
            Text6.Margins = new StiMargins(0, 0, 0, 0);
            Text6.TextBrush = new StiSolidBrush(Color.Black);
            Text6.TextOptions = new StiTextOptions(true, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, StringTrimming.None);
            Text6.Page = Page1;
            Text6.Parent = PageFooterBand1;
            Text6.TextQuality = StiTextQuality.Typographic;


            PageFooterBand1.Components.Clear();
            PageFooterBand1.Components.AddRange(new StiComponent[]
            {
                Text7, Text6
            });
            #endregion
        }
        private void    Create_Page                         (StiPage Page1, StiReport Report)
        {
            Page1.RightToLeft = true;
            if (ms_paper_size.SelectedIndex == 0)
            {
                if (ms_landscape.SelectedIndex == 0)
                {
                    _Height = Page1.PageHeight = 297;
                    _Width = Page1.PageWidth = 210;
                }
                else
                {
                    _Height = Page1.PageHeight = 210;
                    _Width = Page1.PageWidth = 297;
                }
                Page1.PaperSize = System.Drawing.Printing.PaperKind.A4;
            }
            else
            {
                if (ms_landscape.SelectedIndex == 1)
                {
                    _Height = Page1.PageHeight = 148;
                    _Width = Page1.PageWidth = 210;
                }
                else
                {
                    _Height = Page1.PageHeight = 210;
                    _Width = Page1.PageWidth = 148;
                }
                Page1.PaperSize = System.Drawing.Printing.PaperKind.A5;
                
            }
            if (ms_page_segment.Checked)
            {
                //var item2 = ms_field_list
                //   .Controls
                //   .OfType<CheckBox>()
                //   .Where(x => x.Checked)
                //   .Select(x => x.Tag as GridEXColumn)
                //   .Sum(x => x.Width);

                var item2 = ms_GridColumns
                    .GetCheckedRows()
                    .Select(x => (x.DataRow as NzColumn).Width)
                    .Sum();

                var Grid_Width = Convert.ToInt32(Math.Round(
                    item2
                    * PIXEL_TO_MM)

                    );

                var math = Math.Ceiling(Grid_Width/_Width);
                Page1.SegmentPerWidth = Convert.ToInt32(math);
                _Width*= Convert.ToInt32(math);
            }

            Page1.Orientation = ms_landscape.SelectedIndex==1 
                                                ? StiPageOrientation.Landscape 
                                                : StiPageOrientation.Portrait;

            Page1.RightToLeft = true;
            Page1.Border = new StiBorder(StiBorderSides.All, Color.Black, 2, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            Page1.Brush = new StiSolidBrush(Color.Transparent);
            Page1.ExcelSheetValue = null;
            Page1.Interaction = null;
            Page1.Margins = new StiMargins(_Margin, _Margin, _Margin, _Margin);
            Page1.Report = Report;
            Report.Pages.Clear();
            Report.Pages.AddRange(new StiPage[]
               {
                    Page1
               });
        }

        private void    Create_Group_Header                 (StiPage Page, StiReport Report, GridEXGroup Group)
        {
            var GroupHeaderBand1 = new StiGroupHeaderBand();
            if (Group.Column != null)
            {
                GroupHeaderBand1.Condition = new 
                    StiGroupConditionExpression("{MyList." + Group.Column.DataMember + "}");
            }
            else if(Group.CustomGroup!=null)
            {
                GroupHeaderBand1.Condition = new StiGroupConditionExpression(string.Join(":",
                    Group.CustomGroup
                        .CompositeColumns
                        .Select(x => "{MyList." + x.DataMember + "}")));
            }else
                return;
            
            GroupHeaderBand1.Height = 8;
            GroupHeaderBand1.Name = "GroupHeaderBand"+Group.Index;
            GroupHeaderBand1.Border = new StiBorder(StiBorderSides.Bottom | StiBorderSides.Top, Color.Black, 1, 
                StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            GroupHeaderBand1.Brush = new StiSolidBrush(_GridEX.GroupRowFormatStyle.BackColor);
            GroupHeaderBand1.KeepGroupTogether = true;
            GroupHeaderBand1.Parent = Page;
            GroupHeaderBand1.Page = Page;


            Page.Components.Add(GroupHeaderBand1);
            //=========================
            var Text13 = new StiText();
            Text13.DockStyle = StiDockStyle.Right;
            Text13.ShiftMode= StiShiftMode.OnlyInWidthOfComponent;
            Text13.Shift = true;
            Text13.Height = 8;
            Text13.RightToLeft = false;
            Text13.AutoWidth = true;
            Text13.HorAlignment = StiTextHorAlignment.Center;
            Text13.Name = "TextHeadGroup" + Group.Index;
            Text13.Type = StiSystemTextType.DataColumn;
            Text13.VertAlignment = StiVertAlignment.Center;
            Text13.TextQuality = StiTextQuality.Typographic;

            if (Group.Column != null)
            {
                Text13.Text.Value = Group.GroupPrefix + "{MyList." + Group.Column.DataMember + "}";
            }
            else if (Group.CustomGroup != null)
            {
                Text13.Text.Value  = new StiGroupConditionExpression(string.Join("-",
                    Group.CustomGroup
                        .CompositeColumns
                        .Select(x => "{MyList." + x.DataMember + "}")));
            }
            else
                return;
            
            Text13.Border = new StiBorder(StiBorderSides.None , Color.Black, 1, StiPenStyle.Solid, false, 4, 
                       new StiSolidBrush(Color.Black), false);
            Text13.Brush = new StiSolidBrush(Color.Transparent);
            Text13.Font = new Font("IRANSans(FaNum) Medium", 10F);
            Text13.Margins = new StiMargins(0, 0, 0, 0);
            Text13.TextBrush = new StiSolidBrush(_GridEX.GroupRowFormatStyle.ForeColor);

            Text13.TextOptions = new StiTextOptions(true, 
                false, false, 0F,
                System.Drawing.Text.HotkeyPrefix.None,
                StringTrimming.None);
            Text13.Page = Page;
            Text13.Parent = GroupHeaderBand1;
            GroupHeaderBand1.Components.Add(Text13);
        }
        private void    Create_Group_Footer                 (StiPage Page, StiReport Report)
        {
            if (_GridEX.RootTable.Groups.Count > 0 
                    && Page.Components.OfType<StiGroupHeaderBand>().Any()
                    && ((_GridEX.RootTable.GroupTotals!=GroupTotals.Never && _GridEX.RootTable.GroupTotals != GroupTotals.Default)
                    || (_GridEX.GroupTotals!=GroupTotals.Never && _GridEX.GroupTotals != GroupTotals.Default)))
            {
                _GridEX
                .RootTable
                .Groups
                .OfType<GridEXGroup>()
                .MSZ_ForEach(x =>
                {
                    var GroupFooterBand1 = new StiGroupFooterBand();
                    GroupFooterBand1.Height = 8;
                    GroupFooterBand1.Name = "GroupFooterBand"+x.Index;
                    GroupFooterBand1.Border = new StiBorder(StiBorderSides.Top | StiBorderSides.Bottom, Color.Black,
                        1,StiPenStyle.Solid, 
                        false, 4, new StiSolidBrush(Color.Black), false);
                    var color = Color.Transparent;
                    if (!_GridEX.GroupTotalRowFormatStyle.BackColor.IsEmpty)
                        color = _GridEX.GroupTotalRowFormatStyle.BackColor;
                    else if(!_GridEX.GroupRowFormatStyle.BackColor.IsEmpty)
                        color = _GridEX.GroupRowFormatStyle.BackColor;
                    else if (!_GridEX.GroupByBoxFormatStyle.BackColor.IsEmpty)
                        color = _GridEX.GroupByBoxFormatStyle.BackColor;
                   
                    GroupFooterBand1.Brush = new StiSolidBrush(color);
                    GroupFooterBand1.Page = Page;
                    GroupFooterBand1.Parent = Page;
                    GroupFooterBand1.TagValue = x.Index;
                    Page.Components.Add(GroupFooterBand1);
                });
            }
        }

        private void    Generate_List_Data_UnBound          (StiPage Page)
        {

        }
        private void    Generate_List_Data_Bound            (StiPage Page, StiReport Report)
        {
            //1.HeaderBand
            //2.GroupHeader
            //3.DataBand
            //4.GroupFooter
            //5.FooterBand
            //6.Style
            //=======
            var HeaderBand1 = new StiHeaderBand();
            HeaderBand1.Height = 8;
            HeaderBand1.Name = "HeaderBand1";
            HeaderBand1.Border = new StiBorder(StiBorderSides.Bottom, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            HeaderBand1.Brush = new StiSolidBrush(ms_header_Color.Checked ? Color.LightGray : Color.Transparent);
            HeaderBand1.Page = Page;
            HeaderBand1.Parent = Page;
            Page.Components.Add(HeaderBand1);
            //==================
            _GridEX
                .RootTable
                .Groups
                .OfType<GridEXGroup>()
                .MSZ_ForEach(x =>
                {
                    Create_Group_Header(Page, Report, x);
                });

            //==================
            var DataBand1 = new StiDataBand();
            //DataBand1.DataSourceName = "MyList";
            DataBand1.BusinessObjectGuid = "0ff82857b4034dec960809dd1cc0ed8f";
            DataBand1.Height = 8;
            DataBand1.Name = "DataBand1";
            DataBand1.Border = new StiBorder(StiBorderSides.Bottom, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
            DataBand1.Brush = new StiSolidBrush(Color.Transparent);
            DataBand1.Linked = true;
            DataBand1.RightToLeft = true;
            DataBand1.Page = Page;
            DataBand1.Parent = Page;

            if ( NsGrow.Checked)
            { 
	            DataBand1.CanGrow = true;
	            DataBand1.GrowToHeight = true;
	            DataBand1.Linked = true;
            }

            Page.Components.Add(DataBand1);
            //==================
            Create_Group_Footer(Page, Report);

            //==================
            StiFooterBand FooterBand1 = null;
            if (_GridEX.TotalRow == InheritableBoolean.True || _GridEX.RootTable.TotalRow == InheritableBoolean.True)
            {
                FooterBand1 = new StiFooterBand();
                FooterBand1.Height = 8;
                FooterBand1.Name = "FooterBand1";
                FooterBand1.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
                FooterBand1.Brush = new StiSolidBrush(Color.Transparent);
                FooterBand1.Guid = null;
                FooterBand1.Page = Page;
                FooterBand1.Parent = Page;
            }
            //==================
            var StyleStyle1 = new StiStyle();
            if (ms_alternative.Checked)
            {
                StyleStyle1.Name = "Style1";
                Color Alter = Color.WhiteSmoke;
                if (!_GridEX.AlternatingRowFormatStyle.BackColor.IsEmpty)
                    Alter = _GridEX.AlternatingRowFormatStyle.BackColor;
                StyleStyle1.Border = new StiBorder(StiBorderSides.Bottom, Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
                StyleStyle1.Brush = new StiSolidBrush(Alter);
                Report.Styles.AddRange(new StiBaseStyle[] {StyleStyle1});
                DataBand1.EvenStyle = "Style1";
            }
            //==================
            var width = 0;
            var index = 1;

            var FormatConditions = _GridEX
                                    .RootTable
                                    .FormatConditions
                                    .OfType<GridEXFormatCondition>()
                                    .ToList();

            var TotalRow = _GridEX.GetTotalRow();

            ms_GridColumns
            .GetCheckedRows()
            .Select(x=>x.DataRow as NzColumn)
            .MSZ_ForEach(x =>
            {
                if (width >= _Width)
                    return;
                var numeric = x.Width;
                var col     = x.Column;
                var Xaxis   = _Width - (Page.SegmentPerWidth * 2 * _Margin) - numeric - width;

                //1.HeadText
                //2.DataText
                //3.FooterText
                //4.GroupFooterText
                //4.GroupHeaderTotalText
                //=============================
                var Text9 = new StiText();
                 
                //Text9.ClientRectangle = new RectangleD(_Width - (Page.SegmentPerWidth * 2 * _Margin) - numeric - width, 0, numeric, 8);
                Text9.ClientRectangle = new RectangleD(Xaxis < 0 ? 0 : Xaxis, 0, Xaxis < 0 ? numeric + Xaxis : numeric, 8);
                Text9.HorAlignment = StiTextHorAlignment.Center;
                Text9.RightToLeft = true;

                Text9.Name = "HeadText" + index;
                Text9.Text.Value = x.Caption;
                Text9.VertAlignment = StiVertAlignment.Center;
                Text9.Border = new StiBorder(((StiBorderSides.None | StiBorderSides.Left) | StiBorderSides.Right), Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
                Text9.Brush = new StiSolidBrush(Color.Transparent);
                Text9.Font = new Font("IRANSans(FaNum) Medium", 10F);
                Text9.Indicator = null;
                Text9.Interaction = null;
                Text9.Margins = new StiMargins(0, 0, 0, 0);
                Text9.TextBrush = new StiSolidBrush(Color.Black);
                Text9.TextOptions = new StiTextOptions(true, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, StringTrimming.None);
                Text9.Page = Page;
                Text9.Parent = HeaderBand1;
                Text9.TextQuality = StiTextQuality.Typographic;


                Text9.Interaction= new StiInteraction();
                Text9.Interaction.SortingColumn = "DataBand1."+ col.DataMember;
                Text9.Interaction.DrillDownPageGuid = null;

                HeaderBand1.Components.Add(Text9);
                //==============================
                var Text10 = new StiText();
                //Text10.ClientRectangle = new RectangleD(_Width - (Page.SegmentPerWidth * 2 * _Margin) - numeric - width, 0, numeric, 8);
                Text10.ClientRectangle = new RectangleD(Xaxis < 0 ? 0 : Xaxis, 0, Xaxis < 0 ? numeric + Xaxis : numeric, 8);

                Text10.HorAlignment = Cell_Text_Aligment(col);
                Text10.Name = "DataText" + index;
                Text10.Text.Value = "{MyList." + col.DataMember + "}";
                Text10.Type = StiSystemTextType.DataColumn;
                Text10.VertAlignment = Cell_Line_Alignment(col);
                Text10.Border = new StiBorder(((StiBorderSides.None | StiBorderSides.Left) | StiBorderSides.Right),
                    Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);

                //Text10.Border = new StiBorder(StiBorderSides.All,
                //    Color.Red, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Red), false);

                Text10.Brush = new StiSolidBrush(Color.Transparent);
                Text10.Font = new Font("IRANSans(FaNum) Medium", 10F);
                Text10.Indicator = null;
                Text10.RightToLeft = true;

                Text10.Interaction = null;
                Text10.Margins = new StiMargins(2, 2, 0, 0);
                Text10.TextBrush = new StiSolidBrush(Color.Black);
                Text10.TextOptions = new StiTextOptions(true, false, false, 0F, 
                    System.Drawing.Text.HotkeyPrefix.None, StringTrimming.None);
                Text10.Page = Page;
                Text10.Parent = DataBand1;
                Text10.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCustomFormatService(col.FormatString);
                Text10.Linked = true;
                Text10.TextQuality = StiTextQuality.Typographic;

                if (col.WordWrap || NsGrow.Checked)
                {
                    Text10.WordWrap = true;
                    Text10.CanGrow = true;
                    Text10.GrowToHeight = true;
                    Text10.Linked = true;
                }
                else if (NsShrink.Checked)
                {
	                Text10.ShrinkFontToFit = true;
                }

                if (FormatConditions.Any(y=>y.TargetColumn!=null && y.TargetColumn.DataMember==x.Column.DataMember))
                {
                    //
                    FormatConditions.Where(y => y.TargetColumn.DataMember == x.Column.DataMember)
                    .MSZ_ForEach(y =>
                        {
                            Text10.Conditions.Add(ConvertCondition(y));
                        });
                }

                DataBand1.Components.Add(Text10);
                //=================================
                if (col.AggregateFunction != AggregateFunction.None && FooterBand1 != null)
                {
                    var Text_Footer = new StiText();
                    Text_Footer.ClientRectangle = new RectangleD(Xaxis < 0 ? 0 : Xaxis, 0, Xaxis < 0 ? numeric + Xaxis : numeric, 8);
                    //Text_Footer.ClientRectangle = new RectangleD(_Width - (Page.SegmentPerWidth * 2 * _Margin) - numeric - width, 0, numeric, 8);
                    Text_Footer.Type = StiSystemTextType.Totals;
                    Text_Footer.VertAlignment = Text10.VertAlignment;
                    Text_Footer.HorAlignment = Text10.HorAlignment;
                    Text_Footer.Name = "FooterText" + index.ToString();
                    Text_Footer.Border = new StiBorder(((StiBorderSides.None | StiBorderSides.Left) | StiBorderSides.Right)
                        , Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
                    Text_Footer.Brush = new StiSolidBrush(Color.Transparent);
                    Text_Footer.Font = new Font("IRANSans(FaNum) Medium", 10F);
                    Text_Footer.Indicator = null;
                    Text_Footer.Interaction = null;
                    Text_Footer.Margins = new StiMargins(0, 0, 0, 0);
                    Text_Footer.TextBrush = new StiSolidBrush(Color.Black);
                    Text_Footer.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCustomFormatService(col.TotalFormatString);
                    Text_Footer.Text.Value = "{ "+ Get_Col_Aggregation(col) +
                    "(DataBand1, MyList." + col.DataMember + ")}";
                    Text_Footer.TextOptions = new StiTextOptions(true, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, StringTrimming.None);
                    Text_Footer.TextQuality = StiTextQuality.Typographic;

                    Text_Footer.Page = Page;
                    Text_Footer.Parent = FooterBand1;
                    FooterBand1.Components.Add(Text_Footer);
                }
                else if (col.AggregateFunction == AggregateFunction.None && FooterBand1 != null
                    &&(!string.IsNullOrWhiteSpace(TotalRow.Cells[col].Text)|| TotalRow.Cells[col].Value!=null))
                {
                    var Text_Footer = new StiText();
                    Text_Footer.ClientRectangle = new RectangleD(Xaxis < 0 ? 0 : Xaxis, 0, Xaxis < 0 ? numeric + Xaxis : numeric, 8);
                    //Text_Footer.ClientRectangle = new RectangleD(_Width - (Page.SegmentPerWidth * 2 * _Margin) - numeric - width, 0, numeric, 8);
                    Text_Footer.Type = StiSystemTextType.Expression;

                    switch (TotalRow.Cells[col].FormatStyle?.TextAlignment)
                    {
                        case TextAlignment.Empty:
                            Text_Footer.HorAlignment = Text10.HorAlignment;
                            break;
                        case TextAlignment.Near:
                            Text_Footer.HorAlignment =StiTextHorAlignment.Left;
                            break;
                        case TextAlignment.Center:
                            Text_Footer.HorAlignment = StiTextHorAlignment.Center;

                            break;
                        case TextAlignment.Far:
                            Text_Footer.HorAlignment = StiTextHorAlignment.Right;

                            break;
                        default:
                            Text_Footer.HorAlignment = Text10.HorAlignment;
                            break;
                    }
                    Text_Footer.VertAlignment = Text10.VertAlignment;

                    //Text_Footer.HorAlignment = Text10.HorAlignment;
                    Text_Footer.Name = "FooterText" + index.ToString();
                    Text_Footer.Border = new StiBorder(((StiBorderSides.None | StiBorderSides.Left) | StiBorderSides.Right)
                        , Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
                    Text_Footer.Brush = new StiSolidBrush(Color.Transparent);
                    Text_Footer.Font = new Font("IRANSans(FaNum) Medium", 10F);
                    Text_Footer.Indicator = null;
                    Text_Footer.Interaction = null;
                    Text_Footer.Margins = new StiMargins(0, 0, 0, 0);
                    Text_Footer.TextBrush = new StiSolidBrush(Color.Black);
                    //Text_Footer.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCustomFormatService(col.TotalFormatString);
                    Text_Footer.Text.Value = TotalRow.Cells[col].Text;
                    Text_Footer.TextOptions = new StiTextOptions(true, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, StringTrimming.None);
                    Text_Footer.Page = Page;
                    Text_Footer.Parent = FooterBand1;
                    Text_Footer.TextQuality = StiTextQuality.Typographic;

                    FooterBand1.Components.Add(Text_Footer);

                }

                if (col.AggregateFunction != AggregateFunction.None &&
                    Page.Components.OfType<StiGroupFooterBand>().Any())
                {
                    var groups = Page
                        .Components
                        .OfType<StiGroupFooterBand>().Count()-1;
                    Page
                    .Components
                    .OfType<StiGroupFooterBand>()
                    .MSZ_ForEach_With_Index((item, count) =>
                    {
                        var GroupFooterTotalText = new StiText();
                        GroupFooterTotalText.ClientRectangle = new RectangleD(Xaxis < 0 ? 0 : Xaxis, 0, Xaxis < 0 ? numeric + Xaxis : numeric, 8);
                        //GroupFooterTotalText.ClientRectangle = new RectangleD(_Width - (Page.SegmentPerWidth * 2 * _Margin) - numeric - width, 0, numeric , 8);
                        GroupFooterTotalText.Type = StiSystemTextType.Totals;
                        GroupFooterTotalText.VertAlignment = Text10.VertAlignment;
                        GroupFooterTotalText.HorAlignment = Text10.HorAlignment;
                        GroupFooterTotalText.Name = "GroupFooterTotalText" + count.ToString() +index.ToString();
                        GroupFooterTotalText.Border = new StiBorder(((StiBorderSides.None | StiBorderSides.Left) |
                            StiBorderSides.Right), Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);
                        GroupFooterTotalText.Brush = new StiSolidBrush(Color.Transparent);
                        GroupFooterTotalText.Font = new Font("IRANSans(FaNum) Medium", 10F);
                        GroupFooterTotalText.TextBrush = new StiSolidBrush(Color.Black);
                        GroupFooterTotalText.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCustomFormatService(col.TotalFormatString);
                        GroupFooterTotalText.Text.Value = "{ " + Get_Col_Aggregation(col) +
                        "(GroupHeaderBand" + (groups-count)+", MyList." + col.DataMember + ")}";
                        GroupFooterTotalText.TextOptions = new StiTextOptions(true, false, true, 0F,
                            System.Drawing.Text.HotkeyPrefix.None, StringTrimming.None);
                        GroupFooterTotalText.TextQuality = StiTextQuality.Typographic;

                        GroupFooterTotalText.Page = Page;
                        GroupFooterTotalText.Parent = item;
                        item.Components.Add(GroupFooterTotalText);
                    });
                }
                var head =
                    _GridEX
                        .RootTable
                        .GroupHeaderTotals
                        .OfType<GridEXGroupHeaderTotal>()
                        .LastOrDefault(y => y.ColumnAlign == col);
                if (_GridEX.RootTable.GroupHeaderTotals.Count > 0
                    && head!=null)
                {
                    Page
                    .Components
                    .OfType<StiGroupHeaderBand>()
                    .MSZ_ForEach_With_Index((item, couter) =>
                    {
                        var GroupFooterTotalText = new StiText();
                        GroupFooterTotalText.ClientRectangle = new RectangleD(Xaxis < 0 ? 0 : Xaxis, 0, Xaxis < 0 ? numeric + Xaxis : numeric, 8);
                        //GroupFooterTotalText.ClientRectangle = new RectangleD(_Width - (Page.SegmentPerWidth * 2 * _Margin) - numeric - width, 0, numeric, 8);
                        //GroupFooterTotalText.ClientRectangle = new RectangleD(_Width - (Page.SegmentPerWidth * 2 * _Margin) - numeric - width, 0,

                        GroupFooterTotalText.Type = StiSystemTextType.Expression;
                        GroupFooterTotalText.VertAlignment = Text10.VertAlignment;
                        GroupFooterTotalText.HorAlignment = Text10.HorAlignment;
                        GroupFooterTotalText.Name = "GroupHeadeTotalText" + couter.ToString() + index.ToString();
                        GroupFooterTotalText.Border = new StiBorder(((StiBorderSides.All | StiBorderSides.Left) |
                            StiBorderSides.Right), Color.Black, 1, StiPenStyle.Dash, false, 4, new StiSolidBrush(Color.Black), false);
                        GroupFooterTotalText.Brush = new StiSolidBrush(Color.Transparent);
                        GroupFooterTotalText.Font = new Font("IRANSans(FaNum) Medium", 10F);
                        GroupFooterTotalText.TextBrush = new StiSolidBrush(Color.Black);
                        GroupFooterTotalText.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCustomFormatService(col.TotalFormatString);
                        GroupFooterTotalText.Text.Value = head.TotalPrefix + "{ " + Get_Head_Aggregation(head) +
                        "(" + item.Name + ", MyList." + head.Column.DataMember + ")}" + head.TotalSuffix;
                        GroupFooterTotalText.TextOptions = new
                            StiTextOptions(true, false, true, 0F,
                            System.Drawing.Text.HotkeyPrefix.None, StringTrimming.None);
                        GroupFooterTotalText.TextQuality = StiTextQuality.Typographic;

                        GroupFooterTotalText.Page = Page;
                        GroupFooterTotalText.Parent = item;
                        item.Components.Add(GroupFooterTotalText);
                    });
                }
                //=================================
                width += numeric;
                index++;
            });
            //==================
            if (FooterBand1 != null)
            {
                FooterBand1.PrintAtBottom = _GridEX.TotalRowPosition == TotalRowPosition.BottomFixed;
            }
            if (_GridEX.TotalRow == InheritableBoolean.True || _GridEX.RootTable.TotalRow == InheritableBoolean.True)
                Page.Components.Add(FooterBand1);
        }
        private void    Generate_DataTable                  (StiReport Report)
        {
            var data = _GridEX.GetDataRows().Select(x=>x.DataRow).ToList();
            if(data.Count==0)
                return;

            //v/*ar dtt = data.First().GetType();*/

            StiBusinessObject MyList = new 
                StiBusinessObject("", "MyList", "MyList", 
                                  "0ff82857b4034dec960809dd1cc0ed8f", null);
            var listField = new List<string>();
            ms_GridColumns
                .GetCheckedRows()
                .MSZ_ForEach(x =>
                {
                    var col = (x.DataRow as NzColumn).Column;
                    MyList.Columns.Add(col.DataMember, col.DataMember, col.Type);
                    listField.Add(col.DataMember);
                });
            //=============================
            //=============افزودن ستون های گروه بندی
            //=============در صورتیکه وجود نداشته باشد


            if (_GridEX.RootTable.Groups.Count > 0)
            {
                
                foreach (var group in _GridEX.RootTable.Groups.OfType<GridEXGroup>())
                {
                    if (group.Column != null)
                    {
                        MyList.Columns.Add(group.Column.DataMember, group.Column.DataMember, group.Column.Type);
                        listField.Add(group.Column.DataMember);
                    }
                    else if (group.CustomGroup != null && group.CustomGroup.CustomGroupType== CustomGroupType.CompositeColumns)
                    {
                        foreach (var cols in group.CustomGroup.CompositeColumns)
                        {
                                MyList.Columns.Add(cols.DataMember, cols.DataMember, cols.Type);
                                listField.Add(cols.DataMember);
                        }
                    }
                }


            }
            //=============================
            //=============================
            //=============================
            var table = ToDataTable(data, listField);

            Report.Dictionary.BusinessObjects.Add(MyList);
            Report.RegBusinessObject("MyList", table);

            //Report.RegData("MyList", data);
            Report.Dictionary.Synchronize();
        }

        private void    Init                                ()
        {
            _Do_Refresh = false;
            _TempFile=Path.GetTempFileName();
            StiOptions.Viewer.RightToLeft       = StiRightToLeftType.Yes;
            superTabControl2.SelectedTabIndex   = 0;
            stiViewerControl1.RightToLeft       = RightToLeft.Yes;
            ms_paper_size.SelectedIndex         = 0;
            ms_landscape.SelectedIndex          = 0;
            Show_Field_List();
            Generate_Report();
            _Do_Refresh = true;
        }
        private void    Generate_Report                     ()
        {
            stiViewerControl1.SetZoom(80);
            //====================
            Report = new StiReport();
            Report.ScriptLanguage = StiReportLanguageType.CSharp;
            Report.ReportUnit = StiReportUnitType.Millimeters;
            //Report.NeedsCompiling = false;
            Report.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            Report.ReferencedAssemblies = new string[]
            {
                "System.Dll",
                "System.Drawing.Dll",
                "System.Windows.Forms.Dll",
                "System.Data.Dll",
                "System.Xml.Dll",
                "Stimulsoft.Controls.Dll",
                "Stimulsoft.Base.Dll",
                "Stimulsoft.Report.Dll"
                ,"Stimulsoft.Controls.Win.dll",
            };
            Report.ReportAlias = "Report";

            //================
            Generate_DataTable(Report);

            //================
            var Page1 = new StiPage();
            Create_Page(Page1, Report);

            //================
            Create_Header(Page1);

            //================
            Create_Footer(Page1);

            //================
            if (_GridEX.BoundMode == BoundMode.Bound)
                Generate_List_Data_Bound(Page1, Report);
            else
                Generate_List_Data_UnBound(Page1);
            //================


            //======================________________________=======================
            //======================
            //======================  End Of Generate Items
            //======================________________________=======================
            //Report.Compile();

            //Report.Render(true);

            Report.Save (_TempFile);
            Report.Load (_TempFile);
            RegData     (Report);
            //Report.Compile();

            Report.Render(true);

            stiViewerControl1.Report = Report;
        }
        private void    Show_Field_List                     ()
        {
            if (_GridEX == null)
                return;
            var top = 20;
            var tabindex = 0;

            ms_alternative.Checked = _GridEX.AlternatingColors;
           
            _ListColumns = 
            _GridEX
                .RootTable
                .Columns
                .OfType<GridEXColumn>()
                .Where(x => x.Visible && x.ShowInFieldChooser && !x.ActAsSelector)
                .Select(x => new NzColumn
                {
                    Caption     = x.Caption,
                    //Width       = x.Width,
                    Width       = Convert.ToInt32(Math.Floor(x.Width * PIXEL_TO_MM)),
                    Column      = x,

                })
                .ToList();

           ms_GridColumns.DataSource = _ListColumns;
           ms_GridColumns.CheckAllRecords();
           RefetchGrid();
           //ms_GridColumns.Refetch();
        }

        private void    RegData                             (StiReport Report)
        {
            var data = _GridEX.GetDataRows().Select(x => x.DataRow).ToList();
            
            if (NzSelectorRows.Checked)
                data = _GridEX.GetCheckedRows().Select(x => x.DataRow).ToList();

            if (data.Count == 0)
                return;

            var listField = new List<string>();
            ms_GridColumns
                .GetCheckedRows()
                .MSZ_ForEach(x =>
                {
                    var col = (x.DataRow as NzColumn).Column;
                    listField.Add(col.DataMember);
                });

            if (_GridEX.RootTable.Groups.Count > 0)
            {

                foreach (var group in _GridEX.RootTable.Groups.OfType<GridEXGroup>())
                {
                    if (group.Column != null)
                    {
                        listField.Add(group.Column.DataMember);
                    }
                    else if (group.CustomGroup != null && group.CustomGroup.CustomGroupType == CustomGroupType.CompositeColumns)
                    {
                        foreach (var cols in group.CustomGroup.CompositeColumns)
                        {
                            listField.Add(cols.DataMember);
                        }
                    }
                }


            }
            //=============================
            //=============================
            //=============================
            var table = ToDataTable(data, listField);
            Report.RegBusinessObject("MyList", table);
        }


        private StiCondition ConvertCondition(GridEXFormatCondition e)
        {
            var Condition           = new StiCondition();
            Condition.Column        = "MyList." + e.Column.DataMember;
            Condition.Enabled       = true;
            //Condition.Permissions   = StiConditionPermissions.All;
            Condition.Value1        = e.Value1?.ToString();
            Condition.Value2        = e.Value2?.ToString();
            Condition.Item          = StiFilterItem.Value;

            switch (e.ConditionOperator)
            {
                case ConditionOperator.Equal:
                    Condition.Condition = StiFilterCondition.EqualTo;
                    break;
                case ConditionOperator.NotEqual:
                    Condition.Condition = StiFilterCondition.NotEqualTo;
                    break;
                case ConditionOperator.GreaterThan:
                    Condition.Condition = StiFilterCondition.GreaterThan;
                    break;
                case ConditionOperator.LessThan:
                    Condition.Condition = StiFilterCondition.LessThan;
                    break;
                case ConditionOperator.GreaterThanOrEqualTo:
                    Condition.Condition = StiFilterCondition.GreaterThanOrEqualTo;
                    break;
                case ConditionOperator.LessThanOrEqualTo:
                    Condition.Condition = StiFilterCondition.LessThanOrEqualTo;
                    break;
                case ConditionOperator.Between:
                    Condition.Condition = StiFilterCondition.Between;
                    break;
                case ConditionOperator.NotBetween:
                    Condition.Condition = StiFilterCondition.NotBetween;
                    break;
                case ConditionOperator.Contains:
                    Condition.Condition = StiFilterCondition.Containing;
                    break;
                case ConditionOperator.NotContains:
                    Condition.Condition = StiFilterCondition.NotContaining;
                    break;
                case ConditionOperator.BeginsWith:
                    Condition.Condition = StiFilterCondition.BeginningWith;
                    break;
                case ConditionOperator.EndsWith:
                    Condition.Condition = StiFilterCondition.EndingWith;
                    break;
                case ConditionOperator.IsNull:
                    Condition.Condition = StiFilterCondition.IsNull;
                    break;
                case ConditionOperator.NotIsNull:
                    Condition.Condition = StiFilterCondition.IsNotNull;
                    break;
                case ConditionOperator.IsEmpty:
                    Condition.Condition = StiFilterCondition.IsNull;
                    break;
                case ConditionOperator.NotIsEmpty:
                    Condition.Condition = StiFilterCondition.IsNotNull;
                    break;
                case ConditionOperator.In:
                    Condition.Condition = StiFilterCondition.Between;
                    break;
                case ConditionOperator.NotIn:
                    Condition.Condition = StiFilterCondition.NotBetween;
                    break;
            }

            switch (e.Column.DataTypeCode)
            {
                case TypeCode.Boolean:
                    Condition.DataType = StiFilterDataType.Boolean;
                    break;
                case TypeCode.String:
                case TypeCode.Char:
                    Condition.DataType = StiFilterDataType.String;
                    break;
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
                    Condition.DataType = StiFilterDataType.Numeric;
                    break;
                case TypeCode.DateTime:
                    Condition.DataType = StiFilterDataType.DateTime;
                    break;
            }

            StiStyle style;

            if (e.FormatStyle != null)
            {
                style = new StiStyle();
                Font ff = new Font("IRANSans(FaNum) Medium", 10F);
                style.Border= new StiBorder(((StiBorderSides.None | StiBorderSides.Left) | StiBorderSides.Right),
                    Color.Black, 1, StiPenStyle.Solid, false, 4, new StiSolidBrush(Color.Black), false);

                if (e.FormatStyle.FontBold == TriState.True)
                    ff = new Font(ff, FontStyle.Bold);

                if (e.FormatStyle.FontItalic == TriState.True)
                    ff = new Font(ff, FontStyle.Italic);

                if (e.FormatStyle.FontSize > 0)
                    ff=new Font(ff.FontFamily, e.FormatStyle.FontSize,ff.Style);

                style.Font = ff;
               
                switch (e.FormatStyle.LineAlignment)
                {
                    case TextAlignment.Empty:
                        break;
                    case TextAlignment.Near:
                        style.VertAlignment = StiVertAlignment.Top;
                        break;
                    case TextAlignment.Center:
                        style.VertAlignment = StiVertAlignment.Center;
                        break;
                    case TextAlignment.Far:
                        style.VertAlignment = StiVertAlignment.Bottom;
                        break;
                }

                switch (e.FormatStyle.TextAlignment)
                {
                    case TextAlignment.Empty:
                        break;
                    case TextAlignment.Near:
                        style.HorAlignment = StiTextHorAlignment.Left;
                        break;
                    case TextAlignment.Center:
                        style.HorAlignment = StiTextHorAlignment.Center;
                        break;
                    case TextAlignment.Far:
                        style.HorAlignment = StiTextHorAlignment.Right;
                        break;
                }

                if (e.FormatStyle.BackColor != Color.Empty)
                {
                    Condition.BackColor = e.FormatStyle.BackColor;
                    style.Brush         = new StiSolidBrush(e.FormatStyle.BackColor);
                }

                if (e.FormatStyle.ForeColor != Color.Empty)
                {
                    style.TextBrush     = new StiSolidBrush(e.FormatStyle.ForeColor);
                    Condition.TextColor = e.FormatStyle.ForeColor;
                }

                style.AllowUseBrush                 = true;
                style.AllowUseTextBrush             = true;
                style.AllowUseVertAlignment         = true;
                style.AllowUseHorAlignment          = true;
                style.AllowUseBorderFormatting      = false;
                style.AllowUseBorderSides           = false;
                style.AllowUseBorderSidesFromLocation = false;

                style.Name                  = e.Key;
                Condition.Style             = e.Key;

                Report.Styles.Add(style);
            }

            return Condition;
        }
        #endregion
        private void ms_landscape_SelectedIndexChanged      (object sender, EventArgs e)
        {
            if (!_Do_Refresh)
                return;
            //var lst=ms_GridVoucher.GetDataRows().Select(x => x.DataRow as NzColumn).ToList();
            Generate_Report();
        }
        private void ms_fix_Col_CheckedChanged              (object sender, EventArgs e)
        {
            if (_GridEX == null)
                return;

            Set_Page_Size();

            if (ms_fix_Col.Checked)
            {
                //var item2 = ms_field_list
                //    .Controls
                //    .OfType<CheckBox>()
                //    .Where(x => x.Checked)
                //    .Select(x => x.Tag as GridEXColumn)
                //    .Sum(x => x.Width);

                var item2 = ms_GridColumns
                    .GetCheckedRows()
                    .Select(x => (x.DataRow as NzColumn).Width)
                    .Sum();

                var Grid_Width = Convert.ToInt32(Math.Round(
                    item2
                    * PIXEL_TO_MM)
                    );


                double margin   = _Margin;
                if (stiViewerControl1.Report != null && stiViewerControl1.Report.Pages.Count > 0)
                {
                    var page    = stiViewerControl1.Report.Pages[0];
                    margin      = _Margin*page.SegmentPerWidth*2;
                }

                var Mul= (_Width - margin)/Grid_Width;

                int SumOfCols = 0;

                ms_GridColumns
                    .GetCheckedRows()
                    .MSZ_ForEach(x =>
                    {
                        var col         = x.DataRow as NzColumn;
                        var col_width   = Convert.ToInt32(Math.Round(col.Width * PIXEL_TO_MM));
                        col.Width       = Convert.ToInt32(Math.Floor(col_width * Mul));
                        SumOfCols       += col.Width;
                    });
                if (_Width > SumOfCols)
                {
                    var last = ms_GridColumns
                        .GetCheckedRows()
                        .LastOrDefault();
                    if (last != null)
                    {

                        var col = last.DataRow as NzColumn;
                        col.Width += Convert.ToInt32(Math.Round(_Width - SumOfCols));
                    }
                }
                //else if (_Width < SumOfCols)
                //{
                //    var last = ms_GridColumns
                //        .GetCheckedRows()
                //        .LastOrDefault();
                //    if (last != null)
                //    {

                //        var col = last.DataRow as NzColumn;
                //        col.Width -= Convert.ToInt32(Math.Round(SumOfCols - _Width));
                //    }
                //}
            }
            else
            {
                ms_GridColumns
                    .GetCheckedRows()
                    .MSZ_ForEach(x =>
                    {
                        var col = x.DataRow as NzColumn;
                        col.Width = Convert.ToInt32(Math.Floor(col.Column.Width * PIXEL_TO_MM));
                    });

                //ms_field_list.Controls.OfType<IntegerUpDown>().MSZ_ForEach(x =>
                //{
                //    var col = x.Tag as GridEXColumn;
                //    if (col == null)
                //        return;
                //    x.Value = Convert.ToInt32(Math.Round(col.Width*PIXEL_TO_MM));
                //});
            }
            RefetchGrid();
            //ms_GridColumns.Refetch();
            Generate_Report();
        }
        private void ms_GridColumns_RecordUpdated           (object sender, EventArgs e)
        {
            ms_RefreshReport.PerformClick();
        }

        private void Form_List_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (File.Exists(_TempFile))
                    File.Delete(_TempFile);
            }
            catch (Exception)
            {
            }
        }

        private void ms_landscape_SelectedIndexChanged_1    (object sender, EventArgs e)
        {
            if (!_Do_Refresh)
                return;
            Set_Page_Size();

            ms_fix_Col_CheckedChanged(null, null);
        }
        private void Form_List_Shown                        (object sender, EventArgs e)
        {
            Init();
        }
    }
}
