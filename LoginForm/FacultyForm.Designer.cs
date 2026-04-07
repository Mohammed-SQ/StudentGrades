namespace StudentGradesManagementSystem
{
    partial class FacultyForm
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
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFinalGPA = new System.Windows.Forms.Label();
            this.lblFacultyName = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblGrade5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblGrade4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblGrade3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGrade2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGrade1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProfileID = new System.Windows.Forms.TextBox();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colICS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colENG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(119, 23);
            this.txtSearchID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(129, 20);
            this.txtSearchID.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(257, 23);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // lblFinalGPA
            // 
            this.lblFinalGPA.AutoSize = true;
            this.lblFinalGPA.Location = new System.Drawing.Point(17, 213);
            this.lblFinalGPA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinalGPA.Name = "lblFinalGPA";
            this.lblFinalGPA.Size = new System.Drawing.Size(137, 13);
            this.lblFinalGPA.TabIndex = 2;
            this.lblFinalGPA.Text = "Final Calculated GPA:  0.00";
            // 
            // lblFacultyName
            // 
            this.lblFacultyName.AutoSize = true;
            this.lblFacultyName.Location = new System.Drawing.Point(557, 33);
            this.lblFacultyName.Name = "lblFacultyName";
            this.lblFacultyName.Size = new System.Drawing.Size(111, 13);
            this.lblFacultyName.TabIndex = 4;
            this.lblFacultyName.Text = "Logged in as Faculty: ";
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.colMIS,
            this.colICS,
            this.colMATH,
            this.colIAS,
            this.colENG,
            this.colGPA});
            this.dgvStudents.Location = new System.Drawing.Point(0, 57);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(540, 159);
            this.dgvStudents.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSearchID);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dgvStudents);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 234);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Student & View Grades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search By Student ID";
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Location = new System.Drawing.Point(12, 304);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(131, 13);
            this.lblTotalStudents.TabIndex = 8;
            this.lblTotalStudents.Text = "Total Student Registered: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Controls.Add(this.panel10);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.panel8);
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtProfileID);
            this.groupBox3.Controls.Add(this.txtProfileName);
            this.groupBox3.Controls.Add(this.lblFinalGPA);
            this.groupBox3.Location = new System.Drawing.Point(558, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 234);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Grades (Selected Record)";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel9.Controls.Add(this.lblGrade5);
            this.panel9.Location = new System.Drawing.Point(98, 180);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(64, 21);
            this.panel9.TabIndex = 9;
            // 
            // lblGrade5
            // 
            this.lblGrade5.AutoSize = true;
            this.lblGrade5.Location = new System.Drawing.Point(12, 4);
            this.lblGrade5.Name = "lblGrade5";
            this.lblGrade5.Size = new System.Drawing.Size(27, 13);
            this.lblGrade5.TabIndex = 5;
            this.lblGrade5.Text = "N/A";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel7.Controls.Add(this.lblGrade4);
            this.panel7.Location = new System.Drawing.Point(98, 153);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(64, 21);
            this.panel7.TabIndex = 16;
            // 
            // lblGrade4
            // 
            this.lblGrade4.AutoSize = true;
            this.lblGrade4.Location = new System.Drawing.Point(12, 4);
            this.lblGrade4.Name = "lblGrade4";
            this.lblGrade4.Size = new System.Drawing.Size(27, 13);
            this.lblGrade4.TabIndex = 5;
            this.lblGrade4.Text = "N/A";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel10.Controls.Add(this.label15);
            this.panel10.Location = new System.Drawing.Point(16, 180);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(68, 21);
            this.panel10.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "ENG102";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.lblGrade3);
            this.panel5.Location = new System.Drawing.Point(98, 126);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(64, 21);
            this.panel5.TabIndex = 9;
            // 
            // lblGrade3
            // 
            this.lblGrade3.AutoSize = true;
            this.lblGrade3.Location = new System.Drawing.Point(12, 4);
            this.lblGrade3.Name = "lblGrade3";
            this.lblGrade3.Size = new System.Drawing.Size(27, 13);
            this.lblGrade3.TabIndex = 5;
            this.lblGrade3.Text = "N/A";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel8.Controls.Add(this.label13);
            this.panel8.Location = new System.Drawing.Point(16, 153);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(68, 21);
            this.panel8.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "IAS212";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(16, 126);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(68, 21);
            this.panel6.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "MATH101";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.lblGrade2);
            this.panel3.Location = new System.Drawing.Point(98, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 21);
            this.panel3.TabIndex = 9;
            // 
            // lblGrade2
            // 
            this.lblGrade2.AutoSize = true;
            this.lblGrade2.Location = new System.Drawing.Point(12, 4);
            this.lblGrade2.Name = "lblGrade2";
            this.lblGrade2.Size = new System.Drawing.Size(27, 13);
            this.lblGrade2.TabIndex = 5;
            this.lblGrade2.Text = "N/A";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(16, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(68, 21);
            this.panel4.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "ICS104";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.lblGrade1);
            this.panel2.Location = new System.Drawing.Point(98, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 21);
            this.panel2.TabIndex = 7;
            // 
            // lblGrade1
            // 
            this.lblGrade1.AutoSize = true;
            this.lblGrade1.Location = new System.Drawing.Point(12, 4);
            this.lblGrade1.Name = "lblGrade1";
            this.lblGrade1.Size = new System.Drawing.Size(27, 13);
            this.lblGrade1.TabIndex = 5;
            this.lblGrade1.Text = "N/A";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(16, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 21);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "MIS302";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Student Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Student ID:";
            // 
            // txtProfileID
            // 
            this.txtProfileID.Location = new System.Drawing.Point(98, 47);
            this.txtProfileID.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfileID.Multiline = true;
            this.txtProfileID.Name = "txtProfileID";
            this.txtProfileID.Size = new System.Drawing.Size(68, 20);
            this.txtProfileID.TabIndex = 0;
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(98, 23);
            this.txtProfileName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(68, 20);
            this.txtProfileName.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToLoginToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // returnToLoginToolStripMenuItem
            // 
            this.returnToLoginToolStripMenuItem.Name = "returnToLoginToolStripMenuItem";
            this.returnToLoginToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.returnToLoginToolStripMenuItem.Text = "Return to Login";
            this.returnToLoginToolStripMenuItem.Click += new System.EventHandler(this.returnToLoginToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 80;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.Name = "StudentName";
            // 
            // colMIS
            // 
            this.colMIS.HeaderText = "MIS302 Grade";
            this.colMIS.Name = "colMIS";
            this.colMIS.Width = 50;
            // 
            // colICS
            // 
            this.colICS.HeaderText = "ICS104 Grade";
            this.colICS.Name = "colICS";
            this.colICS.Width = 50;
            // 
            // colMATH
            // 
            this.colMATH.HeaderText = "MATH101 Grade";
            this.colMATH.Name = "colMATH";
            this.colMATH.Width = 55;
            // 
            // colIAS
            // 
            this.colIAS.HeaderText = "IAS212 Grade";
            this.colIAS.Name = "colIAS";
            this.colIAS.Width = 50;
            // 
            // colENG
            // 
            this.colENG.HeaderText = "ENG102 Grade";
            this.colENG.Name = "colENG";
            this.colENG.Width = 50;
            // 
            // colGPA
            // 
            this.colGPA.HeaderText = "Calculated GPA";
            this.colGPA.Name = "colGPA";
            this.colGPA.Width = 50;
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 335);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblTotalStudents);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFacultyName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            this.Load += new System.EventHandler(this.FacultyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFinalGPA;
        private System.Windows.Forms.Label lblFacultyName;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProfileID;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblGrade3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGrade2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGrade1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblGrade5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblGrade4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colICS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMATH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colENG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGPA;
    }
}