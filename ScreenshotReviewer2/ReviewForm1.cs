using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Windows.Forms;
//using System.Windows.Forms.ListView;

namespace ScreenshotReviewer2
{
    public partial class ReviewForm1 : Form
    {
        //private string UsrRole;
        //private string PrjName;
        //private string UsrName;
        public static TextBox usrName1 = new TextBox();
        //public static Image ImageData1;
        //public static Image ImageData2;
        public static RadioButton ImageStatus1 = new RadioButton();
        public static RadioButton ImageStatus2 = new RadioButton();
        public static RadioButton ImageStatus3 = new RadioButton();
        public static RadioButton ImageStatus4 = new RadioButton();
        public static CheckBox SetRef1 = new CheckBox();
        public static ListViewItem ImageList1 = new ListViewItem();
        public string constring;
        public static DataGridView DGV1 = new DataGridView();
        public static CheckBox Lang1 = new CheckBox();
        public static CheckBox Lang2 = new CheckBox();
        public static CheckBox Lang3 = new CheckBox();
        public static CheckBox Lang4 = new CheckBox();
        public static CheckBox Lang5 = new CheckBox();
        public static CheckBox Lang6 = new CheckBox();
        public static RichTextBox Comments1 = new RichTextBox();
        public static TextBox Tags1 = new TextBox();
        public static ProgressBar Progress1 = new ProgressBar();
        public static RadioButton usrRole3Select = new RadioButton();
        private string ProjName = ProjectForm1.projName1.Text;
        private string UserName = ProjectForm1.usrName1.Text;
        private string UserRole = ProjectForm1.UserRole;
        private string recentProj = Environment.GetFolderPath(Environment.SpecialFolder.Recent);

		static private SqlCeConnection conDataBase = new SqlCeConnection("Data Source = C:/Xamarin_Projects/Old/042514/ScreenshotReviewer2/ScreenshotReviewerDB1.sdf");

        public ReviewForm1()
        {
            InitializeComponent();
            PopulateListView();
            imgList1.Select();
            
        }
        
        public string ImageStatus;
        string ImagePath = Environment.CurrentDirectory;
        string Languages;

        //This method is to populate the list view
        private void PopulateListView()
        {
            string SelectView = "View." + openFileDialog1.FileName;
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(ImagePath);
            System.IO.FileInfo[] files = dirInfo.GetFiles(openFileDialog1.FileName, SearchOption.TopDirectoryOnly);
            if (files != null)
            {
                foreach(System.IO.FileInfo file in files)
                {
                    ListViewItem item = new ListViewItem(imgList1.Text);
                    item.SubItems.Add(file.FullName);
                    imgList2.Items.Add(item);
                    pictureBoxData4.Text = @Environment.CurrentDirectory;
                }
            }
        }

        public static Image ImageData1
        {
            get { return ImageData1; }
            set { ImageData1 = value; }
        }

        public static Image ImageData2
        {
            get { return ImageData2; }
            set { ImageData2 = value; }
        }

