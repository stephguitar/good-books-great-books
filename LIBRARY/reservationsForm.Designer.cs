namespace LIBRARY
{
    partial class reservationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservationsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.reservationsPanel = new System.Windows.Forms.Panel();
            this.reservePanel = new System.Windows.Forms.Panel();
            this.reservationStatus_COMBO = new System.Windows.Forms.ComboBox();
            this.txtbox_reserveDate = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txtbox_ReservationID = new System.Windows.Forms.TextBox();
            this.btn_Reserve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editionLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.reserveDateLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.txtbox_Edition = new System.Windows.Forms.TextBox();
            this.txtbox_Author = new System.Windows.Forms.TextBox();
            this.txtbox_bookTitle = new System.Windows.Forms.TextBox();
            this.txtbox_CopyID = new System.Windows.Forms.TextBox();
            this.txtbox_BookID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.txtbox_MemberID = new System.Windows.Forms.TextBox();
            this.txtbox_LibrarianName = new System.Windows.Forms.TextBox();
            this.txtbox_LibrarianID = new System.Windows.Forms.TextBox();
            this.booksPanel = new System.Windows.Forms.Panel();
            this.reservationsTBLDATA = new System.Windows.Forms.DataGridView();
            this.reservationLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.reservationsPanel.SuspendLayout();
            this.reservePanel.SuspendLayout();
            this.booksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsTBLDATA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 34);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Home);
            this.panel3.Location = new System.Drawing.Point(-2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(76, 46);
            this.panel3.TabIndex = 1;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.Location = new System.Drawing.Point(-8, -29);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(96, 92);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Location = new System.Drawing.Point(709, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 35);
            this.panel2.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Close.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(-16, -23);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(112, 79);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // reservationsPanel
            // 
            this.reservationsPanel.Controls.Add(this.reservePanel);
            this.reservationsPanel.Controls.Add(this.booksPanel);
            this.reservationsPanel.Location = new System.Drawing.Point(-13, 27);
            this.reservationsPanel.Name = "reservationsPanel";
            this.reservationsPanel.Size = new System.Drawing.Size(793, 685);
            this.reservationsPanel.TabIndex = 2;
            // 
            // reservePanel
            // 
            this.reservePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.reservePanel.Controls.Add(this.reservationStatus_COMBO);
            this.reservePanel.Controls.Add(this.txtbox_reserveDate);
            this.reservePanel.Controls.Add(this.btn_Cancel);
            this.reservePanel.Controls.Add(this.txtbox_ReservationID);
            this.reservePanel.Controls.Add(this.btn_Reserve);
            this.reservePanel.Controls.Add(this.label3);
            this.reservePanel.Controls.Add(this.label2);
            this.reservePanel.Controls.Add(this.editionLabel);
            this.reservePanel.Controls.Add(this.authorLabel);
            this.reservePanel.Controls.Add(this.titleLabel);
            this.reservePanel.Controls.Add(this.reserveDateLabel);
            this.reservePanel.Controls.Add(this.statusLabel);
            this.reservePanel.Controls.Add(this.txtbox_Edition);
            this.reservePanel.Controls.Add(this.txtbox_Author);
            this.reservePanel.Controls.Add(this.txtbox_bookTitle);
            this.reservePanel.Controls.Add(this.txtbox_CopyID);
            this.reservePanel.Controls.Add(this.txtbox_BookID);
            this.reservePanel.Controls.Add(this.txtEmail);
            this.reservePanel.Controls.Add(this.txtContactNumber);
            this.reservePanel.Controls.Add(this.txtbox_Name);
            this.reservePanel.Controls.Add(this.txtbox_MemberID);
            this.reservePanel.Controls.Add(this.txtbox_LibrarianName);
            this.reservePanel.Controls.Add(this.txtbox_LibrarianID);
            this.reservePanel.Location = new System.Drawing.Point(25, 14);
            this.reservePanel.Name = "reservePanel";
            this.reservePanel.Size = new System.Drawing.Size(232, 657);
            this.reservePanel.TabIndex = 2;
            // 
            // reservationStatus_COMBO
            // 
            this.reservationStatus_COMBO.FormattingEnabled = true;
            this.reservationStatus_COMBO.Location = new System.Drawing.Point(71, 491);
            this.reservationStatus_COMBO.Name = "reservationStatus_COMBO";
            this.reservationStatus_COMBO.Size = new System.Drawing.Size(153, 21);
            this.reservationStatus_COMBO.TabIndex = 57;
            // 
            // txtbox_reserveDate
            // 
            this.txtbox_reserveDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_reserveDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_reserveDate.Location = new System.Drawing.Point(13, 559);
            this.txtbox_reserveDate.Name = "txtbox_reserveDate";
            this.txtbox_reserveDate.Size = new System.Drawing.Size(211, 23);
            this.txtbox_reserveDate.TabIndex = 56;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.Location = new System.Drawing.Point(146, 608);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(78, 33);
            this.btn_Cancel.TabIndex = 46;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // txtbox_ReservationID
            // 
            this.txtbox_ReservationID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_ReservationID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_ReservationID.Location = new System.Drawing.Point(13, 430);
            this.txtbox_ReservationID.Name = "txtbox_ReservationID";
            this.txtbox_ReservationID.Size = new System.Drawing.Size(211, 23);
            this.txtbox_ReservationID.TabIndex = 49;
            this.txtbox_ReservationID.Text = "Reservation ID";
            // 
            // btn_Reserve
            // 
            this.btn_Reserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Reserve.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Reserve.Location = new System.Drawing.Point(13, 608);
            this.btn_Reserve.Name = "btn_Reserve";
            this.btn_Reserve.Size = new System.Drawing.Size(78, 33);
            this.btn_Reserve.TabIndex = 2;
            this.btn_Reserve.Text = "RESERVE";
            this.btn_Reserve.UseVisualStyleBackColor = false;
            this.btn_Reserve.Click += new System.EventHandler(this.btn_Reserve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "_______________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "_______________________";
            // 
            // editionLabel
            // 
            this.editionLabel.AutoSize = true;
            this.editionLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editionLabel.Location = new System.Drawing.Point(10, 369);
            this.editionLabel.Name = "editionLabel";
            this.editionLabel.Size = new System.Drawing.Size(56, 13);
            this.editionLabel.TabIndex = 45;
            this.editionLabel.Text = "Edition:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(10, 340);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(55, 13);
            this.authorLabel.TabIndex = 44;
            this.authorLabel.Text = "Author:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(10, 311);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(40, 13);
            this.titleLabel.TabIndex = 43;
            this.titleLabel.Text = "Title:";
            // 
            // reserveDateLabel
            // 
            this.reserveDateLabel.AutoSize = true;
            this.reserveDateLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveDateLabel.Location = new System.Drawing.Point(10, 543);
            this.reserveDateLabel.Name = "reserveDateLabel";
            this.reserveDateLabel.Size = new System.Drawing.Size(138, 13);
            this.reserveDateLabel.TabIndex = 41;
            this.reserveDateLabel.Text = "RESERVATION DATE:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(10, 494);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(52, 13);
            this.statusLabel.TabIndex = 40;
            this.statusLabel.Text = "Status:";
            // 
            // txtbox_Edition
            // 
            this.txtbox_Edition.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Edition.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Edition.Location = new System.Drawing.Point(71, 364);
            this.txtbox_Edition.Name = "txtbox_Edition";
            this.txtbox_Edition.ReadOnly = true;
            this.txtbox_Edition.Size = new System.Drawing.Size(153, 23);
            this.txtbox_Edition.TabIndex = 37;
            // 
            // txtbox_Author
            // 
            this.txtbox_Author.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Author.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Author.Location = new System.Drawing.Point(71, 335);
            this.txtbox_Author.Name = "txtbox_Author";
            this.txtbox_Author.ReadOnly = true;
            this.txtbox_Author.Size = new System.Drawing.Size(153, 23);
            this.txtbox_Author.TabIndex = 36;
            // 
            // txtbox_bookTitle
            // 
            this.txtbox_bookTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_bookTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_bookTitle.Location = new System.Drawing.Point(71, 306);
            this.txtbox_bookTitle.Name = "txtbox_bookTitle";
            this.txtbox_bookTitle.ReadOnly = true;
            this.txtbox_bookTitle.Size = new System.Drawing.Size(153, 23);
            this.txtbox_bookTitle.TabIndex = 35;
            // 
            // txtbox_CopyID
            // 
            this.txtbox_CopyID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_CopyID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_CopyID.Location = new System.Drawing.Point(13, 40);
            this.txtbox_CopyID.Name = "txtbox_CopyID";
            this.txtbox_CopyID.Size = new System.Drawing.Size(211, 23);
            this.txtbox_CopyID.TabIndex = 31;
            this.txtbox_CopyID.Text = "Copy ID";
            // 
            // txtbox_BookID
            // 
            this.txtbox_BookID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_BookID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_BookID.Location = new System.Drawing.Point(13, 11);
            this.txtbox_BookID.Name = "txtbox_BookID";
            this.txtbox_BookID.Size = new System.Drawing.Size(211, 23);
            this.txtbox_BookID.TabIndex = 34;
            this.txtbox_BookID.Text = "Book ID";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmail.Location = new System.Drawing.Point(13, 234);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(211, 23);
            this.txtEmail.TabIndex = 29;
            this.txtEmail.Text = "E-Mail";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtContactNumber.Location = new System.Drawing.Point(13, 205);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.ReadOnly = true;
            this.txtContactNumber.Size = new System.Drawing.Size(211, 23);
            this.txtContactNumber.TabIndex = 28;
            this.txtContactNumber.Text = "Contact Number";
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Name.Location = new System.Drawing.Point(13, 176);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.ReadOnly = true;
            this.txtbox_Name.Size = new System.Drawing.Size(211, 23);
            this.txtbox_Name.TabIndex = 27;
            this.txtbox_Name.Text = "Full Name";
            // 
            // txtbox_MemberID
            // 
            this.txtbox_MemberID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_MemberID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_MemberID.Location = new System.Drawing.Point(13, 147);
            this.txtbox_MemberID.Name = "txtbox_MemberID";
            this.txtbox_MemberID.Size = new System.Drawing.Size(211, 23);
            this.txtbox_MemberID.TabIndex = 26;
            this.txtbox_MemberID.Text = "Member ID";
            // 
            // txtbox_LibrarianName
            // 
            this.txtbox_LibrarianName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_LibrarianName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_LibrarianName.Location = new System.Drawing.Point(13, 108);
            this.txtbox_LibrarianName.Name = "txtbox_LibrarianName";
            this.txtbox_LibrarianName.ReadOnly = true;
            this.txtbox_LibrarianName.Size = new System.Drawing.Size(211, 23);
            this.txtbox_LibrarianName.TabIndex = 25;
            this.txtbox_LibrarianName.Text = "Librarian Name";
            // 
            // txtbox_LibrarianID
            // 
            this.txtbox_LibrarianID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_LibrarianID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_LibrarianID.Location = new System.Drawing.Point(13, 79);
            this.txtbox_LibrarianID.Name = "txtbox_LibrarianID";
            this.txtbox_LibrarianID.Size = new System.Drawing.Size(211, 23);
            this.txtbox_LibrarianID.TabIndex = 24;
            this.txtbox_LibrarianID.Text = "Librarian ID";
            // 
            // booksPanel
            // 
            this.booksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.booksPanel.Controls.Add(this.reservationsTBLDATA);
            this.booksPanel.Controls.Add(this.reservationLabel);
            this.booksPanel.Location = new System.Drawing.Point(263, 14);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Size = new System.Drawing.Size(504, 657);
            this.booksPanel.TabIndex = 1;
            // 
            // reservationsTBLDATA
            // 
            this.reservationsTBLDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationsTBLDATA.Location = new System.Drawing.Point(22, 79);
            this.reservationsTBLDATA.Name = "reservationsTBLDATA";
            this.reservationsTBLDATA.Size = new System.Drawing.Size(462, 562);
            this.reservationsTBLDATA.TabIndex = 2;
            // 
            // reservationLabel
            // 
            this.reservationLabel.AutoSize = true;
            this.reservationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationLabel.Location = new System.Drawing.Point(124, 11);
            this.reservationLabel.Name = "reservationLabel";
            this.reservationLabel.Size = new System.Drawing.Size(436, 55);
            this.reservationLabel.TabIndex = 1;
            this.reservationLabel.Text = "BOOKS CATALOG";
            // 
            // reservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(188)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(766, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reservationsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reservationsForm";
            this.Text = "reservationsForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.reservationsPanel.ResumeLayout(false);
            this.reservePanel.ResumeLayout(false);
            this.reservePanel.PerformLayout();
            this.booksPanel.ResumeLayout(false);
            this.booksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsTBLDATA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel reservationsPanel;
        private System.Windows.Forms.Panel booksPanel;
        private System.Windows.Forms.Label reservationLabel;
        private System.Windows.Forms.Panel reservePanel;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Reserve;
        private System.Windows.Forms.Label editionLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reserveDateLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox txtbox_Edition;
        private System.Windows.Forms.TextBox txtbox_Author;
        private System.Windows.Forms.TextBox txtbox_bookTitle;
        private System.Windows.Forms.TextBox txtbox_CopyID;
        private System.Windows.Forms.TextBox txtbox_BookID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.TextBox txtbox_MemberID;
        private System.Windows.Forms.TextBox txtbox_LibrarianName;
        private System.Windows.Forms.TextBox txtbox_LibrarianID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_ReservationID;
        private System.Windows.Forms.DataGridView reservationsTBLDATA;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.TextBox txtbox_reserveDate;
        private System.Windows.Forms.ComboBox reservationStatus_COMBO;
    }
}