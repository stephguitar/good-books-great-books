namespace LIBRARY
{
    partial class member_loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(member_loginForm));
            this.membersPanel = new System.Windows.Forms.Panel();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.memberLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtbox_memberPassword = new System.Windows.Forms.TextBox();
            this.txtbox_MemberID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.membersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // membersPanel
            // 
            this.membersPanel.Controls.Add(this.btn_Submit);
            this.membersPanel.Controls.Add(this.passwordLabel);
            this.membersPanel.Controls.Add(this.memberLabel);
            this.membersPanel.Controls.Add(this.pictureBox2);
            this.membersPanel.Controls.Add(this.txtbox_memberPassword);
            this.membersPanel.Controls.Add(this.txtbox_MemberID);
            this.membersPanel.Controls.Add(this.pictureBox1);
            this.membersPanel.Location = new System.Drawing.Point(-1, -8);
            this.membersPanel.Name = "membersPanel";
            this.membersPanel.Size = new System.Drawing.Size(824, 546);
            this.membersPanel.TabIndex = 0;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Submit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(138, 427);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(317, 35);
            this.btn_Submit.TabIndex = 9;
            this.btn_Submit.Text = "SUBMIT";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(138, 362);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(93, 16);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "PASSWORD:";
            // 
            // memberLabel
            // 
            this.memberLabel.AutoSize = true;
            this.memberLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberLabel.Location = new System.Drawing.Point(137, 296);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(93, 16);
            this.memberLabel.TabIndex = 7;
            this.memberLabel.Text = "MEMBER ID:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(138, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // txtbox_memberPassword
            // 
            this.txtbox_memberPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtbox_memberPassword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_memberPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_memberPassword.Location = new System.Drawing.Point(138, 381);
            this.txtbox_memberPassword.Name = "txtbox_memberPassword";
            this.txtbox_memberPassword.Size = new System.Drawing.Size(317, 21);
            this.txtbox_memberPassword.TabIndex = 2;
            this.txtbox_memberPassword.Text = "PASSWORD: *";
            this.txtbox_memberPassword.UseSystemPasswordChar = true;
            // 
            // txtbox_MemberID
            // 
            this.txtbox_MemberID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_MemberID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_MemberID.Location = new System.Drawing.Point(138, 315);
            this.txtbox_MemberID.Name = "txtbox_MemberID";
            this.txtbox_MemberID.Size = new System.Drawing.Size(317, 21);
            this.txtbox_MemberID.TabIndex = 1;
            this.txtbox_MemberID.Text = "MEMBER ID: *";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 800);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // member_loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(188)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(776, 531);
            this.Controls.Add(this.membersPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "member_loginForm";
            this.Text = "memberForm";
            this.membersPanel.ResumeLayout(false);
            this.membersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel membersPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbox_MemberID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtbox_memberPassword;
        private System.Windows.Forms.Label memberLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button btn_Submit;
    }
}