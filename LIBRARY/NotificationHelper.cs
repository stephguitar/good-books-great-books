using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY
{
    public static class NotificationHelper
    {
        public static void ShowNotification(string type, string message)
        {
            toastForm toast = new toastForm(type, message);
            toast.Show();
        }
    }
}
