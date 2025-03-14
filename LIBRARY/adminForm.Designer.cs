namespace LIBRARY
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.adminPanel = new System.Windows.Forms.Panel();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.librarianLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtboxAdminPW = new System.Windows.Forms.TextBox();
            this.txtboxLibrarianID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.btn_Submit);
            this.adminPanel.Controls.Add(this.passwordLabel);
            this.adminPanel.Controls.Add(this.librarianLabel);
            this.adminPanel.Controls.Add(this.pictureBox2);
            this.adminPanel.Controls.Add(this.txtboxAdminPW);
            this.adminPanel.Controls.Add(this.txtboxLibrarianID);
            this.adminPanel.Controls.Add(this.pictureBox1);
            this.adminPanel.Location = new System.Drawing.Point(-2, -3);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(803, 558);
            this.adminPanel.TabIndex = 8;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Submit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(152, 422);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(317, 35);
            this.btn_Submit.TabIndex = 15;
            this.btn_Submit.Text = "SUBMIT";
            this.btn_Submit.UseVisualStyleBackColor = false;
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
            // txtboxAdminPW
            // 
            this.txtboxAdminPW.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAdminPW.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxAdminPW.Location = new System.Drawing.Point(152, 376);
            this.txtboxAdminPW.Name = "txtboxAdminPW";
            this.txtboxAdminPW.Size = new System.Drawing.Size(317, 21);
            this.txtboxAdminPW.TabIndex = 11;
            this.txtboxAdminPW.Text = "PASSWORD: *";
            this.txtboxAdminPW.TextChanged += new System.EventHandler(this.txtboxAdminPW_TextChanged);
            // 
            // txtboxLibrarianID
            // 
            this.txtboxLibrarianID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLibrarianID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxLibrarianID.Location = new System.Drawing.Point(152, 310);
            this.txtboxLibrarianID.Name = "txtboxLibrarianID";
            this.txtboxLibrarianID.Size = new System.Drawing.Size(317, 21);
            this.txtboxLibrarianID.TabIndex = 10;
            this.txtboxLibrarianID.Text = "LIBRARIAN ID: *";
            this.txtboxLibrarianID.TextChanged += new System.EventHandler(this.txtboxLibrarianID_TextChanged);
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
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(780, 529);
            this.Controls.Add(this.adminPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminForm";
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
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label librarianLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtboxAdminPW;
        private System.Windows.Forms.TextBox txtboxLibrarianID;
    }
}