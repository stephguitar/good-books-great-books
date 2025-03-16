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
    public partial class loginForm: Form
    {
        public Point mouseLocation;
        public loginForm()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.loginPanel.Controls.Count > 0)
                this.loginPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.loginPanel.Controls.Add(f);
            this.loginPanel.Tag = f;
            f.BringToFront();
            f.Show();
        }

        private void btn_Member_Click(object sender, EventArgs e)
        {
            btn_Librarian.Visible = false;
            btn_Member.Visible = false;
            loadform(new member_loginForm());
        }

        private void btn_Librarian_Click(object sender, EventArgs e)
        {
            btn_Librarian.Visible = false;
            btn_Member.Visible = false;
            loadform(new librarian_loginForm());
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
