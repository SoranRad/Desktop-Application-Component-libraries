using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Control.DataBase.Con_Str
{
    public partial class Form_Con_Str_New : MS_Mother_Two
    {
        public string MS_Con_str = "";
        public bool MS_Show_Lock_Address=false;
        public string MS_Lock_Address = "";

        public bool MultipleDatabase => this.NzMutipleDb.Checked;

        public Form_Con_Str_New(bool Show_Lock_Address=false)
        {
            this.Font = new Font("Tahoma", 9.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(178)));
            InitializeComponent();
            MS_Show_Lock_Address = Show_Lock_Address;

            lbl_Lock.Visible = ms_lock_address.Visible = Show_Lock_Address;
        }

        private void Check_Server_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = txtUserName.Enabled = Check_Server.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cmbListDBs.Items.Clear();
            var str = @"Data Source=" + txtServerName.Text +
                      ";Persist Security Info=True" +
                      (Check_Server.Checked
                          ? ";User Id=" + txtUserName.Text +
                            ";Password=" + txtPassword.Text + ";"
                          : ";Integrated Security=True;");
            try
            {
                SqlConnection objConnection = new SqlConnection(str);
                objConnection.Open();
                DataTable DataBases = objConnection.GetSchema("Databases");
                objConnection.Close();
                foreach (DataRow dr in DataBases.Rows)
                    cmbListDBs.Items.Add(dr["database_name"]);
                cmbListDBs.Focus();
                cmbListDBs.DroppedDown = true;
            }
            catch (Exception ex) { 
                MS_Message.Show("اطـــلاعــات وارد شـــده صــحــیــح نــیــســت.\n\n"
                , "خــــطـــــا در ارتـــبـــاط", ex.Message,
                MessageBoxButtons.OK);
            }
        }
        private void cmbListDBs_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtConStr.Text = "Data Source=" + txtServerName.Text
                    + ";Initial Catalog=" + cmbListDBs.Text+
                   (Check_Server.Checked
                          ? ";User Id=" + txtUserName.Text +
                            ";Password=" + txtPassword.Text + ";"
                          : ";Integrated Security=True;");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MS_Con_str = txtConStr.Text;
            MS_Lock_Address = ms_lock_address.Text;
            this.DialogResult=DialogResult.OK;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            MS_Con_str = "";
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