        void fill_listbox()
        {
			string constring = "Data Source = C:/Xamarin_Projects/Old/042514/ScreenshotReviewer2/ScreenshotReviewerDB1.sdf";
            string Query = "SELECT * FROM database.ScreenshotReviewerDB1 where name='" + imgList1.Text + "' ;";
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
                    imgList1.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ReviewForm1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //This method is to generate the filelist
        private static void GetFilesFromDirectory(string DirPath)
        {
            try
            {
                List<String> TempFiles = new List<string>();
                DirectoryInfo Dir = new DirectoryInfo(DirPath);
                FileInfo[] FileList = Dir.GetFiles("*.*", SearchOption.TopDirectoryOnly );
                var query = from FI in FileList
                where FI.LastWriteTime.Date == DateTime.Now.Date
                select FI.FullName + " " + FI.LastWriteTime;
                TempFiles.Add(DirPath);
                foreach (string s1 in query )
                {
                Console.WriteLine(s1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //This method clears just the image boxes
        private void button6_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            pictureBoxData4.Image = null;
            pictureBoxData1.Image = null;
        }

        //This method controls the save dialog
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Get file name.
            string savename = saveFileDialog1.FileName;
        }

        //This method saves the image for the reference
        private void imgButton3_Click(object sender, EventArgs e)
        {
            try
            {
                // Displays a SaveFileDialog so the user can save the Image
                // assigned to Button2.
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Portable Network Graphic|*.png";
                saveFileDialog1.Title = "Save the image as:";
                saveFileDialog1.ShowDialog();

                // If the file name is not an empty string open it for saving.
                if (saveFileDialog1.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.
                    System.IO.FileStream fs =
                       (System.IO.FileStream)saveFileDialog1.OpenFile();
                    // Saves the Image in the appropriate ImageFormat based upon the
                    // File type selected in the dialog box.
                    // NOTE that the FilterIndex property is one-based.
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            this.imgButton3.Image.Save(fs,
                                System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            this.imgButton3.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Bmp);
                            break;

                        case 3:
                            this.imgButton3.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                        case 4:
                            this.imgButton3.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Png);
                            break;
                    }

                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ReviewForm1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This method controls the image reference for the first(left side) picture box
        private void pictureBoxData1_Click(object sender, EventArgs e)
        {
            Graphics g;
            Bitmap bmp;
            bmp = new Bitmap(200, 200);
            g = this.CreateGraphics();
            g = Graphics.FromImage(bmp);
            g.CopyFromScreen(MousePosition.X - 50, MousePosition.Y - 10, 0, 0, new Size(485, 348));
            pictureBoxData1.Image = bmp;
        }

        //This method controls the image for the main(right side) picture box
        private void pictureBoxData4_Click(object sender, EventArgs e)
        {
            Graphics g;
            Bitmap bmp;
            bmp = new Bitmap(200, 200);
            g = this.CreateGraphics();
            g = Graphics.FromImage(bmp);
            g.CopyFromScreen(MousePosition.X - 50, MousePosition.Y - 10, 0, 0, new Size(485, 348));
            pictureBoxData4.Image = bmp;
        }

        //This method controls the "Set Reference" image toggle
        private void setRefImage_CheckedChanged(object sender, EventArgs e)
        {
            Information1 info = new Information1();
            if (setRefImage.Checked)
            {
                info.Images2 = this.openFileDialog1.FileName;
                SaveXML.SaveData(info, ProjName + ".xml");
                pictureBoxData1.Load(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Please select an image as reference");
            }
        }

        //This method controls the progress bar and progress of the review process
        private void projectProgress(object sender, EventArgs e, string[] filenames)
        {
            ProgressBar pbar = new ProgressBar();
            Information1 info = new Information1();
            pbar.Visible = true;
            pbar.Minimum = 1;
            pbar.Maximum = filenames.Length;
            pbar.Name = "progressBar1";
            pbar.Value = 1;
            pbar.Step = 1;
            for (int x = 1; x <= filenames.Length; x++)
            {
                pbar.PerformStep();
                timer1.Start();
            }
            this.progressBar1.Increment(1);
            info.Progress = progressBar1.Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
                // Stop the timer.
                timer1.Stop();
            else
                this.progressBar1.Increment(1);
                timer1.Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int progress = (int)e.Argument;
            int sum = 0;
            for (int i = 1; i <= progress; i++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                sum += i;
                backgroundWorker1.ReportProgress(i * 100 / progress);
                System.Threading.Thread.Sleep(500);
            }
            e.Result = sum;
        }

        /*This method is to control the filtering for screenshot languages
        //private void groupBox1_Enter(object sender, EventArgs e)
        //{
        //    string[] langFilters = {"*_EN_.*","*_SP_.*","*_FR_.*","*_IT_.*","*_GE_.*"};
        //    //List<FileSystemWatcher> watchers = new List<FileSystemWatcher>();
        //    ListViewItem langFilters = new ListViewItem();

        //    while (string file in langFilters)
        //    {
        //        //FileSystemWatcher w = new FileSystemWatcher();
        //        //w.Filter = file;
        //        //w.Changed += new MyChangedHandler(OnChanged);
        //        //watchers.Add(w);
        //    }

        //    string[] SPFilter1 = Directory.GetFiles(ImagePath, "*_SP_*.bmp | *_ES_*.bmp | *_SP_*.png | *_ES_*.png | *_SP_*.jpg | *_ES_*.jpg");
            

        //    foreach (string file in langFilters)
        //    {
        //        FileInfo fInfo = new FileInfo(file);
        //    }

        //    string[] GEFilter1 = Directory.GetFiles(ImagePath, "*_GE_*.bmp | *_DE_*.bmp | *_GE_*.png | *_DE_*.png | *_GE_*.jpg | *_DE_*.jpg");

        //    foreach (string file in langFilters)
        //    {
        //        FileInfo fInfo = new FileInfo(file);
        //    }

        //    string[] ITFilter1 = Directory.GetFiles(ImagePath, "*_IT_*.bmp | *_IT_*.png | *_IT_*.jpg");

        //    foreach (string file in langFilters)
        //    {
        //        FileInfo fInfo = new FileInfo(file);
        //    }

        //    string[] FRFilter1 = Directory.GetFiles(ImagePath, "*_FR_*.bmp | *_FR_*.png | *_FR_*.jpg");

        //    foreach (string file in langFilters)
        //    {
        //        FileInfo fInfo = new FileInfo(file);
        //    }
        //    string[] ENFilter1 = Directory.GetFiles(ImagePath, "*_EN_*.bmp | *_EN_*.png | *_EN_*.jpg");

        //    foreach (string file in langFilters)
        //    {
        //        FileInfo fInfo = new FileInfo(file);
        //    }
        }*/

        //This method controls image status "Missing"
        private void imgStatus2_CheckedChanged(object sender, EventArgs e)
        {
            if (imgStatus2.Checked)
            ImageStatus = "Missing";
        }

        //This method controls image status "Incorrect"
        private void imgStatus3_CheckedChanged(object sender, EventArgs e)
        {
            ImageStatus = "Incorrect";
        }

        //This method controls image status "Updated"
        private void imgStatus4_CheckedChanged(object sender, EventArgs e)
        {
            ImageStatus = "Updated";
        }

        //This method controls the image open control
        private void imgbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog FBD = new FolderBrowserDialog();
                OpenFileDialog OFD = new OpenFileDialog();
                Information1 info = new Information1();
                ListView item = new ListView();
                DirectoryInfo dir = new DirectoryInfo(ImagePath);
                OFD.Multiselect = true;
                OFD.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Portable Network Graphic|*.png";
                OFD.Title = "Please open a valid image file:";
                //DialogResult dr = this.openFileDialog1.ShowDialog();
                OFD.RestoreDirectory = true;
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileDir in Directory.EnumerateFiles(ImagePath))
                    {
                        imgList1.Items.Clear();
                        //info.Paths = imgList1.Items.ToString();
                        imgList1.Items.AddRange(OFD.FileNames);
                    }

                    //string[] files = Directory.GetFiles(FBD.SelectedPath);

                    foreach (string file in Directory.EnumerateDirectories(ImagePath))
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(file);
                        this.imgList1.Items.Add(dirInfo.Name);
                    }
                    pictureBoxData4.Load(OFD.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ReviewForm1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        //This method resets all of the options in the review software
        private void magButton1_Click(object sender, EventArgs e)
        {
            Graphics g;
            Bitmap bmp1;
            bmp1 = new Bitmap(485, 348);
            g = Graphics.FromImage(bmp1);
            g = this.CreateGraphics();
            pictureBoxData1.Image = bmp1;
            Bitmap bmp2;
            bmp2 = new Bitmap(485, 348);
            g = this.CreateGraphics();
            g = Graphics.FromImage(bmp2);
            pictureBoxData4.Image = bmp2;
            richTextBoxData1.Text = "";
            textBoxData2.Text = "";
            langBox1.Checked = false;
            langBox2.Checked = false;
            langBox3.Checked = false;
            langBox4.Checked = false;
            langBox5.Checked = false;
            langBox6.Checked = false;
            imgStatus1.Checked = false;
            imgStatus2.Checked = false;
            imgStatus3.Checked = false;
            imgStatus4.Checked = false;
            setRefImage.Checked = false;
            imgList1.Items.Clear();
        }

        //This method opens the reference file in the program folder (still testing...)
        private void openButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog FBD = new FolderBrowserDialog();
                OpenFileDialog OFD = new OpenFileDialog();
                XmlSerializer xs = new XmlSerializer(typeof(Information1));
                FileStream readXML = new FileStream(ProjName + ".xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Information1 info = (Information1)xs.Deserialize(readXML);
                ListView item = new ListView();
                DirectoryInfo dir = new DirectoryInfo(ImagePath);
                OFD.Multiselect = true;
                OFD.Filter = "XML | *.xml";
                OFD.Title = "Please open a valid reference file:";
                DialogResult dr = this.openFileDialog1.ShowDialog();
                OFD.RestoreDirectory = true;

                if (OFD.ShowDialog() == DialogResult.OK)
                {
					string constring = "Data Source = C:/Xamarin_Projects/Old/042514/ScreenshotReviewer2/ScreenshotReviewerDB1.sdf";
                    string Query = "Select tblData1.*, tblInfo1.*, tblProject.*, tblUsers1.* from tblData1 CROSS JOIN tblInfo1 CROSS JOIN tblProject CROSS JOIN tblUsers1;";
                    SqlCeConnection conDataBase = new SqlCeConnection(constring);
                    SqlCeCommand cmdDataBase = new SqlCeCommand(Query, conDataBase);
                    SqlCeDataReader myReader;

                    try
                    {
                        using (FileStream fsSource = new FileStream(OFD.FileName, FileMode.Open, FileAccess.Read))
                        {
                            // Read the source file into a byte array. 
                            byte[] bytes = new byte[fsSource.Length];
                            int numBytesToRead = (int)fsSource.Length;
                            int numBytesRead = 0;
                            conDataBase.Open();
                            myReader = cmdDataBase.ExecuteReader();

                            while (numBytesToRead > 0 && myReader.Read())
                            {
                                string Comment = (string)myReader["Comment"];
                                string Tags = (string)myReader["Tags"];
                                string UserName = (string)myReader["UserName"];
                                string Role = (string)myReader["Role"];
                                Image ImageData1 = (Image)myReader["ImageData1"];
                                Image ImageData2 = (Image)myReader["ImageData2"];
                                string Lang = (string)myReader["Lang"];
                                string Name = (string)myReader["Name"];
                                string Path = (string)myReader["Path"];
                                string ImageStatus = (string)myReader["ImageStatus"];
                                string Progress = (string)myReader["Progress"];
                                // Read may return anything from 0 to numBytesToRead. 
                                int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);
                                numBytesRead += n;
                                numBytesToRead -= n;
                                info.Comments = Comment;
                                pictureBoxData4.Image = ImageData1;
                                pictureBoxData1.Image = ImageData2;
                                ImageStatus1.Text = ImageStatus;
                                ImageStatus2.Text = ImageStatus;
                                ImageStatus3.Text = ImageStatus;
                                ImageStatus4.Text = ImageStatus;
                                Tags1.Text = Tags;
                                usrName1.Text = UserName;
                                Lang1.Text = Lang;
                                Lang2.Text = Lang;
                                Lang3.Text = Lang;
                                Lang4.Text = Lang;
                                Lang5.Text = Lang;
                                Lang6.Text = Lang;
                                // Break when the end of the file is reached. 
                                if (n == 0)
                                    break;
                                readXML.Close();
                                conDataBase.Close();
                            }
                            numBytesToRead = bytes.Length;

                            // Write the byte array to the other FileStream. 
                            using (FileStream fsNew = new FileStream(ImagePath,
                                FileMode.Create, FileAccess.Write))
                            {
                                fsNew.Write(bytes, 0, numBytesToRead);
                            }
                            //foreach (string fileDir in Directory.EnumerateFiles(ImagePath))
                            //{
                            //    imgList2.Items.Clear();
                            //    info.Paths = imgList1.Items.ToString();
                            //    //imgList2.Items.SelectedItems[0].Index = true;
                            //}

                            ////string[] files = Directory.GetFiles(FBD.SelectedPath);

                            //foreach (string file in Directory.EnumerateDirectories(ImagePath))
                            //{
                            //    DirectoryInfo dirInfo = new DirectoryInfo(file);
                            //    this.imgList1.Items.Add(dirInfo.Name);
                            //}
                            //pictureBoxData4.Load(OFD.FileName);
                        }
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "ReviewForm1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
            }

            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "You must first save data to the document!");
                }
            }

        //This method creates the reference document, (still testing...)
        public void createButton1_Click(object sender, EventArgs e)
        {
            Information1 info = new Information1();
                      
            try
            {
                ScreenshotReviewer2.ReviewForm1 frm = new ReviewForm1();
                info.Comments = richTextBoxData1.Text;
                info.Images1 = ImageD;
                info.Images2 = pictureBoxData1.Image;
                info.ImageStatus = ImageStatus;
                info.Tags = textBoxData2.Text;
                info.Username = ProjectForm1.usrName1.Text;
                info.Paths = imgList1.SelectedItem.ToString();
                info.Languages = Languages;
                info.Roles = UserRole;
                info.ProjectName = ProjectForm1.projName1.Text;
                SaveXML.SaveData(info, ProjName + ".xml");
                MessageBox.Show("Temp data has been created! \n Please confirm the data is now in the grid. \nYou must also 'Save' the project to update the database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This method controls image status "Correct"
        private void imgStatus1_CheckedChanged(object sender, EventArgs e)
        {
            if (imgStatus1.Checked)
            ImageStatus = "Correct";
        }

        //This method controls language filters for "EN"
        private void langBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (langBox2.Checked)
                Languages = "English";
            if (imgList1.Items.Contains("*.*"))
            {
                imgList1.Items.Remove("IT_*.bmp | IT_*.png | IT_*.jpg | SP_*.bmp | ES_*.bmp | SP_*.png | ES_*.png | SP_*.jpg | ES_*.jpg | FR_*.bmp | FR_*.png | FR_*.jpg | GE_*.bmp | DE_*.bmp | GE_*.png | DE_*.png | GE_*.jpg | DE_*.jpg");
                imgList1.Items.Add("EN_*.bmp | EN_*.png | EN_*.jpg |UK_*.bmp | UK_*.png | UK_*.jpg");
            }
           
        }

        //This method controls language filters for "IT"
        private void langBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (langBox5.Checked)
                Languages = "Italian";
                if (imgList1.Items.Contains("*.*"))
                {
                    imgList1.Items.Remove("EN_*.bmp | EN_*.png | EN_*.jpg | UK_*.bmp | UK_*.png | UK_*.jpg | SP_*.bmp | ES_*.bmp | SP_*.png | ES_*.png | SP_*.jpg | ES_*.jpg | FR_*.bmp | FR_*.png | FR_*.jpg | GE_*.bmp | DE_*.bmp | GE_*.png | DE_*.png | GE_*.jpg | DE_*.jpg");
                    imgList1.Items.Add("IT_*.bmp | IT_*.png | IT_*.jpg");
                }
        }

        //This method controls language filters for "FR"
        private void langBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (langBox6.Checked)
                Languages = "French";
                if (imgList1.Items.Contains("*.*"))
                {
                    imgList1.Items.Remove("IT_*.bmp | IT_*.png | IT_*.jpg | SP_*.bmp | ES_*.bmp | SP_*.png | ES_*.png | SP_*.jpg | ES_*.jpg | GE_*.bmp | DE_*.bmp | GE_*.png | DE_*.png | GE_*.jpg | DE_*.jpg | EN_*.bmp | EN_*.png | EN_*.jpg | UK_*.bmp | UK_*.png | UK_*.jpg");
                    imgList1.Items.Add("FR_*.bmp | FR_*.png | FR_*.jpg");
                }
        }

        //This method controls language filters for "GE"
        private void langBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (langBox4.Checked)
                Languages = "German";
                if (imgList1.Items.Contains("*.*"))
                {
                    imgList1.Items.Remove("IT_*.bmp | IT_*.png | IT_*.jpg | SP_*.bmp | ES_*.bmp | SP_*.png | ES_*.png | SP_*.jpg | ES_*.jpg | FR_*.bmp | FR_*.png | FR_*.jpg | EN_*.bmp | EN_*.png | EN_*.jpg | UK_*.bmp | UK_*.png | UK_*.jpg");
                    imgList1.Items.Add(@"GE_*.bmp | DE_*.bmp | GE_*.png | DE_*.png | GE_*.jpg | DE_*.jpg");
                }
        }

        //This method controls language filters for "SP"
        private void langBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (langBox3.Checked)
            {
                Languages = "Spanish";
            }
                if (imgList1.Items.Contains("*.*"))
                {
                    imgList1.Items.Remove("IT_*.bmp | IT_*.png | IT_*.jpg | FR_*.bmp | FR_*.png | FR_*.jpg | GE_*.bmp | DE_*.bmp | GE_*.png | DE_*.png | GE_*.jpg | DE_*.jpg | EN_*.bmp | EN_*.png | EN_*.jpg | UK_*.bmp | UK_*.png | UK_*.jpg");
                    imgList1.Items.Add(@"SP_*.bmp | ES_*.bmp | SP_*.png | ES_*.png | SP_*.jpg | ES_*.jpg");
                }
        }

