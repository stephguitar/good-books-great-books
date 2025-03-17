using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LIBRARY
{
    public partial class btn2Form_Reports : Form
    {
        public Point mouseLocation;

        public btn2Form_Reports()
        {
            InitializeComponent();
            LoadUnreturnedBooks();
            LoadOverdueBooks();
        }

        // ✅ Load Unreturned Books
        private void LoadUnreturnedBooks()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;"))
            {
                conn.Open();
                string query = @"
                    SELECT b.transaction_id AS 'Transaction ID',
                           b.copy_id AS 'Copy ID',
                           b.book_id AS 'Book ID',
                           bk.title AS 'Title',
                           b.member_id AS 'Member ID',
                           CONCAT(m.first_name, ' ', COALESCE(m.middle_name, ''), ' ', m.last_name) AS 'Borrower',
                           b.issue_date AS 'Issue Date',
                           b.due_date AS 'Due Date'
                    FROM borrow b
                    JOIN books bk ON b.book_id = bk.book_id
                    JOIN members m ON b.member_id = m.member_id
                    WHERE b.return_date IS NULL
                    ORDER BY b.due_date ASC"; // ✅ Ordered by Due Date

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    unreturnedBooksDataGrid.DataSource = dt; // ✅ Bind to DataGridView
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
                    SELECT b.transaction_id AS 'Transaction ID',
                           b.copy_id AS 'Copy ID',
                           b.book_id AS 'Book ID',
                           bk.title AS 'Title',
                           b.member_id AS 'Member ID',
                           CONCAT(m.first_name, ' ', COALESCE(m.middle_name, ''), ' ', m.last_name) AS 'Borrower',
                           b.issue_date AS 'Issue Date',
                           b.due_date AS 'Due Date',
                           DATEDIFF(NOW(), b.due_date) AS 'Days Overdue'
                    FROM borrow b
                    JOIN books bk ON b.book_id = bk.book_id
                    JOIN members m ON b.member_id = m.member_id
                    WHERE b.return_date IS NULL AND b.due_date < NOW()
                    ORDER BY b.due_date ASC"; // ✅ Ordered by Overdue Days

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    overdueBooksDataGrid.DataSource = dt; // ✅ Bind to DataGridView
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