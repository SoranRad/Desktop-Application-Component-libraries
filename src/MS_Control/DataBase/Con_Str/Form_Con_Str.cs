using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System;

namespace MS_Control.DataBase.Con_Str
{
    public partial class Form_Con_Str : MS_Mother
    {
        public class cl_Con_Str
        {
            public static string _Con_Str_Hash;
            public static string _Con_Str_Decode;
            public static string _Title;
        }

        public Form_Con_Str()
        {
            Font = new Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            InitializeComponent();
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }

        private void Check_Server_CheckedChanged(object sender, System.EventArgs e)
        {
            if (Check_Server.Checked == true)
            {
                txtPassword.Enabled = txtUserName.Enabled = true;
            }
            else
            {
                txtPassword.Enabled = txtUserName.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Check_Server.Checked == true)
            {
                try
                {
                    SqlConnection objConnection = new SqlConnection
                    (@"Data Source=" + txtServerName.Text +
                    ";Persist Security Info=True;User Id=" + txtUserName.Text +
                    ";Password=" + txtPassword.Text + "");
                    objConnection.Open();
                    DataTable DataBases = objConnection.GetSchema("Databases");
                    objConnection.Close();
                    foreach (DataRow dr in DataBases.Rows)
                    {
                        cmbListDBs.Items.Add(dr["database_name"]);
                    }
                }
                catch (Exception ex) { MessageBox.Show("اطـــلاعــات وارد شـــده صــحــیــح نــیــســت.\n\n" + ex.Message, "خــــطـــــا در ارتـــبـــاط"); }
            }
            else
            {
                try
                {
                    SqlConnection objConnection = new SqlConnection
                    (@"Data Source=" + txtServerName.Text + ";Integrated Security=True");
                    objConnection.Open();
                    DataTable DataBases = objConnection.GetSchema("Databases");
                    objConnection.Close();
                    foreach (DataRow dr in DataBases.Rows)
                    {
                        cmbListDBs.Items.Add(dr["database_name"]);
                    }
                }
                catch (Exception ex) { MessageBox.Show("اطـــلاعــات وارد شـــده صــحــیــح نــیــســت.\n\n" + ex.Message, "خــــطـــــا در ارتـــبـــاط"); }
            }
            cmbListDBs.Focus();
            cmbListDBs.DroppedDown = true;
        }

        private void cmbListDBs_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (Check_Server.Checked == true)
            {
                txtConStr.Text = "Data Source=" + txtServerName.Text
                    + ";Initial Catalog=" + cmbListDBs.Text
                    + ";Persist Security Info=True;User ID="
                    + txtUserName.Text + ";Password="
                    + txtPassword.Text + "";
            }
            else
            {
                txtConStr.Text = "Data Source=" + txtServerName.Text
                   + ";Initial Catalog=" + cmbListDBs.Text
                   + ";Integrated Security=True";
            }
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            if (ms_title_con.Text.Trim() == "")
            {
                ms_title_con.Focus();
                return;
            }
            cl_Con_Str._Con_Str_Decode = txtConStr.Text;
            cl_Con_Str._Title = ms_title_con.Text;
            this.Close();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ms_address_db_ButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog b = new OpenFileDialog();
            b.Filter = @"image file|*.*";
            DialogResult d = b.ShowDialog();
            if (d == DialogResult.Cancel)
                return;
            ms_address_db.Text = b.FileName;
            ms_name_db.Text = Path.GetFileNameWithoutExtension(b.FileName);
            //"Server=.;AttachDbFilename=F:\\My Project\\C#\\__Zana__\\Shop Mini\\DB_Back_Copanies\\sardasht_isaco\\db.mdf;Database=DB_Mini_Shop;Trusted_Connection=Yes;"

            txtConStr.Text = "Server=" + txtServerName.Text.Trim() + ";AttachDbFilename=" + ms_address_db.Text +
                ";Database=" + ms_name_db.Text + ";Trusted_Connection=Yes;";
            if (Check_Server.Checked == true)
            {
                txtConStr.Text += "User ID="
                    + txtUserName.Text + ";Password="
                    + txtPassword.Text + ";";
            }
        }

        private void ms_name_db_TextChanged(object sender, EventArgs e)
        {
            txtConStr.Text = "Server=" + txtServerName.Text.Trim() + ";AttachDbFilename=" + ms_address_db.Text +
                ";Database=" + ms_name_db.Text + ";Trusted_Connection=Yes;";
            if (Check_Server.Checked == true)
            {
                txtConStr.Text += "User ID="
                    + txtUserName.Text + ";Password="
                    + txtPassword.Text + ";";
            }
        }

        private void ms_test_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection objConnection = new SqlConnection(txtConStr.Text);
                objConnection.Open();
                objConnection.Close();
                MessageBox.Show("تســت موفق .");
            }
            catch (Exception ex) { MessageBox.Show("اطـــلاعــات وارد شـــده صــحــیــح نــیــســت.\n\n" + ex.Message, "خــــطـــــا در ارتـــبـــاط"); }
        }

        private void ms_address_db_TextChanged(object sender, EventArgs e)
        {
            txtConStr.Text = "Server=" + txtServerName.Text.Trim() + ";AttachDbFilename=" + ms_address_db.Text +
                ";Database=" + ms_name_db.Text + ";Trusted_Connection=Yes;";
            if (Check_Server.Checked == true)
            {
                txtConStr.Text += "User ID="
                    + txtUserName.Text + ";Password="
                    + txtPassword.Text + ";";
            }
        }
    }
}
