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
    public partial class RemoveBooksForm : Form
    {
        Library library;

        public RemoveBooksForm(Library library)
        {
            this.library = library;
            InitializeComponent();
        }

        private void RemoveBookBtn_Click(object sender, EventArgs e)
        {
            library.removeBook(this.ISBNNOTextBox.Text, this.RemoveBookNameTextBox.Text);
        }
    }
}
