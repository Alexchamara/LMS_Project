namespace LMS1
{
    partial class RemoverMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoverMemberForm));
            RemoveMemberResonTexBox = new TextBox();
            pictureBox1 = new PictureBox();
            RemoveMemberBtn = new Button();
            RemoveMemberNameTextBox = new TextBox();
            RemoveMembershipIdTextBox = new TextBox();
            RemoveNICTextBox = new TextBox();
            ResonLable = new Label();
            NICLable = new Label();
            MembershipIdNoLable = new Label();
            MemberNameLable = new Label();
            RemoveMemberLable = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            SearchMemberTextRemoveMember = new TextBox();
            memberNameRadioBtn = new RadioButton();
            membershipIdRadioBtn = new RadioButton();
            NICRadioBtn = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // RemoveMemberResonTexBox
            // 
            RemoveMemberResonTexBox.Location = new Point(364, 195);
            RemoveMemberResonTexBox.Margin = new Padding(2, 1, 2, 1);
            RemoveMemberResonTexBox.Name = "RemoveMemberResonTexBox";
            RemoveMemberResonTexBox.Size = new Size(217, 23);
            RemoveMemberResonTexBox.TabIndex = 4;
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
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // RemoveMemberBtn
            // 
            RemoveMemberBtn.BackColor = Color.FromArgb(246, 174, 0);
            RemoveMemberBtn.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveMemberBtn.ForeColor = SystemColors.Control;
            RemoveMemberBtn.Location = new Point(396, 240);
            RemoveMemberBtn.Margin = new Padding(2, 1, 2, 1);
            RemoveMemberBtn.Name = "RemoveMemberBtn";
            RemoveMemberBtn.Size = new Size(184, 27);
            RemoveMemberBtn.TabIndex = 5;
            RemoveMemberBtn.Text = "Remove Member";
            RemoveMemberBtn.UseVisualStyleBackColor = false;
            RemoveMemberBtn.Click += RemoveMemberBtn_Click;
            // 
            // RemoveMemberNameTextBox
            // 
            RemoveMemberNameTextBox.Location = new Point(364, 76);
            RemoveMemberNameTextBox.Margin = new Padding(2, 1, 2, 1);
            RemoveMemberNameTextBox.Name = "RemoveMemberNameTextBox";
            RemoveMemberNameTextBox.Size = new Size(217, 23);
            RemoveMemberNameTextBox.TabIndex = 1;
            // 
            // RemoveMembershipIdTextBox
            // 
            RemoveMembershipIdTextBox.Location = new Point(364, 116);
            RemoveMembershipIdTextBox.Margin = new Padding(2, 1, 2, 1);
            RemoveMembershipIdTextBox.Name = "RemoveMembershipIdTextBox";
            RemoveMembershipIdTextBox.Size = new Size(217, 23);
            RemoveMembershipIdTextBox.TabIndex = 2;
            // 
            // RemoveNICTextBox
            // 
            RemoveNICTextBox.Location = new Point(364, 156);
            RemoveNICTextBox.Margin = new Padding(2, 1, 2, 1);
            RemoveNICTextBox.Name = "RemoveNICTextBox";
            RemoveNICTextBox.Size = new Size(217, 23);
            RemoveNICTextBox.TabIndex = 3;
            // 
            // ResonLable
            // 
            ResonLable.Anchor = AnchorStyles.Top;
            ResonLable.AutoSize = true;
            ResonLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ResonLable.Location = new Point(211, 193);
            ResonLable.Margin = new Padding(2, 0, 2, 0);
            ResonLable.Name = "ResonLable";
            ResonLable.Size = new Size(61, 24);
            ResonLable.TabIndex = 0;
            ResonLable.Text = "Reson";
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
            MemberNameLable.Size = new Size(59, 24);
            MemberNameLable.TabIndex = 0;
            MemberNameLable.Text = "Name";
            // 
            // RemoveMemberLable
            // 
            RemoveMemberLable.Anchor = AnchorStyles.Top;
            RemoveMemberLable.AutoSize = true;
            RemoveMemberLable.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Underline, GraphicsUnit.Point);
            RemoveMemberLable.Location = new Point(345, 16);
            RemoveMemberLable.Margin = new Padding(2, 0, 2, 0);
            RemoveMemberLable.Name = "RemoveMemberLable";
            RemoveMemberLable.Size = new Size(190, 30);
            RemoveMemberLable.TabIndex = 0;
            RemoveMemberLable.Text = "Remove Member";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 328);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(769, 74);
            dataGridView1.TabIndex = 43;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(147, 293);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 0;
            label2.Text = "Search By";
            // 
            // SearchMemberTextRemoveMember
            // 
            SearchMemberTextRemoveMember.Location = new Point(238, 294);
            SearchMemberTextRemoveMember.Margin = new Padding(2, 1, 2, 1);
            SearchMemberTextRemoveMember.Name = "SearchMemberTextRemoveMember";
            SearchMemberTextRemoveMember.Size = new Size(223, 23);
            SearchMemberTextRemoveMember.TabIndex = 0;
            SearchMemberTextRemoveMember.TextChanged += SearchMemberTextRemoveMember_TextChanged;
            // 
            // memberNameRadioBtn
            // 
            memberNameRadioBtn.AutoSize = true;
            memberNameRadioBtn.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberNameRadioBtn.Location = new Point(495, 291);
            memberNameRadioBtn.Name = "memberNameRadioBtn";
            memberNameRadioBtn.Size = new Size(69, 25);
            memberNameRadioBtn.TabIndex = 0;
            memberNameRadioBtn.TabStop = true;
            memberNameRadioBtn.Text = "Name";
            memberNameRadioBtn.UseVisualStyleBackColor = true;
            memberNameRadioBtn.CheckedChanged += memberNameRadioBtn_CheckedChanged_1;
            // 
            // membershipIdRadioBtn
            // 
            membershipIdRadioBtn.AutoSize = true;
            membershipIdRadioBtn.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            membershipIdRadioBtn.Location = new Point(579, 291);
            membershipIdRadioBtn.Name = "membershipIdRadioBtn";
            membershipIdRadioBtn.Size = new Size(132, 25);
            membershipIdRadioBtn.TabIndex = 0;
            membershipIdRadioBtn.TabStop = true;
            membershipIdRadioBtn.Text = "Membership ID";
            membershipIdRadioBtn.UseVisualStyleBackColor = true;
            membershipIdRadioBtn.CheckedChanged += membershipIdRadioBtn_CheckedChanged_1;
            // 
            // NICRadioBtn
            // 
            NICRadioBtn.AutoSize = true;
            NICRadioBtn.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NICRadioBtn.Location = new Point(726, 291);
            NICRadioBtn.Name = "NICRadioBtn";
            NICRadioBtn.Size = new Size(51, 25);
            NICRadioBtn.TabIndex = 0;
            NICRadioBtn.TabStop = true;
            NICRadioBtn.Text = "NIC";
            NICRadioBtn.UseVisualStyleBackColor = true;
            NICRadioBtn.CheckedChanged += NICRadioBtn_CheckedChanged;
            // 
            // RemoverMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 420);
            Controls.Add(NICRadioBtn);
            Controls.Add(membershipIdRadioBtn);
            Controls.Add(memberNameRadioBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(SearchMemberTextRemoveMember);
            Controls.Add(RemoveMemberResonTexBox);
            Controls.Add(pictureBox1);
            Controls.Add(RemoveMemberBtn);
            Controls.Add(RemoveMemberNameTextBox);
            Controls.Add(RemoveMembershipIdTextBox);
            Controls.Add(RemoveNICTextBox);
            Controls.Add(ResonLable);
            Controls.Add(NICLable);
            Controls.Add(MembershipIdNoLable);
            Controls.Add(MemberNameLable);
            Controls.Add(RemoveMemberLable);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "RemoverMemberForm";
            Text = "RemoverMemberForm";
            Load += RemoverMemberForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RemoveMemberResonTexBox;
        private PictureBox pictureBox1;
        private Button RemoveMemberBtn;
        private TextBox RemoveMemberNameTextBox;
        private TextBox RemoveMembershipIdTextBox;
        private TextBox RemoveNICTextBox;
        private Label ResonLable;
        private Label NICLable;
        private Label MembershipIdNoLable;
        private Label MemberNameLable;
        private Label RemoveMemberLable;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox SearchMemberTextRemoveMember;
        private RadioButton memberNameRadioBtn;
        private RadioButton membershipIdRadioBtn;
        private RadioButton NICRadioBtn;
    }
}