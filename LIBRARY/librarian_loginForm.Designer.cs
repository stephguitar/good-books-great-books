namespace LIBRARY
{
    partial class librarian_loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(librarian_loginForm));
            this.adminPanel = new System.Windows.Forms.Panel();
            this.btn_submit = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.librarianLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtbox_librarianPassword = new System.Windows.Forms.TextBox();
            this.txtbox_LibrarianID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.btn_submit);
            this.adminPanel.Controls.Add(this.passwordLabel);
            this.adminPanel.Controls.Add(this.librarianLabel);
            this.adminPanel.Controls.Add(this.pictureBox2);
            this.adminPanel.Controls.Add(this.txtbox_librarianPassword);
            this.adminPanel.Controls.Add(this.txtbox_LibrarianID);
            this.adminPanel.Controls.Add(this.pictureBox1);
            this.adminPanel.Location = new System.Drawing.Point(-2, -3);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(803, 558);
            this.adminPanel.TabIndex = 8;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_submit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(152, 422);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(317, 35);
            this.btn_submit.TabIndex = 15;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.passwordLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(152, 357);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(93, 16);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "PASSWORD:";
            // 
            // librarianLabel
            // 
            this.librarianLabel.AutoSize = true;
            this.librarianLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.librarianLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.librarianLabel.Location = new System.Drawing.Point(151, 291);
            this.librarianLabel.Name = "librarianLabel";
            this.librarianLabel.Size = new System.Drawing.Size(110, 16);
            this.librarianLabel.TabIndex = 13;
            this.librarianLabel.Text = "LIBRARIAN ID:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(152, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // txtbox_librarianPassword
            // 
            this.txtbox_librarianPassword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_librarianPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_librarianPassword.Location = new System.Drawing.Point(152, 376);
            this.txtbox_librarianPassword.Name = "txtbox_librarianPassword";
            this.txtbox_librarianPassword.Size = new System.Drawing.Size(317, 21);
            this.txtbox_librarianPassword.TabIndex = 11;
            this.txtbox_librarianPassword.Text = "PASSWORD: *";
            this.txtbox_librarianPassword.UseSystemPasswordChar = true;
            this.txtbox_librarianPassword.TextChanged += new System.EventHandler(this.txtboxAdminPW_TextChanged);
            // 
            // txtbox_LibrarianID
            // 
            this.txtbox_LibrarianID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_LibrarianID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_LibrarianID.Location = new System.Drawing.Point(152, 310);
            this.txtbox_LibrarianID.Name = "txtbox_LibrarianID";
            this.txtbox_LibrarianID.Size = new System.Drawing.Size(317, 21);
            this.txtbox_LibrarianID.TabIndex = 10;
            this.txtbox_LibrarianID.Text = "LIBRARIAN ID: *";
            this.txtbox_LibrarianID.TextChanged += new System.EventHandler(this.txtboxLibrarianID_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 585);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // librarian_loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(780, 529);
            this.Controls.Add(this.adminPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "librarian_loginForm";
            this.Text = "adminForm";
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label librarianLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtbox_librarianPassword;
        private System.Windows.Forms.TextBox txtbox_LibrarianID;
    }
}