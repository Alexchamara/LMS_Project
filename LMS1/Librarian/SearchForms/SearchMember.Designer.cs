namespace LMS1
{
    partial class SearchMember
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
            NICRadioBtn = new RadioButton();
            membershipIdRadioBtn = new RadioButton();
            memberNameRadioBtn = new RadioButton();
            dataGridView1 = new DataGridView();
            SearchMemberTextRemove = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // NICRadioBtn
            // 
            NICRadioBtn.AutoSize = true;
            NICRadioBtn.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NICRadioBtn.Location = new Point(1152, 60);
            NICRadioBtn.Margin = new Padding(6, 6, 6, 6);
            NICRadioBtn.Name = "NICRadioBtn";
            NICRadioBtn.Size = new Size(97, 41);
            NICRadioBtn.TabIndex = 44;
            NICRadioBtn.Text = "NIC";
            NICRadioBtn.UseVisualStyleBackColor = true;
            NICRadioBtn.CheckedChanged += NICRadioBtn_CheckedChanged;
            // 
            // membershipIdRadioBtn
            // 
            membershipIdRadioBtn.AutoSize = true;
            membershipIdRadioBtn.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            membershipIdRadioBtn.Location = new Point(883, 60);
            membershipIdRadioBtn.Margin = new Padding(6, 6, 6, 6);
            membershipIdRadioBtn.Name = "membershipIdRadioBtn";
            membershipIdRadioBtn.Size = new Size(259, 41);
            membershipIdRadioBtn.TabIndex = 45;
            membershipIdRadioBtn.Text = "Membership ID";
            membershipIdRadioBtn.UseVisualStyleBackColor = true;
            membershipIdRadioBtn.CheckedChanged += membershipIdRadioBtn_CheckedChanged;
            // 
            // memberNameRadioBtn
            // 
            memberNameRadioBtn.AutoSize = true;
            memberNameRadioBtn.Checked = true;
            memberNameRadioBtn.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberNameRadioBtn.Location = new Point(738, 60);
            memberNameRadioBtn.Margin = new Padding(6, 6, 6, 6);
            memberNameRadioBtn.Name = "memberNameRadioBtn";
            memberNameRadioBtn.Size = new Size(131, 41);
            memberNameRadioBtn.TabIndex = 46;
            memberNameRadioBtn.TabStop = true;
            memberNameRadioBtn.Text = "Name";
            memberNameRadioBtn.UseVisualStyleBackColor = true;
            memberNameRadioBtn.CheckedChanged += memberNameRadioBtn_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 132);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1516, 833);
            dataGridView1.TabIndex = 49;
            // 
            // SearchMemberTextRemove
            // 
            SearchMemberTextRemove.BorderStyle = BorderStyle.FixedSingle;
            SearchMemberTextRemove.Location = new Point(294, 62);
            SearchMemberTextRemove.Margin = new Padding(4, 2, 4, 2);
            SearchMemberTextRemove.Name = "SearchMemberTextRemove";
            SearchMemberTextRemove.PlaceholderText = "    Search";
            SearchMemberTextRemove.Size = new Size(411, 39);
            SearchMemberTextRemove.TabIndex = 48;
            SearchMemberTextRemove.TextChanged += SearchMemberTextRemoveMember_TextChanged;
            // 
            // SearchMember
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1542, 976);
            Controls.Add(NICRadioBtn);
            Controls.Add(membershipIdRadioBtn);
            Controls.Add(memberNameRadioBtn);
            Controls.Add(dataGridView1);
            Controls.Add(SearchMemberTextRemove);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "SearchMember";
            Text = "SearchMember";
            Load += SearchMember_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton NICRadioBtn;
        private RadioButton membershipIdRadioBtn;
        private RadioButton memberNameRadioBtn;
        private DataGridView dataGridView1;
        private TextBox SearchMemberTextRemoveMember;
        private TextBox SearchMemberTextRemove;
    }
}