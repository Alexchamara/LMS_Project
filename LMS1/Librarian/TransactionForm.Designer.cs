namespace LMS1
{
    partial class TransactionForm
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
            TrasactionSummeryPanel = new Panel();
            trasactionCard1 = new Librarian.TrasactionCard();
            TrasactionSummeryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TrasactionSummeryPanel
            // 
            TrasactionSummeryPanel.AutoScroll = true;
            TrasactionSummeryPanel.Controls.Add(trasactionCard1);
            TrasactionSummeryPanel.Location = new Point(12, 121);
            TrasactionSummeryPanel.Name = "TrasactionSummeryPanel";
            TrasactionSummeryPanel.Size = new Size(1518, 932);
            TrasactionSummeryPanel.TabIndex = 0;
            // 
            // trasactionCard1
            // 
            trasactionCard1.Location = new Point(17, 25);
            trasactionCard1.Name = "trasactionCard1";
            trasactionCard1.Size = new Size(1485, 304);
            trasactionCard1.TabIndex = 0;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1542, 1065);
            Controls.Add(TrasactionSummeryPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionForm";
            Text = "TransactionForm";
            TrasactionSummeryPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TrasactionSummeryPanel;
        private Librarian.TrasactionCard trasactionCard1;
    }
}