namespace LIBRARY
{
    partial class booksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booksForm));
            this.booksPanel = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.bookidLABEL = new System.Windows.Forms.Label();
            this.statusLABEL = new System.Windows.Forms.Label();
            this.genreLABEL = new System.Windows.Forms.Label();
            this.publisherLABEL = new System.Windows.Forms.Label();
            this.isbnLABEL = new System.Windows.Forms.Label();
            this.txtboxISBN = new System.Windows.Forms.TextBox();
            this.txtboxPublisher = new System.Windows.Forms.TextBox();
            this.availabilityStatus_COMBO = new System.Windows.Forms.ComboBox();
            this.combo_GENRE = new System.Windows.Forms.ComboBox();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxEdition = new System.Windows.Forms.TextBox();
            this.editionLabel = new System.Windows.Forms.Label();
            this.txtboxAuthor = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.txtbox_bookTitle = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.txtboxBookID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.booksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // booksPanel
            // 
            this.booksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(188)))), ((int)(((byte)(165)))));
            this.booksPanel.Controls.Add(this.btn_Update);
            this.booksPanel.Controls.Add(this.btn_Save);
            this.booksPanel.Controls.Add(this.bookidLABEL);
            this.booksPanel.Controls.Add(this.statusLABEL);
            this.booksPanel.Controls.Add(this.genreLABEL);
            this.booksPanel.Controls.Add(this.publisherLABEL);
            this.booksPanel.Controls.Add(this.isbnLABEL);
            this.booksPanel.Controls.Add(this.txtboxISBN);
            this.booksPanel.Controls.Add(this.txtboxPublisher);
            this.booksPanel.Controls.Add(this.availabilityStatus_COMBO);
            this.booksPanel.Controls.Add(this.combo_GENRE);
            this.booksPanel.Controls.Add(this.dataGridViewBooks);
            this.booksPanel.Controls.Add(this.btn_Cancel);
            this.booksPanel.Controls.Add(this.btn_Search);
            this.booksPanel.Controls.Add(this.label5);
            this.booksPanel.Controls.Add(this.txtboxEdition);
            this.booksPanel.Controls.Add(this.editionLabel);
            this.booksPanel.Controls.Add(this.txtboxAuthor);
            this.booksPanel.Controls.Add(this.authorLabel);
            this.booksPanel.Controls.Add(this.txtbox_bookTitle);
            this.booksPanel.Controls.Add(this.titleLabel);
            this.booksPanel.Controls.Add(this.txtboxBookID);
            this.booksPanel.Controls.Add(this.pictureBox1);
            this.booksPanel.Location = new System.Drawing.Point(-1, -4);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Size = new System.Drawing.Size(775, 525);
            this.booksPanel.TabIndex = 0;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Update.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(305, 430);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(132, 34);
            this.btn_Update.TabIndex = 38;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Save.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(160, 430);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(132, 34);
            this.btn_Save.TabIndex = 37;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // bookidLABEL
            // 
            this.bookidLABEL.AutoSize = true;
            this.bookidLABEL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookidLABEL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookidLABEL.Location = new System.Drawing.Point(13, 235);
            this.bookidLABEL.Name = "bookidLABEL";
            this.bookidLABEL.Size = new System.Drawing.Size(68, 16);
            this.bookidLABEL.TabIndex = 36;
            this.bookidLABEL.Text = "Book ID:";
            // 
            // statusLABEL
            // 
            this.statusLABEL.AutoSize = true;
            this.statusLABEL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLABEL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusLABEL.Location = new System.Drawing.Point(302, 236);
            this.statusLABEL.Name = "statusLABEL";
            this.statusLABEL.Size = new System.Drawing.Size(59, 16);
            this.statusLABEL.TabIndex = 35;
            this.statusLABEL.Text = "Status:";
            // 
            // genreLABEL
            // 
            this.genreLABEL.AutoSize = true;
            this.genreLABEL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLABEL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.genreLABEL.Location = new System.Drawing.Point(14, 392);
            this.genreLABEL.Name = "genreLABEL";
            this.genreLABEL.Size = new System.Drawing.Size(55, 16);
            this.genreLABEL.TabIndex = 34;
            this.genreLABEL.Text = "Genre:";
            // 
            // publisherLABEL
            // 
            this.publisherLABEL.AutoSize = true;
            this.publisherLABEL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLABEL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.publisherLABEL.Location = new System.Drawing.Point(12, 340);
            this.publisherLABEL.Name = "publisherLABEL";
            this.publisherLABEL.Size = new System.Drawing.Size(79, 16);
            this.publisherLABEL.TabIndex = 33;
            this.publisherLABEL.Text = "Publisher:";
            // 
            // isbnLABEL
            // 
            this.isbnLABEL.AutoSize = true;
            this.isbnLABEL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLABEL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.isbnLABEL.Location = new System.Drawing.Point(12, 315);
            this.isbnLABEL.Name = "isbnLABEL";
            this.isbnLABEL.Size = new System.Drawing.Size(47, 16);
            this.isbnLABEL.TabIndex = 32;
            this.isbnLABEL.Text = "ISBN:";
            // 
            // txtboxISBN
            // 
            this.txtboxISBN.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxISBN.Location = new System.Drawing.Point(99, 314);
            this.txtboxISBN.Name = "txtboxISBN";
            this.txtboxISBN.Size = new System.Drawing.Size(193, 21);
            this.txtboxISBN.TabIndex = 31;
            // 
            // txtboxPublisher
            // 
            this.txtboxPublisher.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPublisher.Location = new System.Drawing.Point(99, 339);
            this.txtboxPublisher.Name = "txtboxPublisher";
            this.txtboxPublisher.Size = new System.Drawing.Size(193, 21);
            this.txtboxPublisher.TabIndex = 30;
            // 
            // availabilityStatus_COMBO
            // 
            this.availabilityStatus_COMBO.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availabilityStatus_COMBO.FormattingEnabled = true;
            this.availabilityStatus_COMBO.Location = new System.Drawing.Point(367, 235);
            this.availabilityStatus_COMBO.Name = "availabilityStatus_COMBO";
            this.availabilityStatus_COMBO.Size = new System.Drawing.Size(219, 21);
            this.availabilityStatus_COMBO.TabIndex = 29;
            // 
            // combo_GENRE
            // 
            this.combo_GENRE.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_GENRE.FormattingEnabled = true;
            this.combo_GENRE.Location = new System.Drawing.Point(99, 391);
            this.combo_GENRE.Name = "combo_GENRE";
            this.combo_GENRE.Size = new System.Drawing.Size(193, 21);
            this.combo_GENRE.TabIndex = 28;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(298, 262);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(289, 152);
            this.dataGridViewBooks.TabIndex = 27;
            this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellContentClick);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(455, 430);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(132, 34);
            this.btn_Cancel.TabIndex = 23;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(17, 430);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(132, 34);
            this.btn_Search.TabIndex = 21;
            this.btn_Search.Text = "SEARCH";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(75, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(474, 55);
            this.label5.TabIndex = 18;
            this.label5.Text = "BOOK CATALOG MANAGEMENT ";
            // 
            // txtboxEdition
            // 
            this.txtboxEdition.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEdition.Location = new System.Drawing.Point(99, 365);
            this.txtboxEdition.Name = "txtboxEdition";
            this.txtboxEdition.Size = new System.Drawing.Size(193, 21);
            this.txtboxEdition.TabIndex = 17;
            // 
            // editionLabel
            // 
            this.editionLabel.AutoSize = true;
            this.editionLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editionLabel.Location = new System.Drawing.Point(12, 366);
            this.editionLabel.Name = "editionLabel";
            this.editionLabel.Size = new System.Drawing.Size(62, 16);
            this.editionLabel.TabIndex = 16;
            this.editionLabel.Text = "Edition:";
            // 
            // txtboxAuthor
            // 
            this.txtboxAuthor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAuthor.Location = new System.Drawing.Point(99, 287);
            this.txtboxAuthor.Name = "txtboxAuthor";
            this.txtboxAuthor.Size = new System.Drawing.Size(193, 21);
            this.txtboxAuthor.TabIndex = 15;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.authorLabel.Location = new System.Drawing.Point(13, 287);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(61, 16);
            this.authorLabel.TabIndex = 14;
            this.authorLabel.Text = "Author:";
            // 
            // txtbox_bookTitle
            // 
            this.txtbox_bookTitle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_bookTitle.Location = new System.Drawing.Point(99, 261);
            this.txtbox_bookTitle.Name = "txtbox_bookTitle";
            this.txtbox_bookTitle.Size = new System.Drawing.Size(193, 21);
            this.txtbox_bookTitle.TabIndex = 13;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleLabel.Location = new System.Drawing.Point(13, 261);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(43, 16);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Title:";
            // 
            // txtboxBookID
            // 
            this.txtboxBookID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBookID.Location = new System.Drawing.Point(99, 235);
            this.txtboxBookID.Name = "txtboxBookID";
            this.txtboxBookID.Size = new System.Drawing.Size(193, 21);
            this.txtboxBookID.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // booksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(774, 514);
            this.Controls.Add(this.booksPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "booksForm";
            this.Text = "booksForm";
            this.booksPanel.ResumeLayout(false);
            this.booksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel booksPanel;
        private System.Windows.Forms.TextBox txtboxEdition;
        private System.Windows.Forms.Label editionLabel;
        private System.Windows.Forms.TextBox txtboxAuthor;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox txtbox_bookTitle;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox txtboxBookID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.ComboBox availabilityStatus_COMBO;
        private System.Windows.Forms.ComboBox combo_GENRE;
        private System.Windows.Forms.Label publisherLABEL;
        private System.Windows.Forms.Label isbnLABEL;
        private System.Windows.Forms.TextBox txtboxISBN;
        private System.Windows.Forms.TextBox txtboxPublisher;
        private System.Windows.Forms.Label statusLABEL;
        private System.Windows.Forms.Label genreLABEL;
        private System.Windows.Forms.Label bookidLABEL;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Save;
    }
}