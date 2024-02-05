namespace LMS1
{
    partial class MemberBorrowBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberBorrowBookForm));
            pictureBox1 = new PictureBox();
            MemberBorrowBookBtn = new Button();
            MemberBorrowBookNameTextBox = new TextBox();
            MemberBorrowISBNNOTextBox = new TextBox();
            ISBNNoLable = new Label();
            BookNameLable = new Label();
            MemberBorrowBookLable = new Label();
            BorrowBookDate = new DateTimePicker();
            BorrowDateLable = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(632, 92);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // MemberBorrowBookBtn
            // 
            MemberBorrowBookBtn.BackColor = Color.FromArgb(246, 174, 0);
            MemberBorrowBookBtn.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            MemberBorrowBookBtn.ForeColor = SystemColors.Control;
            MemberBorrowBookBtn.Location = new Point(387, 201);
            MemberBorrowBookBtn.Margin = new Padding(2, 1, 2, 1);
            MemberBorrowBookBtn.Name = "MemberBorrowBookBtn";
            MemberBorrowBookBtn.Size = new Size(184, 27);
            MemberBorrowBookBtn.TabIndex = 4;
            MemberBorrowBookBtn.Text = "Borrow Book";
            MemberBorrowBookBtn.UseVisualStyleBackColor = false;
            MemberBorrowBookBtn.Click += MemberBorrowBookBtn_Click;
            // 
            // MemberBorrowBookNameTextBox
            // 
            MemberBorrowBookNameTextBox.Location = new Point(355, 76);
            MemberBorrowBookNameTextBox.Margin = new Padding(2, 1, 2, 1);
            MemberBorrowBookNameTextBox.Name = "MemberBorrowBookNameTextBox";
            MemberBorrowBookNameTextBox.Size = new Size(217, 23);
            MemberBorrowBookNameTextBox.TabIndex = 1;
            // 
            // MemberBorrowISBNNOTextBox
            // 
            MemberBorrowISBNNOTextBox.Location = new Point(355, 116);
            MemberBorrowISBNNOTextBox.Margin = new Padding(2, 1, 2, 1);
            MemberBorrowISBNNOTextBox.Name = "MemberBorrowISBNNOTextBox";
            MemberBorrowISBNNOTextBox.Size = new Size(217, 23);
            MemberBorrowISBNNOTextBox.TabIndex = 2;
            // 
            // ISBNNoLable
            // 
            ISBNNoLable.Anchor = AnchorStyles.Top;
            ISBNNoLable.AutoSize = true;
            ISBNNoLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ISBNNoLable.Location = new Point(211, 113);
            ISBNNoLable.Margin = new Padding(2, 0, 2, 0);
            ISBNNoLable.Name = "ISBNNoLable";
            ISBNNoLable.Size = new Size(77, 24);
            ISBNNoLable.TabIndex = 0;
            ISBNNoLable.Text = "ISBN No";
            // 
            // BookNameLable
            // 
            BookNameLable.Anchor = AnchorStyles.Top;
            BookNameLable.AutoSize = true;
            BookNameLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            BookNameLable.Location = new Point(211, 74);
            BookNameLable.Margin = new Padding(2, 0, 2, 0);
            BookNameLable.Name = "BookNameLable";
            BookNameLable.Size = new Size(106, 24);
            BookNameLable.TabIndex = 0;
            BookNameLable.Text = "Book Name";
            // 
            // MemberBorrowBookLable
            // 
            MemberBorrowBookLable.Anchor = AnchorStyles.Top;
            MemberBorrowBookLable.AutoSize = true;
            MemberBorrowBookLable.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Underline, GraphicsUnit.Point);
            MemberBorrowBookLable.Location = new Point(345, 16);
            MemberBorrowBookLable.Margin = new Padding(2, 0, 2, 0);
            MemberBorrowBookLable.Name = "MemberBorrowBookLable";
            MemberBorrowBookLable.Size = new Size(147, 30);
            MemberBorrowBookLable.TabIndex = 0;
            MemberBorrowBookLable.Text = "Borrow Book";
            // 
            // BorrowBookDate
            // 
            BorrowBookDate.Location = new Point(355, 159);
            BorrowBookDate.Margin = new Padding(2, 1, 2, 1);
            BorrowBookDate.Name = "BorrowBookDate";
            BorrowBookDate.Size = new Size(217, 23);
            BorrowBookDate.TabIndex = 3;
            // 
            // BorrowDateLable
            // 
            BorrowDateLable.Anchor = AnchorStyles.Top;
            BorrowDateLable.AutoSize = true;
            BorrowDateLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowDateLable.Location = new Point(211, 158);
            BorrowDateLable.Margin = new Padding(2, 0, 2, 0);
            BorrowDateLable.Name = "BorrowDateLable";
            BorrowDateLable.Size = new Size(130, 24);
            BorrowDateLable.TabIndex = 0;
            BorrowDateLable.Text = "Borrowed Date";
            // 
            // MemberBorrowBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 420);
            Controls.Add(BorrowBookDate);
            Controls.Add(BorrowDateLable);
            Controls.Add(pictureBox1);
            Controls.Add(MemberBorrowBookBtn);
            Controls.Add(MemberBorrowBookNameTextBox);
            Controls.Add(MemberBorrowISBNNOTextBox);
            Controls.Add(ISBNNoLable);
            Controls.Add(BookNameLable);
            Controls.Add(MemberBorrowBookLable);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "MemberBorrowBookForm";
            Text = "MemberBorrowBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button MemberBorrowBookBtn;
        private TextBox MemberBorrowBookNameTextBox;
        private TextBox MemberBorrowISBNNOTextBox;
        private Label ISBNNoLable;
        private Label BookNameLable;
        private Label MemberBorrowBookLable;
        private DateTimePicker BorrowBookDate;
        private Label BorrowDateLable;
    }
}