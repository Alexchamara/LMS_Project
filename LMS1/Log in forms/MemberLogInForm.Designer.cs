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
            ClearBtn.Location = new Point(450, 650);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(134, 30);
            ClearBtn.TabIndex = 38;
            ClearBtn.Text = "Clear Fields";
            ClearBtn.Click += ClearBtn_Click;
            // 
            // MemberLogInFormBtn
            // 
            MemberLogInFormBtn.BackColor = SystemColors.ControlLight;
            MemberLogInFormBtn.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            MemberLogInFormBtn.Image = (Image)resources.GetObject("MemberLogInFormBtn.Image");
            MemberLogInFormBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MemberLogInFormBtn.Location = new Point(35, 708);
            MemberLogInFormBtn.Name = "MemberLogInFormBtn";
            MemberLogInFormBtn.Size = new Size(551, 59);
            MemberLogInFormBtn.TabIndex = 37;
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
            button1.Location = new Point(598, 12);
            button1.Name = "button1";
            button1.Size = new Size(28, 29);
            button1.TabIndex = 36;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MemberLogInPassword
            // 
            MemberLogInPassword.Location = new Point(241, 597);
            MemberLogInPassword.Name = "MemberLogInPassword";
            MemberLogInPassword.Size = new Size(345, 39);
            MemberLogInPassword.TabIndex = 34;
            MemberLogInPassword.UseSystemPasswordChar = true;
            // 
            // MemberUserNaneTextBox
            // 
            MemberUserNaneTextBox.Location = new Point(241, 507);
            MemberUserNaneTextBox.Name = "MemberUserNaneTextBox";
            MemberUserNaneTextBox.Size = new Size(345, 39);
            MemberUserNaneTextBox.TabIndex = 1;
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.Top;
            Password.AutoSize = true;
            Password.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = SystemColors.Control;
            Password.Location = new Point(35, 591);
            Password.Name = "Password";
            Password.Size = new Size(150, 37);
            Password.TabIndex = 32;
            Password.Tag = "";
            Password.Text = "Password";
            // 
            // MemberLogInNameLable
            // 
            MemberLogInNameLable.Anchor = AnchorStyles.Top;
            MemberLogInNameLable.AutoSize = true;
            MemberLogInNameLable.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MemberLogInNameLable.ForeColor = SystemColors.Control;
            MemberLogInNameLable.Location = new Point(35, 501);
            MemberLogInNameLable.Name = "MemberLogInNameLable";
            MemberLogInNameLable.Size = new Size(170, 37);
            MemberLogInNameLable.TabIndex = 33;
            MemberLogInNameLable.Text = "User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(160, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 380);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(138, 392);
            label1.Name = "label1";
            label1.Size = new Size(349, 61);
            label1.TabIndex = 39;
            label1.Text = "Member Log In";
            // 
            // MemberLogInForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 87, 163);
            ClientSize = new Size(640, 815);
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