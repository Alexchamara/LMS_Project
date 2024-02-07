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
            trasactionDatelbl = new Label();
            memberNamelbl = new Label();
            bookNamelbl = new Label();
            memberIdlbl = new Label();
            bookISBNlbl = new Label();
            trasactionIdlbl = new Label();
            porfomedlbl = new Label();
            transactionNameText = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // transactionTypelbl
            // 
            transactionTypelbl.AutoSize = true;
            transactionTypelbl.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            transactionTypelbl.Location = new Point(168, 106);
            transactionTypelbl.Name = "transactionTypelbl";
            transactionTypelbl.Size = new Size(182, 40);
            transactionTypelbl.TabIndex = 1;
            transactionTypelbl.Text = "Transaction : ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(porfomedlbl);
            panel1.Controls.Add(trasactionIdlbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 70);
            panel1.TabIndex = 2;
            // 
            // trasactionDatelbl
            // 
            trasactionDatelbl.AutoSize = true;
            trasactionDatelbl.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            trasactionDatelbl.Location = new Point(748, 106);
            trasactionDatelbl.Name = "trasactionDatelbl";
            trasactionDatelbl.Size = new Size(91, 40);
            trasactionDatelbl.TabIndex = 3;
            trasactionDatelbl.Text = "Date :";
            // 
            // memberNamelbl
            // 
            memberNamelbl.AutoSize = true;
            memberNamelbl.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            memberNamelbl.Location = new Point(168, 171);
            memberNamelbl.Name = "memberNamelbl";
            memberNamelbl.Size = new Size(139, 40);
            memberNamelbl.TabIndex = 1;
            memberNamelbl.Text = "Member :";
            // 
            // bookNamelbl
            // 
            bookNamelbl.AutoSize = true;
            bookNamelbl.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            bookNamelbl.Location = new Point(748, 171);
            bookNamelbl.Name = "bookNamelbl";
            bookNamelbl.Size = new Size(189, 40);
            bookNamelbl.TabIndex = 3;
            bookNamelbl.Text = "Book Name : ";
            // 
            // memberIdlbl
            // 
            memberIdlbl.AutoSize = true;
            memberIdlbl.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            memberIdlbl.Location = new Point(168, 235);
            memberIdlbl.Name = "memberIdlbl";
            memberIdlbl.Size = new Size(175, 40);
            memberIdlbl.TabIndex = 1;
            memberIdlbl.Text = "Member ID :";
            memberIdlbl.Click += label5_Click;
            // 
            // bookISBNlbl
            // 
            bookISBNlbl.AutoSize = true;
            bookISBNlbl.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            bookISBNlbl.Location = new Point(748, 235);
            bookISBNlbl.Name = "bookISBNlbl";
            bookISBNlbl.Size = new Size(166, 40);
            bookISBNlbl.TabIndex = 3;
            bookISBNlbl.Text = "Book ISBN :";
            // 
            // trasactionIdlbl
            // 
            trasactionIdlbl.AutoSize = true;
            trasactionIdlbl.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            trasactionIdlbl.ForeColor = SystemColors.Control;
            trasactionIdlbl.Location = new Point(146, 14);
            trasactionIdlbl.Name = "trasactionIdlbl";
            trasactionIdlbl.Size = new Size(218, 40);
            trasactionIdlbl.TabIndex = 1;
            trasactionIdlbl.Text = "Transaction ID : ";
            // 
            // porfomedlbl
            // 
            porfomedlbl.AutoSize = true;
            porfomedlbl.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            porfomedlbl.ForeColor = SystemColors.Control;
            porfomedlbl.Location = new Point(805, 14);
            porfomedlbl.Name = "porfomedlbl";
            porfomedlbl.Size = new Size(213, 40);
            porfomedlbl.TabIndex = 1;
            porfomedlbl.Text = "Porformed  By :";
            // 
            // transactionNameText
            // 
            transactionNameText.AutoSize = true;
            transactionNameText.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            transactionNameText.Location = new Point(356, 106);
            transactionNameText.Name = "transactionNameText";
            transactionNameText.Size = new Size(227, 40);
            transactionNameText.TabIndex = 1;
            transactionNameText.Text = "Transaction Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(356, 171);
            label1.Name = "label1";
            label1.Size = new Size(227, 40);
            label1.TabIndex = 1;
            label1.Text = "Transaction Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(356, 235);
            label2.Name = "label2";
            label2.Size = new Size(227, 40);
            label2.TabIndex = 1;
            label2.Text = "Transaction Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(943, 171);
            label4.Name = "label4";
            label4.Size = new Size(227, 40);
            label4.TabIndex = 1;
            label4.Text = "Transaction Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(943, 235);
            label5.Name = "label5";
            label5.Size = new Size(227, 40);
            label5.TabIndex = 1;
            label5.Text = "Transaction Type";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(943, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(390, 39);
            dateTimePicker1.TabIndex = 4;
            // 
            // TrasactionCard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker1);
            Controls.Add(bookISBNlbl);
            Controls.Add(bookNamelbl);
            Controls.Add(memberIdlbl);
            Controls.Add(trasactionDatelbl);
            Controls.Add(memberNamelbl);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(transactionNameText);
            Controls.Add(transactionTypelbl);
            Name = "TrasactionCard";
            Size = new Size(1500, 321);
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
        private DateTimePicker dateTimePicker1;
    }
}
