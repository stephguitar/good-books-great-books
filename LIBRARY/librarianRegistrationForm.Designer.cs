namespace LIBRARY
{
    partial class librarianRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(librarianRegistrationForm));
            this.LibPanel = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.label_address = new System.Windows.Forms.Label();
            this.label_contactNo = new System.Windows.Forms.Label();
            this.label_emailAdd = new System.Windows.Forms.Label();
            this.txtbox_Address = new System.Windows.Forms.TextBox();
            this.txtbox_Number = new System.Windows.Forms.TextBox();
            this.txtbox_Email = new System.Windows.Forms.TextBox();
            this.label_ContactInfo = new System.Windows.Forms.Label();
            this.label_middleName = new System.Windows.Forms.Label();
            this.label_firstName = new System.Windows.Forms.Label();
            this.label_lastName = new System.Windows.Forms.Label();
            this.label_LibrarianInfo = new System.Windows.Forms.Label();
            this.txtbox_MN = new System.Windows.Forms.TextBox();
            this.txtbox_FN = new System.Windows.Forms.TextBox();
            this.txtbox_LN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_libarianPosition = new System.Windows.Forms.Label();
            this.comboBox_LibrarianPosition = new System.Windows.Forms.ComboBox();
            this.txtbox_LibrarianID = new System.Windows.Forms.TextBox();
            this.txtbox_Password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.LibPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LibPanel
            // 
            this.LibPanel.Controls.Add(this.label_password);
            this.LibPanel.Controls.Add(this.txtbox_Password);
            this.LibPanel.Controls.Add(this.btn_Cancel);
            this.LibPanel.Controls.Add(this.btn_Register);
            this.LibPanel.Controls.Add(this.label_address);
            this.LibPanel.Controls.Add(this.label_contactNo);
            this.LibPanel.Controls.Add(this.label_emailAdd);
            this.LibPanel.Controls.Add(this.txtbox_Address);
            this.LibPanel.Controls.Add(this.txtbox_Number);
            this.LibPanel.Controls.Add(this.txtbox_Email);
            this.LibPanel.Controls.Add(this.label_ContactInfo);
            this.LibPanel.Controls.Add(this.label_middleName);
            this.LibPanel.Controls.Add(this.label_firstName);
            this.LibPanel.Controls.Add(this.label_lastName);
            this.LibPanel.Controls.Add(this.label_LibrarianInfo);
            this.LibPanel.Controls.Add(this.txtbox_MN);
            this.LibPanel.Controls.Add(this.txtbox_FN);
            this.LibPanel.Controls.Add(this.txtbox_LN);
            this.LibPanel.Controls.Add(this.label2);
            this.LibPanel.Controls.Add(this.LabelTitle);
            this.LibPanel.Controls.Add(this.pictureBox1);
            this.LibPanel.Controls.Add(this.label_libarianPosition);
            this.LibPanel.Controls.Add(this.comboBox_LibrarianPosition);
            this.LibPanel.Controls.Add(this.txtbox_LibrarianID);
            this.LibPanel.Location = new System.Drawing.Point(-2, 0);
            this.LibPanel.Name = "LibPanel";
            this.LibPanel.Size = new System.Drawing.Size(790, 648);
            this.LibPanel.TabIndex = 9;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(454, 427);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(129, 44);
            this.btn_Cancel.TabIndex = 74;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Register.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(308, 427);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(129, 44);
            this.btn_Register.TabIndex = 73;
            this.btn_Register.Text = "REGISTER";
            this.btn_Register.UseVisualStyleBackColor = false;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(22, 429);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(71, 16);
            this.label_address.TabIndex = 72;
            this.label_address.Text = "Address:";
            // 
            // label_contactNo
            // 
            this.label_contactNo.AutoSize = true;
            this.label_contactNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contactNo.Location = new System.Drawing.Point(306, 379);
            this.label_contactNo.Name = "label_contactNo";
            this.label_contactNo.Size = new System.Drawing.Size(118, 16);
            this.label_contactNo.TabIndex = 71;
            this.label_contactNo.Text = "Phone Number:";
            // 
            // label_emailAdd
            // 
            this.label_emailAdd.AutoSize = true;
            this.label_emailAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emailAdd.Location = new System.Drawing.Point(306, 276);
            this.label_emailAdd.Name = "label_emailAdd";
            this.label_emailAdd.Size = new System.Drawing.Size(120, 16);
            this.label_emailAdd.TabIndex = 70;
            this.label_emailAdd.Text = "E-Mail Address:";
            // 
            // txtbox_Address
            // 
            this.txtbox_Address.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Address.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Address.Location = new System.Drawing.Point(22, 448);
            this.txtbox_Address.Name = "txtbox_Address";
            this.txtbox_Address.Size = new System.Drawing.Size(274, 23);
            this.txtbox_Address.TabIndex = 69;
            // 
            // txtbox_Number
            // 
            this.txtbox_Number.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Number.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Number.Location = new System.Drawing.Point(309, 398);
            this.txtbox_Number.Name = "txtbox_Number";
            this.txtbox_Number.Size = new System.Drawing.Size(274, 23);
            this.txtbox_Number.TabIndex = 68;
            // 
            // txtbox_Email
            // 
            this.txtbox_Email.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Email.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Email.Location = new System.Drawing.Point(309, 295);
            this.txtbox_Email.Name = "txtbox_Email";
            this.txtbox_Email.Size = new System.Drawing.Size(274, 23);
            this.txtbox_Email.TabIndex = 67;
            // 
            // label_ContactInfo
            // 
            this.label_ContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label_ContactInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_ContactInfo.Location = new System.Drawing.Point(302, 221);
            this.label_ContactInfo.Name = "label_ContactInfo";
            this.label_ContactInfo.Size = new System.Drawing.Size(322, 50);
            this.label_ContactInfo.TabIndex = 66;
            this.label_ContactInfo.Text = "CONTACT INFORMATION";
            // 
            // label_middleName
            // 
            this.label_middleName.AutoSize = true;
            this.label_middleName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_middleName.Location = new System.Drawing.Point(19, 379);
            this.label_middleName.Name = "label_middleName";
            this.label_middleName.Size = new System.Drawing.Size(105, 16);
            this.label_middleName.TabIndex = 65;
            this.label_middleName.Text = "Middle Name:";
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstName.Location = new System.Drawing.Point(19, 329);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(91, 16);
            this.label_firstName.TabIndex = 64;
            this.label_firstName.Text = "First Name:";
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastName.Location = new System.Drawing.Point(19, 276);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(89, 16);
            this.label_lastName.TabIndex = 63;
            this.label_lastName.Text = "Last Name:";
            // 
            // label_LibrarianInfo
            // 
            this.label_LibrarianInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label_LibrarianInfo.Location = new System.Drawing.Point(17, 221);
            this.label_LibrarianInfo.Name = "label_LibrarianInfo";
            this.label_LibrarianInfo.Size = new System.Drawing.Size(322, 50);
            this.label_LibrarianInfo.TabIndex = 59;
            this.label_LibrarianInfo.Text = "MEMBER INFORMATION";
            this.label_LibrarianInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbox_MN
            // 
            this.txtbox_MN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_MN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_MN.Location = new System.Drawing.Point(22, 398);
            this.txtbox_MN.Name = "txtbox_MN";
            this.txtbox_MN.Size = new System.Drawing.Size(274, 23);
            this.txtbox_MN.TabIndex = 62;
            // 
            // txtbox_FN
            // 
            this.txtbox_FN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_FN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_FN.Location = new System.Drawing.Point(22, 348);
            this.txtbox_FN.Name = "txtbox_FN";
            this.txtbox_FN.Size = new System.Drawing.Size(274, 23);
            this.txtbox_FN.TabIndex = 61;
            // 
            // txtbox_LN
            // 
            this.txtbox_LN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_LN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_LN.Location = new System.Drawing.Point(22, 295);
            this.txtbox_LN.Name = "txtbox_LN";
            this.txtbox_LN.Size = new System.Drawing.Size(274, 23);
            this.txtbox_LN.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(766, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "______________________________________________________";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(149)))), ((int)(((byte)(101)))));
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(14, 30);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(869, 73);
            this.LabelTitle.TabIndex = 57;
            this.LabelTitle.Text = "LIBRARIAN REGISTRATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -418);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // label_libarianPosition
            // 
            this.label_libarianPosition.AutoSize = true;
            this.label_libarianPosition.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_libarianPosition.Location = new System.Drawing.Point(258, 166);
            this.label_libarianPosition.Name = "label_libarianPosition";
            this.label_libarianPosition.Size = new System.Drawing.Size(138, 16);
            this.label_libarianPosition.TabIndex = 55;
            this.label_libarianPosition.Text = "Librarian Position:";
            // 
            // comboBox_LibrarianPosition
            // 
            this.comboBox_LibrarianPosition.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_LibrarianPosition.FormattingEnabled = true;
            this.comboBox_LibrarianPosition.Location = new System.Drawing.Point(397, 161);
            this.comboBox_LibrarianPosition.Name = "comboBox_LibrarianPosition";
            this.comboBox_LibrarianPosition.Size = new System.Drawing.Size(166, 26);
            this.comboBox_LibrarianPosition.TabIndex = 54;
            // 
            // txtbox_LibrarianID
            // 
            this.txtbox_LibrarianID.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_LibrarianID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_LibrarianID.Location = new System.Drawing.Point(22, 160);
            this.txtbox_LibrarianID.Name = "txtbox_LibrarianID";
            this.txtbox_LibrarianID.Size = new System.Drawing.Size(211, 26);
            this.txtbox_LibrarianID.TabIndex = 53;
            this.txtbox_LibrarianID.Text = "Librarian ID";
            // 
            // txtbox_Password
            // 
            this.txtbox_Password.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Password.Location = new System.Drawing.Point(308, 348);
            this.txtbox_Password.Name = "txtbox_Password";
            this.txtbox_Password.Size = new System.Drawing.Size(275, 23);
            this.txtbox_Password.TabIndex = 75;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(306, 329);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(82, 16);
            this.label_password.TabIndex = 76;
            this.label_password.Text = "Password:";
            // 
            // librarianRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(188)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(780, 640);
            this.Controls.Add(this.LibPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "librarianRegistrationForm";
            this.Text = "librarianRegistration";
            this.Load += new System.EventHandler(this.librarianRegistrationForm_Load);
            this.LibPanel.ResumeLayout(false);
            this.LibPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LibPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_libarianPosition;
        private System.Windows.Forms.ComboBox comboBox_LibrarianPosition;
        private System.Windows.Forms.TextBox txtbox_LibrarianID;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_middleName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.Label label_LibrarianInfo;
        private System.Windows.Forms.TextBox txtbox_MN;
        private System.Windows.Forms.TextBox txtbox_FN;
        private System.Windows.Forms.TextBox txtbox_LN;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_contactNo;
        private System.Windows.Forms.Label label_emailAdd;
        private System.Windows.Forms.TextBox txtbox_Address;
        private System.Windows.Forms.TextBox txtbox_Number;
        private System.Windows.Forms.TextBox txtbox_Email;
        private System.Windows.Forms.Label label_ContactInfo;
        private System.Windows.Forms.TextBox txtbox_Password;
        private System.Windows.Forms.Label label_password;
    }
}