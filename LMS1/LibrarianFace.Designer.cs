namespace LMS1
{
    partial class LibrarianFace
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianFace));
            panel1 = new Panel();
            searchBookBtn = new Button();
            label1 = new Label();
            SidePanel = new Panel();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            removeMemberBtn = new Button();
            addMemberBtn = new Button();
            removeBookBtn = new Button();
            addBookBtn = new Button();
            label2 = new Label();
            button1 = new Button();
            LibrarianMainPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(searchBookBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(removeMemberBtn);
            panel1.Controls.Add(addMemberBtn);
            panel1.Controls.Add(removeBookBtn);
            panel1.Controls.Add(addBookBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 957);
            panel1.TabIndex = 0;
            // 
            // searchBookBtn
            // 
            searchBookBtn.FlatAppearance.BorderSize = 0;
            searchBookBtn.FlatStyle = FlatStyle.Flat;
            searchBookBtn.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            searchBookBtn.ForeColor = Color.White;
            searchBookBtn.Image = (Image)resources.GetObject("searchBookBtn.Image");
            searchBookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchBookBtn.Location = new Point(16, 740);
            searchBookBtn.Margin = new Padding(4, 2, 4, 2);
            searchBookBtn.Name = "searchBookBtn";
            searchBookBtn.Size = new Size(383, 92);
            searchBookBtn.TabIndex = 2;
            searchBookBtn.Text = "        Search Book";
            searchBookBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchBookBtn.UseVisualStyleBackColor = true;
            searchBookBtn.Click += searchBookBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(104, 279);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 37);
            label1.TabIndex = 1;
            label1.Text = "Hi Librarian !";
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(178, 8, 55);
            SidePanel.Location = new Point(4, 354);
            SidePanel.Margin = new Padding(4, 2, 4, 2);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(15, 92);
            SidePanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 75);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(89, 854);
            button5.Margin = new Padding(4, 2, 4, 2);
            button5.Name = "button5";
            button5.Size = new Size(199, 65);
            button5.TabIndex = 1;
            button5.Text = "    Log Out";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // removeMemberBtn
            // 
            removeMemberBtn.FlatAppearance.BorderSize = 0;
            removeMemberBtn.FlatStyle = FlatStyle.Flat;
            removeMemberBtn.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            removeMemberBtn.ForeColor = Color.White;
            removeMemberBtn.Image = (Image)resources.GetObject("removeMemberBtn.Image");
            removeMemberBtn.ImageAlign = ContentAlignment.MiddleLeft;
            removeMemberBtn.Location = new Point(19, 644);
            removeMemberBtn.Margin = new Padding(4, 2, 4, 2);
            removeMemberBtn.Name = "removeMemberBtn";
            removeMemberBtn.Size = new Size(383, 92);
            removeMemberBtn.TabIndex = 1;
            removeMemberBtn.Text = "        Remove Member";
            removeMemberBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            removeMemberBtn.UseVisualStyleBackColor = true;
            removeMemberBtn.Click += removeMemberBtn_Click;
            // 
            // addMemberBtn
            // 
            addMemberBtn.FlatAppearance.BorderSize = 0;
            addMemberBtn.FlatStyle = FlatStyle.Flat;
            addMemberBtn.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            addMemberBtn.ForeColor = Color.White;
            addMemberBtn.Image = (Image)resources.GetObject("addMemberBtn.Image");
            addMemberBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addMemberBtn.Location = new Point(19, 548);
            addMemberBtn.Margin = new Padding(4, 2, 4, 2);
            addMemberBtn.Name = "addMemberBtn";
            addMemberBtn.Size = new Size(383, 92);
            addMemberBtn.TabIndex = 1;
            addMemberBtn.Text = "        Add Member";
            addMemberBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addMemberBtn.UseVisualStyleBackColor = true;
            addMemberBtn.Click += addMemberBtn_Click;
            // 
            // removeBookBtn
            // 
            removeBookBtn.FlatAppearance.BorderSize = 0;
            removeBookBtn.FlatStyle = FlatStyle.Flat;
            removeBookBtn.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            removeBookBtn.ForeColor = Color.White;
            removeBookBtn.Image = (Image)resources.GetObject("removeBookBtn.Image");
            removeBookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            removeBookBtn.Location = new Point(19, 450);
            removeBookBtn.Margin = new Padding(4, 2, 4, 2);
            removeBookBtn.Name = "removeBookBtn";
            removeBookBtn.Size = new Size(383, 92);
            removeBookBtn.TabIndex = 1;
            removeBookBtn.Text = "        Remove Book";
            removeBookBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            removeBookBtn.UseVisualStyleBackColor = true;
            removeBookBtn.Click += removeBookBtn_Click;
            // 
            // addBookBtn
            // 
            addBookBtn.FlatAppearance.BorderSize = 0;
            addBookBtn.FlatStyle = FlatStyle.Flat;
            addBookBtn.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            addBookBtn.ForeColor = Color.White;
            addBookBtn.Image = (Image)resources.GetObject("addBookBtn.Image");
            addBookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addBookBtn.Location = new Point(19, 354);
            addBookBtn.Margin = new Padding(4, 2, 4, 2);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(383, 92);
            addBookBtn.TabIndex = 1;
            addBookBtn.Text = "        Add Book";
            addBookBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addBookBtn.UseVisualStyleBackColor = true;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(405, 2);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(839, 61);
            label2.TabIndex = 2;
            label2.Text = "Libarary Managment System - Librarian";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1907, 12);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(56, 53);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LibrarianMainPanel
            // 
            LibrarianMainPanel.Dock = DockStyle.Bottom;
            LibrarianMainPanel.Location = new Point(399, 61);
            LibrarianMainPanel.Margin = new Padding(4, 2, 4, 2);
            LibrarianMainPanel.Name = "LibrarianMainPanel";
            LibrarianMainPanel.Size = new Size(1575, 896);
            LibrarianMainPanel.TabIndex = 4;
            // 
            // LibrarianFace
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1974, 957);
            Controls.Add(LibrarianMainPanel);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
            Name = "LibrarianFace";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LibrarianFace_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button addBookBtn;
        private Button removeMemberBtn;
        private Button addMemberBtn;
        private Button removeBookBtn;
        private Button button5;
        private PictureBox pictureBox1;
        private Panel SidePanel;
        private Label label1;
        private Label label2;
        private Button button1;
        private Panel LibrarianMainPanel;
        private Button searchBookBtn;
    }
}
