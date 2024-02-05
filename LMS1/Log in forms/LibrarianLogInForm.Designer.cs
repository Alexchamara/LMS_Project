namespace LMS1
{
    partial class LibrarianLogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianLogInForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            LibrarianUserNaneTextBox = new TextBox();
            LibrarianLogInNameLable = new Label();
            Password = new Label();
            LibrarianLogInPassword = new TextBox();
            button1 = new Button();
            LibrarianLogInFormBtn = new Button();
            ClearBtn = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(87, 27);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(76, 187);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 30);
            label1.TabIndex = 0;
            label1.Text = "Librarian Log In";
            // 
            // LibrarianUserNaneTextBox
            // 
            LibrarianUserNaneTextBox.Location = new Point(131, 238);
            LibrarianUserNaneTextBox.Margin = new Padding(2, 1, 2, 1);
            LibrarianUserNaneTextBox.Name = "LibrarianUserNaneTextBox";
            LibrarianUserNaneTextBox.Size = new Size(188, 23);
            LibrarianUserNaneTextBox.TabIndex = 1;
            // 
            // LibrarianLogInNameLable
            // 
            LibrarianLogInNameLable.Anchor = AnchorStyles.Top;
            LibrarianLogInNameLable.AutoSize = true;
            LibrarianLogInNameLable.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LibrarianLogInNameLable.ForeColor = SystemColors.Control;
            LibrarianLogInNameLable.Location = new Point(20, 235);
            LibrarianLogInNameLable.Margin = new Padding(2, 0, 2, 0);
            LibrarianLogInNameLable.Name = "LibrarianLogInNameLable";
            LibrarianLogInNameLable.Size = new Size(58, 21);
            LibrarianLogInNameLable.TabIndex = 0;
            LibrarianLogInNameLable.Text = "User ID";
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.Top;
            Password.AutoSize = true;
            Password.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = SystemColors.Control;
            Password.Location = new Point(20, 277);
            Password.Margin = new Padding(2, 0, 2, 0);
            Password.Name = "Password";
            Password.Size = new Size(76, 21);
            Password.TabIndex = 0;
            Password.Tag = "";
            Password.Text = "Password";
            // 
            // LibrarianLogInPassword
            // 
            LibrarianLogInPassword.Location = new Point(131, 280);
            LibrarianLogInPassword.Margin = new Padding(2, 1, 2, 1);
            LibrarianLogInPassword.Name = "LibrarianLogInPassword";
            LibrarianLogInPassword.Size = new Size(188, 23);
            LibrarianLogInPassword.TabIndex = 2;
            LibrarianLogInPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(323, 6);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(15, 14);
            button1.TabIndex = 28;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LibrarianLogInFormBtn
            // 
            LibrarianLogInFormBtn.BackColor = SystemColors.ControlLight;
            LibrarianLogInFormBtn.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            LibrarianLogInFormBtn.Image = (Image)resources.GetObject("LibrarianLogInFormBtn.Image");
            LibrarianLogInFormBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LibrarianLogInFormBtn.Location = new Point(20, 332);
            LibrarianLogInFormBtn.Margin = new Padding(2, 1, 2, 1);
            LibrarianLogInFormBtn.Name = "LibrarianLogInFormBtn";
            LibrarianLogInFormBtn.Size = new Size(297, 28);
            LibrarianLogInFormBtn.TabIndex = 3;
            LibrarianLogInFormBtn.Text = "    Log In";
            LibrarianLogInFormBtn.UseVisualStyleBackColor = false;
            LibrarianLogInFormBtn.Click += LibrarianLogInFormBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.AutoSize = true;
            ClearBtn.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.ForeColor = SystemColors.Control;
            ClearBtn.Location = new Point(243, 305);
            ClearBtn.Margin = new Padding(2, 0, 2, 0);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(65, 16);
            ClearBtn.TabIndex = 0;
            ClearBtn.Text = "Clear Fields";
            ClearBtn.Click += ClearBtn_Click;
            // 
            // LibrarianLogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 87, 163);
            ClientSize = new Size(345, 382);
            Controls.Add(ClearBtn);
            Controls.Add(LibrarianLogInFormBtn);
            Controls.Add(button1);
            Controls.Add(LibrarianLogInPassword);
            Controls.Add(LibrarianUserNaneTextBox);
            Controls.Add(Password);
            Controls.Add(LibrarianLogInNameLable);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "LibrarianLogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LibrarianLogInForm";
            Load += LibrarianLogInForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox LibrarianUserNaneTextBox;
        private Label LibrarianLogInNameLable;
        private Label Password;
        private TextBox LibrarianLogInPassword;
        private Button button1;
        private Button LibrarianLogInFormBtn;
        private Label ClearBtn;
    }
}