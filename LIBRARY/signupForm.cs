using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LIBRARY
{
    public partial class signupForm: Form
    {
        public Point mouseLocation;
        public signupForm()
        {
            InitializeComponent();

            // MEMBERSHIP TYPE COMBO BOX
            membershipType_COMBO.Items.Add("Student");
            membershipType_COMBO.Items.Add("Staff");

            // GENERATE MEMBER ID
            GenerateMemberID();

            // PLACEHOLDERS 
            SetPlaceholder(txtbox_LN, "Smith");
            SetPlaceholder(txtbox_FN, "John");
            SetPlaceholder(txtbox_MN, "Ash");
            SetPlaceholder(txtbox_Address, "99 Street, Brgy. Example");
            SetPlaceholder(txtbox_Email, "example@email.com");
            SetPlaceholder(txtbox_Password, "password");
            SetPlaceholder(txtbox_Number, "09XXXXXXXX"); 
        }

        // PLACEHOLDER
        private void SetPlaceholder(System.Windows.Forms.TextBox txt, string placeholder)
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


        // GENERATE MEMBER ID ON TEXTBOX
        private void GenerateMemberID()
        {
            string connectionString = "Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string getIdQuery = "SELECT IFNULL(MAX(CAST(SUBSTRING(member_id, 4, LENGTH(member_id) - 3) AS UNSIGNED)), 0) + 1 FROM members";
                    using (MySqlCommand cmdGetId = new MySqlCommand(getIdQuery, conn))
                    {
                        int nextId = Convert.ToInt32(cmdGetId.ExecuteScalar());
                        string newMemberId = $"MEM{nextId:D4}"; // Formats as MEM0001, MEM0002, etc.

                        txtbox_MemberID.Text = newMemberId; // Display it in the textbox
                        txtbox_MemberID.ReadOnly = true; // Make it uneditable
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating Member ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Generate the next Member ID
                    string getIdQuery = "SELECT IFNULL(MAX(CAST(SUBSTRING(member_id, 4, LENGTH(member_id) - 3) AS UNSIGNED)), 0) + 1 FROM members";
                    using (MySqlCommand cmdGetId = new MySqlCommand(getIdQuery, conn))
                    {
                        int nextId = Convert.ToInt32(cmdGetId.ExecuteScalar());
                        string newMemberId = $"MEM{nextId:D4}"; // Formats as MEM0001, MEM0002, etc.
                        txtbox_MemberID.Text = newMemberId; // Display in textbox
                    }

                    // Insert new member record
                    string query = "INSERT INTO members (member_id, last_name, first_name, middle_name, email, password, phone, address, membership_type) " +
                                   "VALUES (@MemberID, @LastName, @FirstName, @MiddleName, @Email, @Password, @Phone, @Address, @MembershipType)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", txtbox_MemberID.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtbox_LN.Text);
                        cmd.Parameters.AddWithValue("@FirstName", txtbox_FN.Text);
                        cmd.Parameters.AddWithValue("@MiddleName", txtbox_MN.Text);
                        cmd.Parameters.AddWithValue("@Email", txtbox_Email.Text);
                        cmd.Parameters.AddWithValue("@Password", txtbox_Password.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtbox_Number.Text);
                        cmd.Parameters.AddWithValue("@Address", txtbox_Address.Text);
                        cmd.Parameters.AddWithValue("@MembershipType", membershipType_COMBO.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sign-up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error: Sign-up failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void txtbox_MemberID_TextChanged(object sender, EventArgs e)
        {
        }

        private void memberLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
