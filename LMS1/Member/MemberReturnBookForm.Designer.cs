namespace LMS1
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
            BorrowBookDate = new DateTimePicker();
            ReturnDateLable = new Label();
            pictureBox1 = new PictureBox();
            MemberReturnBookBtn = new Button();
            MemberReturnBookNameTextBox = new TextBox();
            MemberReturnISBNNOTextBox = new TextBox();
            ISBNNoLable = new Label();
            BookNameLable = new Label();
            MemberReturnBookLable = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BorrowBookDate
            // 
            BorrowBookDate.Location = new Point(660, 340);
            BorrowBookDate.Name = "BorrowBookDate";
            BorrowBookDate.Size = new Size(400, 39);
            BorrowBookDate.TabIndex = 37;
            // 
            // ReturnDateLable
            // 
            ReturnDateLable.Anchor = AnchorStyles.Top;
            ReturnDateLable.AutoSize = true;
            ReturnDateLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnDateLable.Location = new Point(391, 336);
            ReturnDateLable.Name = "ReturnDateLable";
            ReturnDateLable.Size = new Size(249, 43);
            ReturnDateLable.TabIndex = 36;
            ReturnDateLable.Text = "Returned Date";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1174, 197);
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
            MemberReturnBookBtn.Location = new Point(719, 428);
            MemberReturnBookBtn.Name = "MemberReturnBookBtn";
            MemberReturnBookBtn.Size = new Size(341, 58);
            MemberReturnBookBtn.TabIndex = 34;
            MemberReturnBookBtn.Text = "Return Book";
            MemberReturnBookBtn.UseVisualStyleBackColor = false;
            // 
            // MemberReturnBookNameTextBox
            // 
            MemberReturnBookNameTextBox.Location = new Point(660, 163);
            MemberReturnBookNameTextBox.Name = "MemberReturnBookNameTextBox";
            MemberReturnBookNameTextBox.Size = new Size(400, 39);
            MemberReturnBookNameTextBox.TabIndex = 32;
            // 
            // MemberReturnISBNNOTextBox
            // 
            MemberReturnISBNNOTextBox.Location = new Point(660, 248);
            MemberReturnISBNNOTextBox.Name = "MemberReturnISBNNOTextBox";
            MemberReturnISBNNOTextBox.Size = new Size(400, 39);
            MemberReturnISBNNOTextBox.TabIndex = 33;
            // 
            // ISBNNoLable
            // 
            ISBNNoLable.Anchor = AnchorStyles.Top;
            ISBNNoLable.AutoSize = true;
            ISBNNoLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ISBNNoLable.Location = new Point(391, 242);
            ISBNNoLable.Name = "ISBNNoLable";
            ISBNNoLable.Size = new Size(149, 43);
            ISBNNoLable.TabIndex = 30;
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
            BookNameLable.TabIndex = 31;
            BookNameLable.Text = "Book Name";
            // 
            // MemberReturnBookLable
            // 
            MemberReturnBookLable.Anchor = AnchorStyles.Top;
            MemberReturnBookLable.AutoSize = true;
            MemberReturnBookLable.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Underline, GraphicsUnit.Point);
            MemberReturnBookLable.Location = new Point(641, 34);
            MemberReturnBookLable.Name = "MemberReturnBookLable";
            MemberReturnBookLable.Size = new Size(283, 61);
            MemberReturnBookLable.TabIndex = 29;
            MemberReturnBookLable.Text = "Return Book";
            // 
            // MemberReturnBookForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 897);
            Controls.Add(BorrowBookDate);
            Controls.Add(ReturnDateLable);
            Controls.Add(pictureBox1);
            Controls.Add(MemberReturnBookBtn);
            Controls.Add(MemberReturnBookNameTextBox);
            Controls.Add(MemberReturnISBNNOTextBox);
            Controls.Add(ISBNNoLable);
            Controls.Add(BookNameLable);
            Controls.Add(MemberReturnBookLable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberReturnBookForm";
            Text = "MemberReturnBookForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}