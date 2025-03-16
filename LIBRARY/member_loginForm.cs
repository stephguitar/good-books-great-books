using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY
{
    public partial class member_loginForm : Form
    {
        public Point mouseLocation;
        private mainForm mainFormInstance;
        public member_loginForm(mainForm form)
        {
            InitializeComponent();
            mainFormInstance = form;

            // PLACEHOLDERS
            SetPlaceholder(txtbox_MemberID, "MEMBER ID: *");
            SetPlaceholder(txtbox_memberPassword, "PASSWORD: *");
        }

        private void SetPlaceholder(TextBox txt, string placeholder)
        {
            txt.Text = placeholder;
            txt.ForeColor = Color.Gray;

            txt.Enter += (sender, e) =>
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            };

            txt.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray;
                }
            };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string memberId = txtbox_MemberID.Text;
            string password = txtbox_memberPassword.Text;
            string connectionString = "Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;";
            string position = "Member"; // Assuming position is "Member" for this context

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to check member ID and password
                    string query = "SELECT first_name FROM members WHERE member_id = @memberID AND password = @password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Use parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@memberId", memberId);
                        command.Parameters.AddWithValue("@password", password); // **IMPORTANT: In real-world applications, you should hash the password before storing it and comparing it.**

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            // Login successful
                            string firstName = result.ToString();
                            mainFormInstance.ShowMemberButtons();
                            mainFormInstance.UpdateUserRegistrationButton(firstName);
                            this.Hide();
                            mainFormInstance.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Member ID or Password.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
