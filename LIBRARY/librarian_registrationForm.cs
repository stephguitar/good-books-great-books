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
    public partial class librarian_registrationForm: Form
    {
        public librarian_registrationForm()
        {
            InitializeComponent();

            // MEMBERSHIP TYPE COMBO BOX
            librarianPosition_COMBO.Items.Add("Librarian");
            librarianPosition_COMBO.Items.Add("Library Assistant");
            librarianPosition_COMBO.Items.Add("Head Librarian");
            librarianPosition_COMBO.Items.Add("Librarian Manager");

            // GENERATE LIBRARIAN ID
            GenerateLibrarianID();

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
        private void GenerateLibrarianID()
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=LibraryDB;User=root;Password=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string getIdQuery = "SELECT IFNULL(MAX(CAST(SUBSTRING(librarian_id, 4, LENGTH(librarian_id) - 3) AS UNSIGNED)), 0) + 1 FROM librarian";
                    using (MySqlCommand cmdGetId = new MySqlCommand(getIdQuery, conn))
                    {
                        int nextId = Convert.ToInt32(cmdGetId.ExecuteScalar());
                        string newLibrarianId = $"LIB{nextId:D4}"; // Formats as MEM0001, MEM0002, etc.

                        txtbox_LibrarianID.Text = newLibrarianId; // Display it in the textbox
                        txtbox_LibrarianID.ReadOnly = true; // Make it uneditable
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating Member ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string lastName = txtbox_LN.Text;
            string firstName = txtbox_FN.Text;
            string middleName = txtbox_MN.Text;
            string address = txtbox_Address.Text;
            string email = txtbox_Email.Text;
            string password = txtbox_Password.Text; // In a real-world application, hash the password before storing it
            string phoneNumber = txtbox_Number.Text;
            string position = librarianPosition_COMBO.SelectedItem.ToString();

            string connectionString = "Server=127.0.0.1;Port=3306;Database=LibraryDB;User=root;Password=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Generate the next Librarian ID
                    string getIdQuery = "SELECT IFNULL(MAX(CAST(SUBSTRING(librarian_id, 4, LENGTH(librarian_id) - 3) AS UNSIGNED)), 0) + 1 FROM librarian";
                    string newLibrarianId;
                    using (MySqlCommand cmdGetId = new MySqlCommand(getIdQuery, connection))
                    {
                        int nextId = Convert.ToInt32(cmdGetId.ExecuteScalar());
                        newLibrarianId = $"LIB{nextId:D4}"; // Formats as LIB0001, LIB0002, etc.
                    }

                    // Insert new librarian record
                    string query = "INSERT INTO librarian (librarian_id, email, password, last_name, first_name, middle_name, phone, address, position) " +
                                   "VALUES (@LibrarianID, @Email, @Password, @LastName, @FirstName, @MiddleName, @Phone, @Address, @Position)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LibrarianID", newLibrarianId);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password); // **IMPORTANT: Hash the password in a real-world application**
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@MiddleName", middleName);
                        command.Parameters.AddWithValue("@Phone", phoneNumber);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Position", position);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error: Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
