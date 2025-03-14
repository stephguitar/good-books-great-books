using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY
{
    public partial class reportsForm: Form
    {
        public Point mouseLocation;
        public reportsForm()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
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

        private void btn_Status_Click_1(object sender, EventArgs e)
        {
            Form frm = new btn1Form_Reports();
            frm.Show();
        }

        private void btn_unon_Click(object sender, EventArgs e)
        {
            Form frm = new btn2Form_Reports();
            frm.Show();
        }

        private void btn_Borrowed_Click(object sender, EventArgs e)
        {
            Form frm = new btn3Form_Reports();
            frm.Show();
        }

        private void btn_Borrowers_Click(object sender, EventArgs e)
        {
            Form frm = new btn4Form_Reports();
            frm.Show();
        }

        private void btn_BorrowedReturned_Click(object sender, EventArgs e)
        {
            Form frm = new btn6Form_Reports();
            frm.Show();
        }

        private void btn_withFines_Click(object sender, EventArgs e)
        {
            Form frm = new btn5Form_Reports();
            frm.Show();
        }
    }
}
