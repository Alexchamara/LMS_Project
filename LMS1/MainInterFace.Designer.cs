namespace LMS1
{
    partial class MainInterFace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterFace));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            LibrarianLogInBtn = new Button();
            MemberLogInBtn = new Button();
            BookDetailsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1907, 12);
            button1.Name = "button1";
            button1.Size = new Size(55, 41);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(696, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(577, 340);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(575, 474);
            label2.Name = "label2";
            label2.Size = new Size(829, 81);
            label2.TabIndex = 10;
            label2.Text = "Libarary Managment System";
            // 
            // LibrarianLogInBtn
            // 
            LibrarianLogInBtn.BackColor = Color.FromArgb(51, 51, 76);
            LibrarianLogInBtn.FlatAppearance.BorderSize = 0;
            LibrarianLogInBtn.FlatStyle = FlatStyle.Flat;
            LibrarianLogInBtn.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            LibrarianLogInBtn.ForeColor = Color.White;
            LibrarianLogInBtn.Image = (Image)resources.GetObject("LibrarianLogInBtn.Image");
            LibrarianLogInBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LibrarianLogInBtn.Location = new Point(382, 640);
            LibrarianLogInBtn.Name = "LibrarianLogInBtn";
            LibrarianLogInBtn.Size = new Size(308, 91);
            LibrarianLogInBtn.TabIndex = 11;
            LibrarianLogInBtn.Text = "    Librarian Log In";
            LibrarianLogInBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            LibrarianLogInBtn.UseVisualStyleBackColor = false;
            LibrarianLogInBtn.Click += LibrarianLogInBtn_Click;
            // 
            // MemberLogInBtn
            // 
            MemberLogInBtn.BackColor = Color.FromArgb(51, 51, 76);
            MemberLogInBtn.FlatAppearance.BorderSize = 0;
            MemberLogInBtn.FlatStyle = FlatStyle.Flat;
            MemberLogInBtn.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            MemberLogInBtn.ForeColor = Color.White;
            MemberLogInBtn.Image = (Image)resources.GetObject("MemberLogInBtn.Image");
            MemberLogInBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MemberLogInBtn.Location = new Point(825, 640);
            MemberLogInBtn.Name = "MemberLogInBtn";
            MemberLogInBtn.Size = new Size(308, 91);
            MemberLogInBtn.TabIndex = 12;
            MemberLogInBtn.Text = "    Member Log In";
            MemberLogInBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            MemberLogInBtn.UseVisualStyleBackColor = false;
            MemberLogInBtn.Click += MemberLogInBtn_Click;
            // 
            // BookDetailsBtn
            // 
            BookDetailsBtn.BackColor = Color.FromArgb(51, 51, 76);
            BookDetailsBtn.FlatAppearance.BorderSize = 0;
            BookDetailsBtn.FlatStyle = FlatStyle.Flat;
            BookDetailsBtn.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            BookDetailsBtn.ForeColor = Color.White;
            BookDetailsBtn.Image = (Image)resources.GetObject("BookDetailsBtn.Image");
            BookDetailsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            BookDetailsBtn.Location = new Point(1279, 640);
            BookDetailsBtn.Name = "BookDetailsBtn";
            BookDetailsBtn.Size = new Size(308, 91);
            BookDetailsBtn.TabIndex = 13;
            BookDetailsBtn.Text = "    Book Details";
            BookDetailsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            BookDetailsBtn.UseVisualStyleBackColor = false;
            // 
            // MainInterFace
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1974, 957);
            Controls.Add(BookDetailsBtn);
            Controls.Add(MemberLogInBtn);
            Controls.Add(LibrarianLogInBtn);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainInterFace";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainInterFace";
            Load += MainInterFace_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button LibrarianLogInBtn;
        private Button MemberLogInBtn;
        private Button BookDetailsBtn;
    }
}