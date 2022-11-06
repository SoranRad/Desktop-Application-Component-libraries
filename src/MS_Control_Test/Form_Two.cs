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
using MS_Control;
using MS_Control.DataBase.Con_Str;
using MS_Print_Cheque;

namespace MS_Control_Test
{
    public partial class Form_Two : MS_Control.MS_Mother_Two
    {
        List<test> _list = new List<test>();
        public Form_Two()
        {
            InitializeComponent();
            //mS_GridX_Setting1.ImageList = imageList1;
            //toolStripButton2.ImageIndex = 0;
            //mS_Combo_Test1.Refresh_Grid();
            _list.AddRange(new List<test>() {
                new test() {code = 1,name ="سوران"},
                new test() {code = 1,name ="سوران"},
                new test() {code = 1,name ="سوران"},
                new test() {code = 1,name ="سوران"},
                new test() {code = 2,name ="سیروانسیروانسیروان"},
                new test() {code = 2,name ="سیروانسیروانسیروان"},
                new test() {code = 3,name ="محمد"},
                new test() {code = 3,name ="محمد"},
                new test() {code = 3,name ="محمد"},
                new test() {code = 4,name ="شیرکو"},
                new test() {code = 4,name ="شیرکو"},
                new test() {code = 4,name ="شیرکو"},
                new test() {code = 4,name ="شیرکو"},
                });
            ms_grid.DataSource = _list.ToList();
            ms_grid.RetrieveStructure();
            mS_Combo_Test2.Refresh_Grid();
            mS_Combo_Test1.Refresh_Grid();
            mS_Combo_Test3.Refresh_Grid();
            mS_Combo_Test1.MS_Auto_Popup = true;
            mS_Combo_Test2.MS_Auto_Popup = true;
            mS_Combo_Test3.MS_Auto_Popup = true;
            dateTimePicker1.KeyPress += DateTimePicker1_KeyPress;
        }

        private void DateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void mS_Button1_Click(object sender, EventArgs e)
        {
            //MS_Message.Show("سلام بر دولتــمردان");
            //MS_Message.Show("سلام بر دولتــمردان");
            //var r=MS_Message.Show("سلام بر دولتــمردان", "سلام ددیدی", "555",
            //    MessageBoxButtons.OKCancel, 
            //    MSMessage.FarsiMessageBoxIcon.سوال,
            //    MessageBoxDefaultButton.Button1);
            //MessageBox.Show(r.ToString());

            new Form_Notify("متن نمایشی", "شسنت شسی", Form_Notify.FarsiMessageBoxIcon.اضافه)
            .Popup(Form_Notify.Direction_Show.Right_To_Left, 15000);

        }

        private void mS_Button1_Click_1(object sender, EventArgs e)
        {
            MS_Util.MS_Set_Lang_To_Farsi();
            MS_Util.MS_Set_Currency_Setting();
        }

        private void button2_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Down)
            //{
            //    ms_grid.MoveNext();
            //}
            //else if (e.KeyCode == Keys.Up)
            //{
            //    ms_grid.MovePrevious();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MS_INPUT.SendMessage((int)ms_grid.Handle, (int)MS_INPUT.WMessages.WM_KEYDOWN,
            //   (int)MS_INPUT.VKeys.VK_DOWN, 0);

            //MS_INPUT.SendMessage((int)ms_grid.Handle, (int)MS_INPUT.WMessages.WM_KEYDOWN,
            //    (int)MS_INPUT.VKeys.VK_DOWN, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MS_INPUT.SendMessage((int)label1.Handle, (int)MS_INPUT.WMessages.WM_LBUTTONDBLCLK,
            //   0, 0);

            MS_INPUT.SendMessage((int) ms_grid.Handle, (int) MS_INPUT.WMessages.WM_LBUTTONDBLCLK, 0, 0);
            //MS_INPUT.SendMessage((int) ms_grid.Handle, (int) MS_INPUT.WMessages.WM_LBUTTONUP, 0, 0);

            //MS_Mouse_Input.INPUT mouseDownInput = new MS_Mouse_Input.INPUT();
            //mouseDownInput.type = MS_Mouse_Input.SendInputEventType.InputMouse;
            //mouseDownInput.mkhi.mi.dwFlags = MS_Mouse_Input.MouseEventFlags.MOUSEEVENTF_LEFTDOWN;
            //MS_Mouse_Input.SendInput((uint)button2.Handle, ref mouseDownInput, Marshal.SizeOf(new MS_Mouse_Input.INPUT()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mS_Combo_Test1.SelectAll();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("click");

        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("click");

        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("db click lable");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click lable");

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("click down");

        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("click up");

        }

        private void ms_grid_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            MessageBox.Show("row double clicked");

        }

        private void Form_Two_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        private void Form_Two_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F2)
                //button3.PerformClick();
        }

        private void mS_Combo_Test2_MS_On_Row_Selected(object sender, MS_Control.TSDD.On_Selected e)
        {
            if (e.Item != null)
            {
                button2.Text = (e.Item as test).name;
            }
        }

        private void mS_GridX_Setting1_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting1.MS_Company_Name = "شرکت نگین زاگرس";
            mS_GridX_Setting1.MS_Report_Name="گزارش لیست اقساط";
            mS_GridX_Setting1.MS_Tarix_Report="1395/01/05";
            mS_GridX_Setting1.MS_User_Name = "سبحانی راد ویس";
            mS_GridX_Setting1.MS_Molahezat="برای آزمایش برنامه چاپ";
            mS_GridX_Setting1.MS_Logo = System.Drawing.Image.FromFile(@"E:\My Docs\_Negin_\logo.png");

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //var image = Image.FromFile(@"C:\Users\Sonsy.Soft-PC\Desktop\gol.jpg");
            //var frm=new MS_Control.Image.Form_Image_Editor(new Size(100, 100));
            //frm.MS_Image = image;
            //frm.ShowDialog();

            var frm =new Form_Set_Position();
            frm.ShowDialog();

        }

        private void exampleControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
