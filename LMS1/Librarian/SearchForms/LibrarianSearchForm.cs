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
    public partial class LibrarianSearchForm : Form
    {
        User user;

        public LibrarianSearchForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void LibrarianSearchForm_Load(object sender, EventArgs e)
        {
            switchBookMember(new SearchMember());
        }

        //Switch between search book and search member
        public void switchBookMember(object Form)
        {
            if (this.LibrarianSearchPanel.Controls.Count > 0)
                this.LibrarianSearchPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.LibrarianSearchPanel.Controls.Add(f);
            this.LibrarianSearchPanel.Tag = f;
            f.Show();
        }

        private void SearchMemberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switchBookMember(new SearchMember());
        }

        private void SearchBookRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switchBookMember(new SearchBook(user));
        }
    }
}
