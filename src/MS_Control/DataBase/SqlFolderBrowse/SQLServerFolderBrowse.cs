using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System;

namespace MS_Control.DataBase.SqlFolderBrowse
{
    public class SQLServerFolderBrowse : IDisposable
    {
        #region Variables 
        private string strServer;
        private string strUsername;
        private string strPassword;

        private long lngTimeout = 900;
        private SqlConnection sqlcFolders;
        private SqlDataReader drFolders;
        private SqlCommand sqlFixedDrives;
        private SqlCommand sqlAvailableDrives;
        private SqlCommand sqlSubFolders;
        private SqlCommand sqlFile;
        #endregion
        #region  Constants 
        private const string strFixedDrivesSP = "xp_fixeddrives";
        private const string strAvailableDrivesSP = "xp_availablemedia";
        private const string strFile = "xp_dirtree";
        private const string strSubFoldersSP = "xp_subdirs";
        private const string strDatabase = "Master";
        #endregion
        #region Constractor
        public SQLServerFolderBrowse()
        {
            try
            {
                sqlcFolders = new SqlConnection();
                sqlFixedDrives = new SqlCommand(strFixedDrivesSP);
                sqlAvailableDrives = new SqlCommand(strAvailableDrivesSP);
                sqlFile = new SqlCommand(strFile);
                sqlSubFolders = new SqlCommand();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Initialization Error - " + ex.Message);
            }
            finally
            {
            }
        }
        #endregion

        public string Server
        {
            set { strServer = value; }
        }
        public string Username
        {
            set { strUsername = value; }
        }
        public string Password
        {
            set { strPassword = value; }
        }
        public long Timeout
        {
            set { lngTimeout = value; }
        }

        public string[] GetFixedDrives()
        {
            string[] strList = null;
            int intCounter = 0;
            try
            {
                InitializeConnection();
                sqlFixedDrives.Connection = sqlcFolders;
                sqlFixedDrives.CommandType = CommandType.StoredProcedure;
                sqlcFolders.Open();
                //drFolders = 
                drFolders = sqlFixedDrives.ExecuteReader();
                //Populate the tree view with the names of fixed drives
                while (drFolders.Read())
                {
                    Array.Resize(ref strList, intCounter + 1);
                    strList[intCounter] = drFolders.GetString(0);
                    intCounter += 1;
                }

                sqlcFolders.Close();
                sqlcFolders.Dispose();

                return strList;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                drFolders.Close();
                sqlcFolders.Close();
                drFolders = null;
            }
        }
        public string[] GetAvailableDrives()
        {
            string[] strList = { };
            int intCounter = 0;
            try
            {
                InitializeConnection();
                sqlAvailableDrives.Connection = sqlcFolders;
                sqlAvailableDrives.CommandType = CommandType.StoredProcedure;
                sqlcFolders.Open();
                drFolders = sqlAvailableDrives.ExecuteReader();
                //Popualte the tree view with the names of available drives
                while (drFolders.Read())
                {
                    Array.Resize(ref strList, intCounter + 1);
                    strList[intCounter] = drFolders.GetString(0);
                    intCounter += 1;
                }

                sqlcFolders.Close();
                sqlcFolders.Dispose();

                return strList;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Get Available Drives Error - " + ex.Message);
                return null;
            }
            finally
            {
                drFolders.Close();
                sqlcFolders.Close();
                drFolders = null;
            }
        }
        public string[] GetSubFolders(string ParentFolder)
        {
            string[] strList = null;
            int intCounter = 0;
            try
            {
                InitializeConnection();
                sqlSubFolders.Connection = sqlcFolders;
                sqlSubFolders.CommandText = strSubFoldersSP + " '" + ParentFolder + "'";

                sqlcFolders.Open();
                drFolders = sqlSubFolders.ExecuteReader();
                while (drFolders.Read())
                {
                    Array.Resize(ref strList, intCounter + 1);
                    strList[intCounter] = drFolders.GetString(0);
                    intCounter += 1;
                }

                sqlcFolders.Close();
                sqlcFolders.Dispose();

                return strList;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                sqlcFolders.Close();
                drFolders = null;
            }
        }
        public string[] Get_List_File_Support(string Path)
        {
            string[] strList = null;
            int intCounter = 0;
            try
            {
                InitializeConnection();
                sqlFile.Connection = sqlcFolders;
                sqlFile.CommandText = strFile + "  '" + Path + "',1,1";

                sqlcFolders.Open();
                drFolders = sqlFile.ExecuteReader();
                while (drFolders.Read())
                {

                    var kind = drFolders.GetInt32(2);
                    if (kind != 1)
                        continue;
                    var file = drFolders.GetString(0);

                    var ext = System.IO.Path.GetExtension(file).ToLower();
                    if (!string.IsNullOrWhiteSpace(ext))
                        //if ((ext == ".rar" || ext == ".zip" || ext == ".bak" || ext == ".tm"))
                        if ( ext == ".bak" )
                        {
                            Array.Resize(ref strList, intCounter + 1);
                            strList[intCounter] = file;
                            intCounter += 1;
                        }
                }

                sqlcFolders.Close();
                sqlcFolders.Dispose();

                return strList;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                sqlcFolders.Close();
                drFolders = null;
            }
        }

        public bool CreateFolder(string Path,string FolderName)
        {
            //declare @Path varchar(100)
            //set @Path = 'c:\CreatedFromSQL'
            //EXEC master.dbo.xp_create_subdir @Path
            
            try
            {
                InitializeConnection();
                sqlSubFolders.Connection = sqlcFolders;
                sqlSubFolders.CommandText = "xp_create_subdir '"+Path+"\\"+FolderName+"'";
                //sqlSubFolders.CommandType=CommandType.StoredProcedure;

                sqlcFolders.Open();
                sqlSubFolders.ExecuteNonQuery();
                //drFolders = sqlSubFolders.ExecuteReader();
                //while (drFolders.Read())
                //{
                //    Array.Resize(ref strList, intCounter + 1);
                //    strList[intCounter] = drFolders.GetString(0);
                //    intCounter += 1;
                //}

                sqlcFolders.Close();
                sqlcFolders.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlcFolders.Close();
                drFolders = null;
            }
            return true;
        }

        public bool DeleteFolder()
        {
            return true;
        }

        void IDisposable.Dispose()
        {
            try
            {
                sqlcFolders = null;
                drFolders = null;
                sqlFixedDrives = null;
                sqlAvailableDrives = null;
                sqlSubFolders = null;

            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
        }
        private void InitializeConnection()
        {
            try
            {
                //Create connection string if one does not exist
                if (sqlcFolders.ConnectionString.Length == 0)
                {
                    if (strUsername.Trim() == string.Empty || strPassword.Trim() == string.Empty)
                        sqlcFolders.ConnectionString = "POOLING=FALSE;Integrated Security=True;DATABASE=" + strDatabase + 
                            ";SERVER=" + strServer + ";CONNECTION TIMEOUT=" + lngTimeout;
                    else 
                        sqlcFolders.ConnectionString = "POOLING=FALSE;USER ID=" + strUsername + ";PASSWORD=" + strPassword + 
                            ";DATABASE=" + strDatabase + ";SERVER=" + strServer + ";CONNECTION TIMEOUT=" + lngTimeout;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Connection Initialization Error - " + ex.Message);
            }
        }
    }
}
