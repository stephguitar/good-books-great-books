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
    public partial class notificationsForm: Form
    {
        public notificationsForm()
        {
            InitializeComponent();
        }

        public void showToast(string type, string message)
        {
            toastForm toast = new toastForm(type, message);
            toast.Show();
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            showToast("SUCCESS", "SUMMER CUTIE");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            showToast("INFO", "SUMMER IS PWITTI");
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            showToast("WARNING", "CAUTION! SUMMER IS HAWT");
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            showToast("ERROR", "Summer is NOT my crush");
        }
    }
}
