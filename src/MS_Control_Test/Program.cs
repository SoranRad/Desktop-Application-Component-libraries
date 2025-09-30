using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control_Test.Properties;
using MS_Grid_Print;
using MS_Control.Office2007Renderer;

namespace MS_Control_Test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ToolStripManager.Renderer = new Office2007Renderer();
            //MS_Mother_Two.MS_Icon_Form = Resources.textfield;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form_Startup());
            Application.Run(new Form_Mali());

        }
    }
}
