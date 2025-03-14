namespace LIBRARY
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.btn_Member = new System.Windows.Forms.Button();
            this.btn_Librarian = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.btn_Member);
            this.loginPanel.Controls.Add(this.btn_Librarian);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.pictureBox1);
            this.loginPanel.Location = new System.Drawing.Point(0, -2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(711, 520);
            this.loginPanel.TabIndex = 0;
            // 
            // btn_Member
            // 
            this.btn_Member.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_Member.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Member.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Member.Location = new System.Drawing.Point(327, 389);
            this.btn_Member.Name = "btn_Member";
            this.btn_Member.Size = new System.Drawing.Size(217, 38);
            this.btn_Member.TabIndex = 4;
            this.btn_Member.Text = "AS A MEMBER";
            this.btn_Member.UseVisualStyleBackColor = false;
            this.btn_Member.Click += new System.EventHandler(this.btn_Member_Click);
            // 
            // btn_Librarian
            // 
            this.btn_Librarian.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_Librarian.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Librarian.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Librarian.Location = new System.Drawing.Point(70, 389);
            this.btn_Librarian.Name = "btn_Librarian";
            this.btn_Librarian.Size = new System.Drawing.Size(217, 38);
            this.btn_Librarian.TabIndex = 3;
            this.btn_Librarian.Text = "AS A LIBRARIAN";
            this.btn_Librarian.UseVisualStyleBackColor = false;
            this.btn_Librarian.Click += new System.EventHandler(this.btn_Librarian_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(176, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 108);
            this.label2.TabIndex = 2;
            this.label2.Text = "LOG IN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(197, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-291, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(960, 621);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 510);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Member;
        private System.Windows.Forms.Button btn_Librarian;
    }
}