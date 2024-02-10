using LMS1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS1.Librarian
{
    public partial class TrasactionCard : UserControl
    {
        ClassTransaction transaction;
        public TrasactionCard(ClassTransaction transaction)
        {
            InitializeComponent();
            this.transaction = transaction;
        }

        private void TrasactionCard_Load(object sender, EventArgs e)
        {
            this.transactionTypeText.Text = transaction.TransactionType;
            this.transactionMidText.Text = transaction.MemberId;
            this.transactionMnameText.Text = transaction.MemberName;
            this.transactionBisbnText.Text = transaction.BookId;
            this.transactionBnameText.Text = transaction.BookTitle;
            this.TreasactionDate.Value = transaction.TransactionDateTime;
        }

    }
}
