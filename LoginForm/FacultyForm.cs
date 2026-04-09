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
    public partial class FacultyForm : Form
    {
        public FacultyForm()
        {
            InitializeComponent();
        }
        private void FacultyForm_Load(object sender, EventArgs e)
        {
            lblFacultyName.Text = "Logged in as Faculty: " + SharedData.CurrentUserName;
            lblTotalStudents.Text = "Total Student Registered: " + SharedData.studentCount.ToString();

            PopulateTable();
        }
        private void PopulateTable()
        {
            lvStudents.Items.Clear();

            for (int i = 0; i < SharedData.studentCount; i++)
            {
                string[] rowData = new string[]
                {
            SharedData.studentIDs[i],
            SharedData.studentNames[i],
            GetLetterGrade(SharedData.allGrades[i, 0]),
            GetLetterGrade(SharedData.allGrades[i, 1]),
            GetLetterGrade(SharedData.allGrades[i, 2]),
            GetLetterGrade(SharedData.allGrades[i, 3]),
            GetLetterGrade(SharedData.allGrades[i, 4]),
            SharedData.allGPA[i].ToString("F2")
                };

                ListViewItem item = new ListViewItem(rowData);
                lvStudents.Items.Add(item);
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchID = txtSearchID.Text.Trim();

            for (int i = 0; i < SharedData.studentCount; i++)
            {
                if (SharedData.studentIDs[i] == searchID)
                {
                    lblProfileName.Text = SharedData.studentNames[i];
                    lblProfileID.Text = SharedData.studentIDs[i];

                    lblGrade1.Text = GetLetterGrade(SharedData.allGrades[i, 0]);
                    lblGrade2.Text = GetLetterGrade(SharedData.allGrades[i, 1]);
                    lblGrade3.Text = GetLetterGrade(SharedData.allGrades[i, 2]);
                    lblGrade4.Text = GetLetterGrade(SharedData.allGrades[i, 3]);
                    lblGrade5.Text = GetLetterGrade(SharedData.allGrades[i, 4]);

                    lblFinalGPA.Text = "Final Calculated GPA: " + SharedData.allGPA[i].ToString("F2");
                    return;
                }
            }
            MessageBox.Show("Student ID not found.");
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
        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Group Members:\nRidha - 202013940\nMohammed - 202536470\nAli - 202251460");
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnToLoginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

    }
}
