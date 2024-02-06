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
            SearchMemberTextRemoveMember = new TextBox();
            memberNameRadioBtn = new RadioButton();
            membershipIdRadioBtn = new RadioButton();
            NICRadioBtn = new RadioButton();
            ClearBtn = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // RemoveMemberResonTexBox
            // 
            RemoveMemberResonTexBox.Location = new Point(676, 416);
            RemoveMemberResonTexBox.Margin = new Padding(4, 2, 4, 2);
            RemoveMemberResonTexBox.Name = "RemoveMemberResonTexBox";
            RemoveMemberResonTexBox.Size = new Size(400, 39);
            RemoveMemberResonTexBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1128, 213);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // RemoveMemberBtn
            // 
            RemoveMemberBtn.BackColor = Color.FromArgb(246, 174, 0);
            RemoveMemberBtn.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveMemberBtn.ForeColor = SystemColors.Control;
            RemoveMemberBtn.Location = new Point(735, 514);
            RemoveMemberBtn.Margin = new Padding(4, 2, 4, 2);
            RemoveMemberBtn.Name = "RemoveMemberBtn";
            RemoveMemberBtn.Size = new Size(342, 58);
            RemoveMemberBtn.TabIndex = 5;
            RemoveMemberBtn.Text = "Remove Member";
            RemoveMemberBtn.UseVisualStyleBackColor = false;
            RemoveMemberBtn.Click += RemoveMemberBtn_Click;
            // 
            // RemoveMemberNameTextBox
            // 
            RemoveMemberNameTextBox.Location = new Point(676, 162);
            RemoveMemberNameTextBox.Margin = new Padding(4, 2, 4, 2);
            RemoveMemberNameTextBox.Name = "RemoveMemberNameTextBox";
            RemoveMemberNameTextBox.Size = new Size(400, 39);
            RemoveMemberNameTextBox.TabIndex = 1;
            // 
            // RemoveMembershipIdTextBox
            // 
            RemoveMembershipIdTextBox.Location = new Point(676, 247);
            RemoveMembershipIdTextBox.Margin = new Padding(4, 2, 4, 2);
            RemoveMembershipIdTextBox.Name = "RemoveMembershipIdTextBox";
            RemoveMembershipIdTextBox.Size = new Size(400, 39);
            RemoveMembershipIdTextBox.TabIndex = 2;
            // 
            // RemoveNICTextBox
            // 
            RemoveNICTextBox.Location = new Point(676, 333);
            RemoveNICTextBox.Margin = new Padding(4, 2, 4, 2);
            RemoveNICTextBox.Name = "RemoveNICTextBox";
            RemoveNICTextBox.Size = new Size(400, 39);
            RemoveNICTextBox.TabIndex = 3;
            // 
            // ResonLable
            // 
            ResonLable.Anchor = AnchorStyles.Top;
            ResonLable.AutoSize = true;
            ResonLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ResonLable.Location = new Point(276, 412);
            ResonLable.Margin = new Padding(4, 0, 4, 0);
            ResonLable.Name = "ResonLable";
            ResonLable.Size = new Size(119, 43);
            ResonLable.TabIndex = 0;
            ResonLable.Text = "Reson";
            // 
            // NICLable
            // 
            NICLable.Anchor = AnchorStyles.Top;
            NICLable.AutoSize = true;
            NICLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            NICLable.Location = new Point(276, 326);
            NICLable.Margin = new Padding(4, 0, 4, 0);
            NICLable.Name = "NICLable";
            NICLable.Size = new Size(74, 43);
            NICLable.TabIndex = 0;
            NICLable.Text = "NIC";
            // 
            // MembershipIdNoLable
            // 
            MembershipIdNoLable.Anchor = AnchorStyles.Top;
            MembershipIdNoLable.AutoSize = true;
            MembershipIdNoLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            MembershipIdNoLable.Location = new Point(276, 241);
            MembershipIdNoLable.Margin = new Padding(4, 0, 4, 0);
            MembershipIdNoLable.Name = "MembershipIdNoLable";
            MembershipIdNoLable.Size = new Size(260, 43);
            MembershipIdNoLable.TabIndex = 0;
            MembershipIdNoLable.Text = "Membership ID";
            // 
            // MemberNameLable
            // 
            MemberNameLable.Anchor = AnchorStyles.Top;
            MemberNameLable.AutoSize = true;
            MemberNameLable.Font = new Font("Franklin Gothic Medium", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            MemberNameLable.Location = new Point(276, 158);
            MemberNameLable.Margin = new Padding(4, 0, 4, 0);
            MemberNameLable.Name = "MemberNameLable";
            MemberNameLable.Size = new Size(114, 43);
            MemberNameLable.TabIndex = 0;
            MemberNameLable.Text = "Name";
            // 
            // RemoveMemberLable
            // 
            RemoveMemberLable.Anchor = AnchorStyles.Top;
            RemoveMemberLable.AutoSize = true;
            RemoveMemberLable.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Underline, GraphicsUnit.Point);
            RemoveMemberLable.Location = new Point(524, 34);
            RemoveMemberLable.Margin = new Padding(4, 0, 4, 0);
            RemoveMemberLable.Name = "RemoveMemberLable";
            RemoveMemberLable.Size = new Size(380, 61);
            RemoveMemberLable.TabIndex = 0;
            RemoveMemberLable.Text = "Remove Member";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 700);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1516, 354);
            dataGridView1.TabIndex = 43;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // SearchMemberTextRemoveMember
            // 
            SearchMemberTextRemoveMember.Location = new Point(360, 623);
            SearchMemberTextRemoveMember.Margin = new Padding(4, 2, 4, 2);
            SearchMemberTextRemoveMember.Name = "SearchMemberTextRemoveMember";
            SearchMemberTextRemoveMember.PlaceholderText = "   Search";
            SearchMemberTextRemoveMember.Size = new Size(411, 39);
            SearchMemberTextRemoveMember.TabIndex = 0;
            SearchMemberTextRemoveMember.TextChanged += SearchMemberTextRemoveMember_TextChanged;
            // 
            // memberNameRadioBtn
            // 
            memberNameRadioBtn.AutoSize = true;
            memberNameRadioBtn.Checked = true;
            memberNameRadioBtn.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberNameRadioBtn.Location = new Point(797, 621);
            memberNameRadioBtn.Margin = new Padding(6, 6, 6, 6);
            memberNameRadioBtn.Name = "memberNameRadioBtn";
            memberNameRadioBtn.Size = new Size(131, 41);
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
            membershipIdRadioBtn.Location = new Point(951, 621);
            membershipIdRadioBtn.Margin = new Padding(6, 6, 6, 6);
            membershipIdRadioBtn.Name = "membershipIdRadioBtn";
            membershipIdRadioBtn.Size = new Size(259, 41);
            membershipIdRadioBtn.TabIndex = 0;
            membershipIdRadioBtn.Text = "Membership ID";
            membershipIdRadioBtn.UseVisualStyleBackColor = true;
            membershipIdRadioBtn.CheckedChanged += membershipIdRadioBtn_CheckedChanged_1;
            // 
            // NICRadioBtn
            // 
            NICRadioBtn.AutoSize = true;
            NICRadioBtn.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NICRadioBtn.Location = new Point(1222, 621);
            NICRadioBtn.Margin = new Padding(6, 6, 6, 6);
            NICRadioBtn.Name = "NICRadioBtn";
            NICRadioBtn.Size = new Size(97, 41);
            NICRadioBtn.TabIndex = 0;
            NICRadioBtn.Text = "NIC";
            NICRadioBtn.UseVisualStyleBackColor = true;
            NICRadioBtn.CheckedChanged += NICRadioBtn_CheckedChanged;
            // 
            // ClearBtn
            // 
            ClearBtn.AutoSize = true;
            ClearBtn.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.ForeColor = SystemColors.ActiveCaptionText;
            ClearBtn.Location = new Point(951, 469);
            ClearBtn.Margin = new Padding(4, 0, 4, 0);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(134, 30);
            ClearBtn.TabIndex = 0;
            ClearBtn.Text = "Clear Fields";
            ClearBtn.Click += ClearBtn_Click;
            // 
            // RemoverMemberForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1542, 1065);
            Controls.Add(ClearBtn);
            Controls.Add(NICRadioBtn);
            Controls.Add(membershipIdRadioBtn);
            Controls.Add(memberNameRadioBtn);
            Controls.Add(dataGridView1);
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
            Margin = new Padding(4, 2, 4, 2);
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
        private TextBox SearchMemberTextRemoveMember;
        private RadioButton memberNameRadioBtn;
        private RadioButton membershipIdRadioBtn;
        private RadioButton NICRadioBtn;
        private Label ClearBtn;
    }
}