        //This method controls the "All" language selector
        private void langBox1_CheckedChanged(object sender, EventArgs e)
           
        {
            if (langBox1.Checked)
            {
                langBox2.Checked = true;
                langBox3.Checked = true;
                langBox4.Checked = true;
                langBox5.Checked = true;
                langBox6.Checked = true;
            }
            else
            {
                langBox2.Checked = false;
                langBox3.Checked = false;
                langBox4.Checked = false;
                langBox5.Checked = false;
                langBox6.Checked = false;
            }
        }

        //This method controls the next image selector
        private void imgNextButton1_Click(object sender, EventArgs e)
        {
            int index = imgList2.SelectedIndices.Count;

            if (index < imgList1.Items.Count - 1)
            {
                imgList2.Select();
                imgList1.Items[index + 1] = true;
                imgPreviousButton1.Enabled = true;
                if ((index = imgList2.SelectedItems[0].Index) == imgList1.Items.Count - 1)
                {
                    imgNextButton1.Enabled = false;
                }
            }
        }

        //This method controls the previous image selector
        private void imgPreviousButton1_Click(object sender, EventArgs e)
        {
            int index = imgList2.SelectedIndices[0];

            if (index > 0)
            {
                imgList2.Select();
                imgList2.SelectedItems[index - 1].Selected = true;
            }
        }

