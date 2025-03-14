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
    public partial class Form1: Form
    {
        public Point mouseLocation;
        public Form1()
        {
            InitializeComponent();

            

            // HIDES BUTTONS ON THE SIDEBAR 
           /* this.btn_UserRegistration = new System.Windows.Forms.Button();
            this.btn_UserRegistration.Visible = false; // Hides User Registration Button
            this.btn_Notifications = new System.Windows.Forms.Button();
            this.btn_Notifications.Visible = false; // Hides Notification Button
            this.btn_Books = new System.Windows.Forms.Button();
            this.btn_Books.Visible = false; // Hides Books Catalog Button
            this.btn_Transactions = new System.Windows.Forms.Button();
            this.btn_Transactions.Visible = false; // Hides Transactions Button
            this.btn_Reservations = new System.Windows.Forms.Button();
            this.btn_Reservations.Visible = false; // Hides Reservations Button
            this.btn_Fines = new System.Windows.Forms.Button();
            this.btn_Fines.Visible = false; // Hides Fines Button
            this.btn_Reports = new System.Windows.Forms.Button();
            this.btn_Reports.Visible = false; // Hides the Reports button
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Logout.Visible = false; // Hides the Reports button */
        }

        public void ShowSidebarButtons()
        {
            btn_UserRegistration.Visible = true;
            btn_Notifications.Visible = true;
            btn_Books.Visible = true;
            btn_Transactions.Visible = true;
            btn_Reservations.Visible = true;
            btn_Fines.Visible = true;
            btn_Reports.Visible = true;
            btn_Logout.Visible = true;
           
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
            loadform(new profile());
        }

        private void btn_Notifications_Click(object sender, EventArgs e)
        {
            loadform(new notificationsForm());
        }

        private void btn_Books_Click(object sender, EventArgs e)
        {
            loadform(new booksForm());
        }

        private void btn_Transactions_Click(object sender, EventArgs e)
        {
            var newForm = new transactionsForm();
            newForm.Show();
            this.Hide();
        }

        private void btn_Reservations_Click(object sender, EventArgs e)
        {
            var newForm = new reservationsForm();
            newForm.Show();
            this.Hide();
        }
        private void btn_Fines_Click(object sender, EventArgs e)
        {
            var newForm = new finesForm();
            newForm.Show();
            this.Hide();
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
    }
}
