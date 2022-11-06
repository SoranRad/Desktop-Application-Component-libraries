using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//=========================
//=========================
//=========================
using MS_Control;
using MS_Control.DataBase.SqlFolderBrowse;
using MS_Print_Cheque;

namespace MS_Control_Test
{
    public partial class Form2 : MS_Mother_Two
    {
        private bool _is_Mouse_down = false;
        private Point _start;

        public Form2()
        {
            InitializeComponent();
            mS_Anchors1.MS_Min_X = 20;
            mS_Anchors1.MS_Min_Y = 20;
            mS_Anchors1.MS_Max_X = Width-20;
            mS_Anchors1.MS_Max_Y= Height-20;

            mS_Anchors1.Assign(this);
            ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Form_Set_Position().ShowDialog();
            new Form_Add_Back_Up(".", "", "").ShowDialog();
        }

        //private void button1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    _is_Mouse_down = true;
        //    _start = e.Location;
        //}

        //private void button1_MouseUp(object sender, MouseEventArgs e)
        //{
        //    _is_Mouse_down = false;
        //}

        //private void button1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (_is_Mouse_down )
        //        if (_start.X - e.Location.X != 0 || _start.Y - e.Location.Y != 0)
        //    {
        //        button1.Left= e.Location.X- _start.X  ;
        //        button1.Top= e.Location.Y-_start.Y ;
        //    }
        //}
    }
}
