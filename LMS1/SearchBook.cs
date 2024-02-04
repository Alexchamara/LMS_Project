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
        IMongoClient client = new MongoClient();
        IMongoDatabase database;
        List<Book> books = new List<Book>();

        DataTable table;
        public SearchBook()
        {
            InitializeComponent();
            database = client.GetDatabase("LMSdb");
            books = database.GetCollection<Book>("Bookdb").Find(_ => true).ToList();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            this.SearchBookTextBook.Focus();

            books = database.GetCollection<Book>("Bookdb").Find(_ => true).ToList();

            table = new DataTable();
            table.Columns.Add("Titel", typeof(string));
            table.Columns.Add("ISBN", typeof(string));
            table.Columns.Add("Author", typeof(string));
            table.Columns.Add("Publication", typeof(string));
            table.Columns.Add("Subject", typeof(string));
            table.Columns.Add("Price", typeof(int));

            foreach (Book book in books)
            {
                table.Rows.Add(book.BookTitel, book.BookISBN, book.BookAuthor, book.BookPublication, book.BookSubject, book.BookPrice);
            }

            dataGridView1.DataSource = table;
        }

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

        private void ISBNRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.SearchBookTextBook.Focus();

            DataView dv = table.DefaultView;
            dv.RowFilter = "ISBN LIKE '" + SearchBookTextBook.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void BookTitelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.SearchBookTextBook.Focus();

            DataView dv = table.DefaultView;
            dv.RowFilter = "Titel LIKE '" + SearchBookTextBook.Text + "%'";
            dataGridView1.DataSource = dv;
        }
    }
}
