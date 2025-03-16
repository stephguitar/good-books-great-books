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
    public partial class profile: Form
    {

        public profile()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.registrationPanel.Controls.Count > 0)
                this.registrationPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.registrationPanel.Controls.Add(f);
            this.registrationPanel.Tag = f;
            f.BringToFront();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {

            btn_login.Visible = false;
            btn_signUp.Visible = false;
            loadform(new loginForm());
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            btn_login.Visible = false;
            btn_signUp.Visible = false;
            loadform(new member_registrationForm());
        }

        private void btn_registerLibrarian_Click(object sender, EventArgs e)
        {
            btn_login.Visible = false;
            btn_signUp.Visible = false;
            loadform(new librarian_registrationForm());
        }
    }
}
