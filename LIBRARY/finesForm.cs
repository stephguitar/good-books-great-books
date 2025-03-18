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

        private void txtbox_MemberID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbox_MemberID.Text) && txtbox_MemberID.Text != "Member ID")
            {
                using (MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database=LibraryDB;User=root;Password=;"))
                {
                    try
                    {
                        conn.Open();

                        // auto-fill member details
                        string memberQuery = @"
                SELECT CONCAT(first_name, ' ', COALESCE(middle_name, ''), ' ', last_name) AS full_name
                FROM members WHERE member_id = @member_id";

                        using (MySqlCommand cmd = new MySqlCommand(memberQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@member_id", txtbox_MemberID.Text);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtbox_Name.Text = reader["full_name"].ToString();
                                }
                                else
                                {
                                    txtbox_Name.Text = "Member Not Found";
                                    txtbox_FineTotal.Text = "0.00"; // Reset fine total
                                    return;
                                }
                            }
                        }

                        // get total unpaid fines from database
                        decimal totalFines = 0.00m;
                        string fineQuery = "SELECT SUM(fine_amount) FROM fines WHERE member_id = @member_id AND paid = FALSE";
                        using (MySqlCommand cmd = new MySqlCommand(fineQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@member_id", txtbox_MemberID.Text);
                            object result = cmd.ExecuteScalar();
                            if (result != DBNull.Value && result != null)
                            {
                                totalFines = Convert.ToDecimal(result);
                            }
                        }

                        // dynamically calculate additional fines for overdue books
                        string overdueQuery = @"
                SELECT SUM(DATEDIFF(NOW(), due_date) * 5) AS overdue_fine
                FROM borrow WHERE member_id = @member_id 
                AND return_date IS NULL AND due_date < NOW()";

                        using (MySqlCommand cmd = new MySqlCommand(overdueQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@member_id", txtbox_MemberID.Text);
                            object result = cmd.ExecuteScalar();
                            if (result != DBNull.Value && result != null)
                            {
                                totalFines += Convert.ToDecimal(result);
                            }
                        }

                        // display total fines in textbox
                        txtbox_FineTotal.Text = totalFines.ToString("0.00");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching member details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtbox_LibrarianID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbox_LibrarianID.Text) && txtbox_LibrarianID.Text != "Librarian ID")
            {
                using (MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database=LibraryDB;User=root;Password=;"))
                {
                    try
                    {
                        conn.Open();
                        string query = @"
                SELECT CONCAT(first_name, ' ', COALESCE(middle_name, ''), ' ', last_name) AS full_name 
                FROM librarian WHERE librarian_id = @librarian_id";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@librarian_id", txtbox_LibrarianID.Text);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtbox_LibrarianName.Text = reader["full_name"].ToString();
                                }
                                else
                                {
                                    txtbox_LibrarianName.Text = "Librarian Not Found";
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching librarian details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
                using (MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database=LibraryDB;User=root;Password=;"))
                {
                    conn.Open();

                    string query = @"
        SELECT b.transaction_id, b.copy_id, b.book_id, m.member_id, 
               CONCAT(m.first_name, ' ', COALESCE(m.middle_name, ''), ' ', m.last_name) AS full_name,
               b.issue_date, b.due_date, b.return_date, r.status AS reservation_status
        FROM borrow b
        JOIN members m ON b.member_id = m.member_id
        LEFT JOIN reservations r ON b.book_id = r.book_id AND r.member_id = m.member_id
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
                                txtbox_MemberID.Text = reader["member_id"].ToString();
                                txtbox_Name.Text = reader["full_name"].ToString();
                                txtbox_issueDate.Text = reader["issue_date"].ToString();
                                txtbox_dueDate.Text = reader["due_date"].ToString();
                                txtbox_returnDate.Text = reader["return_date"] == DBNull.Value ? "Not Returned" : reader["return_date"].ToString();
                                string reservationStatus = reader["reservation_status"] == DBNull.Value ? "" : reader["reservation_status"].ToString();

                                // call the function to update status
                                UpdateStatusField(txtbox_dueDate.Text, txtbox_returnDate.Text, reservationStatus);
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
            using (MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database=LibraryDB;User=root;Password=;"))
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
        ORDER BY f.paid ASC, f.fine_id DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    finesTBLDATA.DataSource = dt; // Bind Data to DataGridView
                }
            }
        }

        private void btn_PayFine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_MemberID.Text) || txtbox_MemberID.Text == "Member ID")
            {
                MessageBox.Show("Please enter a valid Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database=LibraryDB;User=root;Password=;"))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // check if the member has unpaid fines
                    string fineCheckQuery = "SELECT COUNT(*) FROM fines WHERE member_id = @member_id AND paid = FALSE";
                    using (MySqlCommand cmd = new MySqlCommand(fineCheckQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@member_id", txtbox_MemberID.Text);
                        int unpaidFineCount = Convert.ToInt32(cmd.ExecuteScalar());

                        if (unpaidFineCount == 0)
                        {
                            MessageBox.Show("No unpaid fines found for this member.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // update all unpaid fines to "Paid"
                    string payFineQuery = "UPDATE fines SET paid = TRUE, paid_date = NOW() WHERE member_id = @member_id AND paid = FALSE";
                    using (MySqlCommand cmd = new MySqlCommand(payFineQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@member_id", txtbox_MemberID.Text);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("All fines have been successfully cleared!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // reset Fine Total after Payment
                    txtbox_FineTotal.Text = "0.00";

                    // refresh the fines DataGridView
                    LoadFinesData();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error processing fine payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }








        private void btn_Return_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_TransactionID.Text) || string.IsNullOrWhiteSpace(txtbox_CopyID.Text))
            {
                MessageBox.Show("Please enter a valid Transaction ID and Copy ID.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database=LibraryDB;User=root;Password=;"))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string transactionID = txtbox_TransactionID.Text;
                    string copyID = txtbox_CopyID.Text;

                    // step 1: Check if the book is already returned
                    string checkReturnQuery = "SELECT return_date FROM borrow WHERE transaction_id = @transaction_id AND copy_id = @copy_id";
                    DateTime? returnDate = null;

                    using (MySqlCommand cmd = new MySqlCommand(checkReturnQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@transaction_id", transactionID);
                        cmd.Parameters.AddWithValue("@copy_id", copyID);

                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            returnDate = Convert.ToDateTime(result);
                        }
                    }

                    if (returnDate != null)
                    {
                        MessageBox.Show("This book has already been returned.");
                        transaction.Rollback();
                        return;
                    }

                    // update the book copy status to "available"
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE book_copies SET status = 'available' WHERE copy_id = @copy_id", conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@copy_id", copyID);
                        cmd.ExecuteNonQuery();
                    }

                    // mark the book as returned
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE borrow SET return_date = NOW() WHERE transaction_id = @transaction_id", conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@transaction_id", transactionID);
                        cmd.ExecuteNonQuery();
                    }

                    // check if the book is overdue
                    string getDueDateQuery = "SELECT due_date FROM borrow WHERE transaction_id = @transaction_id";
                    DateTime dueDate = DateTime.Now;

                    using (MySqlCommand cmd = new MySqlCommand(getDueDateQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@transaction_id", transactionID);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            dueDate = Convert.ToDateTime(result);
                        }
                    }

                    DateTime actualReturnDate = DateTime.Now;
                    if (actualReturnDate > dueDate)
                    {
                        int overdueDays = (actualReturnDate - dueDate).Days;
                        decimal fineAmount = overdueDays * 5; // Example: 5 currency units per day overdue

                        using (MySqlCommand cmd = new MySqlCommand(@"
                    INSERT INTO fines (transaction_id, member_id, book_id, copy_id, fine_amount, paid) 
                    VALUES (@transactionID, @memberID, @bookID, @copyID, @fineAmount, FALSE)
                    ON DUPLICATE KEY UPDATE fine_amount = @fineAmount, paid = FALSE", conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@transactionID", transactionID);
                            cmd.Parameters.AddWithValue("@memberID", txtbox_MemberID.Text);
                            cmd.Parameters.AddWithValue("@bookID", txtbox_BookID.Text);
                            cmd.Parameters.AddWithValue("@copyID", copyID);
                            cmd.Parameters.AddWithValue("@fineAmount", fineAmount);
                            cmd.ExecuteNonQuery();
                        }

                        // notify the user about the overdue fine
                        NotificationHelper.ShowNotification("WARNING", "Your book was returned late! A fine has been added.");
                    }
                    else
                    {
                        // notify the user about the successful return
                        NotificationHelper.ShowNotification("SUCCESS", "Book returned successfully! No fines were issued.");
                    }

                    transaction.Commit();
                    MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // refresh DataGridView after return
                    LoadFinesData();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error returning book: " + ex.Message);
                }
            }
        }

    }
}
