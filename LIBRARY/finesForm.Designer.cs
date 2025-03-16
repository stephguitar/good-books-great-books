namespace LIBRARY
{
    partial class finesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.finesLabel = new System.Windows.Forms.Label();
            this.txtbox_MemberID = new System.Windows.Forms.TextBox();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.txtbox_LibrarianID = new System.Windows.Forms.TextBox();
            this.txtbox_LibrarianName = new System.Windows.Forms.TextBox();
            this.allissuedPanel = new System.Windows.Forms.Panel();
            this.finesTBLDATA = new System.Windows.Forms.DataGridView();
            this.issuedLabel = new System.Windows.Forms.Label();
            this.txtbox_bookTitle = new System.Windows.Forms.TextBox();
            this.txtbox_CopyID = new System.Windows.Forms.TextBox();
            this.txtbox_TransactionID = new System.Windows.Forms.TextBox();
            this.txtbox_BookID = new System.Windows.Forms.TextBox();
            this.txtbox_Status = new System.Windows.Forms.TextBox();
            this.finesPanel = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fineAmountLabel = new System.Windows.Forms.Label();
            this.txtbox_fineAmount = new System.Windows.Forms.TextBox();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.issueDateLabel = new System.Windows.Forms.Label();
            this.txtbox_issueDate = new System.Windows.Forms.TextBox();
            this.txtbox_dueDate = new System.Windows.Forms.TextBox();
            this.txtbox_returnDate = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.allissuedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finesTBLDATA)).BeginInit();
            this.finesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 34);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Home);
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(73, 60);
            this.panel4.TabIndex = 1;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.Location = new System.Drawing.Point(-15, -28);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(96, 92);
            this.btn_Home.TabIndex = 5;
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
            this.btn_Close.Location = new System.Drawing.Point(-13, -19);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(112, 79);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, -364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 468);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // finesLabel
            // 
            this.finesLabel.AutoSize = true;
            this.finesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.finesLabel.Location = new System.Drawing.Point(218, 117);
            this.finesLabel.Name = "finesLabel";
            this.finesLabel.Size = new System.Drawing.Size(526, 55);
            this.finesLabel.TabIndex = 19;
            this.finesLabel.Text = "RETURNS AND FINES";
            // 
            // txtbox_MemberID
            // 
            this.txtbox_MemberID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_MemberID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_MemberID.Location = new System.Drawing.Point(13, 119);
            this.txtbox_MemberID.Name = "txtbox_MemberID";
            this.txtbox_MemberID.Size = new System.Drawing.Size(188, 23);
            this.txtbox_MemberID.TabIndex = 20;
            this.txtbox_MemberID.Text = "Member ID";
            this.txtbox_MemberID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Name.Location = new System.Drawing.Point(13, 148);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(188, 23);
            this.txtbox_Name.TabIndex = 21;
            this.txtbox_Name.Text = "Full Name";
            this.txtbox_Name.TextChanged += new System.EventHandler(this.txtbox_Name_TextChanged);
            // 
            // txtbox_LibrarianID
            // 
            this.txtbox_LibrarianID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_LibrarianID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_LibrarianID.Location = new System.Drawing.Point(559, 119);
            this.txtbox_LibrarianID.Name = "txtbox_LibrarianID";
            this.txtbox_LibrarianID.Size = new System.Drawing.Size(211, 23);
            this.txtbox_LibrarianID.TabIndex = 22;
            this.txtbox_LibrarianID.Text = "Librarian ID";
            // 
            // txtbox_LibrarianName
            // 
            this.txtbox_LibrarianName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_LibrarianName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_LibrarianName.Location = new System.Drawing.Point(559, 148);
            this.txtbox_LibrarianName.Name = "txtbox_LibrarianName";
            this.txtbox_LibrarianName.Size = new System.Drawing.Size(211, 23);
            this.txtbox_LibrarianName.TabIndex = 23;
            this.txtbox_LibrarianName.Text = "Librarian Name";
            // 
            // allissuedPanel
            // 
            this.allissuedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.allissuedPanel.Controls.Add(this.finesTBLDATA);
            this.allissuedPanel.Controls.Add(this.issuedLabel);
            this.allissuedPanel.Location = new System.Drawing.Point(13, 181);
            this.allissuedPanel.Name = "allissuedPanel";
            this.allissuedPanel.Size = new System.Drawing.Size(757, 215);
            this.allissuedPanel.TabIndex = 24;
            // 
            // finesTBLDATA
            // 
            this.finesTBLDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finesTBLDATA.Location = new System.Drawing.Point(11, 47);
            this.finesTBLDATA.Name = "finesTBLDATA";
            this.finesTBLDATA.Size = new System.Drawing.Size(735, 151);
            this.finesTBLDATA.TabIndex = 3;
            this.finesTBLDATA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.finesTBLDATA_CellContentClick);
            // 
            // issuedLabel
            // 
            this.issuedLabel.AutoSize = true;
            this.issuedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedLabel.Location = new System.Drawing.Point(3, 3);
            this.issuedLabel.Name = "issuedLabel";
            this.issuedLabel.Size = new System.Drawing.Size(347, 39);
            this.issuedLabel.TabIndex = 2;
            this.issuedLabel.Text = "ALL ISSUED BOOKS";
            // 
            // txtbox_bookTitle
            // 
            this.txtbox_bookTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_bookTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_bookTitle.Location = new System.Drawing.Point(13, 407);
            this.txtbox_bookTitle.Name = "txtbox_bookTitle";
            this.txtbox_bookTitle.Size = new System.Drawing.Size(211, 23);
            this.txtbox_bookTitle.TabIndex = 37;
            this.txtbox_bookTitle.Text = "Book Title";
            // 
            // txtbox_CopyID
            // 
            this.txtbox_CopyID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_CopyID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_CopyID.Location = new System.Drawing.Point(298, 436);
            this.txtbox_CopyID.Name = "txtbox_CopyID";
            this.txtbox_CopyID.Size = new System.Drawing.Size(211, 23);
            this.txtbox_CopyID.TabIndex = 36;
            this.txtbox_CopyID.Text = "Copy ID";
            // 
            // txtbox_TransactionID
            // 
            this.txtbox_TransactionID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_TransactionID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_TransactionID.Location = new System.Drawing.Point(298, 407);
            this.txtbox_TransactionID.Name = "txtbox_TransactionID";
            this.txtbox_TransactionID.Size = new System.Drawing.Size(211, 23);
            this.txtbox_TransactionID.TabIndex = 35;
            this.txtbox_TransactionID.Text = "Transaction ID";
            // 
            // txtbox_BookID
            // 
            this.txtbox_BookID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_BookID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_BookID.Location = new System.Drawing.Point(13, 436);
            this.txtbox_BookID.Name = "txtbox_BookID";
            this.txtbox_BookID.Size = new System.Drawing.Size(211, 23);
            this.txtbox_BookID.TabIndex = 38;
            this.txtbox_BookID.Text = "Book ID";
            // 
            // txtbox_Status
            // 
            this.txtbox_Status.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Status.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Status.Location = new System.Drawing.Point(559, 407);
            this.txtbox_Status.Name = "txtbox_Status";
            this.txtbox_Status.Size = new System.Drawing.Size(211, 23);
            this.txtbox_Status.TabIndex = 39;
            this.txtbox_Status.Text = "Status";
            // 
            // finesPanel
            // 
            this.finesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(188)))), ((int)(((byte)(165)))));
            this.finesPanel.Controls.Add(this.txtbox_returnDate);
            this.finesPanel.Controls.Add(this.txtbox_dueDate);
            this.finesPanel.Controls.Add(this.txtbox_issueDate);
            this.finesPanel.Controls.Add(this.btn_Cancel);
            this.finesPanel.Controls.Add(this.btn_Return);
            this.finesPanel.Controls.Add(this.label6);
            this.finesPanel.Controls.Add(this.fineAmountLabel);
            this.finesPanel.Controls.Add(this.txtbox_fineAmount);
            this.finesPanel.Controls.Add(this.returnDateLabel);
            this.finesPanel.Controls.Add(this.dueDateLabel);
            this.finesPanel.Controls.Add(this.label7);
            this.finesPanel.Controls.Add(this.issueDateLabel);
            this.finesPanel.Controls.Add(this.txtbox_Status);
            this.finesPanel.Controls.Add(this.txtbox_BookID);
            this.finesPanel.Controls.Add(this.txtbox_TransactionID);
            this.finesPanel.Controls.Add(this.txtbox_CopyID);
            this.finesPanel.Controls.Add(this.txtbox_bookTitle);
            this.finesPanel.Controls.Add(this.allissuedPanel);
            this.finesPanel.Controls.Add(this.txtbox_LibrarianName);
            this.finesPanel.Controls.Add(this.txtbox_LibrarianID);
            this.finesPanel.Controls.Add(this.txtbox_Name);
            this.finesPanel.Controls.Add(this.txtbox_MemberID);
            this.finesPanel.Controls.Add(this.finesLabel);
            this.finesPanel.Controls.Add(this.pictureBox1);
            this.finesPanel.Location = new System.Drawing.Point(0, 35);
            this.finesPanel.Name = "finesPanel";
            this.finesPanel.Size = new System.Drawing.Size(949, 706);
            this.finesPanel.TabIndex = 2;
            this.finesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.finesPanel_Paint);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.Location = new System.Drawing.Point(687, 641);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(78, 33);
            this.btn_Cancel.TabIndex = 61;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Return.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Return.Location = new System.Drawing.Point(603, 642);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(78, 33);
            this.btn_Return.TabIndex = 60;
            this.btn_Return.Text = "RETURN";
            this.btn_Return.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.label6.Location = new System.Drawing.Point(12, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1556, 39);
            this.label6.TabIndex = 59;
            this.label6.Text = "_________________________________________________________________________________" +
    "";
            // 
            // fineAmountLabel
            // 
            this.fineAmountLabel.AutoSize = true;
            this.fineAmountLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineAmountLabel.Location = new System.Drawing.Point(12, 659);
            this.fineAmountLabel.Name = "fineAmountLabel";
            this.fineAmountLabel.Size = new System.Drawing.Size(111, 16);
            this.fineAmountLabel.TabIndex = 58;
            this.fineAmountLabel.Text = "FINE AMOUNT:";
            // 
            // txtbox_fineAmount
            // 
            this.txtbox_fineAmount.Location = new System.Drawing.Point(129, 655);
            this.txtbox_fineAmount.Name = "txtbox_fineAmount";
            this.txtbox_fineAmount.Size = new System.Drawing.Size(211, 20);
            this.txtbox_fineAmount.TabIndex = 57;
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateLabel.Location = new System.Drawing.Point(549, 529);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(108, 16);
            this.returnDateLabel.TabIndex = 55;
            this.returnDateLabel.Text = "RETURN DATE:";
            this.returnDateLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(289, 529);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(82, 16);
            this.dueDateLabel.TabIndex = 53;
            this.dueDateLabel.Text = "DUE DATE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.label7.Location = new System.Drawing.Point(16, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1556, 39);
            this.label7.TabIndex = 51;
            this.label7.Text = "_________________________________________________________________________________" +
    "";
            // 
            // issueDateLabel
            // 
            this.issueDateLabel.AutoSize = true;
            this.issueDateLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueDateLabel.Location = new System.Drawing.Point(12, 529);
            this.issueDateLabel.Name = "issueDateLabel";
            this.issueDateLabel.Size = new System.Drawing.Size(96, 16);
            this.issueDateLabel.TabIndex = 48;
            this.issueDateLabel.Text = "ISSUE DATE:";
            // 
            // txtbox_issueDate
            // 
            this.txtbox_issueDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_issueDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_issueDate.Location = new System.Drawing.Point(13, 548);
            this.txtbox_issueDate.Name = "txtbox_issueDate";
            this.txtbox_issueDate.Size = new System.Drawing.Size(220, 23);
            this.txtbox_issueDate.TabIndex = 62;
            this.txtbox_issueDate.Text = "YYYY-MM-DD";
            // 
            // txtbox_dueDate
            // 
            this.txtbox_dueDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_dueDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_dueDate.Location = new System.Drawing.Point(289, 548);
            this.txtbox_dueDate.Name = "txtbox_dueDate";
            this.txtbox_dueDate.Size = new System.Drawing.Size(220, 23);
            this.txtbox_dueDate.TabIndex = 63;
            this.txtbox_dueDate.Text = "YYYY-MM-DD";
            // 
            // txtbox_returnDate
            // 
            this.txtbox_returnDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_returnDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_returnDate.Location = new System.Drawing.Point(550, 548);
            this.txtbox_returnDate.Name = "txtbox_returnDate";
            this.txtbox_returnDate.Size = new System.Drawing.Size(220, 23);
            this.txtbox_returnDate.TabIndex = 64;
            this.txtbox_returnDate.Text = "YYYY-MM-DD";
            // 
            // finesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(195)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(781, 736);
            this.Controls.Add(this.finesPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "finesForm";
            this.Text = "finesForm";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.allissuedPanel.ResumeLayout(false);
            this.allissuedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finesTBLDATA)).EndInit();
            this.finesPanel.ResumeLayout(false);
            this.finesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label finesLabel;
        private System.Windows.Forms.TextBox txtbox_MemberID;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.TextBox txtbox_LibrarianID;
        private System.Windows.Forms.TextBox txtbox_LibrarianName;
        private System.Windows.Forms.Panel allissuedPanel;
        private System.Windows.Forms.DataGridView finesTBLDATA;
        private System.Windows.Forms.Label issuedLabel;
        private System.Windows.Forms.TextBox txtbox_bookTitle;
        private System.Windows.Forms.TextBox txtbox_CopyID;
        private System.Windows.Forms.TextBox txtbox_TransactionID;
        private System.Windows.Forms.TextBox txtbox_BookID;
        private System.Windows.Forms.TextBox txtbox_Status;
        private System.Windows.Forms.Panel finesPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label issueDateLabel;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label fineAmountLabel;
        private System.Windows.Forms.TextBox txtbox_fineAmount;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.TextBox txtbox_issueDate;
        private System.Windows.Forms.TextBox txtbox_returnDate;
        private System.Windows.Forms.TextBox txtbox_dueDate;
    }
}