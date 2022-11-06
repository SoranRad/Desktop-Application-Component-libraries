using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System;
//*****************
using MS_Control;
using System.IO;
using Janus.Windows.UI.CommandBars;

namespace MS_Control.DataBase.SqlFolderBrowse
{
    public partial class Form_Add_Back_Up : MS_Mother_Two
    {
        #region سازنده
        public Form_Add_Back_Up(string serverName, string userName, string password)
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
        private TreeNode mySelectedNode { get;  set; }
        private ToolTip ttBrowser;
        private string strServer;
        private string strUsername;
        private string strPassword;
        private string _pathBackUp = "";
        private bool _DoRefresh = true,_EscPressed=false;
        #endregion

        #region Property

        public string SelectedPath
        {
            get { return _pathBackUp; }
        }

        #endregion
        #region متد

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                _EscPressed = true;
             return  base.ProcessCmdKey(ref msg, keyData);

        }

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
                ttBrowser.SetToolTip(TreeView1, "بـا کـلیـک کـردن روی پـوشـه مـی تـوانـید مـسیـر آن را انـتـخاب کـنیـد.");
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
                TreeView1.BeforeExpand += fxnPopulateNode;
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
        }
        private void Destructor()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.Load -= fxnPopulateList;
                TreeView1.BeforeExpand -= fxnPopulateNode;
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
                    nParent = TreeView1.Nodes.Add(strDrive);
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
                if (string.IsNullOrWhiteSpace(lblPath.Text))
                {
                    MS_Message.Show("مسیـر ایجاد فایل پشتـیبان را انتخـاب کنید");
                    return;
                }
                if (TreeView1.SelectedNode == null)
                {
                    MS_Message.Show("مسیـر ایجاد فایل پشتـیبان را انتخـاب کنید");
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                _pathBackUp = lblPath.Text.Trim();
                this.DialogResult=DialogResult.OK;
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
                _pathBackUp = "";
                this.DialogResult=DialogResult.Cancel;
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
            if(!_DoRefresh)return;

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
                    if(strFolders!=null)
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
        private string GetNewFolderName(TreeNode Node)
        {
            var tmpName = "New Folder";
            var count = 1;
            var newFolder = tmpName;
            while (Node.Nodes.OfType<TreeNode>().Any(x=>x.Text==newFolder))
            {
                newFolder = tmpName + count;
                count++;
            }
            return newFolder;
        }
        #endregion

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(!_DoRefresh)
                return;
            lblPath.Text = e.Node.Tag.ToString();
            if(!e.Node.IsExpanded)
                e.Node.Expand();
        }
        private void ms_New_Folder_Click(object sender, EventArgs e)
        {
            if (lblPath.Text.Trim() != string.Empty && TreeView1.SelectedNode!=null)
            {
                _DoRefresh = false;
                var newFolder = GetNewFolderName(TreeView1.SelectedNode);
                var newNode=new TreeNode(newFolder);
                newNode.Tag = TreeView1.SelectedNode.Tag + "\\" + newFolder;
                TreeView1.SelectedNode.Nodes.Add(newNode);
                TreeView1.SelectedNode.Expand();
                TreeView1.LabelEdit = true;
                newNode.BeginEdit();
            }
        }
        private void TreeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (_EscPressed)
            {
                _EscPressed = false;
                _DoRefresh = true;
                TreeView1.SelectedNode = e.Node.Parent;
                TreeView1.LabelEdit = false;
                e.Node.EndEdit(true);
                fxnPopulateNode(sender,new TreeViewCancelEventArgs(e.Node.Parent,false,TreeViewAction.ByKeyboard));
                return;
            }
            var FolderName = (e.Label ?? "").Trim() == string.Empty
                                ? e.Node.Text
                                : e.Label.Trim();
            if (FolderName != null )
            {
                if (FolderName.Length > 0)
                {
                    if (FolderName.IndexOfAny(new char[] { '@', '.', ',', '!' }) == -1)
                    {
                        //e.Node.BeginEdit();
                        e.Node.EndEdit(false);
                        ssfbFolderList.CreateFolder(e.Node.Parent.Tag.ToString(), FolderName.Trim());
                        TreeView1.LabelEdit = false;
                        _DoRefresh = true;
                        fxnPopulateNode(sender, new 
                            TreeViewCancelEventArgs(e.Node.Parent, false,
                                TreeViewAction.ByKeyboard));
                        TreeView1.LabelEdit = false;
                    }
                    else
                    {
                        /* Cancel the label edit action, inform the user, and 
                           place the node in edit mode again. */
                        e.CancelEdit = true;
                        MS_Message.Show("از علایم " + '@' + '.' + ',' + '!' + " نمیتوانید استفاده کنید");
                        e.Node.BeginEdit();
                    }
                }
                else
                {
                    /* Cancel the label edit action, inform the user, and 
                       place the node in edit mode again. */
                    e.CancelEdit = true;
                    MessageBox.Show("نام پوشه را وارد کنید");
                    e.Node.BeginEdit();
                }
            }
        }
        private void TreeView1_MouseDown(object sender, MouseEventArgs e)
        {
            mySelectedNode = TreeView1.GetNodeAt(e.X, e.Y);
        }
        private void TreeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if(!_DoRefresh)
                return;
            lblPath.Text = e.Node.Tag.ToString();
            TreeView1.SelectedNode = e.Node;
        }

        private void TreeView1_KeyUp(object sender, KeyEventArgs e)
        {
            //MS_Message.Show("");
        }
        private void TreeView1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void Form_Add_Back_Up_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            //_pathBackUp = lblPath.Text;
            //this.DialogResult=DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _pathBackUp = "";

            this.DialogResult=DialogResult.Cancel;
        }
        private void TreeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            lblPath.Text = e.Node.Tag.ToString();
            TreeView1.SelectedNode = e.Node;
        }
    }
}
