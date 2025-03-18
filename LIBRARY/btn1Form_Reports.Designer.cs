namespace LIBRARY
{
    partial class btn1Form_Reports
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
            this.mainFRPanel = new System.Windows.Forms.Panel();
            this.unavailablePanel = new System.Windows.Forms.Panel();
            this.unavailableBooksDataGrid = new System.Windows.Forms.DataGridView();
            this.unavailableLabel = new System.Windows.Forms.Label();
            this.btn1_Panel = new System.Windows.Forms.Panel();
            this.btn1Label = new System.Windows.Forms.Label();
            this.availablePanel = new System.Windows.Forms.Panel();
            this.availableBooksDataGrid = new System.Windows.Forms.DataGridView();
            this.availableLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mainFRPanel.SuspendLayout();
            this.unavailablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unavailableBooksDataGrid)).BeginInit();
            this.btn1_Panel.SuspendLayout();
            this.availablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableBooksDataGrid)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(821, 34);
            this.panel1.TabIndex = 3;
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
            this.btn_Close.Location = new System.Drawing.Point(-24, -23);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(112, 79);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // mainFRPanel
            // 
            this.mainFRPanel.Controls.Add(this.unavailablePanel);
            this.mainFRPanel.Controls.Add(this.btn1_Panel);
            this.mainFRPanel.Location = new System.Drawing.Point(-2, 22);
            this.mainFRPanel.Name = "mainFRPanel";
            this.mainFRPanel.Size = new System.Drawing.Size(830, 502);
            this.mainFRPanel.TabIndex = 4;
            // 
            // unavailablePanel
            // 
            this.unavailablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.unavailablePanel.Controls.Add(this.unavailableBooksDataGrid);
            this.unavailablePanel.Controls.Add(this.unavailableLabel);
            this.unavailablePanel.Location = new System.Drawing.Point(430, 98);
            this.unavailablePanel.Name = "unavailablePanel";
            this.unavailablePanel.Size = new System.Drawing.Size(366, 377);
            this.unavailablePanel.TabIndex = 1;
            // 
            // unavailableBooksDataGrid
            // 
            this.unavailableBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unavailableBooksDataGrid.Location = new System.Drawing.Point(29, 68);
            this.unavailableBooksDataGrid.Name = "unavailableBooksDataGrid";
            this.unavailableBooksDataGrid.Size = new System.Drawing.Size(325, 292);
            this.unavailableBooksDataGrid.TabIndex = 4;
            // 
            // unavailableLabel
            // 
            this.unavailableLabel.AutoSize = true;
            this.unavailableLabel.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unavailableLabel.Location = new System.Drawing.Point(63, 11);
            this.unavailableLabel.Name = "unavailableLabel";
            this.unavailableLabel.Size = new System.Drawing.Size(258, 43);
            this.unavailableLabel.TabIndex = 3;
            this.unavailableLabel.Text = "UNAVAILABLE BOOKS";
            // 
            // btn1_Panel
            // 
            this.btn1_Panel.Controls.Add(this.btn1Label);
            this.btn1_Panel.Controls.Add(this.availablePanel);
            this.btn1_Panel.Location = new System.Drawing.Point(0, 3);
            this.btn1_Panel.Name = "btn1_Panel";
            this.btn1_Panel.Size = new System.Drawing.Size(827, 482);
            this.btn1_Panel.TabIndex = 5;
            // 
            // btn1Label
            // 
            this.btn1Label.AutoSize = true;
            this.btn1Label.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Label.Location = new System.Drawing.Point(147, 31);
            this.btn1Label.Name = "btn1Label";
            this.btn1Label.Size = new System.Drawing.Size(533, 43);
            this.btn1Label.TabIndex = 4;
            this.btn1Label.Text = "LIST OF AVAILABLE AND UNAVAILABLE BOOKS";
            // 
            // availablePanel
            // 
            this.availablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(205)))));
            this.availablePanel.Controls.Add(this.availableBooksDataGrid);
            this.availablePanel.Controls.Add(this.availableLabel);
            this.availablePanel.Location = new System.Drawing.Point(26, 95);
            this.availablePanel.Name = "availablePanel";
            this.availablePanel.Size = new System.Drawing.Size(366, 377);
            this.availablePanel.TabIndex = 2;
            // 
            // availableBooksDataGrid
            // 
            this.availableBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableBooksDataGrid.Location = new System.Drawing.Point(20, 68);
            this.availableBooksDataGrid.Name = "availableBooksDataGrid";
            this.availableBooksDataGrid.Size = new System.Drawing.Size(325, 292);
            this.availableBooksDataGrid.TabIndex = 3;
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableLabel.Location = new System.Drawing.Point(68, 11);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(227, 43);
            this.availableLabel.TabIndex = 2;
            this.availableLabel.Text = "AVAILABLE BOOKS";
            // 
            // btn1Form_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(188)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(821, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainFRPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "btn1Form_Reports";
            this.Text = "btn1Form_Reports";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.mainFRPanel.ResumeLayout(false);
            this.unavailablePanel.ResumeLayout(false);
            this.unavailablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unavailableBooksDataGrid)).EndInit();
            this.btn1_Panel.ResumeLayout(false);
            this.btn1_Panel.PerformLayout();
            this.availablePanel.ResumeLayout(false);
            this.availablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableBooksDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel mainFRPanel;
        private System.Windows.Forms.Panel availablePanel;
        private System.Windows.Forms.Panel unavailablePanel;
        private System.Windows.Forms.Label btn1Label;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.Label unavailableLabel;
        private System.Windows.Forms.DataGridView availableBooksDataGrid;
        private System.Windows.Forms.DataGridView unavailableBooksDataGrid;
        private System.Windows.Forms.Panel btn1_Panel;
    }
}