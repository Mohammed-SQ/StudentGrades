using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradesManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            bool found = false;

            try
            {
                StreamReader inputFile = File.OpenText("users.txt");

                while (!inputFile.EndOfStream)
                {
                    string line = inputFile.ReadLine();
                    string[] parts = line.Split(',');

                    if (username == parts[0] && password == parts[1])
                    {
                        found = true;
                        SharedData.CurrentUserID = parts[3];
                        SharedData.CurrentUserName = parts[0];
                        this.Hide();
                        if (parts[2] == "Student")
                        {
                            StudentForm sf = new StudentForm();
                            sf.ShowDialog();
                        }
                        else if (parts[2] == "Faculty")
                        {
                            FacultyForm ff = new FacultyForm();
                            ff.ShowDialog();
                        }
                        break;
                    }
                }          
                inputFile.Close();

                if (!found)
                {
                    lblError.Text = "Invalid username or password";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "File Error: " + ex.Message;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
