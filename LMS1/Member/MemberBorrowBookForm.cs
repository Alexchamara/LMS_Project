using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS1
{
    public partial class MemberBorrowBookForm : Form
    {
        Member member;
        public MemberBorrowBookForm(Member member)
        {
            InitializeComponent();
            this.member = member;
        }

        private void MemberBorrowBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                member.borrowBook(this.MemberBorrowBookNameTextBox.Text, this.MemberBorrowISBNNOTextBox.Text);                
                this.MemberBorrowBookNameTextBox.Clear();
                this.MemberBorrowISBNNOTextBox.Clear();
                this.BorrowBookDate.Value = DateTime.Now;
                this.ReturnBookDate.Value = DateTime.Now;
                this.MemberBorrowBookNameTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.MemberBorrowBookNameTextBox.Clear();
            this.MemberBorrowISBNNOTextBox.Clear();
            this.BorrowBookDate.Value = DateTime.Now;
            this.ReturnBookDate.Value = DateTime.Now;
            this.MemberBorrowBookNameTextBox.Focus();
        }

        private void MemberBorrowBookForm_Load(object sender, EventArgs e)
        {
            this.MemberBorrowBookNameTextBox.Focus();
        }

        private void BorrowBookDate_ValueChanged(object sender, EventArgs e)
        {
            //DateTime aux = this.BorrowBookDate.Value;
            //this.ReturnBookDate.Value = aux.AddDays(7);
            //aux = aux.AddDays(1);
        }
    }
}
