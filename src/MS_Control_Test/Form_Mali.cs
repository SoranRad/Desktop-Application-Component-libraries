using MS_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control.DataBase.SqlFolderBrowse;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using MS_Control.TSDD;

namespace MS_Control_Test
{
    public partial class Form_Mali : Form_Mother_IRANSans
    {
        class test
        {
            public int age { get; set; }
            public string name { get; set; }
            public string family { get; set; }
        }
        class test2
        {
            public int? age { get; set; }
            public decimal? money { get; set; }
            public string name { get; set; }
            public string family { get; set; }
        }

        private Popup_ToolStrip pp;
        List<Accounts> List = new List<Accounts>();
        public Form_Mali()
        {
            InitializeComponent();
            //MS_Util.myCursor();
            //mS_GridX2.Controls.Add(mS_GridX_Setting2);
            ////mS_GridX2.SetBounds(0, 0, mS_GridX1.Width, mS_GridX1.Height + 30 );
            ////mS_GridX2.Bounds=new Rectangle(0, 0, mS_GridX1.Width, mS_GridX1.Height + 30);
            ////mS_GridX2.Region=new Region(new Rectangle(0, 0, mS_GridX1.Width +50, mS_GridX1.Height + 30));
            //mS_GridX2.ClientSize=new Size(mS_GridX1.Width, mS_GridX1.Height - 30);
            //mS_GridX2.SetBounds(0, 0, mS_GridX1.Width, mS_GridX1.Height + 30);
            mS_Combo_Test1.MS_DropDownSizeMode = SizeMode.Mixed_Size;
            mS_Combo_Test1.Refresh_Grid();
            mS_Combo_Test2.MS_DropDownSizeMode = SizeMode.Control_Size;
            mS_Combo_Test2.Refresh_Grid();
            mS_Combo_Test3.MS_DropDownSizeMode = SizeMode.Control_Size;
            mS_Combo_Test3.MS_Drop_Direction = KindShow.Middle;
            mS_Combo_Test3.Refresh_Grid();
            mS_Combo_Test4.MS_DropDownSizeMode = SizeMode.Mixed_Size;
            mS_Combo_Test4.Refresh_Grid();
            mS_Combo_Test3.VisualStyle = VisualStyle.Office2007;
            mS_Combo_Test5.Refresh_Grid();
            var list = new List<test2>()
            {
                new test2(){age=null,family=string.Empty,money=120,name=string.Empty},
                new test2(){age=10,family="",money= 2500,name=string.Empty},
                new test2(){age=null,family=string.Empty,money=1200,name=""},
            };
            var tb = list.MS_To_DataTable();

            List.Add(new Accounts() {
                ID      =1,
                PID     = 0,
                Code    =11,
                Title   ="بدهیهای جاری",
            });
            List.Add(new Accounts() {
                ID      =2,
                PID     =1,
                Code    =12,
                Title   ="موجودی بانک",
            });
            List.Add(new Accounts() {
                ID      =3,
                PID     =1,
                Code    =111,
                Title   = "موجودی صندوق",
            });
            List.Add(new Accounts() {
                ID      =4,
                PID     = 0,
                Code    =13,
                Title   ="بدهیهای غیر جاری",
            });
            List.Add(new Accounts() {
                ID      =5,
                PID     =4,
                Code    =132,
                Title   ="حسابهای دریافتنی",
            });
            List.Add(new Accounts() {
                ID      =6,
                PID     =4,
                Code    =133,
                Title   ="اسناد دریافتنی",
            });
            List.Add(new Accounts() {
                ID      =7,
                PID     =0,
                Code    =14,
                Title   ="دارایی ها",
            });
            DataSet ds = new DataSet();
            ds.Tables.Add(List.MS_To_DataTable());
            ds.Tables[0].TableName = "Accounts";


            this.dataGridView2.DataSource = ds;
            this.dataGridView2.DataMember = "Accounts";

            //ds.Tables.Add("Accounts");
            //ds.Tables["Accounts"].Clone();
            olvDataTree.RootKeyValue = 0u;
            olvDataTree.DataSource = List;
            //olvDataTree.DataSource = new DataViewManager(ds);
            //olvDataTree.DataMember = "Accounts";
            olvDataTree.ExpandAll();
            //olvDataTree.DataSource = new BindingSource(ds, "Accounts");
            //new BindingSource(ds, "Person");
            //=============================
             pp = new Popup_ToolStrip();
            pp.Size =  olvDataTree.Size;
            pp.Set_Control(mS_GridX1);
            //var Host = new ToolStripControlHost(olvDataTree)
            //{
            //    //Dock                = DockStyle.Fill,
            //    Margin = Padding.Empty,
            //    Padding = Padding.Empty,
            //    AutoSize = false,
            //    //AutoToolTip         = false,
            //    DoubleClickEnabled = true,
            //};
            //olvDataTree.Anchor = AnchorStyles.Bottom
            //              | AnchorStyles.Left
            //              | AnchorStyles.Right
            //              | AnchorStyles.Top;

            ////Ctrl.Dock   = DockStyle.Fill;
            

            ////Ctrl.Location = Point.Empty;
            //Host.Size = new Size(olvDataTree.Size.Width, olvDataTree.Size.Height);
            //Host.Anchor = AnchorStyles.Bottom
            //              | AnchorStyles.Left
            //              | AnchorStyles.Right
            //              | AnchorStyles.Top;
            //pp.Items.Clear();
            //pp.Items.Add(Host);
            //Ctrl.Parent = this;

        }

