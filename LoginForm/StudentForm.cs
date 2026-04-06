using StudentGradesManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradesManagementSystem
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void resultLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (SharedData.studentCount >= 10)
            {
                MessageBox.Show("Maximum number of students reached.");
                return;
            }

            int g1, g2, g3, g4, g5;

            if (!int.TryParse(grade1TextBox.Text, out g1) ||
                !int.TryParse(grade2TextBox.Text, out g2) ||
                !int.TryParse(grade3TextBox.Text, out g3) ||
                !int.TryParse(grade4TextBox.Text, out g4) ||
                !int.TryParse(grade5TextBox.Text, out g5))
            {
                MessageBox.Show("Enter valid numeric grades.");
                return;
            }

            if (!ValidateGradesRange(g1, g2, g3, g4, g5))
                return;

            int row = SharedData.studentCount;

            SharedData.studentIDs[row] = studentIdTextBox.Text.Trim();
            SharedData.studentNames[row] = studentNameTextBox.Text.Trim();

            SharedData.allGrades[row, 0] = g1;
            SharedData.allGrades[row, 1] = g2;
            SharedData.allGrades[row, 2] = g3;
            SharedData.allGrades[row, 3] = g4;
            SharedData.allGrades[row, 4] = g5;

            SharedData.studentCount++;

            MessageBox.Show("Student grades saved.");
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            string output = "";

            output += "Student ID: " + studentIdTextBox.Text + "\n";
            output += "Student Name: " + studentNameTextBox.Text + "\n\n";

            for (int i = 0; i < SharedData.courses.Length; i++)
            {
                output += SharedData.courses[i] + ": ";

                if (i == 0)
                    output += grade1TextBox.Text;
                else if (i == 1)
                    output += grade2TextBox.Text;
                else if (i == 2)
                    output += grade3TextBox.Text;
                else if (i == 3)
                    output += grade4TextBox.Text;
                else if (i == 4)
                    output += grade5TextBox.Text;

                output += "\n";
            }

            resultLabel.Text = output;
        }

        private void gpaButton_Click(object sender, EventArgs e)
        {
            int g1, g2, g3, g4, g5;

            if (!int.TryParse(grade1TextBox.Text, out g1) ||
                !int.TryParse(grade2TextBox.Text, out g2) ||
                !int.TryParse(grade3TextBox.Text, out g3) ||
                !int.TryParse(grade4TextBox.Text, out g4) ||
                !int.TryParse(grade5TextBox.Text, out g5))
            {
                MessageBox.Show("Enter valid numeric grades.");
                return;
            }

            if (!ValidateGradesRange(g1, g2, g3, g4, g5))
                return;

            double average = (g1 + g2 + g3 + g4 + g5) / 5.0;
            double gpa;

            if (average >= 90)
                gpa = 4;
            else if (average >= 80)
                gpa = 3;
            else if (average >= 70)
                gpa = 2;
            else if (average >= 60)
                gpa = 1;
            else
                gpa = 0;

            resultLabel.Text = "GPA = " + gpa.ToString("F2");
        }

        
        private bool ValidateGradesRange(params int[] grades)
        {
            foreach (var g in grades)
            {
                if (g < 0 || g > 100)
                {
                    MessageBox.Show("Grades must be between 0 and 100.");
                    return false;
                }
            }

            return true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void returnToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Group Members:\nRidha - 202013940\nMohammed - 202536470\nAli - 202251460");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
