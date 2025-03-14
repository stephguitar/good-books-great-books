namespace LIBRARY
{
    partial class toastForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toastBorder = new System.Windows.Forms.Panel();
            this.typeLABEL = new System.Windows.Forms.Label();
            this.messageLABEL = new System.Windows.Forms.Label();
            this.imageIcon = new System.Windows.Forms.PictureBox();
            this.toastTimer = new System.Windows.Forms.Timer(this.components);
            this.toastHide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // toastBorder
            // 
            this.toastBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(155)))), ((int)(((byte)(53)))));
            this.toastBorder.Location = new System.Drawing.Point(-6, -6);
            this.toastBorder.Name = "toastBorder";
            this.toastBorder.Size = new System.Drawing.Size(13, 73);
            this.toastBorder.TabIndex = 0;
            // 
            // typeLABEL
            // 
            this.typeLABEL.AutoSize = true;
            this.typeLABEL.Font = new System.Drawing.Font("Segoe UI Semibold", 10.02F, System.Drawing.FontStyle.Bold);
            this.typeLABEL.Location = new System.Drawing.Point(45, 8);
            this.typeLABEL.Name = "typeLABEL";
            this.typeLABEL.Size = new System.Drawing.Size(38, 19);
            this.typeLABEL.TabIndex = 2;
            this.typeLABEL.Text = "Type";
            // 
            // messageLABEL
            // 
            this.messageLABEL.AutoSize = true;
            this.messageLABEL.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLABEL.Location = new System.Drawing.Point(48, 31);
            this.messageLABEL.Name = "messageLABEL";
            this.messageLABEL.Size = new System.Drawing.Size(82, 13);
            this.messageLABEL.TabIndex = 3;
            this.messageLABEL.Text = "Toast Message";
            // 
            // imageIcon
            // 
            this.imageIcon.Image = global::LIBRARY.Properties.Resources.check_icon1;
            this.imageIcon.Location = new System.Drawing.Point(23, 16);
            this.imageIcon.Name = "imageIcon";
            this.imageIcon.Size = new System.Drawing.Size(19, 19);
            this.imageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageIcon.TabIndex = 1;
            this.imageIcon.TabStop = false;
            // 
            // toastTimer
            // 
            this.toastTimer.Enabled = true;
            this.toastTimer.Interval = 10;
            this.toastTimer.Tick += new System.EventHandler(this.toastTimer_Tick);
            // 
            // toastHide
            // 
            this.toastHide.Interval = 10;
            this.toastHide.Tick += new System.EventHandler(this.toastHide_Tick);
            // 
            // toastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 59);
            this.Controls.Add(this.messageLABEL);
            this.Controls.Add(this.typeLABEL);
            this.Controls.Add(this.imageIcon);
            this.Controls.Add(this.toastBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "toastForm";
            this.Text = "summer1";
            this.Load += new System.EventHandler(this.toastForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toastBorder;
        private System.Windows.Forms.PictureBox imageIcon;
        private System.Windows.Forms.Label typeLABEL;
        private System.Windows.Forms.Label messageLABEL;
        private System.Windows.Forms.Timer toastTimer;
        private System.Windows.Forms.Timer toastHide;
    }
}