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

namespace LMS1
{
    public partial class RemoverMemberForm : Form
    {
        Librarian librarian;

        public RemoverMemberForm(Librarian librarian)
        {
            this.librarian = librarian;
            InitializeComponent();
        }

        private void RemoveMemberBtn_Click(object sender, EventArgs e)
        {
            librarian.removeMember(this.RemoveMembershipIdTextBox.Text, this.RemoveMemberNameTextBox.Text);

            this.RemoveMembershipIdTextBox.Clear();
            this.RemoveMemberNameTextBox.Clear();
        }
    }
}
