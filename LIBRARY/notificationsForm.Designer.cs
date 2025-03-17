namespace LIBRARY
{
    partial class notificationsForm
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
            this.notificationsPanel = new System.Windows.Forms.Panel();
            this.btnError = new System.Windows.Forms.Button();
            this.btnWarning = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSuccess = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_PendingFines = new System.Windows.Forms.Label();
            this.finesDataGrid = new System.Windows.Forms.DataGridView();
            this.borrowedBooksDataGrid = new System.Windows.Forms.DataGridView();
            this.lbl_BorrowedBooks = new System.Windows.Forms.Label();
            this.reservedBooksDataGrid = new System.Windows.Forms.DataGridView();
            this.lbl_ReservedBooks = new System.Windows.Forms.Label();
            this.overdueBooksDataGrid = new System.Windows.Forms.DataGridView();
            this.lbl_OverdueBooks = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.notificationsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBooksDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservedBooksDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overdueBooksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // notificationsPanel
            // 
            this.notificationsPanel.Controls.Add(this.btn_Refresh);
            this.notificationsPanel.Controls.Add(this.overdueBooksDataGrid);
            this.notificationsPanel.Controls.Add(this.lbl_OverdueBooks);
            this.notificationsPanel.Controls.Add(this.reservedBooksDataGrid);
            this.notificationsPanel.Controls.Add(this.lbl_ReservedBooks);
            this.notificationsPanel.Controls.Add(this.borrowedBooksDataGrid);
            this.notificationsPanel.Controls.Add(this.lbl_BorrowedBooks);
            this.notificationsPanel.Controls.Add(this.finesDataGrid);
            this.notificationsPanel.Controls.Add(this.lbl_PendingFines);
            this.notificationsPanel.Controls.Add(this.btnError);
            this.notificationsPanel.Controls.Add(this.btnWarning);
            this.notificationsPanel.Controls.Add(this.btnInfo);
            this.notificationsPanel.Controls.Add(this.btnSuccess);
            this.notificationsPanel.Controls.Add(this.panel1);
            this.notificationsPanel.Location = new System.Drawing.Point(-3, -4);
            this.notificationsPanel.Name = "notificationsPanel";
            this.notificationsPanel.Size = new System.Drawing.Size(780, 518);
            this.notificationsPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 41);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(15, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "NOTIFICATIONS";
            // 
            // lbl_PendingFines
            // 
            this.lbl_PendingFines.AutoSize = true;
            this.lbl_PendingFines.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PendingFines.Location = new System.Drawing.Point(15, 66);
            this.lbl_PendingFines.Name = "lbl_PendingFines";
            this.lbl_PendingFines.Size = new System.Drawing.Size(113, 16);
            this.lbl_PendingFines.TabIndex = 49;
            this.lbl_PendingFines.Text = "Pending Fines:";
            // 
            // finesDataGrid
            // 
            this.finesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finesDataGrid.Location = new System.Drawing.Point(15, 85);
            this.finesDataGrid.Name = "finesDataGrid";
            this.finesDataGrid.Size = new System.Drawing.Size(571, 76);
            this.finesDataGrid.TabIndex = 53;
            // 
            // borrowedBooksDataGrid
            // 
            this.borrowedBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowedBooksDataGrid.Location = new System.Drawing.Point(15, 192);
            this.borrowedBooksDataGrid.Name = "borrowedBooksDataGrid";
            this.borrowedBooksDataGrid.Size = new System.Drawing.Size(571, 76);
            this.borrowedBooksDataGrid.TabIndex = 55;
            // 
            // lbl_BorrowedBooks
            // 
            this.lbl_BorrowedBooks.AutoSize = true;
            this.lbl_BorrowedBooks.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BorrowedBooks.Location = new System.Drawing.Point(15, 173);
            this.lbl_BorrowedBooks.Name = "lbl_BorrowedBooks";
            this.lbl_BorrowedBooks.Size = new System.Drawing.Size(130, 16);
            this.lbl_BorrowedBooks.TabIndex = 54;
            this.lbl_BorrowedBooks.Text = "Borrowed Books:";
            // 
            // reservedBooksDataGrid
            // 
            this.reservedBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservedBooksDataGrid.Location = new System.Drawing.Point(15, 302);
            this.reservedBooksDataGrid.Name = "reservedBooksDataGrid";
            this.reservedBooksDataGrid.Size = new System.Drawing.Size(571, 76);
            this.reservedBooksDataGrid.TabIndex = 57;
            // 
            // lbl_ReservedBooks
            // 
            this.lbl_ReservedBooks.AutoSize = true;
            this.lbl_ReservedBooks.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReservedBooks.Location = new System.Drawing.Point(15, 283);
            this.lbl_ReservedBooks.Name = "lbl_ReservedBooks";
            this.lbl_ReservedBooks.Size = new System.Drawing.Size(128, 16);
            this.lbl_ReservedBooks.TabIndex = 56;
            this.lbl_ReservedBooks.Text = "Reserved Books:";
            // 
            // overdueBooksDataGrid
            // 
            this.overdueBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overdueBooksDataGrid.Location = new System.Drawing.Point(15, 408);
            this.overdueBooksDataGrid.Name = "overdueBooksDataGrid";
            this.overdueBooksDataGrid.Size = new System.Drawing.Size(571, 76);
            this.overdueBooksDataGrid.TabIndex = 59;
            // 
            // lbl_OverdueBooks
            // 
            this.lbl_OverdueBooks.AutoSize = true;
            this.lbl_OverdueBooks.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OverdueBooks.Location = new System.Drawing.Point(15, 389);
            this.lbl_OverdueBooks.Name = "lbl_OverdueBooks";
            this.lbl_OverdueBooks.Size = new System.Drawing.Size(122, 16);
            this.lbl_OverdueBooks.TabIndex = 58;
            this.lbl_OverdueBooks.Text = "Overdue Books:";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.Location = new System.Drawing.Point(479, 47);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(107, 27);
            this.btn_Refresh.TabIndex = 66;
            this.btn_Refresh.Text = "REFRESH";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // notificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(188)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(768, 503);
            this.Controls.Add(this.notificationsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "notificationsForm";
            this.Text = "notificationsForm";
            this.notificationsPanel.ResumeLayout(false);
            this.notificationsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBooksDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservedBooksDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overdueBooksDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel notificationsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnWarning;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSuccess;
        private System.Windows.Forms.DataGridView finesDataGrid;
        private System.Windows.Forms.Label lbl_PendingFines;
        private System.Windows.Forms.DataGridView overdueBooksDataGrid;
        private System.Windows.Forms.Label lbl_OverdueBooks;
        private System.Windows.Forms.DataGridView reservedBooksDataGrid;
        private System.Windows.Forms.Label lbl_ReservedBooks;
        private System.Windows.Forms.DataGridView borrowedBooksDataGrid;
        private System.Windows.Forms.Label lbl_BorrowedBooks;
        private System.Windows.Forms.Button btn_Refresh;
    }
}