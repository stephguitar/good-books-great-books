using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LIBRARY
{
    public partial class notificationsForm : Form
    {
        public Point mouseLocation;
        private string memberID; // Store logged-in member ID

        public notificationsForm(string loggedInMemberID)
        {
            InitializeComponent();
            memberID = loggedInMemberID;

            // Load member-specific notifications
            LoadPendingFines();
            LoadBorrowedBooks();
            LoadReservedBooks();
            LoadOverdueBooks();
        }

        // ✅ Load Pending Fines
        private void LoadPendingFines()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;"))
            {
                conn.Open();
                string query = @"
                    SELECT transaction_id AS 'Transaction ID', 
                           book_id AS 'Book ID', 
                           fine_amount AS 'Fine Amount', 
                           CASE WHEN paid = TRUE THEN 'Paid' ELSE 'Unpaid' END AS 'Status'
                    FROM fines 
                    WHERE member_id = @memberID AND paid = FALSE";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@memberID", memberID);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    finesDataGrid.DataSource = dt; // Bind to DataGridView
                }
            }
        }

        // ✅ Load Borrowed Books
        private void LoadBorrowedBooks()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;"))
            {
                conn.Open();
                string query = @"
                    SELECT transaction_id AS 'Transaction ID', 
                           book_id AS 'Book ID', 
                           issue_date AS 'Issue Date', 
                           due_date AS 'Due Date'
                    FROM borrow 
                    WHERE member_id = @memberID AND return_date IS NULL";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@memberID", memberID);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    borrowedBooksDataGrid.DataSource = dt; // Bind to DataGridView
                }
            }
        }

        // ✅ Load Reserved Books
        private void LoadReservedBooks()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;"))
            {
                conn.Open();
                string query = @"
                    SELECT reservation_id AS 'Reservation ID', 
                           book_id AS 'Book ID', 
                           status AS 'Status', 
                           reserve_date AS 'Reserve Date'
                    FROM reservations 
                    WHERE member_id = @memberID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@memberID", memberID);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    reservedBooksDataGrid.DataSource = dt; // Bind to DataGridView
                }
            }
        }

        // ✅ Load Overdue Books
        private void LoadOverdueBooks()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;"))
            {
                conn.Open();
                string query = @"
                    SELECT transaction_id AS 'Transaction ID', 
                           book_id AS 'Book ID', 
                           due_date AS 'Due Date', 
                           DATEDIFF(NOW(), due_date) AS 'Days Overdue'
                    FROM borrow 
                    WHERE member_id = @memberID AND return_date IS NULL AND due_date < NOW()";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@memberID", memberID);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    overdueBooksDataGrid.DataSource = dt; // Bind to DataGridView
                }
            }
        }

        // ✅ Refresh button to reload data
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadPendingFines();
            LoadBorrowedBooks();
            LoadReservedBooks();
            LoadOverdueBooks();
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {

        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}