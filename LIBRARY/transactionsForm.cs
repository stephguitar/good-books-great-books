using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LIBRARY
{
    public partial class transactionsForm : Form
    {
        public Point mouseLocation;
        private MySqlConnection conn = new MySqlConnection("Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;");
        private string transactionID;

        public transactionsForm()
        {
            InitializeComponent();
            GenerateTransactionID();
        }

        private void transactionsForm_Load(object sender, EventArgs e)
        {
            GenerateTransactionID();
            LoadBorrowTransactions(); // Load borrowTBLDATA
            LoadBooks(); // Load booksTBLDATA
            LoadBookCopies(); // Load book_copiesTBLDATA

            txtbox_TransactionID.Text = transactionID;

            // PLACEHOLDERS
            SetPlaceholder(txtbox_CopyID, "Copy ID");

            SetPlaceholder(txtbox_LibrarianID, "Librarian ID");
            SetPlaceholder(txtbox_LibrarianName, "Librarian Name");

            SetPlaceholder(txtbox_MemberID, "Member ID");
            SetPlaceholder(txtbox_Name, "FullName");
            SetPlaceholder(txtContactNumber, "Contact Number");
            SetPlaceholder(txtEmail, "E-mail");

            SetPlaceholder(txtbox_issueDate, "YYYY-MM-DD");
            SetPlaceholder(txtbox_dueDate, "YYYY-MM-DD");

            SetPlaceholder(txtbox_BookID, "Book ID");
            SetPlaceholder(txtbox_Title, "Title");
            SetPlaceholder(txtbox_Author, "Author");
            SetPlaceholder(txtbox_Edition, "Edition");
        }

        private void SetPlaceholder(System.Windows.Forms.TextBox txt, string placeholder)
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

        private void GenerateTransactionID()
        {
            transactionID = "TXN-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            if (txtbox_TransactionID != null)
            {
                txtbox_TransactionID.Text = transactionID;
            }
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
                            txtbox_Title.Text = reader["title"].ToString();
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

        private void ShowNotification(string type, string message)
        {
            notificationsForm notif = new notificationsForm();
            notif.showToast(type, message);
        }

        private void ReturnBook(string copyID)
        {
            using (MySqlConnection conn = new MySqlConnection("Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;"))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Step 1: Get transaction details
                    string getTransactionQuery = @"
            SELECT transaction_id, member_id, book_id, due_date 
            FROM borrow WHERE copy_id = @copyID AND return_date IS NULL";

                    string transactionID = "", memberID = "", bookID = "";
                    DateTime dueDate = DateTime.Now;

                    using (MySqlCommand cmd = new MySqlCommand(getTransactionQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@copyID", copyID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                transactionID = reader["transaction_id"].ToString();
                                memberID = reader["member_id"].ToString();
                                bookID = reader["book_id"].ToString();
                                dueDate = Convert.ToDateTime(reader["due_date"]);
                            }
                        }
                    }

                    if (string.IsNullOrEmpty(transactionID))
                    {
                        MessageBox.Show("No active borrow record found for this book copy.");
                        return;
                    }

                    // Step 2: Update book copy status to 'available'
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE book_copies SET status = 'available' WHERE copy_id = @copyID", conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@copyID", copyID);
                        cmd.ExecuteNonQuery();
                    }

                    // Step 3: Record return date
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE borrow SET return_date = NOW() WHERE transaction_id = @transactionID", conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@transactionID", transactionID);
                        cmd.ExecuteNonQuery();
                    }

                    // Step 4: Calculate Fine (if overdue)
                    DateTime returnDate = DateTime.Now;
                    if (returnDate > dueDate)
                    {
                        int overdueDays = (returnDate - dueDate).Days;
                        decimal fineAmount = overdueDays * 5; // Php 5 per day

                        using (MySqlCommand cmd = new MySqlCommand(@"
                INSERT INTO fines (transaction_id, member_id, book_id, copy_id, fine_amount, paid) 
                VALUES (@transactionID, @memberID, @bookID, @copyID, @fineAmount, FALSE)
                ON DUPLICATE KEY UPDATE fine_amount = @fineAmount, paid = FALSE", conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@transactionID", transactionID);
                            cmd.Parameters.AddWithValue("@memberID", memberID);
                            cmd.Parameters.AddWithValue("@bookID", bookID);
                            cmd.Parameters.AddWithValue("@copyID", copyID);
                            cmd.Parameters.AddWithValue("@fineAmount", fineAmount);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Book returned successfully!");

                    // Refresh Data
                    RefreshBorrowTransactions();
                    RefreshBookCopies();
                    RefreshBooks();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_CopyID.Text))
            {
                MessageBox.Show("Please enter a valid Copy ID.");
                return;
            }

            ReturnBook(txtbox_CopyID.Text);
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






        private void RefreshBooks()
        {
            string query = "SELECT book_id, title, author, edition, status FROM books";
            DataTable dt = new DataTable();

            using (MySqlConnection tempConn = new MySqlConnection(conn.ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, tempConn))
                {
                    try
                    {
                        tempConn.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error refreshing books: " + ex.Message);
                    }
                    finally
                    {
                        tempConn.Close();
                    }
                }
            }

            booksTBLDATA.DataSource = dt; // Update the DataGridView
        }

        private void RefreshBookCopies()
        {
            string query = "SELECT copy_id, book_id, status FROM book_copies";
            DataTable dt = new DataTable();

            using (MySqlConnection tempConn = new MySqlConnection(conn.ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, tempConn))
                {
                    try
                    {
                        tempConn.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error refreshing book copies: " + ex.Message);
                    }
                    finally
                    {
                        tempConn.Close();
                    }
                }
            }

            book_copiesTBLDATA.DataSource = dt; // Update the DataGridView
        }

        private void RefreshBorrowTransactions()
        {
            string query = "SELECT * FROM borrow";
            DataTable dt = new DataTable();

            // Use the same connection string as the main connection
            string connectionString = "Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;";

            using (MySqlConnection tempConn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, tempConn))
                {
                    try
                    {
                        tempConn.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error refreshing borrow transactions: " + ex.Message);
                    }
                    finally
                    {
                        tempConn.Close();
                    }
                }
            }

            borrowTBLDATA.DataSource = dt; // Update the DataGridView
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_CopyID.Text) || string.IsNullOrWhiteSpace(txtbox_BookID.Text) ||
                string.IsNullOrWhiteSpace(txtbox_LibrarianID.Text) || string.IsNullOrWhiteSpace(txtbox_MemberID.Text) ||
                string.IsNullOrWhiteSpace(txtbox_issueDate.Text) || string.IsNullOrWhiteSpace(txtbox_dueDate.Text))
            {
                MessageBox.Show("All fields must be filled out before proceeding.");
                return;
            }

            try
            {
                conn.Open();

                // Step 1: Check if the member has unpaid fines
                string checkFineQuery = "SELECT COUNT(*) FROM fines WHERE member_id = @member_id AND paid = FALSE";
                using (MySqlCommand checkFineCmd = new MySqlCommand(checkFineQuery, conn))
                {
                    checkFineCmd.Parameters.AddWithValue("@member_id", txtbox_MemberID.Text);
                    int unpaidFines = Convert.ToInt32(checkFineCmd.ExecuteScalar());

                    if (unpaidFines > 0)
                    {
                        MessageBox.Show("You have unpaid fines. Please pay them before borrowing a new book.");
                        return; // Stop borrowing process
                    }
                }


                // **Step 2: Validate book_id**
                string validateBookQuery = "SELECT COUNT(*) FROM books WHERE book_id = @book_id";
                using (MySqlCommand validateBookCmd = new MySqlCommand(validateBookQuery, conn))
                {
                    validateBookCmd.Parameters.AddWithValue("@book_id", txtbox_BookID.Text);
                    int bookCount = Convert.ToInt32(validateBookCmd.ExecuteScalar());

                    if (bookCount == 0)
                    {
                        MessageBox.Show("Book ID not found.");
                        return;
                    }
                }

                // **Step 3: Validate copy_id and ensure it belongs to book_id**
                string validateCopyQuery = @"
            SELECT COUNT(*) 
            FROM book_copies 
            WHERE copy_id = @copy_id 
              AND book_id = @book_id 
              AND status = 'available' 
              AND copy_id NOT IN (SELECT copy_id FROM borrow)";
                using (MySqlCommand validateCopyCmd = new MySqlCommand(validateCopyQuery, conn))
                {
                    validateCopyCmd.Parameters.AddWithValue("@copy_id", txtbox_CopyID.Text);
                    validateCopyCmd.Parameters.AddWithValue("@book_id", txtbox_BookID.Text);

                    int copyCount = Convert.ToInt32(validateCopyCmd.ExecuteScalar());

                    if (copyCount == 0)
                    {
                        MessageBox.Show("Invalid copy ID or book ID, or the copy is not available for borrowing.");
                        return;
                    }
                }

                // **Step 4: Validate member_id**
                string validateMemberQuery = "SELECT COUNT(*) FROM members WHERE member_id = @member_id";
                using (MySqlCommand validateMemberCmd = new MySqlCommand(validateMemberQuery, conn))
                {
                    validateMemberCmd.Parameters.AddWithValue("@member_id", txtbox_MemberID.Text);
                    int memberCount = Convert.ToInt32(validateMemberCmd.ExecuteScalar());

                    if (memberCount == 0)
                    {
                        MessageBox.Show("Member ID not found.");
                        return;
                    }
                }

                // **Step 5: Validate librarian_id**
                string validateLibrarianQuery = "SELECT COUNT(*) FROM librarian WHERE librarian_id = @librarian_id";
                using (MySqlCommand validateLibrarianCmd = new MySqlCommand(validateLibrarianQuery, conn))
                {
                    validateLibrarianCmd.Parameters.AddWithValue("@librarian_id", txtbox_LibrarianID.Text);
                    int librarianCount = Convert.ToInt32(validateLibrarianCmd.ExecuteScalar());

                    if (librarianCount == 0)
                    {
                        MessageBox.Show("Librarian ID not found.");
                        return;
                    }
                }

                // **Step 6: Update book copy status**
                MySqlCommand cmd = conn.CreateCommand();
                MySqlTransaction transaction = conn.BeginTransaction(); // Start transaction
                cmd.Transaction = transaction;

                cmd.CommandText = "UPDATE book_copies SET status = 'not available' WHERE copy_id = @copy_id AND book_id = @book_id";
                cmd.Parameters.AddWithValue("@copy_id", txtbox_CopyID.Text);
                cmd.Parameters.AddWithValue("@book_id", txtbox_BookID.Text);
                cmd.ExecuteNonQuery();

                // **Step 7: Insert borrow transaction**
                cmd.CommandText = @"
            INSERT INTO borrow (transaction_id, copy_id, book_id, librarian_id, member_id, issue_date, due_date) 
            VALUES (@txn, @copy, @book, @librarian, @member, @issue, @due)";
                cmd.Parameters.AddWithValue("@txn", transactionID);
                cmd.Parameters.AddWithValue("@copy", txtbox_CopyID.Text);
                cmd.Parameters.AddWithValue("@book", txtbox_BookID.Text);
                cmd.Parameters.AddWithValue("@librarian", txtbox_LibrarianID.Text);
                cmd.Parameters.AddWithValue("@member", txtbox_MemberID.Text);
                cmd.Parameters.AddWithValue("@issue", txtbox_issueDate.Text);
                cmd.Parameters.AddWithValue("@due", txtbox_dueDate.Text);
                cmd.ExecuteNonQuery();

                transaction.Commit(); // Commit transaction
                MessageBox.Show("Book borrowed successfully!");

                // **Step 8: Regenerate Transaction ID**
                GenerateTransactionID(); // Generate a new transaction ID
                txtbox_TransactionID.Text = transactionID; // Update the Transaction ID textbox

                // **Step 9: Refresh all DataGridViews**
                RefreshBorrowTransactions(); // Refresh borrowTBLDATA
                RefreshBooks(); // Refresh booksTBLDATA
                RefreshBookCopies(); // Refresh book_copiesTBLDATA
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close(); // Ensure the connection is closed
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

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadBorrowTransactions()
        {
            string query = "SELECT * FROM borrow";
            DataTable dt = new DataTable();

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }

            borrowTBLDATA.DataSource = dt;
        }


        private void LoadBookCopies()
        {
        string query = "SELECT * FROM book_copies";
        DataTable dt = new DataTable();

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }

            book_copiesTBLDATA.DataSource = dt;
        }

        private void LoadBooks()
        {
            string query = "SELECT book_id, title, author, edition, status FROM books";
            DataTable dt = new DataTable();

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }

                booksTBLDATA.DataSource = dt;
        }

    }
}