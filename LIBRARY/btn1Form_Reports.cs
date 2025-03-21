﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LIBRARY
{
    public partial class btn1Form_Reports : Form
    {
        public Point mouseLocation;

        public btn1Form_Reports()
        {
            InitializeComponent();
            LoadAvailableBooks();
            LoadUnavailableBooks();
        }

        // ✅ Load Available Books
        private void LoadAvailableBooks()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database=LibraryDB;User=root;Password=;"))
            {
                conn.Open();
                string query = @"
                    SELECT book_id AS 'Book ID',
                           title AS 'Title',
                           author AS 'Author',
                           edition AS 'Edition',
                           isbn AS 'ISBN',
                           genre AS 'Genre',
                           publisher AS 'Publisher'
                    FROM books
                    WHERE status = 'Available'
                    ORDER BY title ASC"; // ✅ Sorted Alphabetically

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    availableBooksDataGrid.DataSource = dt; // ✅ Bind to DataGridView
                }
            }
        }

        // ✅ Load Unavailable Books
        private void LoadUnavailableBooks()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database=LibraryDB;User=root;Password=;"))
            {
                conn.Open();
                string query = @"
                    SELECT book_id AS 'Book ID',
                           title AS 'Title',
                           author AS 'Author',
                           edition AS 'Edition',
                           isbn AS 'ISBN',
                           genre AS 'Genre',
                           publisher AS 'Publisher'
                    FROM books
                    WHERE status = 'Not Available'
                    ORDER BY title ASC"; // ✅ Sorted Alphabetically

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    unavailableBooksDataGrid.DataSource = dt; // ✅ Bind to DataGridView
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