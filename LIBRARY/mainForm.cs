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


namespace LIBRARY
{
    public partial class mainForm: Form
    {
        public Point mouseLocation;
        private string loggedInMemberID;
        private notificationsForm notifForm;
        public mainForm()
        {
            InitializeComponent();
            HideSidebarButtons();



        }

        

        public void SetLoggedInMember(string memberID)
        {
            loggedInMemberID = memberID;
        }
        public void ShowLibrarianButtons()
        {
            btn_Notifications.Visible = true;
            btn_Books.Visible = true;
            btn_Transactions.Visible = true;
            btn_Reservations.Visible = true;
            btn_Fines.Visible = true;
            btn_Reports.Visible = true;
            btn_LibRegister.Visible = true;
            btn_Logout.Visible = true;
           
        }

        public void ShowMemberButtons()
        {
            btn_UserRegistration.Visible = true;
            btn_Notifications.Visible = true;

            btn_Books.Visible = false;
            btn_Transactions.Visible = false;
            btn_Reservations.Visible = false;
            btn_Fines.Visible = false;
            btn_Reports.Visible = false;
            btn_LibRegister.Visible = false;
            btn_Logout.Visible = true;
        }

        public void HideSidebarButtons()
        {
            btn_Notifications.Visible = false;
            btn_Books.Visible = false;
            btn_Transactions.Visible = false;
            btn_Reservations.Visible = false;
            btn_Fines.Visible = false;
            btn_Reports.Visible = false;
            btn_Logout.Visible = false;
            btn_LibRegister.Visible = false;
        }

        public void UpdateUserRegistrationButton(string firstName)
        {
            btn_UserRegistration.Text = firstName;
        }

        public void loadform(object Form)
        {
            if (this.mnPanel.Controls.Count > 0)
                this.mnPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mnPanel.Controls.Add(f);
            this.mnPanel.Tag = f;
            f.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadform(new homeForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            loadform(new reportsForm());
        }

        private void btn_UserRegistration_Click(object sender, EventArgs e)
        {
            loadform(new profile(this));
        }


        private void btn_Notifications_Click(object sender, EventArgs e)
        {
            if (notifForm == null || notifForm.IsDisposed) // Ensure only one instance exists
            {
                notifForm = new notificationsForm(loggedInMemberID);
                notifForm.StartPosition = FormStartPosition.Manual; // Prevent default positioning

                // ✅ Position the form to the *right side of mainForm*
                int notifX = this.Location.X + this.Width - 2;  // Adjust based on window width
                int notifY = this.Location.Y + 30;  // Slightly below the top bar

                notifForm.Location = new Point(notifX, notifY);
                notifForm.Show();
            }
            else
            {
                notifForm.Close();  // Close if already open
                notifForm = null;
            }
        }

        private void btn_Books_Click(object sender, EventArgs e)
        {
            loadform(new booksForm());
        }

        private void btn_Transactions_Click(object sender, EventArgs e)
        {
            var newForm = new transactionsForm();
            newForm.Show();
        }

        private void btn_Reservations_Click(object sender, EventArgs e)
        {
            var newForm = new reservationsForm();
            newForm.Show();
        }
        private void btn_Fines_Click(object sender, EventArgs e)
        {
            var newForm = new finesForm();
            newForm.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }

        private void mnPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            HideSidebarButtons();

            // Update the user registration button back to default
            btn_UserRegistration.Text = "Profile";

            // Load the home/landing form
            loadform(new homeForm());

            // Optional: Display a logout message
            MessageBox.Show("You have been logged out successfully.", "Logout",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_LibRegister_Click(object sender, EventArgs e)
        {
            loadform(new librarian_registrationForm());
        }
    }
}
