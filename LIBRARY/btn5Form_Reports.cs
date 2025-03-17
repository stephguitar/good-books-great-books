using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LIBRARY
{
    public partial class btn5Form_Reports : Form
    {
        public Point mouseLocation;

        public btn5Form_Reports()
        {
            InitializeComponent();
            LoadBorrowersWithFines(); // ✅ Load Data on Form Load
        }

        private void LoadBorrowersWithFines()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;"))
            {
                conn.Open();
                string query = @"
                    SELECT f.member_id AS 'Member ID', 
                           CONCAT(m.first_name, ' ', m.last_name) AS 'Name',
                           SUM(f.fine_amount) AS 'Total Fine'
                    FROM fines f
                    JOIN members m ON f.member_id = m.member_id
                    WHERE f.paid = FALSE
                    GROUP BY f.member_id
                    ORDER BY SUM(f.fine_amount) DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    borrowersWithFinesDataGrid.DataSource = dt; // ✅ Bind to DataGridView
                }
            }
        }

        private void btn5Form_Reports_Load(object sender, EventArgs e)
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}