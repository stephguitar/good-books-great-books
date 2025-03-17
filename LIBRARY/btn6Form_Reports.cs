using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LIBRARY
{
    public partial class btn6Form_Reports : Form
    {
        public Point mouseLocation;

        public btn6Form_Reports()
        {
            InitializeComponent();
            LoadBorrowedBooks();
            LoadReturnedBooks();
        }

        // ✅ Load Borrowed Books (Still Not Returned)
        private void LoadBorrowedBooks()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;"))
            {
                conn.Open();
                string query = @"
                    SELECT b.transaction_id AS 'Transaction ID',
                           b.book_id AS 'Book ID',
                           m.member_id AS 'Member ID',
                           CONCAT(m.first_name, ' ', COALESCE(m.middle_name, ''), ' ', m.last_name) AS 'Borrower Name',
                           b.issue_date AS 'Issue Date',
                           b.due_date AS 'Due Date'
                    FROM borrow b
                    JOIN members m ON b.member_id = m.member_id
                    WHERE b.return_date IS NULL
                    ORDER BY b.issue_date DESC"; // ✅ Most recent first

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    borrowedBooksDataGrid.DataSource = dt; // ✅ Bind to DataGridView
                }
            }
        }

        // ✅ Load Returned Books
        private void LoadReturnedBooks()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;"))
            {
                conn.Open();
                string query = @"
                    SELECT b.transaction_id AS 'Transaction ID',
                           b.book_id AS 'Book ID',
                           m.member_id AS 'Member ID',
                           CONCAT(m.first_name, ' ', COALESCE(m.middle_name, ''), ' ', m.last_name) AS 'Borrower Name',
                           b.issue_date AS 'Issue Date',
                           b.due_date AS 'Due Date',
                           b.return_date AS 'Return Date'
                    FROM borrow b
                    JOIN members m ON b.member_id = m.member_id
                    WHERE b.return_date IS NOT NULL
                    ORDER BY b.return_date DESC"; // ✅ Most recent returns first

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    returnedBooksDataGrid.DataSource = dt; // ✅ Bind to DataGridView
                }
            }
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}