﻿using System;
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
    public partial class booksForm : Form
    {
        public booksForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(booksForm_Load);

            // STATUS COMBO BOX
            availabilityStatus_COMBO.Items.Add("Availability Status..."); // Placeholder
            availabilityStatus_COMBO.SelectedIndex = 0;

            availabilityStatus_COMBO.Items.Add("Available");
            availabilityStatus_COMBO.Items.Add("Not Available");

            // GENRE COMBO BOX
            combo_GENRE.Items.Add("Select Genre..."); // Placeholder
            combo_GENRE.SelectedIndex = 0;

            combo_GENRE.Items.Add("Fantasy");
            combo_GENRE.Items.Add("Dystopian");
            combo_GENRE.Items.Add("Romance");
            combo_GENRE.Items.Add("Epic Poetry");
            combo_GENRE.Items.Add("Tragedy");
            combo_GENRE.Items.Add("Gothic Fiction");
            combo_GENRE.Items.Add("Horror");
            combo_GENRE.Items.Add("Adventure");
            combo_GENRE.Items.Add("Science Fiction");
            combo_GENRE.Items.Add("Philosophical Fiction");
            combo_GENRE.Items.Add("Mystery");
            combo_GENRE.Items.Add("Post-Apocalyptic Fiction");
            combo_GENRE.Items.Add("Dystopian Fiction");
            combo_GENRE.Items.Add("Psychological Fiction");

            // TEXT BOX PLACEHOLDERS
            SetPlaceholder(txtboxBookID, "Book ID");
            SetPlaceholder(txtbox_bookTitle, "Harry Potter and the Deathly Hallows");
            SetPlaceholder(txtboxAuthor, "J.K. Rowling");
            SetPlaceholder(txtboxEdition, "1st");
            SetPlaceholder(txtboxISBN, "978-0545139700");
            SetPlaceholder(txtboxPublisher, "Scholastic");
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

        private void booksForm_Load(object sender, EventArgs e)
        {
            LoadBooks(); // Call function to load books
        }

        private void LoadBooks()
        {
            string connectionString = "Server=127.0.0.1;Database=LibraryDB;User=root;Password=;";
            string query = "SELECT book_id AS 'Book ID', title AS 'Title', author AS 'Author', isbn AS 'ISBN', publisher AS 'Publisher', edition AS 'Edition', status AS 'Status', genre AS 'Genre' FROM books";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No books found in the database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dataGridViewBooks.DataSource = dt; // Set DataGridView source
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            string searchBookID = txtboxBookID.Text.Trim() != "Book ID" ? txtboxBookID.Text.Trim() : "";
            string searchTitle = txtbox_bookTitle.Text.Trim() != "Harry Potter and the Deathly Hallows" ? txtbox_bookTitle.Text.Trim() : "";
            string searchAuthor = txtboxAuthor.Text.Trim() != "J.K. Rowling" ? txtboxAuthor.Text.Trim() : "";
            string searchISBN = txtboxISBN.Text.Trim() != "978-0545139700" ? txtboxISBN.Text.Trim() : "";
            string searchPublisher = txtboxPublisher.Text.Trim() != "Scholastic" ? txtboxPublisher.Text.Trim() : "";
            string searchEdition = txtboxEdition.Text.Trim() != "1st" ? txtboxEdition.Text.Trim() : "";
            string searchGenre = combo_GENRE.SelectedIndex > 0 ? combo_GENRE.SelectedItem.ToString() : "";
            string searchStatus = availabilityStatus_COMBO.SelectedIndex > 0 ? availabilityStatus_COMBO.SelectedItem.ToString() : "";

            // Check if the DataGridView has a valid DataSource
            if (dataGridViewBooks.DataSource is DataTable dt)
            {
                string filter = "";

                if (!string.IsNullOrEmpty(searchBookID))
                    filter += "[Book ID] LIKE '%" + searchBookID + "%' AND ";

                if (!string.IsNullOrEmpty(searchTitle))
                    filter += "[Title] LIKE '%" + searchTitle + "%' AND ";

                if (!string.IsNullOrEmpty(searchAuthor))
                    filter += "[Author] LIKE '%" + searchAuthor + "%' AND ";

                if (!string.IsNullOrEmpty(searchISBN))
                    filter += "[ISBN] LIKE '%" + searchISBN + "%' AND ";

                if (!string.IsNullOrEmpty(searchPublisher))
                    filter += "[Publisher] LIKE '%" + searchPublisher + "%' AND ";

                if (!string.IsNullOrEmpty(searchEdition))
                    filter += "[Edition] LIKE '%" + searchEdition + "%' AND ";

                if (!string.IsNullOrEmpty(searchGenre))
                    filter += "[Genre] LIKE '%" + searchGenre + "%' AND ";

                if (!string.IsNullOrEmpty(searchStatus))
                    filter += "[Status] = '" + searchStatus + "' AND ";

                // Remove the last " AND " if filters exist
                if (filter.EndsWith(" AND "))
                    filter = filter.Substring(0, filter.Length - 5);

                dt.DefaultView.RowFilter = filter; // Apply filtering
            }
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxBookID.Text) ||
                string.IsNullOrWhiteSpace(txtbox_bookTitle.Text) ||
                string.IsNullOrWhiteSpace(txtboxAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtboxISBN.Text) ||
                string.IsNullOrWhiteSpace(txtboxPublisher.Text) ||
                string.IsNullOrWhiteSpace(txtboxEdition.Text) ||
                combo_GENRE.SelectedIndex <= 0 ||
                availabilityStatus_COMBO.SelectedIndex <= 0)
            {
                MessageBox.Show("Please fill in all fields before saving.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database=LibraryDB;User=root;Password=;"))
            {
                try
                {
                    conn.Open();
                    string query = @"
                INSERT INTO books (book_id, title, author, isbn, publisher, edition, status, genre, borrow_counter)
                VALUES (@book_id, @title, @author, @isbn, @publisher, @edition, @status, @genre, 0)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@book_id", txtboxBookID.Text);
                        cmd.Parameters.AddWithValue("@title", txtbox_bookTitle.Text);
                        cmd.Parameters.AddWithValue("@author", txtboxAuthor.Text);
                        cmd.Parameters.AddWithValue("@isbn", txtboxISBN.Text);
                        cmd.Parameters.AddWithValue("@publisher", txtboxPublisher.Text);
                        cmd.Parameters.AddWithValue("@edition", txtboxEdition.Text);
                        cmd.Parameters.AddWithValue("@status", availabilityStatus_COMBO.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@genre", combo_GENRE.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks(); // refresh DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxBookID.Text))
            {
                MessageBox.Show("Please enter a valid Book ID to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database=LibraryDB;User=root;Password=;"))
            {
                try
                {
                    conn.Open();
                    string query = @"
                UPDATE books 
                SET title = @title, author = @author, isbn = @isbn, publisher = @publisher, 
                    edition = @edition, status = @status, genre = @genre 
                WHERE book_id = @book_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@book_id", txtboxBookID.Text);
                        cmd.Parameters.AddWithValue("@title", txtbox_bookTitle.Text);
                        cmd.Parameters.AddWithValue("@author", txtboxAuthor.Text);
                        cmd.Parameters.AddWithValue("@isbn", txtboxISBN.Text);
                        cmd.Parameters.AddWithValue("@publisher", txtboxPublisher.Text);
                        cmd.Parameters.AddWithValue("@edition", txtboxEdition.Text);
                        cmd.Parameters.AddWithValue("@status", availabilityStatus_COMBO.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@genre", combo_GENRE.SelectedItem.ToString());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBooks(); // to refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No book found with the given ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
