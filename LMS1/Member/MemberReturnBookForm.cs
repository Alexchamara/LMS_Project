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
    public partial class MemberReturnBookForm : Form
    {
        Member member;
        public MemberReturnBookForm(Member member)
        {
            InitializeComponent();
            this.member = member;
        }

        private void MemberReturnBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                member.returnBook(this.MemberReturnBookNameTextBox.Text, this.MemberReturnISBNNOTextBox.Text);
                this.MemberReturnBookNameTextBox.Clear();
                this.MemberReturnISBNNOTextBox.Clear();
                this.MemberReturnBookDate.Value = DateTime.Now;
                this.MemberReturnBookNameTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.MemberReturnBookNameTextBox.Clear();
            this.MemberReturnISBNNOTextBox.Clear();
            this.MemberReturnBookDate.Value = DateTime.Now;
            this.MemberReturnBookNameTextBox.Focus();
        }

        private void MemberReturnBookForm_Load(object sender, EventArgs e)
        {
            this.MemberReturnBookNameTextBox.Focus();
        }

    }
}
