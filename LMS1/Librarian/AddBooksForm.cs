using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS1.Classes;
using MongoDB.Driver;

namespace LMS1
{
    public partial class AddBooksForm : Form
    {
        Library library = new Library();

        public AddBooksForm(Library library)
        {
            this.library = library;

            InitializeComponent();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            //Add book to the database
            try
            {
                if (isValidate())
                {
                    library.addBook(this.AddBookNameTextBox.Text, this.AddAuthorTextBox.Text, this.AddPublisherTextBox.Text, this.AddSubjectTextBox.Text, this.AddISBNNOTextBox.Text, int.Parse(this.AddPriceTextBox.Text));
                    MessageBox.Show("Book saved successfully!");
                    this.AddBookNameTextBox.Clear();
                    this.AddAuthorTextBox.Clear();
                    this.AddPublisherTextBox.Clear();
                    this.AddSubjectTextBox.Clear();
                    this.AddISBNNOTextBox.Clear();
                    this.AddPriceTextBox.Clear();
                    this.AddBookNameTextBox.Focus();
                }
            }
            catch (MongoWriteException ex)
            {
                if (ex.WriteError.Category == ServerErrorCategory.DuplicateKey)
                {
                    MessageBox.Show("Duplicate Key Error: " + ex.WriteError.Message);
                    this.AddISBNNOTextBox.Clear();
                    this.AddISBNNOTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("MongoDB write error: " + ex.WriteError.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Validate the fields
        private bool isValidate()
        {
            if (this.AddBookNameTextBox.Text == "" || this.AddAuthorTextBox.Text == "" || this.AddISBNNOTextBox.Text == "" || this.AddPriceTextBox.Text == "")
            {
                MessageBox.Show("Please fill all the fields!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AddBooksForm_Load(object sender, EventArgs e)
        {
            this.AddBookNameTextBox.Focus();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.AddBookNameTextBox.Clear();
            this.AddAuthorTextBox.Clear();
            this.AddPublisherTextBox.Clear();
            this.AddSubjectTextBox.Clear();
            this.AddISBNNOTextBox.Clear();
            this.AddPriceTextBox.Clear();
            this.AddBookNameTextBox.Focus();
        }
    }
}
