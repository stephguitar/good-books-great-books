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

        private void ShowNotification(string memberID, string message)
        {
            notificationsForm notif = new notificationsForm();
            notif.showToast("INFO", message);
        }

        public void showToast(string type, string message)
        {
            toastForm toast = new toastForm(type, message);
            toast.Show();
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            showToast("SUCCESS", "GREAT NEWS: Reservation is Queued for Book: Title");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            showToast("INFO", "READY FOR PICK-UP! Kindly Collect at the Library");
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            showToast("WARNING", "REMINDER: Borrowed Book is DUE SOON, RETURN ON TIME to Avoid Penalties");
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            showToast("ERROR", "OVERDUE ALERT! YOU HAVE OVERDUE BOOKS, Return IMMEDIATELY to Avoid FURTHER Fines");
        }


    }
}
