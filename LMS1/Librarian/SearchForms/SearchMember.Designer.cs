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
            label2 = new Label();
            SearchMemberTextRemove = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // NICRadioBtn
            // 
            NICRadioBtn.AutoSize = true;
            NICRadioBtn.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NICRadioBtn.Location = new Point(719, 25);
            NICRadioBtn.Name = "NICRadioBtn";
            NICRadioBtn.Size = new Size(51, 25);
            NICRadioBtn.TabIndex = 44;
            NICRadioBtn.Text = "NIC";
            NICRadioBtn.UseVisualStyleBackColor = true;
            NICRadioBtn.CheckedChanged += NICRadioBtn_CheckedChanged;
            // 
            // membershipIdRadioBtn
            // 
            membershipIdRadioBtn.AutoSize = true;
            membershipIdRadioBtn.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            membershipIdRadioBtn.Location = new Point(572, 25);
            membershipIdRadioBtn.Name = "membershipIdRadioBtn";
            membershipIdRadioBtn.Size = new Size(132, 25);
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
            memberNameRadioBtn.Location = new Point(488, 25);
            memberNameRadioBtn.Name = "memberNameRadioBtn";
            memberNameRadioBtn.Size = new Size(69, 25);
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
            dataGridView1.Location = new Point(11, 62);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(808, 281);
            dataGridView1.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(140, 27);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 47;
            label2.Text = "Search By";
            // 
            // SearchMemberTextRemove
            // 
            SearchMemberTextRemove.Location = new Point(231, 28);
            SearchMemberTextRemove.Margin = new Padding(2, 1, 2, 1);
            SearchMemberTextRemove.Name = "SearchMemberTextRemove";
            SearchMemberTextRemove.Size = new Size(223, 23);
            SearchMemberTextRemove.TabIndex = 48;
            SearchMemberTextRemove.TextChanged += SearchMemberTextRemoveMember_TextChanged;
            // 
            // SearchMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 353);
            Controls.Add(NICRadioBtn);
            Controls.Add(membershipIdRadioBtn);
            Controls.Add(memberNameRadioBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(SearchMemberTextRemove);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label label2;
        private TextBox SearchMemberTextRemoveMember;
        private TextBox SearchMemberTextRemove;
    }
}