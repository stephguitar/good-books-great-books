using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LIBRARY
{
    public partial class btn4Form_Reports : Form
    {
        public Point mouseLocation;

        public btn4Form_Reports()
        {
            InitializeComponent();
            LoadTopBorrowers(); // ✅ Load Data on Form Load
        }

        private void LoadTopBorrowers()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;"))
            {
                conn.Open();
                string query = @"
                    SELECT member_id AS 'Member ID', 
                           CONCAT(first_name, ' ', last_name) AS 'Name', 
                           borrow_counter AS 'Books Borrowed'
                    FROM members
                    ORDER BY borrow_counter DESC
                    LIMIT 10";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    topBorrowersDataGrid.DataSource = dt; // ✅ Bind to DataGridView
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

        private void topBorrowersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}