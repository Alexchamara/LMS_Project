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
            pictureBox1 = new PictureBox();
            RemoveBookBtn = new Button();
            RemoveBookNameTextBox = new TextBox();
            ISBNNOTextBox = new TextBox();
            ISBNNoLable = new Label();
            BookNameLable = new Label();
            RemoveBookLable = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1153, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // RemoveBookBtn
            // 
            RemoveBookBtn.BackColor = Color.FromArgb(246, 174, 0);
            RemoveBookBtn.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveBookBtn.ForeColor = SystemColors.Control;
            RemoveBookBtn.Location = new Point(694, 333);
            RemoveBookBtn.Name = "RemoveBookBtn";
            RemoveBookBtn.Size = new Size(341, 58);
            RemoveBookBtn.TabIndex = 18;
            RemoveBookBtn.Text = "Remove Book";
            RemoveBookBtn.UseVisualStyleBackColor = false;
            RemoveBookBtn.Click += RemoveBookBtn_Click;
            // 
            // RemoveBookNameTextBox
            // 
            RemoveBookNameTextBox.Location = new Point(635, 163);
            RemoveBookNameTextBox.Name = "RemoveBookNameTextBox";
            RemoveBookNameTextBox.Size = new Size(400, 39);
            RemoveBookNameTextBox.TabIndex = 16;
            // 
            // ISBNNOTextBox
            // 
            ISBNNOTextBox.Location = new Point(635, 248);
            ISBNNOTextBox.Name = "ISBNNOTextBox";
            ISBNNOTextBox.Size = new Size(400, 39);
            ISBNNOTextBox.TabIndex = 17;
            // 
            // ISBNNoLable
            // 
            ISBNNoLable.Anchor = AnchorStyles.Top;
            ISBNNoLable.AutoSize = true;
            ISBNNoLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ISBNNoLable.Location = new Point(391, 242);
            ISBNNoLable.Name = "ISBNNoLable";
            ISBNNoLable.Size = new Size(149, 43);
            ISBNNoLable.TabIndex = 14;
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
            BookNameLable.TabIndex = 15;
            BookNameLable.Text = "Book Name";
            // 
            // RemoveBookLable
            // 
            RemoveBookLable.Anchor = AnchorStyles.Top;
            RemoveBookLable.AutoSize = true;
            RemoveBookLable.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Underline, GraphicsUnit.Point);
            RemoveBookLable.Location = new Point(641, 34);
            RemoveBookLable.Name = "RemoveBookLable";
            RemoveBookLable.Size = new Size(313, 61);
            RemoveBookLable.TabIndex = 13;
            RemoveBookLable.Text = "Remove Book";
            // 
            // RemoveBooksForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 897);
            Controls.Add(pictureBox1);
            Controls.Add(RemoveBookBtn);
            Controls.Add(RemoveBookNameTextBox);
            Controls.Add(ISBNNOTextBox);
            Controls.Add(ISBNNoLable);
            Controls.Add(BookNameLable);
            Controls.Add(RemoveBookLable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RemoveBooksForm";
            Text = "RemoveBooksForm";
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
    }
}