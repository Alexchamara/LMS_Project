namespace LMS1.Librarian
{
    partial class TrasactionCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            transactionTypelbl = new Label();
            panel1 = new Panel();
            trasactionIdlbl = new Label();
            transactionIDText = new Label();
            trasactionDatelbl = new Label();
            memberNamelbl = new Label();
            bookNamelbl = new Label();
            memberIdlbl = new Label();
            bookISBNlbl = new Label();
            transactionTypeText = new Label();
            transactionMnameText = new Label();
            transactionMidText = new Label();
            transactionBnameText = new Label();
            transactionBisbnText = new Label();
            TreasactionDate = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // transactionTypelbl
            // 
            transactionTypelbl.AutoSize = true;
            transactionTypelbl.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            transactionTypelbl.Location = new Point(90, 50);
            transactionTypelbl.Margin = new Padding(2, 0, 2, 0);
            transactionTypelbl.Name = "transactionTypelbl";
            transactionTypelbl.Size = new Size(95, 20);
            transactionTypelbl.TabIndex = 1;
            transactionTypelbl.Text = "Transaction : ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(trasactionIdlbl);
            panel1.Controls.Add(transactionIDText);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 33);
            panel1.TabIndex = 2;
            // 
            // trasactionIdlbl
            // 
            trasactionIdlbl.AutoSize = true;
            trasactionIdlbl.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            trasactionIdlbl.ForeColor = SystemColors.Control;
            trasactionIdlbl.Location = new Point(44, 7);
            trasactionIdlbl.Margin = new Padding(2, 0, 2, 0);
            trasactionIdlbl.Name = "trasactionIdlbl";
            trasactionIdlbl.Size = new Size(114, 20);
            trasactionIdlbl.TabIndex = 1;
            trasactionIdlbl.Text = "Transaction ID : ";
            // 
            // transactionIDText
            // 
            transactionIDText.AutoSize = true;
            transactionIDText.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            transactionIDText.ForeColor = SystemColors.Control;
            transactionIDText.Location = new Point(164, 7);
            transactionIDText.Margin = new Padding(2, 0, 2, 0);
            transactionIDText.Name = "transactionIDText";
            transactionIDText.Size = new Size(119, 20);
            transactionIDText.TabIndex = 1;
            transactionIDText.Text = "Transaction Type";
            // 
            // trasactionDatelbl
            // 
            trasactionDatelbl.AutoSize = true;
            trasactionDatelbl.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            trasactionDatelbl.Location = new Point(403, 50);
            trasactionDatelbl.Margin = new Padding(2, 0, 2, 0);
            trasactionDatelbl.Name = "trasactionDatelbl";
            trasactionDatelbl.Size = new Size(48, 20);
            trasactionDatelbl.TabIndex = 3;
            trasactionDatelbl.Text = "Date :";
            // 
            // memberNamelbl
            // 
            memberNamelbl.AutoSize = true;
            memberNamelbl.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            memberNamelbl.Location = new Point(90, 80);
            memberNamelbl.Margin = new Padding(2, 0, 2, 0);
            memberNamelbl.Name = "memberNamelbl";
            memberNamelbl.Size = new Size(72, 20);
            memberNamelbl.TabIndex = 1;
            memberNamelbl.Text = "Member :";
            // 
            // bookNamelbl
            // 
            bookNamelbl.AutoSize = true;
            bookNamelbl.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            bookNamelbl.Location = new Point(403, 80);
            bookNamelbl.Margin = new Padding(2, 0, 2, 0);
            bookNamelbl.Name = "bookNamelbl";
            bookNamelbl.Size = new Size(98, 20);
            bookNamelbl.TabIndex = 3;
            bookNamelbl.Text = "Book Name : ";
            // 
            // memberIdlbl
            // 
            memberIdlbl.AutoSize = true;
            memberIdlbl.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            memberIdlbl.Location = new Point(90, 110);
            memberIdlbl.Margin = new Padding(2, 0, 2, 0);
            memberIdlbl.Name = "memberIdlbl";
            memberIdlbl.Size = new Size(91, 20);
            memberIdlbl.TabIndex = 1;
            memberIdlbl.Text = "Member ID :";
            // 
            // bookISBNlbl
            // 
            bookISBNlbl.AutoSize = true;
            bookISBNlbl.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            bookISBNlbl.Location = new Point(403, 110);
            bookISBNlbl.Margin = new Padding(2, 0, 2, 0);
            bookISBNlbl.Name = "bookISBNlbl";
            bookISBNlbl.Size = new Size(86, 20);
            bookISBNlbl.TabIndex = 3;
            bookISBNlbl.Text = "Book ISBN :";
            // 
            // transactionTypeText
            // 
            transactionTypeText.AutoSize = true;
            transactionTypeText.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            transactionTypeText.Location = new Point(192, 50);
            transactionTypeText.Margin = new Padding(2, 0, 2, 0);
            transactionTypeText.Name = "transactionTypeText";
            transactionTypeText.Size = new Size(119, 20);
            transactionTypeText.TabIndex = 1;
            transactionTypeText.Text = "Transaction Type";
            // 
            // transactionMnameText
            // 
            transactionMnameText.AutoSize = true;
            transactionMnameText.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            transactionMnameText.Location = new Point(192, 80);
            transactionMnameText.Margin = new Padding(2, 0, 2, 0);
            transactionMnameText.Name = "transactionMnameText";
            transactionMnameText.Size = new Size(119, 20);
            transactionMnameText.TabIndex = 1;
            transactionMnameText.Text = "Transaction Type";
            // 
            // transactionMidText
            // 
            transactionMidText.AutoSize = true;
            transactionMidText.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            transactionMidText.Location = new Point(192, 110);
            transactionMidText.Margin = new Padding(2, 0, 2, 0);
            transactionMidText.Name = "transactionMidText";
            transactionMidText.Size = new Size(119, 20);
            transactionMidText.TabIndex = 1;
            transactionMidText.Text = "Transaction Type";
            // 
            // transactionBnameText
            // 
            transactionBnameText.AutoSize = true;
            transactionBnameText.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            transactionBnameText.Location = new Point(508, 80);
            transactionBnameText.Margin = new Padding(2, 0, 2, 0);
            transactionBnameText.Name = "transactionBnameText";
            transactionBnameText.Size = new Size(119, 20);
            transactionBnameText.TabIndex = 1;
            transactionBnameText.Text = "Transaction Type";
            // 
            // transactionBisbnText
            // 
            transactionBisbnText.AutoSize = true;
            transactionBisbnText.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            transactionBisbnText.Location = new Point(508, 110);
            transactionBisbnText.Margin = new Padding(2, 0, 2, 0);
            transactionBisbnText.Name = "transactionBisbnText";
            transactionBisbnText.Size = new Size(119, 20);
            transactionBisbnText.TabIndex = 1;
            transactionBisbnText.Text = "Transaction Type";
            // 
            // TreasactionDate
            // 
            TreasactionDate.Enabled = false;
            TreasactionDate.Location = new Point(508, 50);
            TreasactionDate.Margin = new Padding(2, 1, 2, 1);
            TreasactionDate.Name = "TreasactionDate";
            TreasactionDate.Size = new Size(212, 23);
            TreasactionDate.TabIndex = 4;
            // 
            // TrasactionCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TreasactionDate);
            Controls.Add(bookISBNlbl);
            Controls.Add(bookNamelbl);
            Controls.Add(memberIdlbl);
            Controls.Add(trasactionDatelbl);
            Controls.Add(memberNamelbl);
            Controls.Add(panel1);
            Controls.Add(transactionBisbnText);
            Controls.Add(transactionMidText);
            Controls.Add(transactionBnameText);
            Controls.Add(transactionMnameText);
            Controls.Add(transactionTypeText);
            Controls.Add(transactionTypelbl);
            Margin = new Padding(2, 1, 2, 1);
            Name = "TrasactionCard";
            Size = new Size(808, 150);
            Load += TrasactionCard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label transactionTypelbl;
        private Panel panel1;
        private Label trasactionDatelbl;
        private Label memberNamelbl;
        private Label bookNamelbl;
        private Label memberIdlbl;
        private Label bookISBNlbl;
        private Label porfomedlbl;
        private Label trasactionIdlbl;
        private Label transactionNameText;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private DateTimePicker TreasactionDate;
        private Label label6;
        private Label label3;
        private Label transactionIDText;
        private Label transactionTypeText;
        private Label transactionMnameText;
        private Label transactionMidText;
        private Label transactionBnameText;
        private Label transactionBisbnText;
    }
}
