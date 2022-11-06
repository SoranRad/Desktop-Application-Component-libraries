using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Janus.Windows.GridEX;
using MS_Control.Filter_Manage;

namespace MS_Control.Controls
{
    public partial class MS_GridX : GridEX
    {
        public MS_GridX()
        {
            InitializeComponent();
            if(!DesignMode && this.SaveSettings)
                this.LoadComponentSettings();
        }

        private void MS_GridX_ColumnVisibleChanged(object sender, ColumnActionEventArgs e)
        {
            if (!DesignMode && this.SaveSettings)
            {
                this.RemoveFilters();
                this.SaveComponentSettings();
            }
        }
        
    }
}
