namespace ScreenshotReviewer2
{
    partial class ReviewForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewForm1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imgList2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxData1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxData4 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgStatus1 = new System.Windows.Forms.RadioButton();
            this.imgStatus3 = new System.Windows.Forms.RadioButton();
            this.imgStatus4 = new System.Windows.Forms.RadioButton();
            this.imgStatus2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.langBox6 = new System.Windows.Forms.CheckBox();
            this.langBox5 = new System.Windows.Forms.CheckBox();
            this.langBox4 = new System.Windows.Forms.CheckBox();
            this.langBox3 = new System.Windows.Forms.CheckBox();
            this.langBox2 = new System.Windows.Forms.CheckBox();
            this.langBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.magButton1 = new System.Windows.Forms.Button();
            this.createButton1 = new System.Windows.Forms.Button();
            this.openButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxData2 = new System.Windows.Forms.TextBox();
            this.imgButton2 = new System.Windows.Forms.Button();
            this.imgButton3 = new System.Windows.Forms.Button();
            this.imgbutton1 = new System.Windows.Forms.Button();
            this.imgPreviousButton1 = new System.Windows.Forms.Button();
            this.submitButton1 = new System.Windows.Forms.Button();
            this.imgNextButton1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addList1 = new System.Windows.Forms.Button();
            this.remList1 = new System.Windows.Forms.Button();
            this.exitButton1 = new System.Windows.Forms.Button();
            this.imgList1 = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.richTextBoxData1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.setRefImage = new System.Windows.Forms.CheckBox();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataTable1TableAdapter1 = new ScreenshotReviewer2.ScreenshotReviewerDB1DataSetTableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager1 = new ScreenshotReviewer2.ScreenshotReviewerDB1DataSetTableAdapters.TableAdapterManager();
            this.screenshotReviewerDB1DataSet1 = new ScreenshotReviewer2.ScreenshotReviewerDB1DataSet();
            this.imgListMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxData4)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenshotReviewerDB1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.imgList2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxData1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxData4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.imgList1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.98875F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.89344F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.14344F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 976);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // imgList2
            // 
            this.imgList2.AllowDrop = true;
            this.imgList2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgList2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.imgList2.Location = new System.Drawing.Point(9, 635);
            this.imgList2.Name = "imgList2";
            this.imgList2.Size = new System.Drawing.Size(473, 117);
            this.imgList2.TabIndex = 9;
            this.imgList2.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File Path";
            // 
            // pictureBoxData1
            // 
            this.pictureBoxData1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxData1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxData1.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxData1.Name = "pictureBoxData1";
            this.pictureBoxData1.Size = new System.Drawing.Size(485, 345);
            this.pictureBoxData1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxData1.TabIndex = 1;
            this.pictureBoxData1.TabStop = false;
            this.pictureBoxData1.Click += new System.EventHandler(this.pictureBoxData1_Click);
            // 
            // pictureBoxData4
            // 
            this.pictureBoxData4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxData4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxData4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxData4.Location = new System.Drawing.Point(494, 3);
            this.pictureBoxData4.Name = "pictureBoxData4";
            this.pictureBoxData4.Size = new System.Drawing.Size(485, 345);
            this.pictureBoxData4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxData4.TabIndex = 2;
            this.pictureBoxData4.TabStop = false;
            this.pictureBoxData4.Click += new System.EventHandler(this.pictureBoxData4_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox5);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(494, 354);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(485, 275);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgStatus1);
            this.groupBox2.Controls.Add(this.imgStatus3);
            this.groupBox2.Controls.Add(this.imgStatus4);
            this.groupBox2.Controls.Add(this.imgStatus2);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 75);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Status";
            // 
            // imgStatus1
            // 
            this.imgStatus1.AutoSize = true;
            this.imgStatus1.Location = new System.Drawing.Point(16, 19);
            this.imgStatus1.Name = "imgStatus1";
            this.imgStatus1.Size = new System.Drawing.Size(59, 17);
            this.imgStatus1.TabIndex = 0;
            this.imgStatus1.TabStop = true;
            this.imgStatus1.Text = "Correct";
            this.imgStatus1.UseVisualStyleBackColor = true;
            this.imgStatus1.CheckedChanged += new System.EventHandler(this.imgStatus1_CheckedChanged);
            // 
            // imgStatus3
            // 
            this.imgStatus3.AutoSize = true;
            this.imgStatus3.Location = new System.Drawing.Point(88, 19);
            this.imgStatus3.Name = "imgStatus3";
            this.imgStatus3.Size = new System.Drawing.Size(67, 17);
            this.imgStatus3.TabIndex = 5;
            this.imgStatus3.TabStop = true;
            this.imgStatus3.Text = "Incorrect";
            this.imgStatus3.UseVisualStyleBackColor = true;
            // 
            // imgStatus4
            // 
            this.imgStatus4.AutoSize = true;
            this.imgStatus4.Location = new System.Drawing.Point(88, 42);
            this.imgStatus4.Name = "imgStatus4";
            this.imgStatus4.Size = new System.Drawing.Size(66, 17);
            this.imgStatus4.TabIndex = 7;
            this.imgStatus4.TabStop = true;
            this.imgStatus4.Text = "Updated";
            this.imgStatus4.UseVisualStyleBackColor = true;
            // 
            // imgStatus2
            // 
            this.imgStatus2.AutoSize = true;
            this.imgStatus2.Location = new System.Drawing.Point(16, 42);
            this.imgStatus2.Name = "imgStatus2";
            this.imgStatus2.Size = new System.Drawing.Size(60, 17);
            this.imgStatus2.TabIndex = 6;
            this.imgStatus2.TabStop = true;
            this.imgStatus2.Text = "Missing";
            this.imgStatus2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.langBox6);
            this.groupBox1.Controls.Add(this.langBox5);
            this.groupBox1.Controls.Add(this.langBox4);
            this.groupBox1.Controls.Add(this.langBox3);
            this.groupBox1.Controls.Add(this.langBox2);
            this.groupBox1.Controls.Add(this.langBox1);
            this.groupBox1.Location = new System.Drawing.Point(167, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show Language";
            // 
            // langBox6
            // 
            this.langBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.langBox6.AutoSize = true;
            this.langBox6.Location = new System.Drawing.Point(71, 58);
            this.langBox6.Name = "langBox6";
            this.langBox6.Size = new System.Drawing.Size(40, 17);
            this.langBox6.TabIndex = 6;
            this.langBox6.Text = "FR";
            this.langBox6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.langBox6.UseVisualStyleBackColor = true;
            this.langBox6.CheckedChanged += new System.EventHandler(this.langBox6_CheckedChanged);
            // 
            // langBox5
            // 
            this.langBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.langBox5.AutoSize = true;
            this.langBox5.Location = new System.Drawing.Point(71, 37);
            this.langBox5.Name = "langBox5";
            this.langBox5.Size = new System.Drawing.Size(36, 17);
            this.langBox5.TabIndex = 5;
            this.langBox5.Text = "IT";
            this.langBox5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.langBox5.UseVisualStyleBackColor = true;
            this.langBox5.CheckedChanged += new System.EventHandler(this.langBox5_CheckedChanged);
            // 
            // langBox4
            // 
            this.langBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.langBox4.AutoSize = true;
            this.langBox4.Location = new System.Drawing.Point(71, 15);
            this.langBox4.Name = "langBox4";
            this.langBox4.Size = new System.Drawing.Size(41, 17);
            this.langBox4.TabIndex = 4;
            this.langBox4.Text = "GE";
            this.langBox4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.langBox4.UseVisualStyleBackColor = true;
            this.langBox4.CheckedChanged += new System.EventHandler(this.langBox4_CheckedChanged);
            // 
            // langBox3
            // 
            this.langBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.langBox3.AutoSize = true;
            this.langBox3.Location = new System.Drawing.Point(17, 58);
            this.langBox3.Name = "langBox3";
            this.langBox3.Size = new System.Drawing.Size(40, 17);
            this.langBox3.TabIndex = 3;
            this.langBox3.Text = "SP";
            this.langBox3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.langBox3.UseVisualStyleBackColor = true;
            this.langBox3.CheckedChanged += new System.EventHandler(this.langBox3_CheckedChanged);
            // 
            // langBox2
            // 
            this.langBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.langBox2.AutoSize = true;
            this.langBox2.Location = new System.Drawing.Point(17, 37);
            this.langBox2.Name = "langBox2";
            this.langBox2.Size = new System.Drawing.Size(41, 17);
            this.langBox2.TabIndex = 2;
            this.langBox2.Text = "EN";
            this.langBox2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.langBox2.UseVisualStyleBackColor = true;
            this.langBox2.CheckedChanged += new System.EventHandler(this.langBox2_CheckedChanged);
            // 
            // langBox1
            // 
            this.langBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.langBox1.AutoSize = true;
            this.langBox1.Location = new System.Drawing.Point(17, 15);
            this.langBox1.Name = "langBox1";
            this.langBox1.Size = new System.Drawing.Size(45, 17);
            this.langBox1.TabIndex = 1;
            this.langBox1.Text = "ALL";
            this.langBox1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.langBox1.UseVisualStyleBackColor = true;
            this.langBox1.CheckedChanged += new System.EventHandler(this.langBox1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.progressBar1);
            this.groupBox5.Location = new System.Drawing.Point(293, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 52);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Review Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(157, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.magButton1);
            this.groupBox3.Controls.Add(this.createButton1);
            this.groupBox3.Controls.Add(this.openButton1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxData2);
            this.groupBox3.Controls.Add(this.imgButton2);
            this.groupBox3.Controls.Add(this.imgButton3);
            this.groupBox3.Controls.Add(this.imgbutton1);
            this.groupBox3.Controls.Add(this.imgPreviousButton1);
            this.groupBox3.Controls.Add(this.submitButton1);
            this.groupBox3.Controls.Add(this.imgNextButton1);
            this.groupBox3.Location = new System.Drawing.Point(3, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 117);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image and Document Controls";
            // 
            // magButton1
            // 
            this.magButton1.Location = new System.Drawing.Point(99, 83);
            this.magButton1.Name = "magButton1";
            this.magButton1.Size = new System.Drawing.Size(75, 26);
            this.magButton1.TabIndex = 18;
            this.magButton1.Text = "Reset";
            this.magButton1.UseVisualStyleBackColor = true;
            this.magButton1.Click += new System.EventHandler(this.magButton1_Click);
            // 
            // createButton1
            // 
            this.createButton1.Location = new System.Drawing.Point(189, 83);
            this.createButton1.Name = "createButton1";
            this.createButton1.Size = new System.Drawing.Size(75, 26);
            this.createButton1.TabIndex = 17;
            this.createButton1.Text = "Create Ref";
            this.createButton1.UseVisualStyleBackColor = true;
            this.createButton1.Click += new System.EventHandler(this.createButton1_Click);
            // 
            // openButton1
            // 
            this.openButton1.Location = new System.Drawing.Point(270, 83);
            this.openButton1.Name = "openButton1";
            this.openButton1.Size = new System.Drawing.Size(75, 26);
            this.openButton1.TabIndex = 16;
            this.openButton1.Text = "Open Ref";
            this.openButton1.UseVisualStyleBackColor = true;
            this.openButton1.Click += new System.EventHandler(this.openButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tag (csv):";
            // 
            // textBoxData2
            // 
            this.textBoxData2.Location = new System.Drawing.Point(189, 54);
            this.textBoxData2.Name = "textBoxData2";
            this.textBoxData2.Size = new System.Drawing.Size(237, 20);
            this.textBoxData2.TabIndex = 14;
            // 
            // imgButton2
            // 
            this.imgButton2.Location = new System.Drawing.Point(9, 51);
            this.imgButton2.Name = "imgButton2";
            this.imgButton2.Size = new System.Drawing.Size(75, 26);
            this.imgButton2.TabIndex = 13;
            this.imgButton2.Text = "Pull Image";
            this.imgButton2.UseVisualStyleBackColor = true;
            this.imgButton2.Click += new System.EventHandler(this.button6_Click);
            // 
            // imgButton3
            // 
            this.imgButton3.Location = new System.Drawing.Point(9, 83);
            this.imgButton3.Name = "imgButton3";
            this.imgButton3.Size = new System.Drawing.Size(75, 26);
            this.imgButton3.TabIndex = 12;
            this.imgButton3.Text = "Save Image";
            this.imgButton3.UseVisualStyleBackColor = true;
            this.imgButton3.Click += new System.EventHandler(this.imgButton3_Click);
            // 
            // imgbutton1
            // 
            this.imgbutton1.Location = new System.Drawing.Point(9, 19);
            this.imgbutton1.Name = "imgbutton1";
            this.imgbutton1.Size = new System.Drawing.Size(75, 26);
            this.imgbutton1.TabIndex = 11;
            this.imgbutton1.Text = "Open Image";
            this.imgbutton1.UseVisualStyleBackColor = true;
            this.imgbutton1.Click += new System.EventHandler(this.imgbutton1_Click);
            // 
            // imgPreviousButton1
            // 
            this.imgPreviousButton1.Location = new System.Drawing.Point(99, 51);
            this.imgPreviousButton1.Name = "imgPreviousButton1";
            this.imgPreviousButton1.Size = new System.Drawing.Size(75, 26);
            this.imgPreviousButton1.TabIndex = 10;
            this.imgPreviousButton1.Text = "Previous";
            this.imgPreviousButton1.UseVisualStyleBackColor = true;
            this.imgPreviousButton1.Click += new System.EventHandler(this.imgPreviousButton1_Click);
            // 
            // submitButton1
            // 
            this.submitButton1.Location = new System.Drawing.Point(351, 83);
            this.submitButton1.Name = "submitButton1";
            this.submitButton1.Size = new System.Drawing.Size(75, 26);
            this.submitButton1.TabIndex = 2;
            this.submitButton1.Text = "Save";
            this.submitButton1.UseVisualStyleBackColor = true;
            this.submitButton1.Click += new System.EventHandler(this.submitButton1_Click);
            // 
            // imgNextButton1
            // 
            this.imgNextButton1.Location = new System.Drawing.Point(99, 19);
            this.imgNextButton1.Name = "imgNextButton1";
            this.imgNextButton1.Size = new System.Drawing.Size(75, 26);
            this.imgNextButton1.TabIndex = 4;
            this.imgNextButton1.Text = "Next";
            this.imgNextButton1.UseVisualStyleBackColor = true;
            this.imgNextButton1.Click += new System.EventHandler(this.imgNextButton1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addList1);
            this.groupBox4.Controls.Add(this.remList1);
            this.groupBox4.Controls.Add(this.exitButton1);
            this.groupBox4.Location = new System.Drawing.Point(3, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 51);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List Controls";
            // 
            // addList1
            // 
            this.addList1.Location = new System.Drawing.Point(9, 19);
            this.addList1.Name = "addList1";
            this.addList1.Size = new System.Drawing.Size(75, 26);
            this.addList1.TabIndex = 16;
            this.addList1.Text = "Add Item";
            this.addList1.UseVisualStyleBackColor = true;
            this.addList1.Click += new System.EventHandler(this.addList1_Click);
            // 
            // remList1
            // 
            this.remList1.Location = new System.Drawing.Point(99, 19);
            this.remList1.Name = "remList1";
            this.remList1.Size = new System.Drawing.Size(75, 26);
            this.remList1.TabIndex = 17;
            this.remList1.Text = "Delete Item";
            this.remList1.UseVisualStyleBackColor = true;
            this.remList1.Click += new System.EventHandler(this.remList1_Click);
            // 
            // exitButton1
            // 
            this.exitButton1.Location = new System.Drawing.Point(189, 19);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(75, 26);
            this.exitButton1.TabIndex = 15;
            this.exitButton1.Text = "Exit";
            this.exitButton1.UseVisualStyleBackColor = true;
            this.exitButton1.Click += new System.EventHandler(this.exitButton1_Click);
            // 
            // imgList1
            // 
            this.imgList1.AllowDrop = true;
            this.imgList1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgList1.FormattingEnabled = true;
            this.imgList1.Location = new System.Drawing.Point(494, 635);
            this.imgList1.Name = "imgList1";
            this.imgList1.Size = new System.Drawing.Size(485, 121);
            this.imgList1.TabIndex = 6;
            this.imgList1.SelectedIndexChanged += new System.EventHandler(this.imgList2_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.Controls.Add(this.richTextBoxData1);
            this.groupBox6.Location = new System.Drawing.Point(3, 378);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(485, 227);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Comments";
            // 
            // richTextBoxData1
            // 
            this.richTextBoxData1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBoxData1.Location = new System.Drawing.Point(6, 18);
            this.richTextBoxData1.Name = "richTextBoxData1";
            this.richTextBoxData1.Size = new System.Drawing.Size(473, 203);
            this.richTextBoxData1.TabIndex = 3;
            this.richTextBoxData1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "jpg,.bmp,.gif,.png";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // setRefImage
            // 
            this.setRefImage.AutoSize = true;
            this.setRefImage.Location = new System.Drawing.Point(361, 357);
            this.setRefImage.Name = "setRefImage";
            this.setRefImage.Size = new System.Drawing.Size(127, 17);
            this.setRefImage.TabIndex = 1;
            this.setRefImage.Text = "Set Reference Image";
            this.setRefImage.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.UserProfile;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = ScreenshotReviewer2.ScreenshotReviewerDB1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // screenshotReviewerDB1DataSet1
            // 
            this.screenshotReviewerDB1DataSet1.DataSetName = "ScreenshotReviewerDB1DataSet";
            this.screenshotReviewerDB1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imgListMenuStrip1
            // 
            this.imgListMenuStrip1.Name = "imgListMenuStrip1";
            this.imgListMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ReviewForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 758);
            this.Controls.Add(this.setRefImage);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReviewForm1";
            this.Text = "Screenshot Reviewer";
            this.Load += new System.EventHandler(this.ReviewForm1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxData4)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screenshotReviewerDB1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxData1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button submitButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button imgNextButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button imgPreviousButton1;
        private System.Windows.Forms.Button imgButton2;
        private System.Windows.Forms.Button imgButton3;
        private System.Windows.Forms.Button imgbutton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createButton1;
        private System.Windows.Forms.Button openButton1;
        private System.Windows.Forms.Button magButton1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button exitButton1;
        private ScreenshotReviewerDB1DataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private ScreenshotReviewerDB1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private ScreenshotReviewerDB1DataSet screenshotReviewerDB1DataSet1;
        public System.Windows.Forms.PictureBox pictureBoxData4;
        public System.Windows.Forms.RadioButton imgStatus1;
        public System.Windows.Forms.CheckBox langBox1;
        public System.Windows.Forms.RichTextBox richTextBoxData1;
        public System.Windows.Forms.CheckBox langBox6;
        public System.Windows.Forms.CheckBox langBox5;
        public System.Windows.Forms.CheckBox langBox4;
        public System.Windows.Forms.CheckBox langBox3;
        public System.Windows.Forms.CheckBox langBox2;
        public System.Windows.Forms.RadioButton imgStatus3;
        public System.Windows.Forms.RadioButton imgStatus4;
        public System.Windows.Forms.RadioButton imgStatus2;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.CheckBox setRefImage;
        public System.Windows.Forms.TextBox textBoxData2;
        public System.Windows.Forms.ListBox imgList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView imgList2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button addList1;
        private System.Windows.Forms.Button remList1;
        private System.Windows.Forms.ContextMenuStrip imgListMenuStrip1;
    }
}

