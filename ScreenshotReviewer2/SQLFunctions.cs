using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;

namespace ScreenshotReviewer2
{

    static class SQLFunctions
    {
        static private string UserName = ProjectForm1.usrName1.Text;
        //private string Comment = ReviewForm1.richTextBoxData1.Text;
        //private string Tags = ReviewForm1.textBoxData2.Text;
        static private string Role = ProjectForm1.UserRole;
        //private string ImageData = ReviewForm1.pictureBoxData4.Image;
        //private string Lang = ReviewForm1.groupBox1.Text;
        static private string ProjName = ProjectForm1.projName1.Text;

        //private string Progress1 = ReviewForm1.progressBar1.ToString();
        //private string ImageStatus = ImageStatus;
        //private string Name = ReviewForm1.imgList1.Items;
		static private string constring = "Data Source = C:/Xamarin_Projects/Old/042514/ScreenshotReviewer2/ScreenshotReviewerDB1.sdf";
        static private SqlCeConnection conDataBase = new SqlCeConnection(constring);


        static public void Refresh(DataGridView dataTable1DataGridView)
        {
            
            using (conDataBase)
            using (SqlCeCommand ReadCom = new SqlCeCommand("SELECT tblData1.*, tblInfo1.*, tblProject.*, tblUsers1.* FROM tblData1 CROSS JOIN tblInfo1 CROSS JOIN tblProject CROSS JOIN tblUsers1", conDataBase))
                try
                {
                    conDataBase.Open();
                    SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter("SELECT tblData1.*, tblInfo1.*, tblProject.*, tblUsers1.* FROM tblData1 CROSS JOIN tblInfo1 CROSS JOIN tblProject CROSS JOIN tblUsers1", conDataBase);
                    DataTable dataTable = new DataTable();
                    SqlCeDataReader reader = ReadCom.ExecuteReader();
                    while (reader.Read())
                    {
                        dataAdapter.Fill(dataTable);
                        dataTable1DataGridView.DataSource = dataTable;
                    }
                }
                catch (SqlCeException exception)
                {
                    MessageBox.Show(exception.ToString());
                }
                finally
                {
                    conDataBase.Close();
                }
        }

        static public void Insert(string UserName, string Comment, string Tags, string Role, string ImageData, string Lang, string Paths, string ImageStatus, string ProjName)
        {
            string Query1 = "INSERT INTO tblInfo1 (Comment, Tags) VALUES('" + Comment + "','" + Tags + "')";
            string Query2 = "INSERT INTO tblUsers1 (UserName, Role) VALUES('" + UserName + "','" + Role + "')";
            string Query3 = "INSERT INTO tblData1 (ImageData, Lang, Name, ImageStatus) VALUES('" + ImageData + "','" + Lang + "','" + Paths + "','" + ImageStatus + "')";
            string Query4 = "INSERT INTO tblProject (ProjectName) VALUES('"+ ProjName + "')";

            try
            {
                conDataBase.Open();
                SqlCeCommand cmdDataBase1 = new SqlCeCommand(Query1, conDataBase);
                SqlCeCommand cmdDataBase2 = new SqlCeCommand(Query2, conDataBase);
                SqlCeCommand cmdDataBase3 = new SqlCeCommand(Query3, conDataBase);
                SqlCeCommand cmdDataBase4 = new SqlCeCommand(Query4, conDataBase);
                cmdDataBase1.CommandText = Query1;
                cmdDataBase1.Parameters.AddWithValue("@Comment", SqlDbType.NVarChar).Value = Comment;
                cmdDataBase1.Parameters.AddWithValue("@Tags", SqlDbType.NVarChar).Value = Tags;
                cmdDataBase1.ExecuteNonQuery();
                cmdDataBase2.CommandText = Query2;
                cmdDataBase2.Parameters.AddWithValue("@UserName", SqlDbType.NChar).Value = UserName;
                cmdDataBase2.Parameters.AddWithValue("@Role", SqlDbType.NChar).Value = Role;
                cmdDataBase2.ExecuteNonQuery();
                cmdDataBase3.CommandText = Query3;
                cmdDataBase3.Parameters.AddWithValue("@ImageData", SqlDbType.Image).Value = ImageData;
                cmdDataBase3.Parameters.AddWithValue("@Lang", SqlDbType.NChar).Value = Lang;
                cmdDataBase3.Parameters.AddWithValue("@Paths", SqlDbType.NVarChar).Value = Paths;
                cmdDataBase3.Parameters.AddWithValue("@ImageStatus", SqlDbType.NVarChar).Value = ImageStatus;
                cmdDataBase3.ExecuteNonQuery();
                cmdDataBase4.CommandText = Query4;
                //cmdDataBase4.Parameters.AddWithValue("@Progress", SqlDbType.Int).Value = Progress;
                cmdDataBase4.Parameters.AddWithValue("@ProjectName", SqlDbType.NVarChar).Value = ProjName;
                cmdDataBase4.ExecuteNonQuery();
                cmdDataBase1.Parameters.Clear();
                cmdDataBase2.Parameters.Clear();
                cmdDataBase3.Parameters.Clear();
                cmdDataBase4.Parameters.Clear();
                conDataBase.Close();
            }
            catch (SqlCeException exception)
            {
                MessageBox.Show(exception.ToString());
                Application.ExitThread();
            }
            finally
            {
                conDataBase.Close();
            }

        }

        static public void Remove(string _userName, DataGridView _dataGridView)
        {
            try
            {
                conDataBase.Open();
                SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter("DELETE tblData1.*, tblInfo1.*, tblProject.*, tblUsers1.* FROM tblData1 CROSS JOIN tblInfo1 CROSS JOIN tblProject CROSS JOIN tblUsers1", conDataBase);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
            }
            catch (SqlCeException exception)
            {
                MessageBox.Show(exception.ToString());
                Application.ExitThread();
            }
            finally
            {
                conDataBase.Close();
            }

        }

        static public void fill_listbox(string ProjName)
        {
			string constring = "Data Source = C:/Xamarin_Projects/Old/042514/ScreenshotReviewer2/ScreenshotReviewerDB1.sdf";
            string Query = "SELECT tblData1.*, tblInfo1.*, tblProject.*, tblUsers1.* FROM tblData1 CROSS JOIN tblInfo1 CROSS JOIN tblProject CROSS JOIN tblUsers1 where name='" + ProjName + "' ;";
            SqlCeConnection conDataBase = new SqlCeConnection(constring);
            SqlCeCommand cmdDataBase = new SqlCeCommand(Query, conDataBase);
            SqlCeDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetOrdinal("Name").ToString();
                    //ProjectForm1.projectView1.Items.Add(sName);
                }
            }
            catch (SqlCeException exception)
            {
                MessageBox.Show(exception.Message, "ProjectForm1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }

        }
    }
}
