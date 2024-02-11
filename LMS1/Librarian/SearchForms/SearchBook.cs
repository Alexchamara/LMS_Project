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
using LMS1.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS1
{
    public partial class SearchBook : Form
    {
        // MongoDB connection
        IMongoClient client = new MongoClient();
        IMongoDatabase database;
        List<Book> books = new List<Book>();

        User user;

        // DataTable for the DataGridView
        DataTable table;

        // Constructor
        public SearchBook(User user)
        {
            InitializeComponent();
            database = client.GetDatabase("LMSdb");
            books = database.GetCollection<Book>("Bookdb").Find(_ => true).ToList();
            this.user = user;
        }

        // Load event
        private void SearchBook_Load(object sender, EventArgs e)
        {
            this.SearchBookTextBook.Focus();

            // Fill the DataGridView with the books from the database
            //books = user.searchBook();

            // Create a new DataTable
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
            }

            // Set the DataGridView data source to the DataTable
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

        // Radio button checked changed to ISBN
        private void ISBNRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.SearchBookTextBook.Clear();
            this.SearchBookTextBook.Focus();

            // Search the book using ISBN
            Book book = user.searchBook(SearchBookTextBook.Text);
        }

        // Radio button checked changed to BookTitel
        private void BookTitelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.SearchBookTextBook.Clear();
            this.SearchBookTextBook.Focus();

            // Search the book using BookTitel
            Book book = user.searchBook(SearchBookTextBook.Text);
        }
    }
}
