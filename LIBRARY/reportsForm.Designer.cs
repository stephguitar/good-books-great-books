namespace LIBRARY
{
    partial class reportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportsForm));
            this.statusPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStatus_Panel = new System.Windows.Forms.Panel();
            this.btn_Status = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.un_onPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnunonPanel = new System.Windows.Forms.Panel();
            this.btn_unon = new System.Windows.Forms.Button();
            this.borrowedPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Borrowed = new System.Windows.Forms.Button();
            this.borrowersPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Borrowers = new System.Windows.Forms.Button();
            this.withFinesPanel = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_withFines = new System.Windows.Forms.Button();
            this.borrowedReturnedPanel = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_BorrowedReturned = new System.Windows.Forms.Button();
            this.reportsPanel = new System.Windows.Forms.Panel();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.btnStatus_Panel.SuspendLayout();
            this.un_onPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.btnunonPanel.SuspendLayout();
            this.borrowedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.borrowersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel6.SuspendLayout();
            this.withFinesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel7.SuspendLayout();
            this.borrowedReturnedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel8.SuspendLayout();
            this.reportsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.statusPanel.Controls.Add(this.btnStatus_Panel);
            this.statusPanel.Controls.Add(this.pictureBox1);
            this.statusPanel.Location = new System.Drawing.Point(24, 101);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(180, 158);
            this.statusPanel.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStatus_Panel
            // 
            this.btnStatus_Panel.Controls.Add(this.btn_Status);
            this.btnStatus_Panel.Location = new System.Drawing.Point(5, 106);
            this.btnStatus_Panel.Name = "btnStatus_Panel";
            this.btnStatus_Panel.Size = new System.Drawing.Size(172, 41);
            this.btnStatus_Panel.TabIndex = 23;
            // 
            // btn_Status
            // 
            this.btn_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.btn_Status.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Status.Location = new System.Drawing.Point(-9, -59);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(188, 159);
            this.btn_Status.TabIndex = 22;
            this.btn_Status.Text = "Available and Unavailable Books";
            this.btn_Status.UseVisualStyleBackColor = false;
            this.btn_Status.Click += new System.EventHandler(this.btn_Status_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(128, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 55);
            this.label5.TabIndex = 27;
            this.label5.Text = "REPORTS GENERATION";
            // 
            // un_onPanel
            // 
            this.un_onPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.un_onPanel.Controls.Add(this.btnunonPanel);
            this.un_onPanel.Controls.Add(this.pictureBox2);
            this.un_onPanel.Location = new System.Drawing.Point(214, 101);
            this.un_onPanel.Name = "un_onPanel";
            this.un_onPanel.Size = new System.Drawing.Size(180, 158);
            this.un_onPanel.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnunonPanel
            // 
            this.btnunonPanel.Controls.Add(this.btn_unon);
            this.btnunonPanel.Location = new System.Drawing.Point(17, 106);
            this.btnunonPanel.Name = "btnunonPanel";
            this.btnunonPanel.Size = new System.Drawing.Size(152, 41);
            this.btnunonPanel.TabIndex = 23;
            // 
            // btn_unon
            // 
            this.btn_unon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.btn_unon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unon.Location = new System.Drawing.Point(-13, -59);
            this.btn_unon.Name = "btn_unon";
            this.btn_unon.Size = new System.Drawing.Size(173, 159);
            this.btn_unon.TabIndex = 22;
            this.btn_unon.Text = "Unreturned or Overdue Books";
            this.btn_unon.UseVisualStyleBackColor = false;
            this.btn_unon.Click += new System.EventHandler(this.btn_unon_Click);
            // 
            // borrowedPanel
            // 
            this.borrowedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.borrowedPanel.Controls.Add(this.pictureBox3);
            this.borrowedPanel.Controls.Add(this.panel5);
            this.borrowedPanel.Location = new System.Drawing.Point(403, 101);
            this.borrowedPanel.Name = "borrowedPanel";
            this.borrowedPanel.Size = new System.Drawing.Size(180, 158);
            this.borrowedPanel.TabIndex = 32;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(159, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_Borrowed);
            this.panel5.Location = new System.Drawing.Point(10, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(159, 41);
            this.panel5.TabIndex = 23;
            // 
            // btn_Borrowed
            // 
            this.btn_Borrowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.btn_Borrowed.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Borrowed.Location = new System.Drawing.Point(-29, -59);
            this.btn_Borrowed.Name = "btn_Borrowed";
            this.btn_Borrowed.Size = new System.Drawing.Size(214, 159);
            this.btn_Borrowed.TabIndex = 26;
            this.btn_Borrowed.Text = "TOP 10 BORROWED";
            this.btn_Borrowed.UseVisualStyleBackColor = false;
            this.btn_Borrowed.Click += new System.EventHandler(this.btn_Borrowed_Click);
            // 
            // borrowersPanel
            // 
            this.borrowersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.borrowersPanel.Controls.Add(this.panel6);
            this.borrowersPanel.Controls.Add(this.pictureBox4);
            this.borrowersPanel.Location = new System.Drawing.Point(24, 278);
            this.borrowersPanel.Name = "borrowersPanel";
            this.borrowersPanel.Size = new System.Drawing.Size(180, 158);
            this.borrowersPanel.TabIndex = 33;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(9, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(163, 94);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_Borrowers);
            this.panel6.Location = new System.Drawing.Point(10, 110);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(162, 41);
            this.panel6.TabIndex = 23;
            // 
            // btn_Borrowers
            // 
            this.btn_Borrowers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.btn_Borrowers.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Borrowers.Location = new System.Drawing.Point(-31, -61);
            this.btn_Borrowers.Name = "btn_Borrowers";
            this.btn_Borrowers.Size = new System.Drawing.Size(214, 159);
            this.btn_Borrowers.TabIndex = 26;
            this.btn_Borrowers.Text = "TOP 10 BORROWERS";
            this.btn_Borrowers.UseVisualStyleBackColor = false;
            this.btn_Borrowers.Click += new System.EventHandler(this.btn_Borrowers_Click);
            // 
            // withFinesPanel
            // 
            this.withFinesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.withFinesPanel.Controls.Add(this.panel7);
            this.withFinesPanel.Controls.Add(this.pictureBox5);
            this.withFinesPanel.Location = new System.Drawing.Point(214, 278);
            this.withFinesPanel.Name = "withFinesPanel";
            this.withFinesPanel.Size = new System.Drawing.Size(180, 158);
            this.withFinesPanel.TabIndex = 31;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(10, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(159, 94);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_withFines);
            this.panel7.Location = new System.Drawing.Point(10, 110);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(159, 41);
            this.panel7.TabIndex = 23;
            // 
            // btn_withFines
            // 
            this.btn_withFines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.btn_withFines.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_withFines.Location = new System.Drawing.Point(-33, -61);
            this.btn_withFines.Name = "btn_withFines";
            this.btn_withFines.Size = new System.Drawing.Size(227, 159);
            this.btn_withFines.TabIndex = 22;
            this.btn_withFines.Text = "Borrowers with Fines";
            this.btn_withFines.UseVisualStyleBackColor = false;
            this.btn_withFines.Click += new System.EventHandler(this.btn_withFines_Click);
            // 
            // borrowedReturnedPanel
            // 
            this.borrowedReturnedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.borrowedReturnedPanel.Controls.Add(this.panel8);
            this.borrowedReturnedPanel.Controls.Add(this.pictureBox6);
            this.borrowedReturnedPanel.Location = new System.Drawing.Point(403, 278);
            this.borrowedReturnedPanel.Name = "borrowedReturnedPanel";
            this.borrowedReturnedPanel.Size = new System.Drawing.Size(180, 158);
            this.borrowedReturnedPanel.TabIndex = 29;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(10, 10);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(159, 94);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_BorrowedReturned);
            this.panel8.Location = new System.Drawing.Point(10, 110);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(166, 41);
            this.panel8.TabIndex = 23;
            // 
            // btn_BorrowedReturned
            // 
            this.btn_BorrowedReturned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.btn_BorrowedReturned.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BorrowedReturned.Location = new System.Drawing.Point(-11, -60);
            this.btn_BorrowedReturned.Name = "btn_BorrowedReturned";
            this.btn_BorrowedReturned.Size = new System.Drawing.Size(181, 159);
            this.btn_BorrowedReturned.TabIndex = 22;
            this.btn_BorrowedReturned.Text = "Borrowed and Returned Books";
            this.btn_BorrowedReturned.UseVisualStyleBackColor = false;
            this.btn_BorrowedReturned.Click += new System.EventHandler(this.btn_BorrowedReturned_Click);
            // 
            // reportsPanel
            // 
            this.reportsPanel.Controls.Add(this.borrowedReturnedPanel);
            this.reportsPanel.Controls.Add(this.un_onPanel);
            this.reportsPanel.Controls.Add(this.borrowedPanel);
            this.reportsPanel.Controls.Add(this.withFinesPanel);
            this.reportsPanel.Controls.Add(this.label5);
            this.reportsPanel.Controls.Add(this.borrowersPanel);
            this.reportsPanel.Controls.Add(this.statusPanel);
            this.reportsPanel.Location = new System.Drawing.Point(-2, 4);
            this.reportsPanel.Name = "reportsPanel";
            this.reportsPanel.Size = new System.Drawing.Size(830, 601);
            this.reportsPanel.TabIndex = 3;
            // 
            // reportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(188)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(829, 592);
            this.Controls.Add(this.reportsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reportsForm";
            this.Text = "reportsForm";
            this.statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.btnStatus_Panel.ResumeLayout(false);
            this.un_onPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.btnunonPanel.ResumeLayout(false);
            this.borrowedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.borrowersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.withFinesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel7.ResumeLayout(false);
            this.borrowedReturnedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel8.ResumeLayout(false);
            this.reportsPanel.ResumeLayout(false);
            this.reportsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Panel btnStatus_Panel;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel un_onPanel;
        private System.Windows.Forms.Panel btnunonPanel;
        private System.Windows.Forms.Button btn_unon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel borrowedPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Borrowed;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel borrowersPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Borrowers;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel withFinesPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_withFines;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel borrowedReturnedPanel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_BorrowedReturned;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel reportsPanel;
    }
}