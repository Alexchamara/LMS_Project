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
            pictureBox1.Location = new Point(1174, 197);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // MemberBorrowBookBtn
            // 
            MemberBorrowBookBtn.BackColor = Color.FromArgb(246, 174, 0);
            MemberBorrowBookBtn.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            MemberBorrowBookBtn.ForeColor = SystemColors.Control;
            MemberBorrowBookBtn.Location = new Point(719, 428);
            MemberBorrowBookBtn.Name = "MemberBorrowBookBtn";
            MemberBorrowBookBtn.Size = new Size(341, 58);
            MemberBorrowBookBtn.TabIndex = 25;
            MemberBorrowBookBtn.Text = "Borrow Book";
            MemberBorrowBookBtn.UseVisualStyleBackColor = false;
            MemberBorrowBookBtn.Click += MemberBorrowBookBtn_Click;
            // 
            // MemberBorrowBookNameTextBox
            // 
            MemberBorrowBookNameTextBox.Location = new Point(660, 163);
            MemberBorrowBookNameTextBox.Name = "MemberBorrowBookNameTextBox";
            MemberBorrowBookNameTextBox.Size = new Size(400, 39);
            MemberBorrowBookNameTextBox.TabIndex = 23;
            // 
            // MemberBorrowISBNNOTextBox
            // 
            MemberBorrowISBNNOTextBox.Location = new Point(660, 248);
            MemberBorrowISBNNOTextBox.Name = "MemberBorrowISBNNOTextBox";
            MemberBorrowISBNNOTextBox.Size = new Size(400, 39);
            MemberBorrowISBNNOTextBox.TabIndex = 24;
            // 
            // ISBNNoLable
            // 
            ISBNNoLable.Anchor = AnchorStyles.Top;
            ISBNNoLable.AutoSize = true;
            ISBNNoLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ISBNNoLable.Location = new Point(391, 242);
            ISBNNoLable.Name = "ISBNNoLable";
            ISBNNoLable.Size = new Size(149, 43);
            ISBNNoLable.TabIndex = 21;
            ISBNNoLable.Text = "ISBN No";
            // 
            // BookNameLable
            // 
            BookNameLable.Anchor = AnchorStyles.Top;
            BookNameLable.AutoSize = true;
            BookNameLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            BookNameLable.Location = new Point(391, 157);
            BookNameLable.Name = "BookNameLable";
            BookNameLable.Size = new Size(205, 43);
            BookNameLable.TabIndex = 22;
            BookNameLable.Text = "Book Name";
            // 
            // MemberBorrowBookLable
            // 
            MemberBorrowBookLable.Anchor = AnchorStyles.Top;
            MemberBorrowBookLable.AutoSize = true;
            MemberBorrowBookLable.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Underline, GraphicsUnit.Point);
            MemberBorrowBookLable.Location = new Point(641, 34);
            MemberBorrowBookLable.Name = "MemberBorrowBookLable";
            MemberBorrowBookLable.Size = new Size(288, 61);
            MemberBorrowBookLable.TabIndex = 20;
            MemberBorrowBookLable.Text = "Borrow Book";
            // 
            // BorrowBookDate
            // 
            BorrowBookDate.Location = new Point(660, 340);
            BorrowBookDate.Name = "BorrowBookDate";
            BorrowBookDate.Size = new Size(400, 39);
            BorrowBookDate.TabIndex = 28;
            // 
            // BorrowDateLable
            // 
            BorrowDateLable.Anchor = AnchorStyles.Top;
            BorrowDateLable.AutoSize = true;
            BorrowDateLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowDateLable.Location = new Point(391, 336);
            BorrowDateLable.Name = "BorrowDateLable";
            BorrowDateLable.Size = new Size(254, 43);
            BorrowDateLable.TabIndex = 27;
            BorrowDateLable.Text = "Borrowed Date";
            // 
            // MemberBorrowBookForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 897);
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