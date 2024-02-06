﻿namespace LMS1
{
    partial class MemberReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberReturnBookForm));
            MemberReturnBookDate = new DateTimePicker();
            ReturnDateLable = new Label();
            pictureBox1 = new PictureBox();
            MemberReturnBookBtn = new Button();
            MemberReturnBookNameTextBox = new TextBox();
            MemberReturnISBNNOTextBox = new TextBox();
            ISBNNoLable = new Label();
            BookNameLable = new Label();
            MemberReturnBookLable = new Label();
            ClearBtn = new Label();
            ISBNRadioButton = new RadioButton();
            BookTitelRadioButton = new RadioButton();
            dataGridView1 = new DataGridView();
            SearchBookTextBook = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MemberReturnBookDate
            // 
            MemberReturnBookDate.Location = new Point(659, 339);
            MemberReturnBookDate.Margin = new Padding(4, 2, 4, 2);
            MemberReturnBookDate.Name = "MemberReturnBookDate";
            MemberReturnBookDate.Size = new Size(400, 39);
            MemberReturnBookDate.TabIndex = 3;
            // 
            // ReturnDateLable
            // 
            ReturnDateLable.Anchor = AnchorStyles.Top;
            ReturnDateLable.AutoSize = true;
            ReturnDateLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnDateLable.Location = new Point(292, 337);
            ReturnDateLable.Margin = new Padding(4, 0, 4, 0);
            ReturnDateLable.Name = "ReturnDateLable";
            ReturnDateLable.Size = new Size(249, 43);
            ReturnDateLable.TabIndex = 0;
            ReturnDateLable.Text = "Returned Date";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1122, 213);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // MemberReturnBookBtn
            // 
            MemberReturnBookBtn.BackColor = Color.FromArgb(246, 174, 0);
            MemberReturnBookBtn.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            MemberReturnBookBtn.ForeColor = SystemColors.Control;
            MemberReturnBookBtn.Location = new Point(719, 442);
            MemberReturnBookBtn.Margin = new Padding(4, 2, 4, 2);
            MemberReturnBookBtn.Name = "MemberReturnBookBtn";
            MemberReturnBookBtn.Size = new Size(342, 58);
            MemberReturnBookBtn.TabIndex = 4;
            MemberReturnBookBtn.Text = "Return Book";
            MemberReturnBookBtn.UseVisualStyleBackColor = false;
            MemberReturnBookBtn.Click += MemberReturnBookBtn_Click;
            // 
            // MemberReturnBookNameTextBox
            // 
            MemberReturnBookNameTextBox.Location = new Point(659, 162);
            MemberReturnBookNameTextBox.Margin = new Padding(4, 2, 4, 2);
            MemberReturnBookNameTextBox.Name = "MemberReturnBookNameTextBox";
            MemberReturnBookNameTextBox.Size = new Size(400, 39);
            MemberReturnBookNameTextBox.TabIndex = 1;
            // 
            // MemberReturnISBNNOTextBox
            // 
            MemberReturnISBNNOTextBox.Location = new Point(659, 247);
            MemberReturnISBNNOTextBox.Margin = new Padding(4, 2, 4, 2);
            MemberReturnISBNNOTextBox.Name = "MemberReturnISBNNOTextBox";
            MemberReturnISBNNOTextBox.Size = new Size(400, 39);
            MemberReturnISBNNOTextBox.TabIndex = 2;
            // 
            // ISBNNoLable
            // 
            ISBNNoLable.Anchor = AnchorStyles.Top;
            ISBNNoLable.AutoSize = true;
            ISBNNoLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ISBNNoLable.Location = new Point(292, 241);
            ISBNNoLable.Margin = new Padding(4, 0, 4, 0);
            ISBNNoLable.Name = "ISBNNoLable";
            ISBNNoLable.Size = new Size(149, 43);
            ISBNNoLable.TabIndex = 0;
            ISBNNoLable.Text = "ISBN No";
            // 
            // BookNameLable
            // 
            BookNameLable.Anchor = AnchorStyles.Top;
            BookNameLable.AutoSize = true;
            BookNameLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            BookNameLable.Location = new Point(292, 158);
            BookNameLable.Margin = new Padding(4, 0, 4, 0);
            BookNameLable.Name = "BookNameLable";
            BookNameLable.Size = new Size(205, 43);
            BookNameLable.TabIndex = 0;
            BookNameLable.Text = "Book Name";
            // 
            // MemberReturnBookLable
            // 
            MemberReturnBookLable.Anchor = AnchorStyles.Top;
            MemberReturnBookLable.AutoSize = true;
            MemberReturnBookLable.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Underline, GraphicsUnit.Point);
            MemberReturnBookLable.Location = new Point(623, 34);
            MemberReturnBookLable.Margin = new Padding(4, 0, 4, 0);
            MemberReturnBookLable.Name = "MemberReturnBookLable";
            MemberReturnBookLable.Size = new Size(283, 61);
            MemberReturnBookLable.TabIndex = 0;
            MemberReturnBookLable.Text = "Return Book";
            // 
            // ClearBtn
            // 
            ClearBtn.AutoSize = true;
            ClearBtn.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.ForeColor = SystemColors.ActiveCaptionText;
            ClearBtn.Location = new Point(936, 393);
            ClearBtn.Margin = new Padding(4, 0, 4, 0);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(134, 30);
            ClearBtn.TabIndex = 36;
            ClearBtn.Text = "Clear Fields";
            ClearBtn.Click += ClearBtn_Click;
            // 
            // ISBNRadioButton
            // 
            ISBNRadioButton.AutoSize = true;
            ISBNRadioButton.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ISBNRadioButton.Location = new Point(1013, 578);
            ISBNRadioButton.Margin = new Padding(6, 6, 6, 6);
            ISBNRadioButton.Name = "ISBNRadioButton";
            ISBNRadioButton.Size = new Size(161, 41);
            ISBNRadioButton.TabIndex = 40;
            ISBNRadioButton.Text = "ISBN No";
            ISBNRadioButton.UseVisualStyleBackColor = true;
            ISBNRadioButton.CheckedChanged += ISBNRadioButton_CheckedChanged;
            // 
            // BookTitelRadioButton
            // 
            BookTitelRadioButton.AutoSize = true;
            BookTitelRadioButton.Checked = true;
            BookTitelRadioButton.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BookTitelRadioButton.Location = new Point(810, 578);
            BookTitelRadioButton.Margin = new Padding(6, 6, 6, 6);
            BookTitelRadioButton.Name = "BookTitelRadioButton";
            BookTitelRadioButton.Size = new Size(184, 41);
            BookTitelRadioButton.TabIndex = 39;
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
            dataGridView1.Location = new Point(13, 659);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1516, 395);
            dataGridView1.TabIndex = 38;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // SearchBookTextBook
            // 
            SearchBookTextBook.Location = new Point(368, 580);
            SearchBookTextBook.Margin = new Padding(4, 2, 4, 2);
            SearchBookTextBook.Name = "SearchBookTextBook";
            SearchBookTextBook.PlaceholderText = "   Search";
            SearchBookTextBook.Size = new Size(411, 39);
            SearchBookTextBook.TabIndex = 37;
            SearchBookTextBook.TextChanged += SearchBookTextBook_TextChanged;
            // 
            // MemberReturnBookForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1542, 1065);
            Controls.Add(ISBNRadioButton);
            Controls.Add(BookTitelRadioButton);
            Controls.Add(dataGridView1);
            Controls.Add(SearchBookTextBook);
            Controls.Add(ClearBtn);
            Controls.Add(MemberReturnBookDate);
            Controls.Add(ReturnDateLable);
            Controls.Add(pictureBox1);
            Controls.Add(MemberReturnBookBtn);
            Controls.Add(MemberReturnBookNameTextBox);
            Controls.Add(MemberReturnISBNNOTextBox);
            Controls.Add(ISBNNoLable);
            Controls.Add(BookNameLable);
            Controls.Add(MemberReturnBookLable);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
            Name = "MemberReturnBookForm";
            Text = "MemberReturnBookForm";
            Load += MemberReturnBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker BorrowBookDate;
        private Label ReturnDateLable;
        private PictureBox pictureBox1;
        private Button MemberReturnBookBtn;
        private TextBox MemberReturnBookNameTextBox;
        private TextBox MemberReturnISBNNOTextBox;
        private Label ISBNNoLable;
        private Label BookNameLable;
        private Label MemberReturnBookLable;
        private DateTimePicker ReturnBookDate;
        private DateTimePicker MemberReturnBookDate;
        private Label ClearBtn;
        private RadioButton ISBNRadioButton;
        private RadioButton BookTitelRadioButton;
        private DataGridView dataGridView1;
        private TextBox SearchBookTextBook;
    }
}