        //This method controls the indexing of the listview
        private void imgList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem imageFiles = new ListViewItem();

            if (imgList2.SelectedItems.Count != 0)
            {
                try
                {
                    var files = from file in Directory.EnumerateFiles(@".../ScreenshotReviewer/", "*.png | *.bmp | *.jpg", SearchOption.TopDirectoryOnly)
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
                pictureBoxData4.Image = System.Drawing.Image.FromFile(ImagePath + imgList2.SelectedItems[0].SubItems[0].Text);
            }
        }

        //This method controls the mouse selection from the listview 
        private void imgList2_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewItem selection = imgList2.GetItemAt(e.X, e.Y);
            if (selection != null)
            {
                string name = selection.ToString().Remove(0, 15).TrimEnd('}');
                openFileDialog1.FileName = name.ToString();
                if (selection != null)
                {
                    pictureBoxData4.Image = System.Drawing.Image.FromFile(selection.SubItems[1].Text);
                }
            }
        }

        //private void imgList2_MouseUp(object sender, MouseEventArgs e)
        //{
        //    ListViewItem selection = imgList2.GetItemAt(e.X, e.Y);
        //    if (selection != null)
        //    {
        //        string name = selection.ToString().Remove(0, 15).TrimEnd('}');
        //        openFileDialog1.FileName = name.ToString();
        //        if (selection != null)
        //        {
        //            pictureBoxData4.Image = System.Drawing.Image.FromFile(selection.SubItems[1].Text);
        //        }
        //    }
        //}

