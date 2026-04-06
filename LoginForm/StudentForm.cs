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

        private void gpaButton_Click(object sender, EventArgs e)
        {
            string output = "";

            for (int i = 0; i < SharedData.courses.Length; i++)
            {
                output += SharedData.courses[i] + ": ";

                if (i == 0) output += grade1TextBox.Text;
                else if (i == 1) output += grade2TextBox.Text;
                else if (i == 2) output += grade3TextBox.Text;
                else if (i == 3) output += grade4TextBox.Text;
                else if (i == 4) output += grade5TextBox.Text;

                output += "\n";
            }

            
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
            MessageBox.Show("Group Members:\nSaleh - 20210001\nMember2 - ID\nMember3 - ID");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
