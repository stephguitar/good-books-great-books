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
            this.reserveDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.btn_Reserve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editionLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.reserveDateLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtCopyID = new System.Windows.Forms.TextBox();
            this.txtb_bkID = new System.Windows.Forms.TextBox();
            this.txtboxStatus = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.txtbox_MemberID = new System.Windows.Forms.TextBox();
            this.txtbox_LibrarianName = new System.Windows.Forms.TextBox();
            this.txtbox_LibrarianID = new System.Windows.Forms.TextBox();
            this.booksPanel = new System.Windows.Forms.Panel();
            this.ReservedDB = new System.Windows.Forms.DataGridView();
            this.reservationLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.reservationsPanel.SuspendLayout();
            this.reservePanel.SuspendLayout();
            this.booksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservedDB)).BeginInit();
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
            this.reservePanel.Controls.Add(this.reserveDate);
            this.reservePanel.Controls.Add(this.btn_Cancel);
            this.reservePanel.Controls.Add(this.txtReservationID);
            this.reservePanel.Controls.Add(this.btn_Reserve);
            this.reservePanel.Controls.Add(this.label3);
            this.reservePanel.Controls.Add(this.label2);
            this.reservePanel.Controls.Add(this.editionLabel);
            this.reservePanel.Controls.Add(this.authorLabel);
            this.reservePanel.Controls.Add(this.titleLabel);
            this.reservePanel.Controls.Add(this.reserveDateLabel);
            this.reservePanel.Controls.Add(this.statusLabel);
            this.reservePanel.Controls.Add(this.textBox5);
            this.reservePanel.Controls.Add(this.textBox6);
            this.reservePanel.Controls.Add(this.textBox7);
            this.reservePanel.Controls.Add(this.txtCopyID);
            this.reservePanel.Controls.Add(this.txtb_bkID);
            this.reservePanel.Controls.Add(this.txtboxStatus);
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
            // reserveDate
            // 
            this.reserveDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveDate.Location = new System.Drawing.Point(10, 559);
            this.reserveDate.Name = "reserveDate";
            this.reserveDate.Size = new System.Drawing.Size(219, 21);
            this.reserveDate.TabIndex = 55;
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
            // txtReservationID
            // 
            this.txtReservationID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtReservationID.Location = new System.Drawing.Point(13, 430);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(211, 23);
            this.txtReservationID.TabIndex = 49;
            this.txtReservationID.Text = "Reservation ID";
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
            this.editionLabel.Location = new System.Drawing.Point(10, 374);
            this.editionLabel.Name = "editionLabel";
            this.editionLabel.Size = new System.Drawing.Size(56, 13);
            this.editionLabel.TabIndex = 45;
            this.editionLabel.Text = "Edition:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(10, 345);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(55, 13);
            this.authorLabel.TabIndex = 44;
            this.authorLabel.Text = "Author:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(10, 313);
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
            this.statusLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox5.Location = new System.Drawing.Point(71, 364);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(153, 23);
            this.textBox5.TabIndex = 37;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox6.Location = new System.Drawing.Point(71, 335);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(153, 23);
            this.textBox6.TabIndex = 36;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox7.Location = new System.Drawing.Point(71, 306);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(153, 23);
            this.textBox7.TabIndex = 35;
            // 
            // txtCopyID
            // 
            this.txtCopyID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopyID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCopyID.Location = new System.Drawing.Point(13, 40);
            this.txtCopyID.Name = "txtCopyID";
            this.txtCopyID.Size = new System.Drawing.Size(211, 23);
            this.txtCopyID.TabIndex = 31;
            this.txtCopyID.Text = "Copy ID";
            // 
            // txtb_bkID
            // 
            this.txtb_bkID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_bkID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtb_bkID.Location = new System.Drawing.Point(13, 11);
            this.txtb_bkID.Name = "txtb_bkID";
            this.txtb_bkID.Size = new System.Drawing.Size(211, 23);
            this.txtb_bkID.TabIndex = 34;
            this.txtb_bkID.Text = "Book ID";
            // 
            // txtboxStatus
            // 
            this.txtboxStatus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxStatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxStatus.Location = new System.Drawing.Point(71, 489);
            this.txtboxStatus.Name = "txtboxStatus";
            this.txtboxStatus.Size = new System.Drawing.Size(153, 23);
            this.txtboxStatus.TabIndex = 32;
            this.txtboxStatus.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmail.Location = new System.Drawing.Point(13, 234);
            this.txtEmail.Name = "txtEmail";
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
            this.booksPanel.Controls.Add(this.ReservedDB);
            this.booksPanel.Controls.Add(this.reservationLabel);
            this.booksPanel.Location = new System.Drawing.Point(263, 14);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Size = new System.Drawing.Size(504, 657);
            this.booksPanel.TabIndex = 1;
            // 
            // ReservedDB
            // 
            this.ReservedDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservedDB.Location = new System.Drawing.Point(22, 79);
            this.ReservedDB.Name = "ReservedDB";
            this.ReservedDB.Size = new System.Drawing.Size(462, 562);
            this.ReservedDB.TabIndex = 2;
            // 
            // reservationLabel
            // 
            this.reservationLabel.AutoSize = true;
            this.reservationLabel.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationLabel.Location = new System.Drawing.Point(124, 11);
            this.reservationLabel.Name = "reservationLabel";
            this.reservationLabel.Size = new System.Drawing.Size(269, 55);
            this.reservationLabel.TabIndex = 1;
            this.reservationLabel.Text = "BOOKS CATALOG";
            this.reservationLabel.Click += new System.EventHandler(this.label1_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.ReservedDB)).EndInit();
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtCopyID;
        private System.Windows.Forms.TextBox txtb_bkID;
        private System.Windows.Forms.TextBox txtboxStatus;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.TextBox txtbox_MemberID;
        private System.Windows.Forms.TextBox txtbox_LibrarianName;
        private System.Windows.Forms.TextBox txtbox_LibrarianID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.DataGridView ReservedDB;
        private System.Windows.Forms.DateTimePicker reserveDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Home;
    }
}