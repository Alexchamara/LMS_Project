using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS1
{
    public partial class MemberBorrowBookForm : Form
    {
        Member member;
        public MemberBorrowBookForm()
        {
            InitializeComponent();
        }
        public MemberBorrowBookForm(Member member)
        {
            this.member = member;
        }



        private void MemberBorrowBookBtn_Click(object sender, EventArgs e)
        {
            //member.BorrowBook(new Book(this.MemberBorrowBookNameTextBox.Text, this.MemberBorrowISBNNOTextBox.Text));
        }
    }
}
