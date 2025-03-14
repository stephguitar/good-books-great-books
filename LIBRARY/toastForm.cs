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
    
    public partial class toastForm: Form
    {
        int toastX, toastY;
        public toastForm(string type, string message)
        {
            InitializeComponent();
            typeLABEL.Text = type;
            messageLABEL.Text = message;
            switch (type){
                case "SUCCESS":
                    toastBorder.BackColor = Color.FromArgb(57, 155, 53);
                    imageIcon.Image = Properties.Resources.check_icon1;
                    break;

                case "ERROR":
                    toastBorder.BackColor = Color.FromArgb(227, 50, 45);
                    imageIcon.Image = Properties.Resources.error_icon;
                    break;

                case "INFO":
                    toastBorder.BackColor = Color.FromArgb(18, 136, 191);
                    imageIcon.Image = Properties.Resources.info_icon;
                    break;

                case "WARNING":
                    toastBorder.BackColor = Color.FromArgb(245, 171, 35);
                    imageIcon.Image = Properties.Resources.warning_icon;
                    break;
            }
        }

        private void toastForm_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void toastTimer_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if (toastY <= 850) {
                toastTimer.Stop();
                toastHide.Start();
            }
        }
        int y = 100;
        private void toastHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0){
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if (toastY > 1000){
                    toastHide.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 5;
            toastY = ScreenHeight - this.Height + 70;

            this.Location = new Point(toastX, toastY);
        }
    }
}
