namespace LIBRARY
{
    partial class btn2Form_Reports
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn2_Panel = new System.Windows.Forms.Panel();
            this.unreturnedPanel = new System.Windows.Forms.Panel();
            this.unreturnedBooksDataGrid = new System.Windows.Forms.DataGridView();
            this.unreturnedLabel = new System.Windows.Forms.Label();
            this.overduePanel = new System.Windows.Forms.Panel();
            this.overdueBooksDataGrid = new System.Windows.Forms.DataGridView();
            this.overdueLabel = new System.Windows.Forms.Label();
            this.btn2Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.btn2_Panel.SuspendLayout();
            this.unreturnedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unreturnedBooksDataGrid)).BeginInit();
            this.overduePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overdueBooksDataGrid)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(830, 34);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // panel3
            // 
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
            this.btn_Close.Location = new System.Drawing.Point(-24, -24);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(112, 79);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn2_Panel
            // 
            this.btn2_Panel.Controls.Add(this.unreturnedPanel);
            this.btn2_Panel.Controls.Add(this.overduePanel);
            this.btn2_Panel.Controls.Add(this.btn2Label);
            this.btn2_Panel.Location = new System.Drawing.Point(-2, 26);
            this.btn2_Panel.Name = "btn2_Panel";
            this.btn2_Panel.Size = new System.Drawing.Size(854, 505);
            this.btn2_Panel.TabIndex = 5;
            // 
            // unreturnedPanel
            // 
            this.unreturnedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.unreturnedPanel.Controls.Add(this.unreturnedBooksDataGrid);
            this.unreturnedPanel.Controls.Add(this.unreturnedLabel);
            this.unreturnedPanel.Location = new System.Drawing.Point(30, 105);
            this.unreturnedPanel.Name = "unreturnedPanel";
            this.unreturnedPanel.Size = new System.Drawing.Size(366, 377);
            this.unreturnedPanel.TabIndex = 7;
            // 
            // unreturnedBooksDataGrid
            // 
            this.unreturnedBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unreturnedBooksDataGrid.Location = new System.Drawing.Point(20, 68);
            this.unreturnedBooksDataGrid.Name = "unreturnedBooksDataGrid";
            this.unreturnedBooksDataGrid.Size = new System.Drawing.Size(325, 292);
            this.unreturnedBooksDataGrid.TabIndex = 3;
            // 
            // unreturnedLabel
            // 
            this.unreturnedLabel.AutoSize = true;
            this.unreturnedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unreturnedLabel.Location = new System.Drawing.Point(56, 11);
            this.unreturnedLabel.Name = "unreturnedLabel";
            this.unreturnedLabel.Size = new System.Drawing.Size(423, 42);
            this.unreturnedLabel.TabIndex = 2;
            this.unreturnedLabel.Text = "UNRETURNED BOOKS";
            // 
            // overduePanel
            // 
            this.overduePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.overduePanel.Controls.Add(this.overdueBooksDataGrid);
            this.overduePanel.Controls.Add(this.overdueLabel);
            this.overduePanel.Location = new System.Drawing.Point(432, 105);
            this.overduePanel.Name = "overduePanel";
            this.overduePanel.Size = new System.Drawing.Size(366, 377);
            this.overduePanel.TabIndex = 6;
            // 
            // overdueBooksDataGrid
            // 
            this.overdueBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overdueBooksDataGrid.Location = new System.Drawing.Point(29, 68);
            this.overdueBooksDataGrid.Name = "overdueBooksDataGrid";
            this.overdueBooksDataGrid.Size = new System.Drawing.Size(325, 292);
            this.overdueBooksDataGrid.TabIndex = 4;
            // 
            // overdueLabel
            // 
            this.overdueLabel.AutoSize = true;
            this.overdueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdueLabel.Location = new System.Drawing.Point(88, 11);
            this.overdueLabel.Name = "overdueLabel";
            this.overdueLabel.Size = new System.Drawing.Size(346, 42);
            this.overdueLabel.TabIndex = 3;
            this.overdueLabel.Text = "OVERDUE BOOKS";
            // 
            // btn2Label
            // 
            this.btn2Label.AutoSize = true;
            this.btn2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Label.Location = new System.Drawing.Point(157, 24);
            this.btn2Label.Name = "btn2Label";
            this.btn2Label.Size = new System.Drawing.Size(857, 42);
            this.btn2Label.TabIndex = 5;
            this.btn2Label.Text = "LIST OF UNRETURNED AND OVERDUE BOOKS";
            // 
            // btn2Form_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(188)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(830, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn2_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "btn2Form_Reports";
            this.Text = "btn2Form_Reports";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.btn2_Panel.ResumeLayout(false);
            this.btn2_Panel.PerformLayout();
            this.unreturnedPanel.ResumeLayout(false);
            this.unreturnedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unreturnedBooksDataGrid)).EndInit();
            this.overduePanel.ResumeLayout(false);
            this.overduePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overdueBooksDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel btn2_Panel;
        private System.Windows.Forms.Label btn2Label;
        private System.Windows.Forms.Panel unreturnedPanel;
        private System.Windows.Forms.DataGridView unreturnedBooksDataGrid;
        private System.Windows.Forms.Label unreturnedLabel;
        private System.Windows.Forms.Panel overduePanel;
        private System.Windows.Forms.DataGridView overdueBooksDataGrid;
        private System.Windows.Forms.Label overdueLabel;
    }
}