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
            ClearBtn = new Label();
            ReturnBookDate = new DateTimePicker();
            ReturnDateLable = new Label();
            label2 = new Label();
            ISBNRadioButton = new RadioButton();
            BookTitelRadioButton = new RadioButton();
            dataGridView1 = new DataGridView();
            SearchBookTextBook = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            MemberBorrowBookBtn.Location = new Point(387, 252);
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
            ISBNNoLable.Location = new Point(211, 116);
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
            BorrowBookDate.AccessibleRole = AccessibleRole.MenuBar;
            BorrowBookDate.Location = new Point(355, 159);
            BorrowBookDate.Margin = new Padding(2, 1, 2, 1);
            BorrowBookDate.MaxDate = new DateTime(2100, 2, 5, 11, 18, 0, 0);
            BorrowBookDate.MinDate = new DateTime(2024, 2, 5, 0, 0, 0, 0);
            BorrowBookDate.Name = "BorrowBookDate";
            BorrowBookDate.Size = new Size(217, 23);
            BorrowBookDate.TabIndex = 3;
            BorrowBookDate.Value = new DateTime(2024, 2, 5, 11, 44, 0, 0);
            BorrowBookDate.ValueChanged += BorrowBookDate_ValueChanged;
            // 
            // BorrowDateLable
            // 
            BorrowDateLable.Anchor = AnchorStyles.Top;
            BorrowDateLable.AutoSize = true;
            BorrowDateLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowDateLable.Location = new Point(211, 160);
            BorrowDateLable.Margin = new Padding(2, 0, 2, 0);
            BorrowDateLable.Name = "BorrowDateLable";
            BorrowDateLable.Size = new Size(130, 24);
            BorrowDateLable.TabIndex = 0;
            BorrowDateLable.Text = "Borrowed Date";
            // 
            // ClearBtn
            // 
            ClearBtn.AutoSize = true;
            ClearBtn.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.ForeColor = SystemColors.ActiveCaptionText;
            ClearBtn.Location = new Point(504, 232);
            ClearBtn.Margin = new Padding(2, 0, 2, 0);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(65, 16);
            ClearBtn.TabIndex = 0;
            ClearBtn.Text = "Clear Fields";
            ClearBtn.Click += ClearBtn_Click;
            // 
            // ReturnBookDate
            // 
            ReturnBookDate.Location = new Point(355, 206);
            ReturnBookDate.Margin = new Padding(2, 1, 2, 1);
            ReturnBookDate.Name = "ReturnBookDate";
            ReturnBookDate.Size = new Size(217, 23);
            ReturnBookDate.TabIndex = 4;
            // 
            // ReturnDateLable
            // 
            ReturnDateLable.Anchor = AnchorStyles.Top;
            ReturnDateLable.AutoSize = true;
            ReturnDateLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnDateLable.Location = new Point(211, 206);
            ReturnDateLable.Margin = new Padding(2, 0, 2, 0);
            ReturnDateLable.Name = "ReturnDateLable";
            ReturnDateLable.Size = new Size(107, 24);
            ReturnDateLable.TabIndex = 0;
            ReturnDateLable.Text = "Return Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(149, 298);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 31;
            label2.Text = "Search By";
            // 
            // ISBNRadioButton
            // 
            ISBNRadioButton.AutoSize = true;
            ISBNRadioButton.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ISBNRadioButton.Location = new Point(605, 296);
            ISBNRadioButton.Name = "ISBNRadioButton";
            ISBNRadioButton.Size = new Size(83, 25);
            ISBNRadioButton.TabIndex = 30;
            ISBNRadioButton.Text = "ISBN No";
            ISBNRadioButton.UseVisualStyleBackColor = true;
            ISBNRadioButton.CheckedChanged += ISBNRadioButton_CheckedChanged;
            // 
            // BookTitelRadioButton
            // 
            BookTitelRadioButton.AutoSize = true;
            BookTitelRadioButton.Checked = true;
            BookTitelRadioButton.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BookTitelRadioButton.Location = new Point(497, 296);
            BookTitelRadioButton.Name = "BookTitelRadioButton";
            BookTitelRadioButton.Size = new Size(96, 25);
            BookTitelRadioButton.TabIndex = 29;
            BookTitelRadioButton.TabStop = true;
            BookTitelRadioButton.Text = "Book Titel";
            BookTitelRadioButton.UseVisualStyleBackColor = true;
            BookTitelRadioButton.CheckedChanged += BookTitelRadioButton_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 339);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(808, 71);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // SearchBookTextBook
            // 
            SearchBookTextBook.Location = new Point(231, 299);
            SearchBookTextBook.Margin = new Padding(2, 1, 2, 1);
            SearchBookTextBook.Name = "SearchBookTextBook";
            SearchBookTextBook.Size = new Size(223, 23);
            SearchBookTextBook.TabIndex = 27;
            SearchBookTextBook.TextChanged += SearchBookTextBook_TextChanged;
            // 
            // MemberBorrowBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 420);
            Controls.Add(label2);
            Controls.Add(ISBNRadioButton);
            Controls.Add(BookTitelRadioButton);
            Controls.Add(dataGridView1);
            Controls.Add(SearchBookTextBook);
            Controls.Add(ReturnBookDate);
            Controls.Add(ReturnDateLable);
            Controls.Add(ClearBtn);
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
            Load += MemberBorrowBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label ClearBtn;
        private DateTimePicker ReturnBookDate;
        private Label ReturnDateLable;
        private Label label2;
        private RadioButton ISBNRadioButton;
        private RadioButton BookTitelRadioButton;
        private DataGridView dataGridView1;
        private TextBox SearchBookTextBook;
    }
}