        private void ms_Save_Click(object sender, EventArgs e)
        {
            //MS_INPUT.SendMessage((int)mS_GridX1.Handle,
            //    (int)MS_INPUT.WMessages.WM_LBUTTONDOWN,
            //    (int)MS_INPUT.VKeys.VK_LBUTTON,
            //    0);
            //MS_INPUT.SendMessage((int)mS_GridX1.Handle,
            //    (int)MS_INPUT.WMessages.WM_LBUTTONUP,
            //    (int)MS_INPUT.VKeys.VK_LBUTTON,
            //    0);

            MessageBox.Show(MS_Util.GetImageFilter(false));

            //OpenFileDialog b    = new OpenFileDialog();
            //b.Filter            = MS_Util.GetImageFilter(false);

            //foreach (var row in mS_GridX1.GetRows())
            //{
            //    if (row.Children > 0)
            //    {
            //        foreach (var subRow in row.GetChildRows())
            //        {
            //            if (subRow.RowType == RowType.Record)
            //                MessageBox.Show("row");
            //        }
            //    }
            //    else
            //        MessageBox.Show(row.RowType.ToString());
            //}

        }

        private void mS_Button_GridX1_Click(object sender, EventArgs e)
        {
            //new MS_Control.DataBase.Form_CMD().Show(this);
            pp.Show(mS_Button_GridX1,new Point(1,1));
            //Debug.Print("Click");
            //new Form_Restore(".","sa","123456").ShowDialog(this);
        }

        private void Form_Mali_Load(object sender, EventArgs e)
        {
            //mS_GridX1.LoadComponentSettings();
            //mS_GridX2.LoadComponentSettings();

            List<test> _list = new List<test>();
            _list.Add(new test() { age = 12, family = "سوران", name = "سوران" });
            _list.Add(new test() { age = 133, family = "سیری", name = "سیری" });
            _list.Add(new test() { age = 144, family = "سالکه", name = "سالکه" });
            _list.Add(new test() { age = 155, family = "گلی", name = "گلی" });

            mS_GridX1.DataSource = _list.ToList();

            _list = new List<test>();
            _list.Add(new test() { age = 12, family = "2سوران", name = "سورانd" });
            _list.Add(new test() { age = 133, family = "سیری2", name = "سیری2" });
            _list.Add(new test() { age = 144, family = "سالکه2", name = "سالک2ه" });
            _list.Add(new test() { age = 155, family = "2گلی", name = "گلی2" });

            mS_GridX2.DataSource = _list.ToList();
            //mS_GridX1.RetrieveStructure();
        }

        private void mS_GridX1_FormattingRow(object sender, RowLoadEventArgs e)
        {
            if (e.Row.RowType == RowType.TotalRow)
            {
                e.Row.Cells["age"].Text = "سوران";
                e.Row.Cells["age"].FormatStyle=new GridEXFormatStyle(){TextAlignment = TextAlignment.Far};

            }

            //if (!string.IsNullOrEmpty(textBox1.Text))
            //{
            //    foreach (GridEXCell cell in e.Row.Cells)
            //    {
            //        if (cell.Text.Contains(textBox1.Text))
            //        {
            //            cell.FormatStyle = new GridEXFormatStyle();
            //            cell.FormatStyle.BackColor = Color.Yellow;
            //        }
            //    }
            //}
            //mS_GridX1.

            //if (!string.IsNullOrEmpty(textBox1.Text))
            //{
            //    foreach (GridEXCell cell in e.Row.Cells)
            //    {
            //        if (!cell.Text.Contains(textBox1.Text))
            //            continue;
            //        var cellBound = mS_GridX1.GetCellBounds(e.Row.Position, cell.Column);

            //        var cellselect = Rectangle.Inflate(cellBound, 1, 3);

            //        Font fontMeasure;

            //        fontMeasure = cell.FormatStyle != null ? cell.FormatStyle?.Font : e.Row.GridEX.Font;

            //        var gra = e.Row.GridEX.CreateGraphics();

            //        Size s1 = TextRenderer.MeasureText(gra, textBox1.Text, fontMeasure, cellBound.Size);
            //        Size s2 = TextRenderer.MeasureText(gra, cell.Text, fontMeasure, cellBound.Size);

            //        if (s1.Width > 5)
            //        {
            //            cellselect.X = cellBound.X + s1.Width - 5;
            //            cellselect.Width = s2.Width;
            //        }
            //        else
            //        {
            //            cellselect.X = cellBound.X + 2;
            //            cellselect.Width = s2.Width;
            //        }
            //        SolidBrush hl_brush = new SolidBrush(Color.Yellow);

            //        gra.FillRectangle(hl_brush, cellselect);
            //        ////Now, draw the percent bar:
            //        //if (e.Row.Cells[e.Column].Value != DBNull.Value)
            //        //{
            //        //    float percentValue = .4F; //(float)e.Row.Cells[e.Column].Value;
            //        //    //calculate the rect to draw:
            //        //    Rectangle rect = Rectangle.Inflate(e.Bounds, 1, 3);
            //        //    rect.Width = (int) (rect.Width*percentValue);
            //        //    //now draw the rectangle:
            //        //    Brush br = new SolidBrush(Color.Blue);
            //        //    e.Graphics.FillRectangle(br, rect);
            //        //    br.Dispose();
            //        //    e.Handled = true;
            //        //}
            //    }

            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //mS_GridX1.Refresh();
            //mS_GridX1.Invalidate();
        }

