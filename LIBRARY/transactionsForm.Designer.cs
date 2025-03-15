namespace LIBRARY
{
    partial class transactionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transactionsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.transactionsPanel = new System.Windows.Forms.Panel();
            this.issuedSidePanel = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Borrow = new System.Windows.Forms.Button();
            this.bookInfoLabel = new System.Windows.Forms.Label();
            this.bEditionLabel = new System.Windows.Forms.Label();
            this.bAuthorLabel = new System.Windows.Forms.Label();
            this.bTitleLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.issueDateLabel = new System.Windows.Forms.Label();
            this.txtbox_Edition = new System.Windows.Forms.TextBox();
            this.txtbox_Author = new System.Windows.Forms.TextBox();
            this.txtbox_Title = new System.Windows.Forms.TextBox();
            this.txtbox_TransactionID = new System.Windows.Forms.TextBox();
            this.txtbox_CopyID = new System.Windows.Forms.TextBox();
            this.txtbox_BookID = new System.Windows.Forms.TextBox();
            this.txtbox_dueDate = new System.Windows.Forms.TextBox();
            this.txtbox_issueDate = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.txtbox_MemberID = new System.Windows.Forms.TextBox();
            this.txtbox_LibrarianName = new System.Windows.Forms.TextBox();
            this.txtbox_LibrarianID = new System.Windows.Forms.TextBox();
            this.issuedPanel = new System.Windows.Forms.Panel();
            this.booksTBLDATA = new System.Windows.Forms.DataGridView();
            this.borrowTBLDATA = new System.Windows.Forms.DataGridView();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.book_copiesTBLDATA = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.transactionsPanel.SuspendLayout();
            this.issuedSidePanel.SuspendLayout();
            this.issuedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksTBLDATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowTBLDATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_copiesTBLDATA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 36);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 34);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_Home);
            this.panel5.Location = new System.Drawing.Point(3, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(58, 41);
            this.panel5.TabIndex = 1;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.Location = new System.Drawing.Point(-22, -31);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(96, 92);
            this.btn_Home.TabIndex = 3;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Close);
            this.panel3.Location = new System.Drawing.Point(767, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(71, 35);
            this.panel3.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Close.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(-14, -24);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(112, 79);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // transactionsPanel
            // 
            this.transactionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(188)))), ((int)(((byte)(165)))));
            this.transactionsPanel.Controls.Add(this.issuedSidePanel);
            this.transactionsPanel.Controls.Add(this.issuedPanel);
            this.transactionsPanel.Location = new System.Drawing.Point(0, 31);
            this.transactionsPanel.Name = "transactionsPanel";
            this.transactionsPanel.Size = new System.Drawing.Size(949, 591);
            this.transactionsPanel.TabIndex = 1;
            // 
            // issuedSidePanel
            // 
            this.issuedSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.issuedSidePanel.Controls.Add(this.btn_Cancel);
            this.issuedSidePanel.Controls.Add(this.btn_Borrow);
            this.issuedSidePanel.Controls.Add(this.bookInfoLabel);
            this.issuedSidePanel.Controls.Add(this.bEditionLabel);
            this.issuedSidePanel.Controls.Add(this.bAuthorLabel);
            this.issuedSidePanel.Controls.Add(this.bTitleLabel);
            this.issuedSidePanel.Controls.Add(this.dueDateLabel);
            this.issuedSidePanel.Controls.Add(this.issueDateLabel);
            this.issuedSidePanel.Controls.Add(this.txtbox_Edition);
            this.issuedSidePanel.Controls.Add(this.txtbox_Author);
            this.issuedSidePanel.Controls.Add(this.txtbox_Title);
            this.issuedSidePanel.Controls.Add(this.txtbox_TransactionID);
            this.issuedSidePanel.Controls.Add(this.txtbox_CopyID);
            this.issuedSidePanel.Controls.Add(this.txtbox_BookID);
            this.issuedSidePanel.Controls.Add(this.txtbox_dueDate);
            this.issuedSidePanel.Controls.Add(this.txtbox_issueDate);
            this.issuedSidePanel.Controls.Add(this.txtEmail);
            this.issuedSidePanel.Controls.Add(this.txtContactNumber);
            this.issuedSidePanel.Controls.Add(this.txtbox_Name);
            this.issuedSidePanel.Controls.Add(this.txtbox_MemberID);
            this.issuedSidePanel.Controls.Add(this.txtbox_LibrarianName);
            this.issuedSidePanel.Controls.Add(this.txtbox_LibrarianID);
            this.issuedSidePanel.Location = new System.Drawing.Point(11, 12);
            this.issuedSidePanel.Name = "issuedSidePanel";
            this.issuedSidePanel.Size = new System.Drawing.Size(232, 554);
            this.issuedSidePanel.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.Location = new System.Drawing.Point(146, 509);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(78, 33);
            this.btn_Cancel.TabIndex = 46;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Borrow
            // 
            this.btn_Borrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Borrow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Borrow.Location = new System.Drawing.Point(66, 509);
            this.btn_Borrow.Name = "btn_Borrow";
            this.btn_Borrow.Size = new System.Drawing.Size(78, 33);
            this.btn_Borrow.TabIndex = 2;
            this.btn_Borrow.Text = "BORROW";
            this.btn_Borrow.UseVisualStyleBackColor = false;
            this.btn_Borrow.Click += new System.EventHandler(this.btn_Borrow_Click);
            // 
            // bookInfoLabel
            // 
            this.bookInfoLabel.AutoSize = true;
            this.bookInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookInfoLabel.Location = new System.Drawing.Point(6, 342);
            this.bookInfoLabel.Name = "bookInfoLabel";
            this.bookInfoLabel.Size = new System.Drawing.Size(342, 37);
            this.bookInfoLabel.TabIndex = 2;
            this.bookInfoLabel.Text = "BOOK INFORMATION";
            // 
            // bEditionLabel
            // 
            this.bEditionLabel.AutoSize = true;
            this.bEditionLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditionLabel.Location = new System.Drawing.Point(10, 490);
            this.bEditionLabel.Name = "bEditionLabel";
            this.bEditionLabel.Size = new System.Drawing.Size(56, 13);
            this.bEditionLabel.TabIndex = 45;
            this.bEditionLabel.Text = "Edition:";
            // 
            // bAuthorLabel
            // 
            this.bAuthorLabel.AutoSize = true;
            this.bAuthorLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAuthorLabel.Location = new System.Drawing.Point(10, 461);
            this.bAuthorLabel.Name = "bAuthorLabel";
            this.bAuthorLabel.Size = new System.Drawing.Size(55, 13);
            this.bAuthorLabel.TabIndex = 44;
            this.bAuthorLabel.Text = "Author:";
            // 
            // bTitleLabel
            // 
            this.bTitleLabel.AutoSize = true;
            this.bTitleLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTitleLabel.Location = new System.Drawing.Point(10, 429);
            this.bTitleLabel.Name = "bTitleLabel";
            this.bTitleLabel.Size = new System.Drawing.Size(40, 13);
            this.bTitleLabel.TabIndex = 43;
            this.bTitleLabel.Text = "Title:";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(10, 306);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(70, 13);
            this.dueDateLabel.TabIndex = 41;
            this.dueDateLabel.Text = "Due Date:";
            // 
            // issueDateLabel
            // 
            this.issueDateLabel.AutoSize = true;
            this.issueDateLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueDateLabel.Location = new System.Drawing.Point(10, 277);
            this.issueDateLabel.Name = "issueDateLabel";
            this.issueDateLabel.Size = new System.Drawing.Size(81, 13);
            this.issueDateLabel.TabIndex = 40;
            this.issueDateLabel.Text = "Issue Date:";
            // 
            // txtbox_Edition
            // 
            this.txtbox_Edition.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Edition.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Edition.Location = new System.Drawing.Point(71, 480);
            this.txtbox_Edition.Name = "txtbox_Edition";
            this.txtbox_Edition.ReadOnly = true;
            this.txtbox_Edition.Size = new System.Drawing.Size(153, 23);
            this.txtbox_Edition.TabIndex = 37;
            // 
            // txtbox_Author
            // 
            this.txtbox_Author.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Author.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Author.Location = new System.Drawing.Point(71, 451);
            this.txtbox_Author.Name = "txtbox_Author";
            this.txtbox_Author.ReadOnly = true;
            this.txtbox_Author.Size = new System.Drawing.Size(153, 23);
            this.txtbox_Author.TabIndex = 36;
            // 
            // txtbox_Title
            // 
            this.txtbox_Title.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Title.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Title.Location = new System.Drawing.Point(71, 422);
            this.txtbox_Title.Name = "txtbox_Title";
            this.txtbox_Title.ReadOnly = true;
            this.txtbox_Title.Size = new System.Drawing.Size(153, 23);
            this.txtbox_Title.TabIndex = 35;
            // 
            // txtbox_TransactionID
            // 
            this.txtbox_TransactionID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_TransactionID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_TransactionID.Location = new System.Drawing.Point(13, 11);
            this.txtbox_TransactionID.Name = "txtbox_TransactionID";
            this.txtbox_TransactionID.ReadOnly = true;
            this.txtbox_TransactionID.Size = new System.Drawing.Size(211, 23);
            this.txtbox_TransactionID.TabIndex = 30;
            this.txtbox_TransactionID.Text = "Transaction ID";
            // 
            // txtbox_CopyID
            // 
            this.txtbox_CopyID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_CopyID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_CopyID.Location = new System.Drawing.Point(13, 40);
            this.txtbox_CopyID.Name = "txtbox_CopyID";
            this.txtbox_CopyID.Size = new System.Drawing.Size(211, 23);
            this.txtbox_CopyID.TabIndex = 31;
            // 
            // txtbox_BookID
            // 
            this.txtbox_BookID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_BookID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_BookID.Location = new System.Drawing.Point(13, 393);
            this.txtbox_BookID.Name = "txtbox_BookID";
            this.txtbox_BookID.Size = new System.Drawing.Size(211, 23);
            this.txtbox_BookID.TabIndex = 34;
            this.txtbox_BookID.Text = "Book ID";
            this.txtbox_BookID.TextChanged += new System.EventHandler(this.txtbox_BookID_TextChanged);
            // 
            // txtbox_dueDate
            // 
            this.txtbox_dueDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_dueDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_dueDate.Location = new System.Drawing.Point(98, 301);
            this.txtbox_dueDate.Name = "txtbox_dueDate";
            this.txtbox_dueDate.Size = new System.Drawing.Size(126, 23);
            this.txtbox_dueDate.TabIndex = 33;
            // 
            // txtbox_issueDate
            // 
            this.txtbox_issueDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_issueDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_issueDate.Location = new System.Drawing.Point(98, 272);
            this.txtbox_issueDate.Name = "txtbox_issueDate";
            this.txtbox_issueDate.Size = new System.Drawing.Size(126, 23);
            this.txtbox_issueDate.TabIndex = 32;
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
            this.txtbox_MemberID.TextChanged += new System.EventHandler(this.txtbox_MemberID_TextChanged);
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
            this.txtbox_LibrarianID.TextChanged += new System.EventHandler(this.txtbox_LibrarianID_TextChanged);
            // 
            // issuedPanel
            // 
            this.issuedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.issuedPanel.Controls.Add(this.book_copiesTBLDATA);
            this.issuedPanel.Controls.Add(this.booksTBLDATA);
            this.issuedPanel.Controls.Add(this.borrowTBLDATA);
            this.issuedPanel.Controls.Add(this.transactionLabel);
            this.issuedPanel.Location = new System.Drawing.Point(250, 11);
            this.issuedPanel.Name = "issuedPanel";
            this.issuedPanel.Size = new System.Drawing.Size(576, 556);
            this.issuedPanel.TabIndex = 0;
            // 
            // booksTBLDATA
            // 
            this.booksTBLDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksTBLDATA.Location = new System.Drawing.Point(14, 328);
            this.booksTBLDATA.Name = "booksTBLDATA";
            this.booksTBLDATA.Size = new System.Drawing.Size(266, 205);
            this.booksTBLDATA.TabIndex = 3;
            // 
            // borrowTBLDATA
            // 
            this.borrowTBLDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowTBLDATA.Location = new System.Drawing.Point(14, 91);
            this.borrowTBLDATA.Name = "borrowTBLDATA";
            this.borrowTBLDATA.Size = new System.Drawing.Size(543, 205);
            this.borrowTBLDATA.TabIndex = 2;
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionLabel.Location = new System.Drawing.Point(111, 24);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(594, 55);
            this.transactionLabel.TabIndex = 1;
            this.transactionLabel.Text = "TRANSACTION HISTORY";
            // 
            // book_copiesTBLDATA
            // 
            this.book_copiesTBLDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_copiesTBLDATA.Location = new System.Drawing.Point(291, 328);
            this.book_copiesTBLDATA.Name = "book_copiesTBLDATA";
            this.book_copiesTBLDATA.Size = new System.Drawing.Size(266, 205);
            this.book_copiesTBLDATA.TabIndex = 4;
            // 
            // transactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 609);
            this.Controls.Add(this.transactionsPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "transactionsForm";
            this.Text = "transactionsForm";
            this.Load += new System.EventHandler(this.transactionsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.transactionsPanel.ResumeLayout(false);
            this.issuedSidePanel.ResumeLayout(false);
            this.issuedSidePanel.PerformLayout();
            this.issuedPanel.ResumeLayout(false);
            this.issuedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksTBLDATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowTBLDATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_copiesTBLDATA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel transactionsPanel;
        private System.Windows.Forms.Panel issuedPanel;
        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.Panel issuedSidePanel;
        private System.Windows.Forms.TextBox txtbox_LibrarianName;
        private System.Windows.Forms.TextBox txtbox_LibrarianID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.TextBox txtbox_MemberID;
        private System.Windows.Forms.TextBox txtbox_TransactionID;
        private System.Windows.Forms.TextBox txtbox_dueDate;
        private System.Windows.Forms.TextBox txtbox_issueDate;
        private System.Windows.Forms.TextBox txtbox_CopyID;
        private System.Windows.Forms.TextBox txtbox_Edition;
        private System.Windows.Forms.TextBox txtbox_Author;
        private System.Windows.Forms.TextBox txtbox_Title;
        private System.Windows.Forms.TextBox txtbox_BookID;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label issueDateLabel;
        private System.Windows.Forms.Label bEditionLabel;
        private System.Windows.Forms.Label bAuthorLabel;
        private System.Windows.Forms.Label bTitleLabel;
        private System.Windows.Forms.Label bookInfoLabel;
        private System.Windows.Forms.Button btn_Borrow;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridView borrowTBLDATA;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.DataGridView booksTBLDATA;
        private System.Windows.Forms.DataGridView book_copiesTBLDATA;
    }
}