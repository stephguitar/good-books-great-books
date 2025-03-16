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
    public partial class librarianRegistrationForm: Form
    {
        public librarianRegistrationForm()
        {
            InitializeComponent();

            // PLACEHOLDERS 
            SetPlaceholder(txtbox_LN, "Smith");
            SetPlaceholder(txtbox_FN, "John");
            SetPlaceholder(txtbox_MN, "Ash");
            SetPlaceholder(txtbox_Address, "99 Street, Brgy. Example");
            SetPlaceholder(txtbox_Email, "example@email.com");
            SetPlaceholder(txtbox_Password, "password");
            SetPlaceholder(txtbox_Number, "09XXXXXXXX");
        }

        // PLACEHOLDER
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

        private void librarianRegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
