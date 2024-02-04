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
            pictureBox1.Location = new Point(162, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 380);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(142, 398);
            label1.Name = "label1";
            label1.Size = new Size(364, 61);
            label1.TabIndex = 1;
            label1.Text = "Librarian Log In";
            // 
            // LibrarianUserNaneTextBox
            // 
            LibrarianUserNaneTextBox.Location = new Point(243, 507);
            LibrarianUserNaneTextBox.Name = "LibrarianUserNaneTextBox";
            LibrarianUserNaneTextBox.Size = new Size(345, 39);
            LibrarianUserNaneTextBox.TabIndex = 1;
            // 
            // LibrarianLogInNameLable
            // 
            LibrarianLogInNameLable.Anchor = AnchorStyles.Top;
            LibrarianLogInNameLable.AutoSize = true;
            LibrarianLogInNameLable.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LibrarianLogInNameLable.ForeColor = SystemColors.Control;
            LibrarianLogInNameLable.Location = new Point(37, 501);
            LibrarianLogInNameLable.Name = "LibrarianLogInNameLable";
            LibrarianLogInNameLable.Size = new Size(170, 37);
            LibrarianLogInNameLable.TabIndex = 26;
            LibrarianLogInNameLable.Text = "User Name";
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.Top;
            Password.AutoSize = true;
            Password.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = SystemColors.Control;
            Password.Location = new Point(37, 591);
            Password.Name = "Password";
            Password.Size = new Size(150, 37);
            Password.TabIndex = 26;
            Password.Tag = "";
            Password.Text = "Password";
            // 
            // LibrarianLogInPassword
            // 
            LibrarianLogInPassword.Location = new Point(243, 597);
            LibrarianLogInPassword.Name = "LibrarianLogInPassword";
            LibrarianLogInPassword.Size = new Size(345, 39);
            LibrarianLogInPassword.TabIndex = 27;
            LibrarianLogInPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(600, 12);
            button1.Name = "button1";
            button1.Size = new Size(28, 29);
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
            LibrarianLogInFormBtn.Location = new Point(37, 708);
            LibrarianLogInFormBtn.Name = "LibrarianLogInFormBtn";
            LibrarianLogInFormBtn.Size = new Size(551, 59);
            LibrarianLogInFormBtn.TabIndex = 29;
            LibrarianLogInFormBtn.Text = "    Log In";
            LibrarianLogInFormBtn.UseVisualStyleBackColor = false;
            LibrarianLogInFormBtn.Click += LibrarianLogInFormBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.AutoSize = true;
            ClearBtn.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.ForeColor = SystemColors.Control;
            ClearBtn.Location = new Point(452, 650);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(134, 30);
            ClearBtn.TabIndex = 30;
            ClearBtn.Text = "Clear Fields";
            ClearBtn.Click += ClearBtn_Click;
            // 
            // LibrarianLogInForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 87, 163);
            ClientSize = new Size(640, 815);
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