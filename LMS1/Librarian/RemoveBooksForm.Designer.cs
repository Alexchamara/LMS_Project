namespace LMS1
{
    partial class RemoveBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveBooksForm));
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            RemoveBookBtn = new Button();
            RemoveBookNameTextBox = new TextBox();
            ISBNNOTextBox = new TextBox();
            ISBNNoLable = new Label();
            BookNameLable = new Label();
            RemoveBookLable = new Label();
            ISBNRadioButton = new RadioButton();
            BookTitelRadioButton = new RadioButton();
            SearchBookTextRemoveBook = new TextBox();
            ClearBtn = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 264);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(816, 230);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(591, 76);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // RemoveBookBtn
            // 
            RemoveBookBtn.BackColor = Color.FromArgb(246, 174, 0);
            RemoveBookBtn.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveBookBtn.ForeColor = SystemColors.Control;
            RemoveBookBtn.Location = new Point(374, 163);
            RemoveBookBtn.Margin = new Padding(2, 1, 2, 1);
            RemoveBookBtn.Name = "RemoveBookBtn";
            RemoveBookBtn.Size = new Size(184, 27);
            RemoveBookBtn.TabIndex = 3;
            RemoveBookBtn.Text = "Remove Book";
            RemoveBookBtn.UseVisualStyleBackColor = false;
            RemoveBookBtn.Click += RemoveBookBtn_Click;
            // 
            // RemoveBookNameTextBox
            // 
            RemoveBookNameTextBox.Location = new Point(342, 76);
            RemoveBookNameTextBox.Margin = new Padding(2, 1, 2, 1);
            RemoveBookNameTextBox.Name = "RemoveBookNameTextBox";
            RemoveBookNameTextBox.Size = new Size(217, 23);
            RemoveBookNameTextBox.TabIndex = 1;
            // 
            // ISBNNOTextBox
            // 
            ISBNNOTextBox.Location = new Point(342, 116);
            ISBNNOTextBox.Margin = new Padding(2, 1, 2, 1);
            ISBNNOTextBox.Name = "ISBNNOTextBox";
            ISBNNOTextBox.Size = new Size(217, 23);
            ISBNNOTextBox.TabIndex = 2;
            // 
            // ISBNNoLable
            // 
            ISBNNoLable.Anchor = AnchorStyles.Top;
            ISBNNoLable.AutoSize = true;
            ISBNNoLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ISBNNoLable.Location = new Point(113, 113);
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
            BookNameLable.Location = new Point(113, 74);
            BookNameLable.Margin = new Padding(2, 0, 2, 0);
            BookNameLable.Name = "BookNameLable";
            BookNameLable.Size = new Size(106, 24);
            BookNameLable.TabIndex = 0;
            BookNameLable.Text = "Book Name";
            // 
            // RemoveBookLable
            // 
            RemoveBookLable.Anchor = AnchorStyles.Top;
            RemoveBookLable.AutoSize = true;
            RemoveBookLable.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Underline, GraphicsUnit.Point);
            RemoveBookLable.Location = new Point(247, 16);
            RemoveBookLable.Margin = new Padding(2, 0, 2, 0);
            RemoveBookLable.Name = "RemoveBookLable";
            RemoveBookLable.Size = new Size(158, 30);
            RemoveBookLable.TabIndex = 0;
            RemoveBookLable.Text = "Remove Book";
            // 
            // ISBNRadioButton
            // 
            ISBNRadioButton.AutoSize = true;
            ISBNRadioButton.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ISBNRadioButton.Location = new Point(539, 231);
            ISBNRadioButton.Name = "ISBNRadioButton";
            ISBNRadioButton.Size = new Size(83, 25);
            ISBNRadioButton.TabIndex = 0;
            ISBNRadioButton.Text = "ISBN No";
            ISBNRadioButton.UseVisualStyleBackColor = true;
            ISBNRadioButton.CheckedChanged += ISBNRadioButton_CheckedChanged;
            // 
            // BookTitelRadioButton
            // 
            BookTitelRadioButton.AutoSize = true;
            BookTitelRadioButton.Checked = true;
            BookTitelRadioButton.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BookTitelRadioButton.Location = new Point(436, 230);
            BookTitelRadioButton.Name = "BookTitelRadioButton";
            BookTitelRadioButton.Size = new Size(96, 25);
            BookTitelRadioButton.TabIndex = 0;
            BookTitelRadioButton.TabStop = true;
            BookTitelRadioButton.Text = "Book Titel";
            BookTitelRadioButton.UseVisualStyleBackColor = true;
            BookTitelRadioButton.CheckedChanged += BookTitelRadioButton_CheckedChanged;
            // 
            // SearchBookTextRemoveBook
            // 
            SearchBookTextRemoveBook.Location = new Point(193, 232);
            SearchBookTextRemoveBook.Margin = new Padding(2, 1, 2, 1);
            SearchBookTextRemoveBook.Name = "SearchBookTextRemoveBook";
            SearchBookTextRemoveBook.PlaceholderText = "   Search";
            SearchBookTextRemoveBook.Size = new Size(223, 23);
            SearchBookTextRemoveBook.TabIndex = 0;
            SearchBookTextRemoveBook.TextChanged += SearchBookTextRemoveBook_TextChanged;
            // 
            // ClearBtn
            // 
            ClearBtn.AutoSize = true;
            ClearBtn.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.ForeColor = SystemColors.ActiveCaptionText;
            ClearBtn.Location = new Point(490, 141);
            ClearBtn.Margin = new Padding(2, 0, 2, 0);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(65, 16);
            ClearBtn.TabIndex = 0;
            ClearBtn.Text = "Clear Fields";
            ClearBtn.Click += ClearBtn_Click;
            // 
            // RemoveBooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 499);
            Controls.Add(ClearBtn);
            Controls.Add(dataGridView1);
            Controls.Add(ISBNRadioButton);
            Controls.Add(BookTitelRadioButton);
            Controls.Add(SearchBookTextRemoveBook);
            Controls.Add(pictureBox1);
            Controls.Add(RemoveBookBtn);
            Controls.Add(RemoveBookNameTextBox);
            Controls.Add(ISBNNOTextBox);
            Controls.Add(ISBNNoLable);
            Controls.Add(BookNameLable);
            Controls.Add(RemoveBookLable);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "RemoveBooksForm";
            Text = "RemoveBooksForm";
            Load += RemoveBooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button RemoveBookBtn;
        private TextBox RemoveBookNameTextBox;
        private TextBox ISBNNOTextBox;
        private Label ISBNNoLable;
        private Label BookNameLable;
        private Label RemoveBookLable;
        private RadioButton ISBNRadioButton;
        private RadioButton BookTitelRadioButton;
        private TextBox SearchBookTextRemoveBook;
        private DataGridView dataGridView1;
        private Label ClearBtn;
    }
}