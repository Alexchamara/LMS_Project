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
using MongoDB.Driver;



namespace LMS1
{
    public partial class LibrarianLogInForm : Form
    {
        public LibrarianLogInForm()
        {
            InitializeComponent();
            this.LibrarianUserNaneTextBox.Focus();
        }

        //Close the form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Check the librarianId and password is valid
        private void LibrarianLogInFormBtn_Click(object sender, EventArgs e)
        {
            //Create a connection with the database
            var client = new MongoClient().GetDatabase("LMSdb");
            var librarianInfo = client.GetCollection<Librarian>("Librariandb").Find(l => l.UserId == this.LibrarianUserNaneTextBox.Text).FirstOrDefault();

            //Check the user name and password is valid
            if (librarianInfo != null && librarianInfo.librarianLogin(this.LibrarianUserNaneTextBox.Text, this.LibrarianLogInPassword.Text))
            {
                //Hide the main interface form
                if (librarianInfo.librarianLogin(this.LibrarianUserNaneTextBox.Text, this.LibrarianLogInPassword.Text))
                {
                    MainInterFace mainInterFaceForm = Application.OpenForms["MainInterFace"] as MainInterFace;
                    mainInterFaceForm.Hide();

                    this.Hide();

                    Librarian librarian = new Librarian("userName", "userId", "password", "userNIC", "userEmail", 1234);
                    Library library = new Library();

                    new LibrarianFace(library, librarian).Show();
                }
                else   //If the user name and password is invalid
                {
                    new InvalidUname_Password().ShowDialog();
                    LibrarianUserNaneTextBox.Clear();
                    LibrarianLogInPassword.Clear();
                    LibrarianUserNaneTextBox.Focus();
                }
            }   //If the user name and password is empty
            else if (isValid())
            {
                new InvalidUname_Password().ShowDialog();
                LibrarianUserNaneTextBox.Clear();
                LibrarianLogInPassword.Clear();
                LibrarianUserNaneTextBox.Focus();
            }
        }

        //Check the text boxs are empty
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

        //Clear the text boxes
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

