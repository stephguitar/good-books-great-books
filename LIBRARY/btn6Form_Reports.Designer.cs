namespace LIBRARY
{
    partial class btn6Form_Reports
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
            this.brPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn6Label = new System.Windows.Forms.Label();
            this.borrowedPanel = new System.Windows.Forms.Panel();
            this.borrowedBooksDataGrid = new System.Windows.Forms.DataGridView();
            this.borrowedLabel = new System.Windows.Forms.Label();
            this.returnedPanel = new System.Windows.Forms.Panel();
            this.returnedBooksDataGrid = new System.Windows.Forms.DataGridView();
            this.returnedLabel = new System.Windows.Forms.Label();
            this.btn6_Panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.borrowedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBooksDataGrid)).BeginInit();
            this.returnedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnedBooksDataGrid)).BeginInit();
            this.btn6_Panel.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(815, 34);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Back);
            this.panel3.Controls.Add(this.brPanel);
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
            // brPanel
            // 
            this.brPanel.Location = new System.Drawing.Point(4, 28);
            this.brPanel.Name = "brPanel";
            this.brPanel.Size = new System.Drawing.Size(812, 504);
            this.brPanel.TabIndex = 8;
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
            // btn6Label
            // 
            this.btn6Label.AutoSize = true;
            this.btn6Label.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6Label.Location = new System.Drawing.Point(152, 21);
            this.btn6Label.Name = "btn6Label";
            this.btn6Label.Size = new System.Drawing.Size(498, 43);
            this.btn6Label.TabIndex = 6;
            this.btn6Label.Text = "LIST OF BORROWED AND RETURNED BOOKS";
            // 
            // borrowedPanel
            // 
            this.borrowedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.borrowedPanel.Controls.Add(this.borrowedBooksDataGrid);
            this.borrowedPanel.Controls.Add(this.borrowedLabel);
            this.borrowedPanel.Location = new System.Drawing.Point(19, 92);
            this.borrowedPanel.Name = "borrowedPanel";
            this.borrowedPanel.Size = new System.Drawing.Size(366, 377);
            this.borrowedPanel.TabIndex = 8;
            // 
            // borrowedBooksDataGrid
            // 
            this.borrowedBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowedBooksDataGrid.Location = new System.Drawing.Point(20, 68);
            this.borrowedBooksDataGrid.Name = "borrowedBooksDataGrid";
            this.borrowedBooksDataGrid.Size = new System.Drawing.Size(325, 292);
            this.borrowedBooksDataGrid.TabIndex = 3;
            // 
            // borrowedLabel
            // 
            this.borrowedLabel.AutoSize = true;
            this.borrowedLabel.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedLabel.Location = new System.Drawing.Point(66, 14);
            this.borrowedLabel.Name = "borrowedLabel";
            this.borrowedLabel.Size = new System.Drawing.Size(230, 43);
            this.borrowedLabel.TabIndex = 2;
            this.borrowedLabel.Text = "BORROWED BOOKS";
            // 
            // returnedPanel
            // 
            this.returnedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.returnedPanel.Controls.Add(this.returnedBooksDataGrid);
            this.returnedPanel.Controls.Add(this.returnedLabel);
            this.returnedPanel.Location = new System.Drawing.Point(426, 126);
            this.returnedPanel.Name = "returnedPanel";
            this.returnedPanel.Size = new System.Drawing.Size(366, 377);
            this.returnedPanel.TabIndex = 7;
            // 
            // returnedBooksDataGrid
            // 
            this.returnedBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnedBooksDataGrid.Location = new System.Drawing.Point(29, 68);
            this.returnedBooksDataGrid.Name = "returnedBooksDataGrid";
            this.returnedBooksDataGrid.Size = new System.Drawing.Size(325, 292);
            this.returnedBooksDataGrid.TabIndex = 4;
            // 
            // returnedLabel
            // 
            this.returnedLabel.AutoSize = true;
            this.returnedLabel.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnedLabel.Location = new System.Drawing.Point(81, 11);
            this.returnedLabel.Name = "returnedLabel";
            this.returnedLabel.Size = new System.Drawing.Size(220, 43);
            this.returnedLabel.TabIndex = 3;
            this.returnedLabel.Text = "RETURNED BOOKS";
            // 
            // btn6_Panel
            // 
            this.btn6_Panel.Controls.Add(this.borrowedPanel);
            this.btn6_Panel.Controls.Add(this.btn6Label);
            this.btn6_Panel.Location = new System.Drawing.Point(0, 31);
            this.btn6_Panel.Name = "btn6_Panel";
            this.btn6_Panel.Size = new System.Drawing.Size(825, 500);
            this.btn6_Panel.TabIndex = 9;
            // 
            // btn6Form_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(188)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(815, 526);
            this.Controls.Add(this.returnedPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn6_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "btn6Form_Reports";
            this.Text = "btn6Form_Reports";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.borrowedPanel.ResumeLayout(false);
            this.borrowedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBooksDataGrid)).EndInit();
            this.returnedPanel.ResumeLayout(false);
            this.returnedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnedBooksDataGrid)).EndInit();
            this.btn6_Panel.ResumeLayout(false);
            this.btn6_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label btn6Label;
        private System.Windows.Forms.Panel borrowedPanel;
        private System.Windows.Forms.DataGridView borrowedBooksDataGrid;
        private System.Windows.Forms.Label borrowedLabel;
        private System.Windows.Forms.Panel returnedPanel;
        private System.Windows.Forms.DataGridView returnedBooksDataGrid;
        private System.Windows.Forms.Label returnedLabel;
        private System.Windows.Forms.Panel brPanel;
        private System.Windows.Forms.Panel btn6_Panel;
    }
}