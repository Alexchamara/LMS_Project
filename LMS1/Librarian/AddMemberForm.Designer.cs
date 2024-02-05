namespace LMS1
{
    partial class AddMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMemberForm));
            pictureBox1 = new PictureBox();
            AddMemberBtn = new Button();
            AddMemberNameTextBox = new TextBox();
            AddMembershipIdTextBox = new TextBox();
            AddNICTextBox = new TextBox();
            AddEmailTextBox = new TextBox();
            EmailLable = new Label();
            ContactLable = new Label();
            NICLable = new Label();
            MembershipIdNoLable = new Label();
            MemberNameLable = new Label();
            AddMemberLable = new Label();
            MemberContactTexBox = new TextBox();
            MemberLoginPasswordTextBox = new TextBox();
            label1 = new Label();
            ClearBtn = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(655, 116);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // AddMemberBtn
            // 
            AddMemberBtn.BackColor = Color.FromArgb(246, 174, 0);
            AddMemberBtn.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            AddMemberBtn.ForeColor = SystemColors.Control;
            AddMemberBtn.Location = new Point(397, 324);
            AddMemberBtn.Margin = new Padding(2, 1, 2, 1);
            AddMemberBtn.Name = "AddMemberBtn";
            AddMemberBtn.Size = new Size(184, 27);
            AddMemberBtn.TabIndex = 7;
            AddMemberBtn.Text = "Add Member";
            AddMemberBtn.UseVisualStyleBackColor = false;
            AddMemberBtn.Click += AddMemberBtn_Click;
            // 
            // AddMemberNameTextBox
            // 
            AddMemberNameTextBox.Location = new Point(364, 76);
            AddMemberNameTextBox.Margin = new Padding(2, 1, 2, 1);
            AddMemberNameTextBox.Name = "AddMemberNameTextBox";
            AddMemberNameTextBox.Size = new Size(217, 23);
            AddMemberNameTextBox.TabIndex = 1;
            // 
            // AddMembershipIdTextBox
            // 
            AddMembershipIdTextBox.Location = new Point(364, 116);
            AddMembershipIdTextBox.Margin = new Padding(2, 1, 2, 1);
            AddMembershipIdTextBox.Name = "AddMembershipIdTextBox";
            AddMembershipIdTextBox.Size = new Size(217, 23);
            AddMembershipIdTextBox.TabIndex = 2;
            // 
            // AddNICTextBox
            // 
            AddNICTextBox.Location = new Point(364, 156);
            AddNICTextBox.Margin = new Padding(2, 1, 2, 1);
            AddNICTextBox.Name = "AddNICTextBox";
            AddNICTextBox.Size = new Size(217, 23);
            AddNICTextBox.TabIndex = 3;
            // 
            // AddEmailTextBox
            // 
            AddEmailTextBox.Location = new Point(364, 236);
            AddEmailTextBox.Margin = new Padding(2, 1, 2, 1);
            AddEmailTextBox.Name = "AddEmailTextBox";
            AddEmailTextBox.Size = new Size(217, 23);
            AddEmailTextBox.TabIndex = 5;
            // 
            // EmailLable
            // 
            EmailLable.Anchor = AnchorStyles.Top;
            EmailLable.AutoSize = true;
            EmailLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLable.Location = new Point(211, 233);
            EmailLable.Margin = new Padding(2, 0, 2, 0);
            EmailLable.Name = "EmailLable";
            EmailLable.Size = new Size(62, 24);
            EmailLable.TabIndex = 0;
            EmailLable.Text = "E-mail";
            // 
            // ContactLable
            // 
            ContactLable.Anchor = AnchorStyles.Top;
            ContactLable.AutoSize = true;
            ContactLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ContactLable.Location = new Point(211, 193);
            ContactLable.Margin = new Padding(2, 0, 2, 0);
            ContactLable.Name = "ContactLable";
            ContactLable.Size = new Size(72, 24);
            ContactLable.TabIndex = 0;
            ContactLable.Text = "Contact";
            // 
            // NICLable
            // 
            NICLable.Anchor = AnchorStyles.Top;
            NICLable.AutoSize = true;
            NICLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            NICLable.Location = new Point(211, 153);
            NICLable.Margin = new Padding(2, 0, 2, 0);
            NICLable.Name = "NICLable";
            NICLable.Size = new Size(38, 24);
            NICLable.TabIndex = 0;
            NICLable.Text = "NIC";
            // 
            // MembershipIdNoLable
            // 
            MembershipIdNoLable.Anchor = AnchorStyles.Top;
            MembershipIdNoLable.AutoSize = true;
            MembershipIdNoLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            MembershipIdNoLable.Location = new Point(211, 113);
            MembershipIdNoLable.Margin = new Padding(2, 0, 2, 0);
            MembershipIdNoLable.Name = "MembershipIdNoLable";
            MembershipIdNoLable.Size = new Size(134, 24);
            MembershipIdNoLable.TabIndex = 0;
            MembershipIdNoLable.Text = "Membership ID";
            // 
            // MemberNameLable
            // 
            MemberNameLable.Anchor = AnchorStyles.Top;
            MemberNameLable.AutoSize = true;
            MemberNameLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            MemberNameLable.Location = new Point(211, 74);
            MemberNameLable.Margin = new Padding(2, 0, 2, 0);
            MemberNameLable.Name = "MemberNameLable";
            MemberNameLable.Size = new Size(94, 24);
            MemberNameLable.TabIndex = 0;
            MemberNameLable.Text = "Full Name";
            // 
            // AddMemberLable
            // 
            AddMemberLable.Anchor = AnchorStyles.Top;
            AddMemberLable.AutoSize = true;
            AddMemberLable.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Underline, GraphicsUnit.Point);
            AddMemberLable.Location = new Point(345, 16);
            AddMemberLable.Margin = new Padding(2, 0, 2, 0);
            AddMemberLable.Name = "AddMemberLable";
            AddMemberLable.Size = new Size(145, 30);
            AddMemberLable.TabIndex = 0;
            AddMemberLable.Text = "Add Member";
            // 
            // MemberContactTexBox
            // 
            MemberContactTexBox.Location = new Point(364, 195);
            MemberContactTexBox.Margin = new Padding(2, 1, 2, 1);
            MemberContactTexBox.Name = "MemberContactTexBox";
            MemberContactTexBox.Size = new Size(217, 23);
            MemberContactTexBox.TabIndex = 4;
            // 
            // MemberLoginPasswordTextBox
            // 
            MemberLoginPasswordTextBox.Location = new Point(364, 277);
            MemberLoginPasswordTextBox.Margin = new Padding(2, 1, 2, 1);
            MemberLoginPasswordTextBox.Name = "MemberLoginPasswordTextBox";
            MemberLoginPasswordTextBox.Size = new Size(217, 23);
            MemberLoginPasswordTextBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(211, 277);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 24);
            label1.TabIndex = 33;
            label1.Text = "Login Password";
            // 
            // ClearBtn
            // 
            ClearBtn.AutoSize = true;
            ClearBtn.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.ForeColor = SystemColors.ActiveCaptionText;
            ClearBtn.Location = new Point(513, 301);
            ClearBtn.Margin = new Padding(2, 0, 2, 0);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(65, 16);
            ClearBtn.TabIndex = 0;
            ClearBtn.Text = "Clear Fields";
            ClearBtn.Click += ClearBtn_Click;
            // 
            // AddMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 420);
            Controls.Add(ClearBtn);
            Controls.Add(MemberLoginPasswordTextBox);
            Controls.Add(label1);
            Controls.Add(MemberContactTexBox);
            Controls.Add(pictureBox1);
            Controls.Add(AddMemberBtn);
            Controls.Add(AddMemberNameTextBox);
            Controls.Add(AddMembershipIdTextBox);
            Controls.Add(AddNICTextBox);
            Controls.Add(AddEmailTextBox);
            Controls.Add(EmailLable);
            Controls.Add(ContactLable);
            Controls.Add(NICLable);
            Controls.Add(MembershipIdNoLable);
            Controls.Add(MemberNameLable);
            Controls.Add(AddMemberLable);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "AddMemberForm";
            Text = "AddMemberForm";
            Load += AddMemberForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button AddMemberBtn;
        private TextBox AddMemberNameTextBox;
        private TextBox AddMembershipIdTextBox;
        private TextBox AddNICTextBox;
        private TextBox AddEmailTextBox;
        private Label EmailLable;
        private Label ContactLable;
        private Label NICLable;
        private Label MembershipIdNoLable;
        private Label MemberNameLable;
        private Label AddMemberLable;
        private TextBox MemberContactTexBox;
        private TextBox MemberLoginPasswordTextBox;
        private Label label1;
        private Label ClearBtn;
    }
}