        //private void imgList2_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    ListViewItem selection = imgList2.GetItemAt(e.X, e.Y);
        //    if (selection != null)
        //    {
        //        string name = selection.ToString().Remove(0, 15).TrimEnd('}');
        //        openFileDialog1.FileName = name.ToString();
        //        if (selection != null)
        //        {
        //            pictureBoxData4.Image = System.Drawing.Image.FromFile(selection.SubItems[1].Text);
        //        }
        //    }
        //}

        //This method clears the memory and exits the program cleanly

        private void exitButton1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(-1);
        }

        private void ReviewForm1_Load(object sender, EventArgs e)
        {
            Information1 info = new Information1();
            this.dataTable1TableAdapter1.Fill(this.screenshotReviewerDB1DataSet1.DataTable1);
            //SQLFunctions.Refresh(this.screenshotReviewerDB1DataSet1);
            ImageStatus1 = imgStatus1;
            ImageStatus2 = imgStatus2;
            ImageStatus3 = imgStatus3;
            ImageStatus4 = imgStatus4;
            SetRef1 = setRefImage;
            //ImgList1 = imgList1;
            Lang1 = langBox1;
            Lang2 = langBox2;
            Lang3 = langBox3;
            Lang4 = langBox4;
            Lang5 = langBox5;
            Lang6 = langBox6;
            Progress1 = progressBar1;
            Comments1 = richTextBoxData1;
            Tags1 = textBoxData2;
        }

        private void addList1_Click(object sender, EventArgs e)
        {
            
        }

        private void remList1_Click(object sender, EventArgs e)
        {
            imgList2.SelectedItems.Clear();
        }

        //This method saves the reference document review1 and updates the DB (still testing...)
        private void submitButton1_Click(object sender, EventArgs e)
        {
            //string constring = "Data Source = C:\Xamarin_Projects\Old\042514\ScreenshotReviewer2";
            //string Query = "Select tblData1.*, tblInfo1.*, tblProject.*, tblUsers1.* from tblData1 CROSS JOIN tblInfo1 CROSS JOIN tblProject CROSS JOIN tblUsers1;";
            //SqlCeConnection conDataBase = new SqlCeConnection(constring);
            //SqlCeCommand cmdDataBase = new SqlCeCommand(Query, conDataBase);
            DataForm1 fm3 = new DataForm1();
            
            XmlSerializer xs = new XmlSerializer(typeof(Information1));
            FileStream writeXML = new FileStream(ProjName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            //Information1 info = (Information1)xs.Serialize(writeXML, DGV1)
            Information1 info = new Information1();
            //SqlCeDataReader myReader;

            try
            {
                SQLFunctions.Refresh(DGV1);
                //string Tags = (string)myReader["Tags"];
                //string UserName = (string)myReader["UserName"];
                //string Role = (string)myReader["Role"];
                //Image ImageData1 = (Image)myReader["ImageData1"];
                //Image ImageData2 = (Image)myReader["ImageData2"];
                //string Lang = (string)myReader["Lang"];
                //string Name = (string)myReader["Name"];
                //string ImageStatus = (string)myReader["ImageStatus"];
                //string Path = (string)myReader["Path"];
                //string Progress = (string)myReader["Progress"];
                //string ProjectName = (string)myReader["ProjectName"];
                //string Comment = (string)myReader["Comment"];

                info.Comments = richTextBoxData1.Text;
                //ImageData1 = pictureBoxData4.Image;
                //ImageData2 = pictureBoxData1.Image;
                info.ImageStatus = ImageStatus;
                info.Tags = textBoxData2.Text;
                info.Username = UserName;
                info.Languages = Languages;
                info.Progress = progressBar1.ToString();
                info.Roles = UserRole;
                info.Paths = imgList2.Text;
                info.ProjectName = ProjName;

                while (DGV1.Focused != true)
                {
                    info.Comments = DGV1.CurrentRow.Cells[7].Value.ToString();
                    info.Paths = DGV1.CurrentRow.Cells[1].Value.ToString();
                    info.Paths = DGV1.CurrentRow.Cells[3].Value.ToString();
                    ImageStatus = DGV1.CurrentRow.Cells[4].Value.ToString();
                    info.Tags = DGV1.CurrentRow.Cells[10].Value.ToString();
                    ProjectForm1.usrName1.Text = DGV1.CurrentRow.Cells[19].Value.ToString();
                    info.Paths = DGV1.CurrentRow.Cells[5].Value.ToString();
                    Languages = DGV1.CurrentRow.Cells[2].Value.ToString();
                    //info.Progress = DGV1.CurrentRow.Cells[16].Value.ToString();
                    UserRole = DGV1.CurrentRow.Cells[20].Value.ToString();
                    info.ProjectName = DGV1.CurrentRow.Cells[12].Value.ToString();
                    foreach (ListViewItem itemRow in this.imgList1.Items)
                    {
                        for (int counter = 0; counter < itemRow.SubItems.Count; counter++)
                        {
                            int ItemCount = itemRow.SubItems.Count;
                            List<string> fileList = itemRow.SubItems.Cast<ListViewItem>().Select(item => item.Text).ToList();
                        }
                    }
                }
                
                SaveXML.SaveData(info, ProjName + ".xml");
                SQLFunctions.Insert(info.Username, info.Comments, info.Tags, info.Roles, info.Images2, info.Languages, info.Paths, info.ImageStatus, info.ProjectName);
                SQLFunctions.Refresh(DGV1);
                this.Validate();
                this.tableAdapterManager1.UpdateAll(this.screenshotReviewerDB1DataSet1);
                
                MessageBox.Show("Data has been saved to the DB!");
                fm3.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ReviewForm1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  //private void imgListMenuStrip1_Click(object sender, EventArgs e)
        //{
        //    if ()
        //    {

        //    }
        //}
    }
}
