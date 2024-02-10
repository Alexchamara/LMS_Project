namespace LMS1
{
    partial class SearchBook
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
            components = new System.ComponentModel.Container();
            SearchBookTextBook = new TextBox();
            dataGridView1 = new DataGridView();
            bookBindingSource = new BindingSource(components);
            BookTitelRadioButton = new RadioButton();
            ISBNRadioButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // SearchBookTextBook
            // 
            SearchBookTextBook.BorderStyle = BorderStyle.FixedSingle;
            SearchBookTextBook.Location = new Point(198, 34);
            SearchBookTextBook.Margin = new Padding(2, 1, 2, 1);
            SearchBookTextBook.Name = "SearchBookTextBook";
            SearchBookTextBook.PlaceholderText = "   Search";
            SearchBookTextBook.Size = new Size(222, 23);
            SearchBookTextBook.TabIndex = 1;
            SearchBookTextBook.TextChanged += SearchBookTextBook_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 68);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(808, 384);
            dataGridView1.TabIndex = 2;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Classes.Book);
            // 
            // BookTitelRadioButton
            // 
            BookTitelRadioButton.AutoSize = true;
            BookTitelRadioButton.Checked = true;
            BookTitelRadioButton.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BookTitelRadioButton.Location = new Point(438, 33);
            BookTitelRadioButton.Name = "BookTitelRadioButton";
            BookTitelRadioButton.Size = new Size(96, 25);
            BookTitelRadioButton.TabIndex = 4;
            BookTitelRadioButton.TabStop = true;
            BookTitelRadioButton.Text = "Book Title";
            BookTitelRadioButton.UseVisualStyleBackColor = true;
            BookTitelRadioButton.CheckedChanged += BookTitelRadioButton_CheckedChanged;
            // 
            // ISBNRadioButton
            // 
            ISBNRadioButton.AutoSize = true;
            ISBNRadioButton.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ISBNRadioButton.Location = new Point(546, 33);
            ISBNRadioButton.Name = "ISBNRadioButton";
            ISBNRadioButton.Size = new Size(83, 25);
            ISBNRadioButton.TabIndex = 5;
            ISBNRadioButton.Text = "ISBN No";
            ISBNRadioButton.UseVisualStyleBackColor = true;
            ISBNRadioButton.CheckedChanged += ISBNRadioButton_CheckedChanged;
            // 
            // SearchBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 458);
            Controls.Add(ISBNRadioButton);
            Controls.Add(BookTitelRadioButton);
            Controls.Add(dataGridView1);
            Controls.Add(SearchBookTextBook);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "SearchBook";
            Text = "SearchBook";
            Load += SearchBook_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox SearchBookTextBook;
        private DataGridView dataGridView1;
        private BindingSource bookBindingSource;
        private RadioButton BookTitelRadioButton;
        private RadioButton ISBNRadioButton;
    }
}