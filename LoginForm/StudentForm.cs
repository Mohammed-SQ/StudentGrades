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
using System.Xml.Linq;

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
            lblProfileID.Text = SharedData.CurrentUserID;
            lblProfileName.Text = SharedData.CurrentUserName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "Your GPA: 0.00" || string.IsNullOrEmpty(resultLabel.Text))
            {
                MessageBox.Show("Please click 'Calculate GPA' first to confirm your final score.", "Data Save Error");
                return;
            }
            int row = SharedData.studentCount;

            if (row >= 10)
            {
                MessageBox.Show("System Error: Maximum student capacity (10) reached.", "Data Save Error");
                return;
            }

            SharedData.studentIDs[row] = lblProfileID.Text;
            SharedData.studentNames[row] = lblProfileName.Text;

            SharedData.allGrades[row, 0] = GetGradePoints(cmbGrade1.Text);
            SharedData.allGrades[row, 1] = GetGradePoints(cmbGrade2.Text);
            SharedData.allGrades[row, 2] = GetGradePoints(cmbGrade3.Text);
            SharedData.allGrades[row, 3] = GetGradePoints(cmbGrade4.Text);
            SharedData.allGrades[row, 4] = GetGradePoints(cmbGrade5.Text);

            string gpaText = resultLabel.Text.Replace("Your GPA: ", "").Trim();
            SharedData.allGPA[row] = double.Parse(gpaText);

            SharedData.studentCount++;
            MessageBox.Show($"Grades for {lblProfileName.Text} saved!");
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private int GetGradePoints(string letter)
        {
            switch (letter)
            {
                case "A": return 4;
                case "B": return 3;
                case "C": return 2;
                case "D": return 1;
                case "F": return 0;
                default: return 0;
            }
        }
        private string GetLetterGrade(int points)
        {
            switch (points)
            {
                case 4: return "A";
                case 3: return "B";
                case 2: return "C";
                case 1: return "D";
                case 0: return "F";
                default: return "N/A";
            }
        }

        private void gpaButton_Click(object sender, EventArgs e)
        {
            if (cmbGrade1.SelectedIndex == -1 || cmbGrade2.SelectedIndex == -1 ||
                cmbGrade3.SelectedIndex == -1 || cmbGrade4.SelectedIndex == -1 ||
                cmbGrade5.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a grade for all courses.");
                return;
            }

            int[] points = new int[5];
            points[0] = GetGradePoints(cmbGrade1.SelectedItem.ToString());
            points[1] = GetGradePoints(cmbGrade2.SelectedItem.ToString());
            points[2] = GetGradePoints(cmbGrade3.SelectedItem.ToString());
            points[3] = GetGradePoints(cmbGrade4.SelectedItem.ToString());
            points[4] = GetGradePoints(cmbGrade5.SelectedItem.ToString());

            double sum = 0;
            foreach (int p in points) { sum += p; }

            double gpa = sum / points.Length;

            resultLabel.Text = "Your GPA: " + gpa.ToString("F2");
        }

        private void returnToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
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
        private void viewGpaButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            string currentID = SharedData.CurrentUserID;

            for (int i = 0; i < SharedData.studentCount; i++)
            {
                if (SharedData.studentIDs[i] == currentID)
                {
                    resultLabel.Text = "Your GPA: " + SharedData.allGPA[i].ToString("F2");

                    cmbGrade1.Text = GetLetterGrade(SharedData.allGrades[i, 0]);
                    cmbGrade2.Text = GetLetterGrade(SharedData.allGrades[i, 1]);
                    cmbGrade3.Text = GetLetterGrade(SharedData.allGrades[i, 2]);
                    cmbGrade4.Text = GetLetterGrade(SharedData.allGrades[i, 3]);
                    cmbGrade5.Text = GetLetterGrade(SharedData.allGrades[i, 4]);

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("No saved data found.");
            }
        }
    }
}
