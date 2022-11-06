using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control.Controls;


namespace MS_Control.Filter_Manage
{
    public partial class Form_FilterEditor : MS_Mother_Two
    {
        public Form_FilterEditor(MS_GridX DataGrid)
        {
            InitializeComponent();
            filterEditor1.SourceControl = DataGrid;
            this.AutoScroll = true;
        }
    }
}
