namespace LMS1
{
    partial class MemberLogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberLogInForm));
            ClearBtn = new Label();
            MemberLogInFormBtn = new Button();
            button1 = new Button();
            MemberLogInPassword = new TextBox();
            MemberUserNaneTextBox = new TextBox();
            Password = new Label();
            MemberLogInNameLable = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ClearBtn
            // 
            ClearBtn.AutoSize = true;
            ClearBtn.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.ForeColor = SystemColors.Control;
            ClearBtn.Location = new Point(242, 305);
            ClearBtn.Margin = new Padding(2, 0, 2, 0);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(65, 16);
            ClearBtn.TabIndex = 0;
            ClearBtn.Text = "Clear Fields";
            ClearBtn.Click += ClearBtn_Click;
            // 
            // MemberLogInFormBtn
            // 
            MemberLogInFormBtn.BackColor = SystemColors.ControlLight;
            MemberLogInFormBtn.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            MemberLogInFormBtn.Image = (Image)resources.GetObject("MemberLogInFormBtn.Image");
            MemberLogInFormBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MemberLogInFormBtn.Location = new Point(19, 332);
            MemberLogInFormBtn.Margin = new Padding(2, 1, 2, 1);
            MemberLogInFormBtn.Name = "MemberLogInFormBtn";
            MemberLogInFormBtn.Size = new Size(297, 28);
            MemberLogInFormBtn.TabIndex = 3;
            MemberLogInFormBtn.Text = "    Log In";
            MemberLogInFormBtn.UseVisualStyleBackColor = false;
            MemberLogInFormBtn.Click += MemberLogInFormBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(322, 6);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(15, 14);
            button1.TabIndex = 36;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MemberLogInPassword
            // 
            MemberLogInPassword.Location = new Point(130, 280);
            MemberLogInPassword.Margin = new Padding(2, 1, 2, 1);
            MemberLogInPassword.Name = "MemberLogInPassword";
            MemberLogInPassword.Size = new Size(188, 23);
            MemberLogInPassword.TabIndex = 2;
            MemberLogInPassword.UseSystemPasswordChar = true;
            // 
            // MemberUserNaneTextBox
            // 
            MemberUserNaneTextBox.Location = new Point(130, 238);
            MemberUserNaneTextBox.Margin = new Padding(2, 1, 2, 1);
            MemberUserNaneTextBox.Name = "MemberUserNaneTextBox";
            MemberUserNaneTextBox.Size = new Size(188, 23);
            MemberUserNaneTextBox.TabIndex = 1;
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.Top;
            Password.AutoSize = true;
            Password.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = SystemColors.Control;
            Password.Location = new Point(19, 277);
            Password.Margin = new Padding(2, 0, 2, 0);
            Password.Name = "Password";
            Password.Size = new Size(76, 21);
            Password.TabIndex = 0;
            Password.Tag = "";
            Password.Text = "Password";
            // 
            // MemberLogInNameLable
            // 
            MemberLogInNameLable.Anchor = AnchorStyles.Top;
            MemberLogInNameLable.AutoSize = true;
            MemberLogInNameLable.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MemberLogInNameLable.ForeColor = SystemColors.Control;
            MemberLogInNameLable.Location = new Point(19, 235);
            MemberLogInNameLable.Margin = new Padding(2, 0, 2, 0);
            MemberLogInNameLable.Name = "MemberLogInNameLable";
            MemberLogInNameLable.Size = new Size(58, 21);
            MemberLogInNameLable.TabIndex = 0;
            MemberLogInNameLable.Text = "User ID";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 27);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(74, 184);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 30);
            label1.TabIndex = 0;
            label1.Text = "Member Log In";
            // 
            // MemberLogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 87, 163);
            ClientSize = new Size(345, 382);
            Controls.Add(label1);
            Controls.Add(ClearBtn);
            Controls.Add(MemberLogInFormBtn);
            Controls.Add(button1);
            Controls.Add(MemberLogInPassword);
            Controls.Add(MemberUserNaneTextBox);
            Controls.Add(Password);
            Controls.Add(MemberLogInNameLable);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "MemberLogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberLogInForm";
            Load += MemberLogInForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ClearBtn;
        private Button MemberLogInFormBtn;
        private Button button1;
        private TextBox MemberLogInPassword;
        private TextBox MemberUserNaneTextBox;
        private Label Password;
        private Label MemberLogInNameLable;
        private PictureBox pictureBox1;
        private Label label1;
    }
}