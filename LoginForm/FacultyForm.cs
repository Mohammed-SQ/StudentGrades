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
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchID = searchIdTextBox.Text.Trim();
            bool found = false;
            string output = "";

            for (int i = 0; i < SharedData.studentCount; i++)
            {
                if (SharedData.studentIDs[i] == searchID)
                {
                    found = true;

                    output += "Student ID: " + SharedData.studentIDs[i] + "\n";
                    output += "Student Name: " + SharedData.studentNames[i] + "\n";

                    int total = 0;

                    for (int j = 0; j < SharedData.courses.Length; j++)
                    {
                        output += SharedData.courses[j] + ": " + SharedData.allGrades[i, j] + "\n";
                        total += SharedData.allGrades[i, j];
                    }

                    double average = total / 5.0;
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

                    output += "GPA: " + gpa.ToString("F2");
                    break;
                }
            }

            if (found)
                resultLabel.Text = output;
            else
                MessageBox.Show("Student ID not found.");
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
