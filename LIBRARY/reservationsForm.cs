using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LIBRARY
{
    public partial class reservationsForm : Form
    {
        public Point mouseLocation;
        private MySqlConnection conn = new MySqlConnection("Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;");

        public reservationsForm()
        {
            InitializeComponent();

            // RESERVATION STATUS COMBO BOX
            reservationStatus_COMBO.Items.Add("Reservation Status..."); // Placeholder
            reservationStatus_COMBO.SelectedIndex = 0;

            reservationStatus_COMBO.Items.Add("Approved");
            reservationStatus_COMBO.Items.Add("Pending");
            reservationStatus_COMBO.Items.Add("Cancelled");

            // PLACEHOLDERS
            SetPlaceholder(txtbox_BookID, "Book ID");
            SetPlaceholder(txtbox_CopyID, "Copy ID");

            SetPlaceholder(txtbox_LibrarianID, "Librarian ID");
            SetPlaceholder(txtbox_LibrarianName, "Librarian Name");

            SetPlaceholder(txtbox_MemberID, "Member ID");
            SetPlaceholder(txtbox_Name, "FullName");
            SetPlaceholder(txtContactNumber, "Contact Number");
            SetPlaceholder(txtEmail, "E-mail");

            SetPlaceholder(txtbox_bookTitle, "Title");
            SetPlaceholder(txtbox_Author, "Author");
            SetPlaceholder(txtbox_Edition, "Edition");

            SetPlaceholder(txtbox_ReservationID, "Reservation ID");
            SetPlaceholder(txtbox_reserveDate, "YYYY-MM-DD");


            // Generate and display the initial reservation ID
            txtbox_ReservationID.Text = GenerateReservationID();

            // Load reservations when the form loads
            LoadReservations();

            // Attach TextChanged event handlers
            txtbox_BookID.TextChanged += txtbox_BookID_TextChanged;
            txtbox_MemberID.TextChanged += txtbox_MemberID_TextChanged;
            txtbox_LibrarianID.TextChanged += txtbox_LibrarianID_TextChanged;
        }

        private void SetPlaceholder(TextBox txt, string placeholder)
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

        private void LoadReservations()
        {
            string query = "SELECT * FROM reservations";
            DataTable dt = new DataTable();

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading reservations: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            reservationsTBLDATA.DataSource = dt; // Bind data to DataGridView
        }

        private string GenerateReservationID()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void txtbox_BookID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbox_BookID.Text))
            {
                string query = "SELECT title, author, edition, status FROM books WHERE book_id = @book_id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@book_id", txtbox_BookID.Text);
                    try
                    {
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtbox_bookTitle.Text = reader["title"].ToString();
                            txtbox_Author.Text = reader["author"].ToString();
                            txtbox_Edition.Text = reader["edition"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btn_Reserve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_BookID.Text) || string.IsNullOrWhiteSpace(txtbox_MemberID.Text))
            {
                MessageBox.Show("Book ID and Member ID are required.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection("Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;"))
            {
                conn.Open();

                // *Check if the member has overdue books*
                string overdueCheckQuery = @"
                SELECT COUNT(*) FROM borrow 
                WHERE member_id = @memberID AND due_date < NOW()";

                using (MySqlCommand cmd = new MySqlCommand(overdueCheckQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@memberID", txtbox_MemberID.Text);
                    int overdueCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (overdueCount > 0)
                    {
                        MessageBox.Show("You have overdue books. Please return them before making a reservation.");
                        return;
                    }
                }

                // *Check if the user already has 3 reservations*
                string reservationCheckQuery = @"
        SELECT COUNT(*) FROM reservations 
        WHERE member_id = @memberID AND status = 'Pending'";

                using (MySqlCommand cmd = new MySqlCommand(reservationCheckQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@memberID", txtbox_MemberID.Text);
                    int reservationCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (reservationCount >= 3)
                    {
                        MessageBox.Show("You can only have 3 active reservations at a time.");
                        return;
                    }
                }

                // *Check if all copies of the book are taken*
                string copyCheckQuery = @"
        SELECT COUNT(*) FROM book_copies 
        WHERE book_id = @bookID AND status = 'available'";

                using (MySqlCommand cmd = new MySqlCommand(copyCheckQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@bookID", txtbox_BookID.Text);
                    int availableCopies = Convert.ToInt32(cmd.ExecuteScalar());

                    if (availableCopies > 0)
                    {
                        MessageBox.Show("This book still has available copies. No reservation is needed.");
                        return;
                    }
                }

                // *Insert reservation*
                string query = @"
        INSERT INTO reservations (reservation_id, book_id, member_id, status, reserve_date, notified) 
        VALUES (@reservationID, @bookID, @memberID, 'Pending', NOW(), FALSE)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@reservationID", Guid.NewGuid().ToString());
                    cmd.Parameters.AddWithValue("@bookID", txtbox_BookID.Text);
                    cmd.Parameters.AddWithValue("@memberID", txtbox_MemberID.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Reservation placed successfully.");
            }
        }


        private void txtbox_MemberID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbox_MemberID.Text))
            {
                string query = @"
            SELECT CONCAT(first_name, ' ', COALESCE(middle_name, ''), ' ', last_name) AS full_name, phone, email 
            FROM members 
            WHERE member_id = @member_id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@member_id", txtbox_MemberID.Text);
                    try
                    {
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtbox_Name.Text = reader["full_name"].ToString();
                            txtContactNumber.Text = reader["phone"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void txtbox_LibrarianID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbox_LibrarianID.Text))
            {
                string query = @"
            SELECT CONCAT(first_name, ' ', COALESCE(middle_name, ''), ' ', last_name) AS full_name 
            FROM librarian 
            WHERE librarian_id = @librarian_id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@librarian_id", txtbox_LibrarianID.Text);
                    try
                    {
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtbox_LibrarianName.Text = reader["full_name"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btn_Approve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_ReservationID.Text))
            {
                MessageBox.Show("Please enter a Reservation ID.");
                return;
            }

            ApproveReservation(txtbox_ReservationID.Text);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_ReservationID.Text))
            {
                MessageBox.Show("Please enter a Reservation ID.");
                return;
            }

            CancelReservation(txtbox_ReservationID.Text);
        }

        private void ApproveReservation(string reservationID)
        {
            string query = "UPDATE reservations SET status = 'Approved' WHERE reservation_id = @reservation_id";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@reservation_id", reservationID);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation approved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error approving reservation: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            LoadReservations(); // Refresh the DataGridView
        }

        private void CancelReservation(string reservationID)
        {
            string query = "UPDATE reservations SET status = 'Cancelled' WHERE reservation_id = @reservation_id";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@reservation_id", reservationID);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation cancelled successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error cancelling reservation: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            LoadReservations(); // Refresh the DataGridView
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
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


    }
}