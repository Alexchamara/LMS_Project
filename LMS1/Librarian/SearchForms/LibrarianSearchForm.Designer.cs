namespace LMS1
{
    partial class LibrarianSearchForm
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
            SearchBookRadioButton = new RadioButton();
            SearchMemberRadioButton = new RadioButton();
            LibrarianSearchPanel = new Panel();
            label2 = new Label();
            SuspendLayout();
            // 
            // SearchBookRadioButton
            // 
            SearchBookRadioButton.AutoSize = true;
            SearchBookRadioButton.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBookRadioButton.Location = new Point(481, 18);
            SearchBookRadioButton.Name = "SearchBookRadioButton";
            SearchBookRadioButton.Size = new Size(63, 25);
            SearchBookRadioButton.TabIndex = 7;
            SearchBookRadioButton.Text = "Book";
            SearchBookRadioButton.UseVisualStyleBackColor = true;
            SearchBookRadioButton.CheckedChanged += SearchBookRadioButton_CheckedChanged;
            // 
            // SearchMemberRadioButton
            // 
            SearchMemberRadioButton.AutoSize = true;
            SearchMemberRadioButton.Checked = true;
            SearchMemberRadioButton.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchMemberRadioButton.Location = new Point(377, 18);
            SearchMemberRadioButton.Name = "SearchMemberRadioButton";
            SearchMemberRadioButton.Size = new Size(85, 25);
            SearchMemberRadioButton.TabIndex = 6;
            SearchMemberRadioButton.TabStop = true;
            SearchMemberRadioButton.Text = "Member";
            SearchMemberRadioButton.UseVisualStyleBackColor = true;
            SearchMemberRadioButton.CheckedChanged += SearchMemberRadioButton_CheckedChanged;
            // 
            // LibrarianSearchPanel
            // 
            LibrarianSearchPanel.Dock = DockStyle.Bottom;
            LibrarianSearchPanel.Location = new Point(0, 66);
            LibrarianSearchPanel.Name = "LibrarianSearchPanel";
            LibrarianSearchPanel.Size = new Size(830, 433);
            LibrarianSearchPanel.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(285, 19);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 9;
            label2.Text = "Search  :";
            // 
            // LibrarianSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 499);
            Controls.Add(label2);
            Controls.Add(LibrarianSearchPanel);
            Controls.Add(SearchBookRadioButton);
            Controls.Add(SearchMemberRadioButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LibrarianSearchForm";
            Text = "LibrarianSearchForm";
            Load += LibrarianSearchForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton SearchBookRadioButton;
        private RadioButton SearchMemberRadioButton;
        private Panel LibrarianSearchPanel;
        private Label label2;
    }
}