        private void mS_GridX1_DrawGridArea(object sender, DrawGridAreaEventArgs e)
        {
            //if (!string.IsNullOrEmpty(textBox1.Text))
            //{
            //    foreach (GridEXCell cell in e.Row.Cells)
            //    {
            //        if(!cell.Text.Contains(textBox1.Text))
            //            continue;
            //        var cellBound = mS_GridX1.GetCellBounds(e.Row.Position,cell.Column);

            //        var cellselect= Rectangle.Inflate(cellBound, 1, 3);

            //        Font fontMeasure;

            //        if (cell.FormatStyle != null)
            //            fontMeasure = cell.FormatStyle?.Font;
            //        else if (e.Font != null)
            //            fontMeasure = e.Font;
            //        else
            //            fontMeasure = mS_GridX1.Font;

            //        Size s1 = TextRenderer.MeasureText(e.Graphics, textBox1.Text,fontMeasure, cellBound.Size);
            //        Size s2 = TextRenderer.MeasureText(e.Graphics, cell.Text , fontMeasure, cellBound.Size);

            //        if (s1.Width > 5)
            //        {
            //            cellselect.X = cellBound.X + s1.Width - 5;
            //            cellselect.Width = s2.Width - 6;
            //        }
            //        else
            //        {
            //            cellselect.X = cellBound.X + 2;
            //            cellselect.Width = s2.Width - 6;
            //        }
            //        SolidBrush hl_brush =  new SolidBrush(Color.Yellow);

            //        e.Graphics.FillRectangle(hl_brush, cellselect);
            //        ////Now, draw the percent bar:
            //        //if (e.Row.Cells[e.Column].Value != DBNull.Value)
            //        //{
            //        //    float percentValue = .4F; //(float)e.Row.Cells[e.Column].Value;
            //        //    //calculate the rect to draw:
            //        //    Rectangle rect = Rectangle.Inflate(e.Bounds, 1, 3);
            //        //    rect.Width = (int) (rect.Width*percentValue);
            //        //    //now draw the rectangle:
            //        //    Brush br = new SolidBrush(Color.Blue);
            //        //    e.Graphics.FillRectangle(br, rect);
            //        //    br.Dispose();
            //        //    e.Handled = true;
            //        //}
            //    }
                
            //}
        }

        private void Form_Mali_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                var Item = mS_Button_GridX1;
                var Coordinate = Cursor.Position;

                Coordinate= Item.PointToClient(Coordinate);

                MS_INPUT.SendMessage(Item.Handle, (int)MS_INPUT.WMessages.WM_LBUTTONDOWN, (IntPtr)0,
                    MS_INPUT.MakeLParam(Coordinate.X, Coordinate.Y));

               

                MS_INPUT.SendMessage(Item.Handle, (int)MS_INPUT.WMessages.WM_LBUTTONUP, (IntPtr)0,
                    MS_INPUT.MakeLParam(Coordinate.X, Coordinate.Y));
            }
        }

        private void mS_Button_GridX1_MouseDown(object sender, MouseEventArgs e)
        {
            Debug.Print("Mouse Down("+e.X+","+e.Y+")");
        }

        private void mS_Button_GridX1_MouseUp(object sender, MouseEventArgs e)
        {
            Debug.Print("Mouse Up(" + e.X + "," + e.Y + ")");

        }

        private void contextMenuStrip2_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {

        }

        private void contextMenuStrip1_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var StrDate = new MS_Structure_Shamsi("۱۴۰۱/۰۳/۱۶");


            //contextMenuStrip1.Show(new Point(MousePosition.X,MousePosition.Y));
            //contextMenuStrip2.Show(new Point(MousePosition.X+contextMenuStrip2.Width,MousePosition.Y));

            //MS_Message.Show(this, "برای آزمایش", "اخصار");

            MSMessage.Show("برای آزمایش");
            MSMessage.Show("آزمایش 2", "", "هشدار", MSMessage.FarsiMessageBoxButton.بله_خیر,
                MSMessage.FarsiMessageBoxIcon.خطا);

            MSMessage.Show("آزمایش 2", " ew", "هشدار", MSMessage.FarsiMessageBoxButton.بله_خیر,
                MSMessage.FarsiMessageBoxIcon.خطا);


        }

        private void mS_Combo_Test4_MS_On_Row_Selected(object sender, On_Selected e)
        {
            Debug.Print("test");
        }
    }
}
