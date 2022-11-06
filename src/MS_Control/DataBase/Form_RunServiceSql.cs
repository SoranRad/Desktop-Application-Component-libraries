using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;

namespace MS_Control.DataBase
{
    public partial class Form_RunServiceSql : MS_Mother_Mali
    {
        public Form_RunServiceSql()
        {
            InitializeComponent();
            Application.DoEvents();
            GetListService();
        }

        private void GetListService()
        {
            MSWait frm = new MSWait();
            frm.Show(this);
            Application.DoEvents();
            string myServer = Environment.MachineName;

            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < servers.Rows.Count; i++)
            {
                Application.DoEvents();
                if (myServer == servers.Rows[i]["ServerName"].ToString()) ///// used to get the servers in the local machine////
                {
                    if ((servers.Rows[i]["InstanceName"] as string) != null)
                    {
                        CmbServerName.Items.Add(/*servers.Rows[i]["ServerName"].ToString()*/ "MSSQL$" +  servers.Rows[i]["InstanceName"]);
                        CmbServerName.SelectedIndex = 0;
                    }
                    else
                        CmbServerName.Items.Add(servers.Rows[i]["ServerName"]);
                }
            }
            frm.Close();
        }

        public static void StartService(string serviceName)
        {
            ServiceController myService = new ServiceController();
            myService.ServiceName = serviceName;// "MSSQL$MOHSEN";
            string svcStatus = myService.Status.ToString();
            if (svcStatus == "Stopped" || svcStatus == "StopPending")
            {
                myService.Start();
                new Form_Notify("راه انـدازی سـرویـس", "سـرویس مـورد نـظر راه انـدازی شــد.",
                          Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                         .Popup(Form_Notify.Direction_Show.Right_To_Left, 2000);
                myService.Refresh();
            }
            else
            {
                MS_Message.Show("سـرویـس انـتـخاب شـده درحـالـت Start مـی بــاشـد.",
                         "تـوجــه", "", MessageBoxButtons.OK, MSMessage.FarsiMessageBoxIcon.تنظیمات);
            }
        }
        public static void StopService(string serviceName)
        {
            ServiceController myService = new ServiceController();
            myService.ServiceName = serviceName;// "MSSQL$MOHSEN";
            string svcStatus = myService.Status.ToString();
            if (svcStatus == "Running")
            {
                myService.Stop();
                new Form_Notify("راه انـدازی سـرویـس", "سـرویس مـورد نـظر غـیـر فـعال شــد.",
                          Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                         .Popup(Form_Notify.Direction_Show.Right_To_Left, 2000);
                myService.Refresh();
            }
            else
            {
                MS_Message.Show("سـرویـس انـتـخاب شـده درحـالـت Stop مـی بــاشـد.",
                         "تـوجــه", "", MessageBoxButtons.OK, MSMessage.FarsiMessageBoxIcon.تنظیمات);
            }
        }

        private void ms_Start_Click(object sender, EventArgs e)
        {
            StartService(CmbServerName.Text.Trim());
        }

        private void ms_Stop_Click(object sender, EventArgs e)
        {
            StopService(CmbServerName.Text.Trim());
        }

        private void CmbServerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CmbServerName.SelectedIndex >= 0)
                {
                    ServiceController myService = new ServiceController();
                    myService.ServiceName = CmbServerName.Text.Trim();
                    ms_Vaziat.Text = myService.Status.ToString();
                }
            }
            catch { }
        }
    }
}
