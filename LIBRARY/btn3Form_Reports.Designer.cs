﻿namespace LIBRARY
{
    partial class btn3Form_Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btn3Form_Reports));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn3Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tenBorrowedDB = new System.Windows.Forms.DataGridView();
            this.btn3_Panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenBorrowedDB)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(817, 34);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn3_Panel);
            this.panel3.Controls.Add(this.btn_Back);
            this.panel3.Location = new System.Drawing.Point(-2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(76, 46);
            this.panel3.TabIndex = 1;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Back.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(-17, -32);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(106, 97);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "<";
            this.btn_Back.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Location = new System.Drawing.Point(764, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 35);
            this.panel2.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.btn_Close.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(-24, -23);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(112, 79);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn3Label
            // 
            this.btn3Label.AutoSize = true;
            this.btn3Label.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn3Label.Location = new System.Drawing.Point(262, 229);
            this.btn3Label.Name = "btn3Label";
            this.btn3Label.Size = new System.Drawing.Size(315, 43);
            this.btn3Label.TabIndex = 28;
            this.btn3Label.Text = "TOP 10 BORROWED BOOKS";
            this.btn3Label.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-19, -346);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(836, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // tenBorrowedDB
            // 
            this.tenBorrowedDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tenBorrowedDB.Location = new System.Drawing.Point(28, 287);
            this.tenBorrowedDB.Name = "tenBorrowedDB";
            this.tenBorrowedDB.Size = new System.Drawing.Size(755, 214);
            this.tenBorrowedDB.TabIndex = 30;
            // 
            // btn3_Panel
            // 
            this.btn3_Panel.Location = new System.Drawing.Point(2, 25);
            this.btn3_Panel.Name = "btn3_Panel";
            this.btn3_Panel.Size = new System.Drawing.Size(852, 499);
            this.btn3_Panel.TabIndex = 31;
            // 
            // btn3Form_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(188)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(817, 513);
            this.Controls.Add(this.tenBorrowedDB);
            this.Controls.Add(this.btn3Label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "btn3Form_Reports";
            this.Text = "btn3Form_Reports";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenBorrowedDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label btn3Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tenBorrowedDB;
        private System.Windows.Forms.Panel btn3_Panel;
    }
}