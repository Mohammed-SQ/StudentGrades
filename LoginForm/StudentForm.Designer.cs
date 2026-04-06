namespace StudentGradesManagementSystem
{
    partial class StudentForm
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
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.grade1TextBox = new System.Windows.Forms.TextBox();
            this.grade2TextBox = new System.Windows.Forms.TextBox();
            this.grade3TextBox = new System.Windows.Forms.TextBox();
            this.grade4TextBox = new System.Windows.Forms.TextBox();
            this.grade5TextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.gpaButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.Location = new System.Drawing.Point(72, 65);
            this.studentIdTextBox.Multiline = true;
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(100, 27);
            this.studentIdTextBox.TabIndex = 0;
            this.studentIdTextBox.Text = "Student ID";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(227, 65);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(100, 27);
            this.studentNameTextBox.TabIndex = 1;
            this.studentNameTextBox.Text = "Student Name";
            // 
            // grade1TextBox
            // 
            this.grade1TextBox.Location = new System.Drawing.Point(98, 185);
            this.grade1TextBox.Name = "grade1TextBox";
            this.grade1TextBox.Size = new System.Drawing.Size(100, 27);
            this.grade1TextBox.TabIndex = 2;
            // 
            // grade2TextBox
            // 
            this.grade2TextBox.Location = new System.Drawing.Point(98, 234);
            this.grade2TextBox.Name = "grade2TextBox";
            this.grade2TextBox.Size = new System.Drawing.Size(100, 27);
            this.grade2TextBox.TabIndex = 3;
            // 
            // grade3TextBox
            // 
            this.grade3TextBox.Location = new System.Drawing.Point(98, 279);
            this.grade3TextBox.Name = "grade3TextBox";
            this.grade3TextBox.Size = new System.Drawing.Size(100, 27);
            this.grade3TextBox.TabIndex = 4;
            // 
            // grade4TextBox
            // 
            this.grade4TextBox.Location = new System.Drawing.Point(98, 327);
            this.grade4TextBox.Name = "grade4TextBox";
            this.grade4TextBox.Size = new System.Drawing.Size(100, 27);
            this.grade4TextBox.TabIndex = 5;
            // 
            // grade5TextBox
            // 
            this.grade5TextBox.Location = new System.Drawing.Point(98, 371);
            this.grade5TextBox.Name = "grade5TextBox";
            this.grade5TextBox.Size = new System.Drawing.Size(100, 27);
            this.grade5TextBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(413, 169);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 29);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(413, 222);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(76, 39);
            this.viewButton.TabIndex = 8;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // gpaButton
            // 
            this.gpaButton.Location = new System.Drawing.Point(413, 283);
            this.gpaButton.Name = "gpaButton";
            this.gpaButton.Size = new System.Drawing.Size(76, 34);
            this.gpaButton.TabIndex = 9;
            this.gpaButton.Text = "GPA";
            this.gpaButton.UseVisualStyleBackColor = true;
            this.gpaButton.Click += new System.EventHandler(this.gpaButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(633, 247);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(48, 19);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "result";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToLoginToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // returnToLoginToolStripMenuItem
            // 
            this.returnToLoginToolStripMenuItem.Name = "returnToLoginToolStripMenuItem";
            this.returnToLoginToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.returnToLoginToolStripMenuItem.Text = "Return to Login";
            this.returnToLoginToolStripMenuItem.Click += new System.EventHandler(this.returnToLoginToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.gpaButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.grade5TextBox);
            this.Controls.Add(this.grade4TextBox);
            this.Controls.Add(this.grade3TextBox);
            this.Controls.Add(this.grade2TextBox);
            this.Controls.Add(this.grade1TextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.studentIdTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox grade1TextBox;
        private System.Windows.Forms.TextBox grade2TextBox;
        private System.Windows.Forms.TextBox grade3TextBox;
        private System.Windows.Forms.TextBox grade4TextBox;
        private System.Windows.Forms.TextBox grade5TextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button gpaButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}