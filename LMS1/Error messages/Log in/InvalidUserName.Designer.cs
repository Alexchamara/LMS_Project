namespace LMS1.Error_messages
{
    partial class InvalidUserName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvalidUserName));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            OKBtn = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 57);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(470, 10);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 29;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(70, 34);
            label1.TabIndex = 1;
            label1.Text = "Error";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(146, 129);
            label2.Name = "label2";
            label2.Size = new Size(215, 34);
            label2.TabIndex = 2;
            label2.Text = "Enter user name.";
            // 
            // OKBtn
            // 
            OKBtn.Font = new Font("Franklin Gothic Medium", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            OKBtn.Location = new Point(372, 4);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(123, 41);
            OKBtn.TabIndex = 3;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = true;
            OKBtn.Click += OKBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(OKBtn);
            panel2.Location = new Point(-1, 230);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 51);
            panel2.TabIndex = 4;
            // 
            // InvalidUserName
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 279);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InvalidUserName";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InvalidUserName";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button OKBtn;
        private Panel panel2;
    }
}