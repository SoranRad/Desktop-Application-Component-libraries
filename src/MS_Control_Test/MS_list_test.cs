using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_Control.TSDD;

namespace MS_Control_Test
{
    public class test
    {
        public int      code;
        public string   name;
    }
    public partial class MS_list_test : MS_Base_GridPopup
    {
        List<test> _list = new List<test>();

        public MS_list_test()
        {
            InitializeComponent();
            //mS_Tool_Strip1.Items.Remove(ms_null);
            ms_null.Visible = false;
            ms_Add.Click += Ms_Add_Click;

        }

        private void Ms_Add_Click(object sender, EventArgs e)
        {
            //_Parent.HideMenu();
            //new Form2().ShowDialog();
            //_Parent.ShowMenu();
        }

        private void Refresh_List()
        {
            ms_grid.DataSource = _list.ToList();
        }


        public override void Refresh_Grid()
        {
            _list.Clear();
            _list.AddRange(new List<test>() {
                new test() {code = 1,name ="سوران"},
                new test() {code = 1,name ="سوران"},
                new test() {code = 1,name ="سوران"},
                new test() {code = 1,name ="سوران"},
                new test() {code = 1,name ="سوران"},
                new test() {code = 2,name ="سیروان"},
                new test() {code = 2,name ="سیروان"},
                new test() {code = 2,name ="سیروان"},
                new test() {code = 2,name ="سیروان"},
                new test() {code = 2,name ="سیروان"},
                new test() {code = 2,name ="سیروان"},
                new test() {code = 3,name ="محمد"},
                new test() {code = 3,name ="محمد"},
                new test() {code = 3,name ="محمد"},
                new test() {code = 3,name ="محمد"},
                new test() {code = 3,name ="محمد"},
                new test() {code = 4,name ="شیرکو"},
                new test() {code = 4,name ="شیرکو"},
                new test() {code = 4,name ="شیرکو"},
                new test() {code = 4,name ="شیرکو"},
                new test() {code = 4,name ="شیرکو"},
                new test() {code = 4,name ="شیرکو"},
                });
            Refresh_List();
            mS_Tool_Strip1.Items.Remove(ms_null);

        }
        public override void Filter_Grid(string Str)
        {
            Str = (Str ?? "").Trim();
            if (string.IsNullOrEmpty(Str))
                Refresh_List();
            else
            {
                //var list = _list.Where(x => x.name.Contains(Str));
                //ms_grid.DataSource = list.ToList();
            }
        }


    }
}
