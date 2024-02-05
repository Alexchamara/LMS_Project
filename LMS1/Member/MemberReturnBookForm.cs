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
        public MemberReturnBookForm()
        {
            InitializeComponent();
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
