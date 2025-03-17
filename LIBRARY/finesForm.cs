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
    public partial class finesForm: Form
    {
        public Point mouseLocation;

        public finesForm()
        {
            InitializeComponent();

            // PLACEHOLDERS
            SetPlaceholder(txtbox_MemberID, "Member ID");
            SetPlaceholder(txtbox_Name, "FullName");

            SetPlaceholder(txtbox_LibrarianID, "Librarian ID");
            SetPlaceholder(txtbox_LibrarianName, "Librarian Name");

            SetPlaceholder(txtbox_BookID, "Book ID");
            SetPlaceholder(txtbox_Title, "Title");

            SetPlaceholder(txtbox_TransactionID, "Transaction ID");
            SetPlaceholder(txtbox_CopyID, "Copy ID");
  
            SetPlaceholder(txtbox_Status, "");

            SetPlaceholder(txtbox_issueDate, "YYYY-MM-DD");
            SetPlaceholder(txtbox_dueDate, "YYYY-MM-DD");
            SetPlaceholder(txtbox_returnDate, "YYYY-MM-DD");

            // loads datagridview
            LoadFinesData();

        }

        // PLACEHOLDER
        private void SetPlaceholder(System.Windows.Forms.TextBox txt, string placeholder)
        {
            txt.Text = placeholder;
            txt.ForeColor = Color.Gray;

            txt.GotFocus += (sender, e) =>
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            };

            txt.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray;
                }
            };
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void finesPanel_Paint(object sender, PaintEventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void returnDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void finesTBLDATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateStatusField(string dueDateStr, string returnDateStr, string reservationStatus)
        {
            DateTime dueDate = DateTime.Parse(dueDateStr);
            DateTime? returnDate = returnDateStr == "Not Returned" ? (DateTime?)null : DateTime.Parse(returnDateStr);
            DateTime today = DateTime.Now;

            if (returnDate == null && today > dueDate)
            {
                txtbox_Status.Text = "Overdue";  // Book is overdue
            }
            else if (returnDate != null)
            {
                txtbox_Status.Text = "Returned"; // Book has been returned
            }
            else if (!string.IsNullOrWhiteSpace(reservationStatus) && reservationStatus == "Approved")
            {
                txtbox_Status.Text = "Reserved"; // Book is reserved
            }
            else
            {
                txtbox_Status.Text = "Available"; // No reservations, not overdue
            }
        }

        private void txtbox_TransactionID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbox_TransactionID.Text))
            {
                using (MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=LibraryDB;User=root;Password=;"))
                {
                    conn.Open();

                    string query = @"
            SELECT b.transaction_id, b.copy_id, b.book_id, b.librarian_id, 
                   CONCAT(l.first_name, ' ', COALESCE(l.middle_name, ''), ' ', l.last_name) AS librarian_name,
                   b.member_id, 
                   CONCAT(m.first_name, ' ', COALESCE(m.middle_name, ''), ' ', m.last_name) AS member_name,
                   b.issue_date, b.due_date, b.return_date, 
                   IF(f.fine_amount IS NULL, 0, f.fine_amount) AS fine_amount, f.paid
            FROM borrow b
            JOIN members m ON b.member_id = m.member_id
            JOIN librarian l ON b.librarian_id = l.librarian_id
            LEFT JOIN fines f ON b.transaction_id = f.transaction_id
            WHERE b.transaction_id = @transaction_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@transaction_id", txtbox_TransactionID.Text);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtbox_CopyID.Text = reader["copy_id"].ToString();
                                txtbox_BookID.Text = reader["book_id"].ToString();
                                txtbox_LibrarianID.Text = reader["librarian_id"].ToString();
                                txtbox_LibrarianName.Text = reader["librarian_name"].ToString();
                                txtbox_MemberID.Text = reader["member_id"].ToString();
                                txtbox_Name.Text = reader["member_name"].ToString();
                                txtbox_issueDate.Text = reader["issue_date"].ToString();
                                txtbox_dueDate.Text = reader["due_date"].ToString();
                                txtbox_returnDate.Text = reader["return_date"] == DBNull.Value ? "Not Returned" : reader["return_date"].ToString();
                                txtbox_fineAmount.Text = reader["fine_amount"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Transaction not found.");
                            }
                        }
                    }
                }
            }
        }

        private void LoadFinesData()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=LibraryDB;User=root;Password=;"))
            {
                conn.Open();
                string query = @"
        SELECT f.fine_id AS 'Fine ID', 
               f.transaction_id AS 'Transaction ID', 
               m.member_id AS 'Member ID', 
               CONCAT(m.first_name, ' ', COALESCE(m.middle_name, ''), ' ', m.last_name) AS 'Member Name',
               f.book_id AS 'Book ID', 
               f.copy_id AS 'Copy ID', 
               f.fine_amount AS 'Fine Amount', 
               CASE WHEN f.paid = TRUE THEN 'Paid' ELSE 'Unpaid' END AS 'Status',
               f.paid_date AS 'Paid Date'
        FROM fines f
        JOIN members m ON f.member_id = m.member_id
        ORDER BY f.paid ASC, f.fine_id DESC";  // Show unpaid fines first

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    finesTBLDATA.DataSource = dt; // Bind Data to DataGridView
                }
            }
        }
    }
}
