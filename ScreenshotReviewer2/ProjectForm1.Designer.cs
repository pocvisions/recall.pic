namespace ScreenshotReviewer2
{
    partial class ProjectForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.remProj1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.projectData1 = new System.Windows.Forms.TextBox();
            this.opProj1 = new System.Windows.Forms.Button();
            this.creProj1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.projectView1 = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usrData1 = new System.Windows.Forms.TextBox();
            this.usrRole3 = new System.Windows.Forms.RadioButton();
            this.usrRole2 = new System.Windows.Forms.RadioButton();
            this.usrRole1 = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.helpLink1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.remProj1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.projectData1);
            this.groupBox1.Controls.Add(this.opProj1);
            this.groupBox1.Controls.Add(this.creProj1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.projectView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Controls";
            // 
            // remProj1
            // 
            this.remProj1.Location = new System.Drawing.Point(19, 214);
            this.remProj1.Name = "remProj1";
            this.remProj1.Size = new System.Drawing.Size(111, 25);
            this.remProj1.TabIndex = 6;
            this.remProj1.Text = "Remove Project";
            this.remProj1.UseVisualStyleBackColor = true;
            this.remProj1.Click += new System.EventHandler(this.remProj1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Project Name:";
            // 
            // projectData1
            // 
            this.projectData1.Location = new System.Drawing.Point(136, 179);
            this.projectData1.Name = "projectData1";
            this.projectData1.Size = new System.Drawing.Size(310, 20);
            this.projectData1.TabIndex = 4;
            // 
            // opProj1
            // 
            this.opProj1.Location = new System.Drawing.Point(19, 135);
            this.opProj1.Name = "opProj1";
            this.opProj1.Size = new System.Drawing.Size(111, 25);
            this.opProj1.TabIndex = 3;
            this.opProj1.Text = "Open Project";
            this.opProj1.UseVisualStyleBackColor = true;
            this.opProj1.Click += new System.EventHandler(this.opProj1_Click);
            // 
            // creProj1
            // 
            this.creProj1.Location = new System.Drawing.Point(19, 174);
            this.creProj1.Name = "creProj1";
            this.creProj1.Size = new System.Drawing.Size(111, 25);
            this.creProj1.TabIndex = 2;
            this.creProj1.Text = "Create Project";
            this.creProj1.UseVisualStyleBackColor = true;
            this.creProj1.Click += new System.EventHandler(this.creProj1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please select a project by double clicking below.";
            // 
            // projectView1
            // 
            this.projectView1.Location = new System.Drawing.Point(19, 32);
            this.projectView1.Name = "projectView1";
            this.projectView1.Size = new System.Drawing.Size(427, 97);
            this.projectView1.TabIndex = 0;
            this.projectView1.UseCompatibleStateImageBehavior = false;
            this.projectView1.SelectedIndexChanged += new System.EventHandler(this.projectView1_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.usrData1);
            this.groupBox4.Controls.Add(this.usrRole3);
            this.groupBox4.Controls.Add(this.usrRole2);
            this.groupBox4.Controls.Add(this.usrRole1);
            this.groupBox4.Location = new System.Drawing.Point(92, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 95);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "User Roles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name :";
            // 
            // usrData1
            // 
            this.usrData1.Location = new System.Drawing.Point(124, 43);
            this.usrData1.Name = "usrData1";
            this.usrData1.Size = new System.Drawing.Size(162, 20);
            this.usrData1.TabIndex = 3;
            this.usrData1.TextChanged += new System.EventHandler(this.usrData1_TextChanged);
            // 
            // usrRole3
            // 
            this.usrRole3.AutoSize = true;
            this.usrRole3.Location = new System.Drawing.Point(18, 68);
            this.usrRole3.Name = "usrRole3";
            this.usrRole3.Size = new System.Drawing.Size(82, 17);
            this.usrRole3.TabIndex = 2;
            this.usrRole3.TabStop = true;
            this.usrRole3.Text = "Client (Final)";
            this.usrRole3.UseVisualStyleBackColor = true;
            this.usrRole3.CheckedChanged += new System.EventHandler(this.usrRole3_CheckedChanged);
            // 
            // usrRole2
            // 
            this.usrRole2.AutoSize = true;
            this.usrRole2.Location = new System.Drawing.Point(18, 44);
            this.usrRole2.Name = "usrRole2";
            this.usrRole2.Size = new System.Drawing.Size(70, 17);
            this.usrRole2.TabIndex = 1;
            this.usrRole2.TabStop = true;
            this.usrRole2.Text = "Reviewer";
            this.usrRole2.UseVisualStyleBackColor = true;
            this.usrRole2.CheckedChanged += new System.EventHandler(this.usrRole2_CheckedChanged);
            // 
            // usrRole1
            // 
            this.usrRole1.AutoSize = true;
            this.usrRole1.Location = new System.Drawing.Point(18, 20);
            this.usrRole1.Name = "usrRole1";
            this.usrRole1.Size = new System.Drawing.Size(100, 17);
            this.usrRole1.TabIndex = 0;
            this.usrRole1.TabStop = true;
            this.usrRole1.Text = "Submitter (Start)";
            this.usrRole1.UseVisualStyleBackColor = true;
            this.usrRole1.CheckedChanged += new System.EventHandler(this.usrRole1_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // helpLink1
            // 
            this.helpLink1.AutoSize = true;
            this.helpLink1.Location = new System.Drawing.Point(454, 3);
            this.helpLink1.Name = "helpLink1";
            this.helpLink1.Size = new System.Drawing.Size(29, 13);
            this.helpLink1.TabIndex = 14;
            this.helpLink1.TabStop = true;
            this.helpLink1.Text = "Help";
            this.helpLink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpLink1_LinkClicked);
            // 
            // ProjectForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 373);
            this.Controls.Add(this.helpLink1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectForm1";
            this.Text = "Screenshot Reviewer";
            this.Load += new System.EventHandler(this.ProjectForm1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView projectView1;
        private System.Windows.Forms.Button remProj1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox projectData1;
        private System.Windows.Forms.Button opProj1;
        private System.Windows.Forms.Button creProj1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usrData1;
        private System.Windows.Forms.RadioButton usrRole3;
        private System.Windows.Forms.RadioButton usrRole2;
        private System.Windows.Forms.RadioButton usrRole1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel helpLink1;
    }
}