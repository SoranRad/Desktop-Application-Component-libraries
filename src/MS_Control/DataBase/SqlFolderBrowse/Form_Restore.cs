using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System;
using System.IO;
//*****************
using MS_Control;

namespace MS_Control.DataBase.SqlFolderBrowse
{
    public partial class Form_Restore : MS_Mother_Two
    {
        #region سازنده
        public Form_Restore(string serverName, string userName, string password)
        {
            InitializeComponent();
            strServer = serverName;
            strUsername = userName;
            strPassword = password;
            Constructor();
        }
        #endregion
        #region فیلد
        private SQLServerFolderBrowse ssfbFolderList = new SQLServerFolderBrowse();
        private ToolTip ttBrowser;
        private string strServer;
        private string strUsername;
        private string strPassword;
        private string pathBackUp = "";
        private bool _DoRefresh = true, _EscPressed = false;

        #endregion
        #region Property

        public string SelectedPath => pathBackUp;

        #endregion
        #region متد
        private void AssociateQuery()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //Error that occurs during application execution.
            }
            catch (Exception Ex)
            {

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void LoadData()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //Error that occurs during application execution.
            }
            catch (Exception Ex)
            {
                //MsgBox(Ex.Message, MsgBoxStyle.Information | MsgBoxStyle.OKOnly, "Load Data Error");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void ConstraintsViewsAndManagers()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //Error that occurs during application execution.
            }
            catch (Exception Ex)
            {
                //MsgBox(Ex.Message, MsgBoxStyle.Information | MsgBoxStyle.OKOnly, "Create Constraint Error");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void PopulateCombobox()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //Error that occurs during application execution.
            }
            catch (Exception Ex)
            {
                //MsgBox(Ex.Message, MsgBoxStyle.Information | MsgBoxStyle.OKOnly, "Populate Dropdown Error");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void BindControls(bool blnBind)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            catch (Exception Ex)
            {
                //MsgBox(Ex.Message, MsgBoxStyle.Information | MsgBoxStyle.OKOnly, "Bind Controls Error");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void SetParameters()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //Error that occurs during application execution.
            }
            catch (Exception Ex)
            {
                //MsgBox(Ex.Message, MsgBoxStyle.Information | MsgBoxStyle.OKOnly, "Set Parameters Error");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void SetDefaults()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //Error that occurs during application execution.
            }
            catch (Exception Ex)
            {
                //MsgBox(Ex.Message, MsgBoxStyle.Information | MsgBoxStyle.OKOnly, "Set Defaults Error");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void HelpAndTips()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                SetHelp();
                SetTips();
                //Error that occurs during application execution.
            }
            catch (Exception Ex)
            {
                //MsgBox(Ex.Message, MsgBoxStyle.Information | MsgBoxStyle.OKOnly, "Help And Tips Main Error");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void SetHelp()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //Error that occurs during application execution.
            }
            catch (Exception Ex)
            {
                //MsgBox(Ex.Message, MsgBoxStyle.Information | MsgBoxStyle.OKOnly, "Set Help Error");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void SetTips()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ttBrowser = new ToolTip();
                ttBrowser.SetToolTip(treeView1, "بـا کـلیـک کـردن روی پـوشـه مـی تـوانـید مـسیـر آن را انـتـخاب کـنیـد.");
                ttBrowser.SetToolTip(btnOk, "Assign the folder to the main screen as location.");
                ttBrowser.SetToolTip(btnCancel, "Cancel folder browsing");
                //Error that occurs during application execution.
            }
            catch (Exception Ex)
            {
                //MsgBox(Ex.Message, MsgBoxStyle.Information | MsgBoxStyle.OKOnly, "Set Tips Error");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void DataMain()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                AssociateQuery();
                LoadData();
                ConstraintsViewsAndManagers();
                //Error that occurs during application execution.
            }
            catch (Exception Ex)
            {
                //Interaction.MsgBox(Ex.Message, MsgBoxStyle.Information | MsgBoxStyle.OkOnly, "Data Main Error");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void Constructor()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //frmCallingForm.Enabled = false;
                this.Load += fxnPopulateList;
                treeView1.BeforeExpand += fxnPopulateNode;
                btnOk.Click += fxnGetLocation;
                btnCancel.Click += fxnCancel;
                SetParameters();
                DataMain();
                SetDefaults();
                HelpAndTips();
                //Error that occurs during application execution.
            }
            catch (Exception Ex)
            {
                //MsgBox(Ex.Message, MsgBoxStyle.Information | MsgBoxStyle.OKOnly, "Constructor Error");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            //try
            //{
            //    Cursor.Current = Cursors.WaitCursor;
            //    //frmCallingForm.Enabled = false;
            //    this.Load += fxnPopulateList;
            //    treeView1.BeforeExpand += fxnPopulateNode;
            //    btnOk.Click += fxnGetLocation;
            //    btnCancel.Click += fxnCancel;
            //    SetParameters();
            //    DataMain();
            //    SetDefaults();
            //    HelpAndTips();
            //    //Error that occurs during application execution.
            //}
            //catch (Exception Ex)
            //{
            //    //MsgBox(Ex.Message, MsgBoxStyle.Information | MsgBoxStyle.OKOnly, "Constructor Error");
            //}
            //finally
            //{
            //    Cursor.Current = Cursors.Default;
            //}
        }
        private void Destructor()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.Load -= fxnPopulateList;
                treeView1.BeforeExpand -= fxnPopulateNode;
                btnOk.Click -= fxnGetLocation;
                btnCancel.Click -= fxnCancel;
                //Error that occurs during application execution.
            }
            catch (Exception Ex)
            {
                //switch (Err.Number)
                //{
                //    default:
                //        MsgBox(Ex.Message, MsgBoxStyle.Information | MsgBoxStyle.OKOnly, "Destructor Error");
                //        break;
                //}
            }
            finally
            {
                //frmCallingForm.Enabled = true;

                ssfbFolderList = null;
                //frmCallingForm = null;
            }
        }
        private void fxnPopulateList(System.Object sender, System.EventArgs e)
        {
            string[] strDrives = null;
            string strDrive = null;
            TreeNode nParent = default(TreeNode);
            string strFullname = null;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                fxnConnection();
                strDrives = ssfbFolderList.GetFixedDrives();
                foreach (string strDrive_loopVariable in strDrives)
                {
                    strDrive = strDrive_loopVariable;
                    nParent = treeView1.Nodes.Add(strDrive);
                    nParent.ImageIndex = 0;
                    strFullname = strDrive + ":";
                    nParent.Tag = strFullname;
                    //Keep track of the full path name of the folder.
                    //If subfolders exist, let the user know by showing the collapse(+)
                    if ((ssfbFolderList.GetSubFolders(strFullname) != null))
                    {
                        nParent.Nodes.Add("Dummy");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Folder List Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void fxnGetLocation(object sender, System.EventArgs e)
        {
            try
            {
                if (treeView_Files.Nodes.Count == 0)
                {
                    MS_Message.Show("هیچ فایلی جهت بازگزدانی اطلاعات انتخاب نشده است");
                    return;
                }
                if (treeView_Files.SelectedNode == null)
                {
                    MS_Message.Show("یکی از فایل هـارا جهت بازگردانی اطلاعات انتخاب کنید");
                    return;
                }

                Cursor.Current = Cursors.WaitCursor;
                pathBackUp = lblPath.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Folder Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void fxnCancel(object sender, System.EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pathBackUp = "";
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cancel Browse Folder Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void fxnPopulateNode(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
        {
            if (!_DoRefresh) return;

            string strFullname = null;
            string[] strFolders = null, strFiles = null;
            string strFolder = null;
            TreeNode nChild = default(TreeNode);
            TreeNode nGrandChildNode = default(TreeNode);
            try
            {
                //This is a straight forward function
                Cursor.Current = Cursors.WaitCursor;
                fxnConnection();
                if (e.Node.GetNodeCount(true) > 0)
                {
                    nChild = e.Node;
                    e.Node.FirstNode.Remove();
                    e.Node.Nodes.Clear();
                    strFullname = Convert.ToString(e.Node.Tag);
                    strFolders = ssfbFolderList.GetSubFolders(strFullname);
                    if (strFolders != null)
                        foreach (string strFolder_loopVariable in strFolders)
                        {
                            strFolder = strFolder_loopVariable;
                            //Avoid the system folders to be displayed.
                            if (strFolder.ToLower() != "system volume information"
                                && strFolder.ToLower() != "recycler"
                                && !strFolder.StartsWith("$")
                                && !strFolder.ToLower().EndsWith(".msi"))
                            {
                                nGrandChildNode = nChild.Nodes.Add(strFolder);
                                nGrandChildNode.Tag = strFullname + "\\" + strFolder;
                                nGrandChildNode.ImageIndex = 1;
                                nGrandChildNode.SelectedImageIndex = 2;
                                if ((ssfbFolderList.GetSubFolders(strFullname + "\\" + strFolder) != null))
                                {
                                    nGrandChildNode.Nodes.Add("Dummy");
                                }
                            }
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Populate Node Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void fxnConnection()
        {
            try
            {
                ssfbFolderList.Username = strUsername;
                ssfbFolderList.Password = strPassword;
                ssfbFolderList.Server = strServer;
                ssfbFolderList.Timeout = 600;

            }
            catch (Exception ex)
            {
            }
        }

        private void ShowFileList(TreeViewEventArgs e)
        {
            string strFullname = null;
            string[] strFiles = null;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                fxnConnection();
                strFullname = Convert.ToString(e.Node.Tag);
                //=========================فایل بکاپ
                treeView_Files.Nodes.Clear();
                strFiles = ssfbFolderList.Get_List_File_Support(strFullname);
                if (strFiles != null)
                {
                    foreach (string file in strFiles)
                    {
                        treeView_Files.Nodes.Add(file);
                        lblNothing.Visible = false;
                    }
                }
                else
                    lblNothing.Visible = true;
            }
            catch (Exception ex)
            {
                MS_Message.Show( "خطا در خواندن لیست ","خطا",ex.Message,MessageBoxButtons.OK);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!_DoRefresh)
                return;
            lblPath.Text = e.Node.Tag.ToString();
            if (!e.Node.IsExpanded)
                e.Node.Expand();
            ShowFileList(e);
        }
        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (!_DoRefresh)
                return;
            lblPath.Text = e.Node.Tag.ToString();
            treeView1.SelectedNode = e.Node;
        }

        private void treeView_Files_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblPath.Text += @"\" + e.Node.Text;
        }

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            lblPath.Text = e.Node.Tag.ToString();
            treeView1.SelectedNode = e.Node;
        }

    }
}
