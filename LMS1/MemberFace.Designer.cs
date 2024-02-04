namespace LMS1
{
    partial class MemberFace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberFace));
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            SidePanel = new Panel();
            button5 = new Button();
            searchBookBtn = new Button();
            borrowedBookBtn = new Button();
            returnBookBtn = new Button();
            borrowBookBtn = new Button();
            MemberMainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(405, 3);
            label2.Name = "label2";
            label2.Size = new Size(785, 61);
            label2.TabIndex = 6;
            label2.Text = "Libarary Managment Syste - Member";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(104, 279);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 1;
            label1.Text = "Hi Member !";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(searchBookBtn);
            panel1.Controls.Add(borrowedBookBtn);
            panel1.Controls.Add(returnBookBtn);
            panel1.Controls.Add(borrowBookBtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 957);
            panel1.TabIndex = 5;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(178, 8, 55);
            SidePanel.Location = new Point(3, 394);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(15, 91);
            SidePanel.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(89, 796);
            button5.Name = "button5";
            button5.Size = new Size(198, 62);
            button5.TabIndex = 1;
            button5.Text = "    Log Out";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // searchBookBtn
            // 
            searchBookBtn.FlatAppearance.BorderSize = 0;
            searchBookBtn.FlatStyle = FlatStyle.Flat;
            searchBookBtn.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            searchBookBtn.ForeColor = Color.White;
            searchBookBtn.Image = (Image)resources.GetObject("searchBookBtn.Image");
            searchBookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchBookBtn.Location = new Point(18, 685);
            searchBookBtn.Name = "searchBookBtn";
            searchBookBtn.Size = new Size(382, 91);
            searchBookBtn.TabIndex = 1;
            searchBookBtn.Text = "        Search Book";
            searchBookBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchBookBtn.UseVisualStyleBackColor = true;
            searchBookBtn.Click += searchBookBtn_Click;
            // 
            // borrowedBookBtn
            // 
            borrowedBookBtn.FlatAppearance.BorderSize = 0;
            borrowedBookBtn.FlatStyle = FlatStyle.Flat;
            borrowedBookBtn.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            borrowedBookBtn.ForeColor = Color.White;
            borrowedBookBtn.Image = (Image)resources.GetObject("borrowedBookBtn.Image");
            borrowedBookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            borrowedBookBtn.Location = new Point(18, 588);
            borrowedBookBtn.Name = "borrowedBookBtn";
            borrowedBookBtn.Size = new Size(382, 91);
            borrowedBookBtn.TabIndex = 1;
            borrowedBookBtn.Text = "        Borrowed Book";
            borrowedBookBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            borrowedBookBtn.UseVisualStyleBackColor = true;
            borrowedBookBtn.Click += borrowedBookBtn_Click;
            // 
            // returnBookBtn
            // 
            returnBookBtn.FlatAppearance.BorderSize = 0;
            returnBookBtn.FlatStyle = FlatStyle.Flat;
            returnBookBtn.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            returnBookBtn.ForeColor = Color.White;
            returnBookBtn.Image = (Image)resources.GetObject("returnBookBtn.Image");
            returnBookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            returnBookBtn.Location = new Point(18, 491);
            returnBookBtn.Name = "returnBookBtn";
            returnBookBtn.Size = new Size(382, 91);
            returnBookBtn.TabIndex = 1;
            returnBookBtn.Text = "        Return Book";
            returnBookBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            returnBookBtn.UseVisualStyleBackColor = true;
            returnBookBtn.Click += returnBookBtn_Click;
            // 
            // borrowBookBtn
            // 
            borrowBookBtn.FlatAppearance.BorderSize = 0;
            borrowBookBtn.FlatStyle = FlatStyle.Flat;
            borrowBookBtn.Font = new Font("Franklin Gothic Medium", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            borrowBookBtn.ForeColor = Color.White;
            borrowBookBtn.Image = (Image)resources.GetObject("borrowBookBtn.Image");
            borrowBookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            borrowBookBtn.Location = new Point(18, 394);
            borrowBookBtn.Name = "borrowBookBtn";
            borrowBookBtn.Size = new Size(382, 91);
            borrowBookBtn.TabIndex = 1;
            borrowBookBtn.Text = "        Borrow Book";
            borrowBookBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            borrowBookBtn.UseVisualStyleBackColor = true;
            borrowBookBtn.Click += borrowBookBtn_Click;
            // 
            // MemberMainPanel
            // 
            MemberMainPanel.Location = new Point(398, 67);
            MemberMainPanel.Name = "MemberMainPanel";
            MemberMainPanel.Size = new Size(1577, 890);
            MemberMainPanel.TabIndex = 8;
            // 
            // MemberFace
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1974, 957);
            Controls.Add(MemberMainPanel);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberFace";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberFace";
            Load += MemberFace_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel SidePanel;
        private Button button5;
        private Button searchBookBtn;
        private Button borrowedBookBtn;
        private Button returnBookBtn;
        private Button borrowBookBtn;
        private Panel MemberMainPanel;
    }
}