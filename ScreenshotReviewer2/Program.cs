using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Data.SqlServerCe;

namespace ScreenshotReviewer2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            string ImagePath = Environment.CurrentDirectory;
            if (args.Length > 0)
            {
                if (Directory.Exists(args[0]))
                {
                    ImagePath = args[0];
                }
                else
                {
                    Console.WriteLine("{0} not found; using current directory:",
                        args[0]);
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var review1 = new Information1
            {
                data1 = "Comments",
                data2 = "Tags",
                data3 = "Username",
                data4 = "Images1",
                data5 = "ImageStatus",
                data6 = "Languages",
                data7 = "Progress",
                data9 = "Images2",
                data10 = "Roles"
            };

            foreach (string paths in args)
            {
                if (File.Exists(paths))
                {
                    // This path is a file
                    ProcessFile(paths);
                }
                else if (Directory.Exists(paths))
                {
                    // This path is a directory
                    ProcessDirectory(paths);
                }
                else
                {
                    MessageBox.Show("{0} is not a valid file or directory.", paths);
                }
            }

            //using (SqlCeConnection cs = new SqlCeConnection(@"Data Source = |DataDirectory|...\ScreenshotReviewerDB1.sdf"))
            //{
            //    byte[] data;
            //    try
            //    {
            //        Information1 pathInfo = new Information1();
            //        pathInfo.Paths = ReviewForm1.ActiveForm.ToString();
            //        data = System.IO.File.ReadAllBytes(@"...\ScreenshotReviewerDB1.sdf");
            //        SqlCeCommand cmd = new SqlCeCommand("INSERT INTO tblData1 (data) VALUES (@DATA)", cs);
            //        cmd.Parameters.AddWithValue("@DATA", data);
            //        cs.Open();
            //        cmd.ExecuteNonQuery();
            //        cs.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            Application.Run(new ProjectForm1());
        }

        public static void ProcessDirectory(string targetDirectory)
            {
                // Process the list of files found in the directory. 
                string[] fileEntries = Directory.GetFiles(targetDirectory);
                foreach (string fileName in fileEntries)
                    ProcessFile(fileName);

                // Recurse into subdirectories of this directory. 
                string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
                foreach (string subdirectory in subdirectoryEntries)
                    ProcessDirectory(subdirectory);
            }

        // Insert logic for processing found files here. 
        public static void ProcessFile(string path)
        {
            MessageBox.Show("Processed file '{0}'.", path);
        }
    }
}
