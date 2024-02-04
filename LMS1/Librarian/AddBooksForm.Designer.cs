namespace LMS1
{
    partial class AddBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooksForm));
            AddBookNameTextBox = new TextBox();
            AddISBNNOTextBox = new TextBox();
            AddAuthorTextBox = new TextBox();
            AddPriceTextBox = new TextBox();
            AddSubjectTextBox = new TextBox();
            PriceLable = new Label();
            SubjectLable = new Label();
            PublisherLable = new Label();
            AuthorLable = new Label();
            ISBNNoLable = new Label();
            BookNameLable = new Label();
            AddBookLable = new Label();
            AddBookBtn = new Button();
            pictureBox1 = new PictureBox();
            AddPublisherTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AddBookNameTextBox
            // 
            AddBookNameTextBox.Location = new Point(635, 163);
            AddBookNameTextBox.Name = "AddBookNameTextBox";
            AddBookNameTextBox.Size = new Size(400, 39);
            AddBookNameTextBox.TabIndex = 11;
            // 
            // AddISBNNOTextBox
            // 
            AddISBNNOTextBox.Location = new Point(635, 248);
            AddISBNNOTextBox.Name = "AddISBNNOTextBox";
            AddISBNNOTextBox.Size = new Size(400, 39);
            AddISBNNOTextBox.TabIndex = 12;
            // 
            // AddAuthorTextBox
            // 
            AddAuthorTextBox.Location = new Point(635, 333);
            AddAuthorTextBox.Name = "AddAuthorTextBox";
            AddAuthorTextBox.Size = new Size(400, 39);
            AddAuthorTextBox.TabIndex = 13;
            // 
            // AddPriceTextBox
            // 
            AddPriceTextBox.Location = new Point(635, 588);
            AddPriceTextBox.Name = "AddPriceTextBox";
            AddPriceTextBox.Size = new Size(400, 39);
            AddPriceTextBox.TabIndex = 14;
            // 
            // AddSubjectTextBox
            // 
            AddSubjectTextBox.Location = new Point(635, 503);
            AddSubjectTextBox.Name = "AddSubjectTextBox";
            AddSubjectTextBox.Size = new Size(400, 39);
            AddSubjectTextBox.TabIndex = 15;
            // 
            // PriceLable
            // 
            PriceLable.Anchor = AnchorStyles.Top;
            PriceLable.AutoSize = true;
            PriceLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            PriceLable.Location = new Point(391, 582);
            PriceLable.Name = "PriceLable";
            PriceLable.Size = new Size(98, 43);
            PriceLable.TabIndex = 5;
            PriceLable.Text = "Price";
            // 
            // SubjectLable
            // 
            SubjectLable.Anchor = AnchorStyles.Top;
            SubjectLable.AutoSize = true;
            SubjectLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            SubjectLable.Location = new Point(391, 497);
            SubjectLable.Name = "SubjectLable";
            SubjectLable.Size = new Size(137, 43);
            SubjectLable.TabIndex = 6;
            SubjectLable.Text = "Subject";
            // 
            // PublisherLable
            // 
            PublisherLable.Anchor = AnchorStyles.Top;
            PublisherLable.AutoSize = true;
            PublisherLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            PublisherLable.Location = new Point(391, 412);
            PublisherLable.Name = "PublisherLable";
            PublisherLable.Size = new Size(197, 43);
            PublisherLable.TabIndex = 7;
            PublisherLable.Text = "Publication";
            // 
            // AuthorLable
            // 
            AuthorLable.Anchor = AnchorStyles.Top;
            AuthorLable.AutoSize = true;
            AuthorLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorLable.Location = new Point(391, 327);
            AuthorLable.Name = "AuthorLable";
            AuthorLable.Size = new Size(125, 43);
            AuthorLable.TabIndex = 8;
            AuthorLable.Text = "Author";
            // 
            // ISBNNoLable
            // 
            ISBNNoLable.Anchor = AnchorStyles.Top;
            ISBNNoLable.AutoSize = true;
            ISBNNoLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ISBNNoLable.Location = new Point(391, 242);
            ISBNNoLable.Name = "ISBNNoLable";
            ISBNNoLable.Size = new Size(149, 43);
            ISBNNoLable.TabIndex = 9;
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
            BookNameLable.TabIndex = 10;
            BookNameLable.Text = "Book Name";
            // 
            // AddBookLable
            // 
            AddBookLable.Anchor = AnchorStyles.Top;
            AddBookLable.AutoSize = true;
            AddBookLable.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Underline, GraphicsUnit.Point);
            AddBookLable.Location = new Point(641, 34);
            AddBookLable.Name = "AddBookLable";
            AddBookLable.Size = new Size(225, 61);
            AddBookLable.TabIndex = 4;
            AddBookLable.Text = "Add Book";
            // 
            // AddBookBtn
            // 
            AddBookBtn.BackColor = Color.FromArgb(246, 174, 0);
            AddBookBtn.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            AddBookBtn.ForeColor = SystemColors.Control;
            AddBookBtn.Location = new Point(694, 685);
            AddBookBtn.Name = "AddBookBtn";
            AddBookBtn.Size = new Size(341, 58);
            AddBookBtn.TabIndex = 17;
            AddBookBtn.Text = "Add Book";
            AddBookBtn.UseVisualStyleBackColor = false;
            AddBookBtn.Click += AddBookBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1168, 328);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // AddPublisherTextBox
            // 
            AddPublisherTextBox.Location = new Point(635, 418);
            AddPublisherTextBox.Name = "AddPublisherTextBox";
            AddPublisherTextBox.Size = new Size(400, 39);
            AddPublisherTextBox.TabIndex = 19;
            // 
            // AddBooksForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 897);
            Controls.Add(AddPublisherTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(AddBookBtn);
            Controls.Add(AddBookNameTextBox);
            Controls.Add(AddISBNNOTextBox);
            Controls.Add(AddAuthorTextBox);
            Controls.Add(AddPriceTextBox);
            Controls.Add(AddSubjectTextBox);
            Controls.Add(PriceLable);
            Controls.Add(SubjectLable);
            Controls.Add(PublisherLable);
            Controls.Add(AuthorLable);
            Controls.Add(ISBNNoLable);
            Controls.Add(BookNameLable);
            Controls.Add(AddBookLable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBooksForm";
            Text = "AddBooksForm";
            Load += AddBooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox AddBookNameTextBox;
        private TextBox AddISBNNOTextBox;
        private TextBox AddAuthorTextBox;
        private TextBox AddPriceTextBox;
        private TextBox AddSubjectTextBox;
        private Label PriceLable;
        private Label SubjectLable;
        private Label PublisherLable;
        private Label AuthorLable;
        private Label ISBNNoLable;
        private Label BookNameLable;
        private Label AddBookLable;
        private Button AddBookBtn;
        private PictureBox pictureBox1;
        private TextBox AddPublisherTextBox;
    }
}