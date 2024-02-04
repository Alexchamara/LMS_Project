using LMS1.Classes;
using LMS1.Error_messages;
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
    public partial class LibrarianLogInForm : Form
    {
        public LibrarianLogInForm()
        {
            InitializeComponent();
            this.LibrarianUserNaneTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LibrarianLogInFormBtn_Click(object sender, EventArgs e)
        {
            if (LibrarianUserNaneTextBox.Text == "alex" && LibrarianLogInPassword.Text == "1234")
            {
                MainInterFace mainInterFaceForm = Application.OpenForms["MainInterFace"] as MainInterFace;
                mainInterFaceForm.Hide();

                this.Hide();

                Librarian librarian = new Librarian("userName", "userId", "password", "userNIC", "userEmail", 1234);
                Library library = new Library();

                new LibrarianFace(library, librarian).Show();
            }
            else if (isValid())
            {
                new InvalidUname_Password().ShowDialog();
                LibrarianUserNaneTextBox.Clear();
                LibrarianLogInPassword.Clear();
                LibrarianUserNaneTextBox.Focus();
            }
        }

        private bool isValid()
        {
            if (LibrarianUserNaneTextBox.Text == string.Empty)
            {
                new InvalidUserName().ShowDialog();
                return false;
            }
            else if (LibrarianLogInPassword.Text == string.Empty)
            {
                new InvalidPassword().ShowDialog();
                return false;
            }
            return true;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            LibrarianUserNaneTextBox.Clear();
            LibrarianLogInPassword.Clear();
            LibrarianUserNaneTextBox.Focus();
        }

        private void LibrarianLogInForm_Load(object sender, EventArgs e)
        {
            LibrarianUserNaneTextBox.Focus();
        }
    }
}
