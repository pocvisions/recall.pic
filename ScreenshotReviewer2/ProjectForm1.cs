using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
//using System.Windows.Forms.ListView;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml;
using System.IO.MemoryMappedFiles;
using System.Data.SqlServerCe;

namespace ScreenshotReviewer2
{
    public partial class ProjectForm1 : Form
    {
        public static TextBox usrName1 = new TextBox();
        public static TextBox projName1 = new TextBox();
        public static RadioButton usrRole1Select = new RadioButton();
        public static RadioButton usrRole2Select = new RadioButton();
        public static RadioButton usrRole3Select = new RadioButton();
        public static string UserRole;
        public static ListViewItem ProjectList1 = new ListViewItem();

        //public void LoadListView(ListViewItemCollection items)
        //{

        //}

        public ProjectForm1()
        {
            InitializeComponent();
            PopulateListView();
            projectView1.Select();
        }
      
        //private string PrjName;
   
        string ProjectPath = Environment.CurrentDirectory;

        //This method is to populate the list view
        private void PopulateListView()
        {
            string SelectView = "View." + openFileDialog1.FileName;
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(ProjectPath);
            System.IO.FileInfo[] files = dirInfo.GetFiles(openFileDialog1.FileName, SearchOption.TopDirectoryOnly);
            if (files != null)
            {
                foreach (System.IO.FileInfo file in files)
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.FullName);
                    projectView1.Items.Add(item);    
                }
            }
        }

        //This method controls user role "Submitter"
        private void usrRole1_CheckedChanged(object sender, EventArgs e)
        {
            Information1 info = new Information1();
            if (usrRole1.Checked)
            {
                UserRole = "Submitter";
                info.Roles = UserRole;
            }
        }

        //This method controls user role "Reviewer"
        private void usrRole2_CheckedChanged(object sender, EventArgs e)
        {
            Information1 info = new Information1();
            if (usrRole1.Checked)
            {
                UserRole = "Reviewer";
                info.Roles = UserRole;
            }
        }

        //This method controls user role "Client"
        private void usrRole3_CheckedChanged(object sender, EventArgs e)
        {
            Information1 info = new Information1();
            if (usrRole1.Checked)
            {
                UserRole = "Client";
                info.Roles = UserRole;
            }
        }

        private void usrData1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (usrData1.Text != null)
                {
                    Information1 info = new Information1();
                    info.Username = usrData1.Text;
                }
                else
                {
                    MessageBox.Show("Please state your name before proceeding.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please confirm your project directory is valid.");
            }
        }

        private void opProj1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            OpenFileDialog OFD = new OpenFileDialog();
            ListView item = new ListView();
            DirectoryInfo dir = new DirectoryInfo(ProjectPath);
            ReviewForm1 newProject = new ReviewForm1();
            try
            {
                OFD.Multiselect = true;
                OFD.Filter = "XML | *.xml";
                OFD.Title = "Please open a valid reference file:";
                OFD.RestoreDirectory = true;
                OFD.ShowDialog();

                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileDir in Directory.EnumerateFiles(ProjectPath))
                    {
                        projectView1.Items.Clear();
                        //info.Paths = imgList1.Items.ToString();
                        projectView1.Items.Add(OFD.FileName);
                    }

                    foreach (string file in Directory.EnumerateDirectories(ProjectPath))
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(file);
                        this.projectView1.Items.Add(dirInfo.Name);
                    }
                }
                else
                {
                    MessageBox.Show("Please select valid reference file(s).");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ProjectForm1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

			string constring = "Data Source= C:/Xamarin_Projects/Old/042514/ScreenshotReviewer2/ScreenshotReviewerDB1.sdf";
            string Query = "Select tblData1.*, tblInfo1.*, tblProject.*, tblUsers1.* from tblData1 CROSS JOIN tblInfo1 CROSS JOIN tblProject CROSS JOIN tblUsers1;";
            SqlCeConnection conDataBase = new SqlCeConnection(constring);
            SqlCeCommand cmdDataBase = new SqlCeCommand(Query, conDataBase);
            SqlCeDataReader myReader;
            
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                string Tags = (string)myReader["Tags"];
                string UserName = (string)myReader["UserName"];
                string Role = (string)myReader["Role"];
                Image ImageData1 = (Image)myReader["ImageData1"];
                Image ImageData2 = (Image)myReader["ImageData2"];
                string Lang = (string)myReader["Lang"];
                string Name = (string)myReader["Name"];
                string ImageStatus = (string)myReader["ImageStatus"];
                string Path = (string)myReader["Path"];
                string Progress = (string)myReader["Progress"];
                string ProjectName = (string)myReader["ProjectName"];
                string Comment = (string)myReader["Comment"];
                XmlSerializer xs = new XmlSerializer(typeof(Information1));
                FileStream readXML = new FileStream(OFD.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                Information1 info = (Information1)xs.Deserialize(readXML);

                while (myReader.Read())
                {
                    ReviewForm1.Comments1.Text = Comment;
                    ReviewForm1.ImageData1 = ImageData1;
                    ReviewForm1.ImageData2 = ImageData2;
                    ReviewForm1.ImageStatus1.Text = ImageStatus;
                    ReviewForm1.ImageStatus2.Text = ImageStatus;
                    ReviewForm1.ImageStatus3.Text = ImageStatus;
                    ReviewForm1.ImageStatus4.Text = ImageStatus;
                    ReviewForm1.Tags1.Text = Tags;
                    usrName1.Text = UserName;
                    ReviewForm1.Lang1.Text = Lang;
                    ReviewForm1.Lang2.Text = Lang;
                    ReviewForm1.Lang3.Text = Lang;
                    ReviewForm1.Lang4.Text = Lang;
                    ReviewForm1.Lang5.Text = Lang;
                    ReviewForm1.Lang6.Text = Lang;
                    //ReviewForm1.ImagePath.Text = 
                    newProject.ShowDialog();
                    readXML.Close();
                    conDataBase.Close();
                }
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ProjectForm1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This method creates the project data and root document
        private void creProj1_Click(object sender, EventArgs e)     
        {
            ReviewForm1 fm2 = new ReviewForm1();
            
            try
            {
                Information1 info = new Information1();
                info.ProjectName = projectData1.Text;
                info.Roles = UserRole;
                info.Username = usrData1.Text;
                SaveXML.SaveData(info, info.ProjectName);
                XmlRootAttribute xRoot = new XmlRootAttribute(info.ProjectName);
                xRoot.Namespace = info.ProjectName;
                xRoot.ElementName = info.ProjectName;

                foreach (ListViewItem itemRow in this.projectView1.Items)
                {
                    for (int counter = 0; counter < itemRow.SubItems.Count; counter++)
                    {
                        int ItemCount = itemRow.SubItems.Count;
                        List<string> fileList = itemRow.SubItems.Cast<ListViewItem>().Select(item => item.Text).ToList();
                    }
                }
                fm2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This method opens the help documentation
        private void helpLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://sea-sps-02/test_ProdDev/pokewiki/SitePages/Screenshot%20Reviewer%20Help.aspx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Note: You must first be connected to the Internet!");
            }
        }

        private void projectView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(ProjectPath);
            foreach (object item in projectView1.Items)
            {
                if (projectView1.SelectedItems.Count != 0)
                {
                    try
                    {
                        var files = from file in Directory.EnumerateFiles(ProjectPath, ".xml", SearchOption.TopDirectoryOnly)
                                    from line in File.ReadLines(file)
                                    select new
                                    {
                                        File = file,
                                        Line = line
                                    };

                        foreach (var f in files)
                        {
                            Console.WriteLine("{0}\t{1}", f.File, f.Line);
                        }
                        Console.WriteLine("{0} files found.", files.Count().ToString());
                    }
                    catch (UnauthorizedAccessException UAEx)
                    {
                        Console.WriteLine(UAEx.Message);
                    }
                    catch (PathTooLongException PathEx)
                    {
                        Console.WriteLine(PathEx.Message);
                    }
                    projectView1.Show();
                }
            }
            var projectViewItem = new ListViewItem();
            projectView1.Items.Add(projectViewItem);
        }

        private void ProjectForm1_Load(object sender, EventArgs e)
        {
            usrName1 = usrData1;
            usrRole1Select = usrRole1;
            usrRole2Select = usrRole2;
            usrRole3Select = usrRole3;
            projName1 = projectData1;
        }

        private void remProj1_Click(object sender, EventArgs e)
        {
            projectView1.Clear();
        }
    }
}
