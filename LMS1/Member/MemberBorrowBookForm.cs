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
using MongoDB.Driver;
using LMS1.Classes;
using MySqlX.XDevAPI.Relational;

namespace LMS1
{
    public partial class MemberBorrowBookForm : Form
    {
        Member member;

        IMongoClient client = new MongoClient();
        IMongoDatabase database;
        List<Book> books = new List<Book>();

        DataTable table;

        public MemberBorrowBookForm(Member member)
        {
            InitializeComponent();
            this.member = member;

            database = client.GetDatabase("LMSdb");
            books = database.GetCollection<Book>("Bookdb").Find(_ => true).ToList();
        }

        private void MemberBorrowBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    // Call the borrowBook method from the Member class
                    member.borrowBook(this.MemberBorrowBookNameTextBox.Text, this.MemberBorrowISBNNOTextBox.Text);
                    this.MemberBorrowBookNameTextBox.Clear();
                    this.MemberBorrowISBNNOTextBox.Clear();
                    this.BorrowBookDate.Value = DateTime.Now;
                    this.ReturnBookDate.Value = DateTime.Now;
                    this.MemberBorrowBookNameTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            refreshtb();
        }

        // Check if the fields are empty
        private bool isValid()
        {
            if (this.MemberBorrowBookNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter the book name!");
                this.MemberBorrowBookNameTextBox.Focus();
                return false;
            }
            if (this.MemberBorrowISBNNOTextBox.Text == "")
            {
                MessageBox.Show("Please enter the ISBN number!");
                this.MemberBorrowISBNNOTextBox.Focus();
                return false;
            }
            return true;
        }

        // Clear button
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
            refreshtb();
        }

        // Refresh the DataGridView
        private void refreshtb()
        {
            // Fill the DataGridView with the books from the database
            books = database.GetCollection<Book>("Bookdb").Find(_ => true).ToList();

            table = new DataTable();
            table.Columns.Add("Titel", typeof(string));
            table.Columns.Add("ISBN", typeof(string));
            table.Columns.Add("Author", typeof(string));
            table.Columns.Add("Publication", typeof(string));
            table.Columns.Add("Subject", typeof(string));
            table.Columns.Add("Price", typeof(int));
            table.Columns.Add("Available", typeof(bool));

            // Add the books to the DataTable
            foreach (Book book in books)
            {
                table.Rows.Add(book.BookTitel, book.BookISBN, book.BookAuthor,
                    book.BookPublication, book.BookSubject, book.BookPrice, book.BookAvailablility);

                //show only available books in gridveiw
                //if (book.BookAvailablility == true)
                //{
                //    DataView dv = table.DefaultView;
                //    dv.RowFilter = "Availablity = true";
                //    dataGridView1.DataSource = dv;
                //}

                // Set the DataGridView data source to the DataTable
            }

            dataGridView1.DataSource = table;
        }

        // Search text changed event
        private void SearchBookTextBook_TextChanged(object sender, EventArgs e)
        {
            if (this.BookTitelRadioButton.Checked)
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = "Titel LIKE '" + SearchBookTextBook.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            else if (this.ISBNRadioButton.Checked)
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = "ISBN LIKE '" + SearchBookTextBook.Text + "%'";
                dataGridView1.DataSource = dv;
            }
        }

        private void BookTitelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.SearchBookTextBook.Clear();
            this.SearchBookTextBook.Focus();

            DataView dv = table.DefaultView;
            dv.RowFilter = "Titel LIKE '" + SearchBookTextBook.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void ISBNRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.SearchBookTextBook.Clear();
            this.SearchBookTextBook.Focus();

            DataView dv = table.DefaultView;
            dv.RowFilter = "ISBN LIKE '" + SearchBookTextBook.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void BorrowBookDate_ValueChanged(object sender, EventArgs e)
        {
            //DateTime aux = this.BorrowBookDate.Value;
            //this.ReturnBookDate.Value = aux.AddDays(7);
            //aux = aux.AddDays(1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.MemberBorrowBookNameTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.MemberBorrowISBNNOTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
