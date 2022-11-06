using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.CustomCombo;
using MS_Control.DataBase.Con_Str;
using MS_Control.Tarikh;
using MS_Control.TSDD;

namespace MS_Control_Test
{
    public partial class Form_Test : MS_Mother
    {

        //class test
        //{
        //    public int age { get; set; }
        //    public string name { get; set; }
        //    public string family { get; set; }
        //}

        private bool do_close = true;
        //List<test>_list=new List<test>(); 
        public Form_Test()
        {
            MS_Tatikh_View.MS_List_Years = new List<int>() { 1393, 1394, 1395, 1396, 1397 };
            InitializeComponent();
            //ms_test_me.refresh();
            //userControl21.refff();
            //mS_Tarikh_Box1.MS_Tarikh = new MS_Structure_Shamsi(DateTime.Now);
            //mS_Tarikh_Box2.MS_Tarikh = new MS_Structure_Shamsi(DateTime.Now).AddDays(20);
            //mS_ComboBox_Custom1.DropDownControl = mS_Button1;
            //mS_ComboBox_Custom1.DropDownSizeMode = CustomComboBox.SizeMode.UseComboSize;
            //_list.Add(new test() { age = 12, family = "سوران", name = "سوران" });
            //_list.Add(new test() { age = 133, family = "سیری", name = "سیری" });
            //_list.Add(new test() { age = 144, family = "سالکه", name = "سالکه" });
            //_list.Add(new test() { age = 155, family = "گلی", name = "گلی" });

            //multiColumnCombo1.DataSource = _list.ToList();
            //multiColumnCombo1.DataMember = "family";
            //multiColumnCombo1.DropDownList.RetrieveStructure();
            //ToolStripControlHost host = new ToolStripControlHost(treeView1);

            ////add ToolStripControlHost object to context menu. simple!  
            //contextMenuStrip1.Items.Add(host);
            //mS_GridX1.AddItem("11111", "en");
            //mS_GridX1.AddItem("11111", "fa");
            //mS_GridX1.AddItem("56789", "fr");
            //mS_GridX1.AddItem("11111", "ar");
        }

        private void btnTaeid_Click(object sender, EventArgs e)
        {
            MSMessage.FarsiDialogResault mErrore =
                                MSMessage.Show("بــه دلــیــل خــطـــا در ایـــنــتـــرنـــت !!! \n\nپـــیـــغـــام بــه بــرنــامــه نــویــس ارســـال نـــشـــد . . .",
                                "برای تست", "لــغــو ارســــال خــطـــا",
                                MSMessage.FarsiMessageBoxButton.بله_خیر, MSMessage.FarsiMessageBoxIcon.اضافه);
        }

        private void btnBale_Click(object sender, EventArgs e)
        {
            var Frm = new MS_Control.DataBase.Con_Str.Form_Con_Str();
            Frm.ShowDialog();
            MS_Tarikh_TextBox n = new MS_Tarikh_TextBox();
            //n.MS_Tarikh.Value.ToShamsi
        }

        private void mS_Tatikh_View1_MS_On_OK_Clicked()
        {
            //mS_TextBox1.Text = mS_Tatikh_View1.MS_Tarikh.ToShamsi();
        }

        private void gfhj_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(mS_Tarikh_Box1.MS_Tarikh.HasValue ? mS_Tarikh_Box1.MS_Tarikh.Value.ToShamsi() : "-------");
        }

        private void mS_Button1_Click(object sender, EventArgs e)
        {
            MS_Control.Send_SMS.MS_Send_SMS.Send_SMS("برای تست م س", "09308694570");
        }

        private void mS_Button1_Click_1(object sender, EventArgs e)
        {
            //var frm = new Form_Con_Str();
            //if (frm.ShowDialog(this) == DialogResult.OK)
            //    textBox1.Text = Form_Con_Str.cl_Con_Str._Con_Str_Decode;
        }

        private void multiColumnCombo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!multiColumnCombo1.DroppedDown)
            //    multiColumnCombo1.DroppedDown = true;
            //if (!string.IsNullOrEmpty(multiColumnCombo1.Text.Trim()))
            //{
            //    var list = _list.Where(x => x.family.Contains(multiColumnCombo1.Text.Trim())).ToList();
            //    multiColumnCombo1.DropDownList.DataSource = list;
            //    multiColumnCombo1.DropDownList.Refetch();
            //}
            //if (string.IsNullOrEmpty(multiColumnCombo1.Text))
            //{
            //    multiColumnCombo1.DataSource = _list.ToList();
            //    multiColumnCombo1.DropDownList.Refetch();                
            //}
        }

        private void mS_GridX1_MouseUp(object sender, MouseEventArgs e)
        {
            //if (mS_GridX1.CurrentColumn != null)
            //    MessageBox.Show(mS_GridX1.CurrentColumn.Index.ToString());
            //var k = mS_GridX1.RootTable.FilterCondition;
            //var f = new GridEXFilterCondition();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //contextMenuStrip1.Show(textBox1, textBox1.Width, textBox1.Height + 5);
            //textBox1.Focus();
        }

        private void contextMenuStrip1_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            e.Cancel = do_close;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            do_close = false;
        }

        private void mS_Tarikh_TextBox1_Click(object sender, EventArgs e)
        {

        }

        private void mS_Tarikh_TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //label1.Text = e.KeyCode.ToString();
        }

        private void mS_Button1_Click_2(object sender, EventArgs e)
        {
            var msDel = MSMessage.Show("آیـــا مــایــلــیــد ردیـف انــتــخــاب شــده حــذف شــود؟",
                     "سلام", "حـــذف ردیــف", MSMessage.FarsiMessageBoxButton.بله_خیر, MSMessage.FarsiMessageBoxIcon.حذف);
        }

        private void mS_Tarikh_TextBox1_TextChanged(object sender, EventArgs e)
        {
            //if (mS_Tarikh_TextBox1.MS_Tarikh.HasValue)
            //{
            //    MessageBox.Show(mS_Tarikh_TextBox1.MS_Tarikh.Value.ToShamsi());
            //}
        }

        private void mS_Button1_Click_3(object sender, EventArgs e)
        {
            //mS_Tarikh_TextBox2.MS_Tarikh=new MS_Structure_Shamsi(DateTime.Now);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MS_Util.MS_Get_Shahr_Ostan_Code_Meli("2860077642"));
            //var frm=new Form_Notification("Text","Hello",Form_Notification.FarsiMessageBoxIcon.چـک_باکس,Color.Empty);
            //frm.Popup(Form_Notification.Direction_Show.DownToUp,2000);
            //var itm=mS_Tarikh_TextBox1.MS_Tarikh.Value.ToDatetime();
            //var txt = mS_Tarikh_TextBox1.Text;
            //MessageBox.Show(itm.ToString());
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
