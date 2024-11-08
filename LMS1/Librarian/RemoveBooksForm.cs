﻿using LMS1.Classes;
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
    public partial class RemoveBooksForm : Form
    {
        Library library;

        // MongoDB connection
        IMongoClient client = new MongoClient();
        IMongoDatabase database;
        List<Book> books = new List<Book>();

        // DataTable for the DataGridView
        DataTable table;

        public RemoveBooksForm(Library library)
        {
            this.library = library;
            InitializeComponent();

            // Fill the books list with the books from the database
            database = client.GetDatabase("LMSdb");
            books = database.GetCollection<Book>("Bookdb").Find(_ => true).ToList();
        }

        // Remove book button click event
        private void RemoveBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    // Remove the book from the library
                    library.removeBook(this.ISBNNOTextBox.Text, this.RemoveBookNameTextBox.Text);
                    MessageBox.Show("Book removed successfully!");
                    this.ISBNNOTextBox.Clear();
                    this.RemoveBookNameTextBox.Clear();
                    this.RemoveBookNameTextBox.Focus();
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
            if (this.RemoveBookNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter the book name!");
                this.RemoveBookNameTextBox.Focus();
                return false;
            }
            else if (this.ISBNNOTextBox.Text == "")
            {
                MessageBox.Show("Please enter the ISBN number!");
                this.ISBNNOTextBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        // Form load event
        private void RemoveBooksForm_Load(object sender, EventArgs e)
        {
            this.RemoveBookNameTextBox.Focus();
            refreshtb();
        }

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
            table.Columns.Add("Availablity", typeof(bool));

            // Add the books to the DataTable
            foreach (Book book in books)
            {
                table.Rows.Add(book.BookTitel, book.BookISBN, book.BookAuthor,
                    book.BookPublication, book.BookSubject, book.BookPrice, book.BookAvailablility);

                //show only available books in gridveiw
                if (book.BookAvailablility == true)
                {
                    DataView dv = table.DefaultView;
                    dv.RowFilter = "Availablity = true";
                    dataGridView1.DataSource = dv;
                }
            }

            // Set the DataGridView's data source to the DataTable
            dataGridView1.DataSource = table;
        }

        // Radio button checked changed to BookTitel
        private void BookTitelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.SearchBookTextRemoveBook.Clear();
            this.SearchBookTextRemoveBook.Focus();

            DataView dv = table.DefaultView;
            dv.RowFilter = "Titel LIKE '" + SearchBookTextRemoveBook.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        // Radio button checked changed to ISBN
        private void ISBNRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.SearchBookTextRemoveBook.Clear();
            this.SearchBookTextRemoveBook.Focus();

            DataView dv = table.DefaultView;
            dv.RowFilter = "ISBN LIKE '" + SearchBookTextRemoveBook.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        // Search text changed event
        private void SearchBookTextRemoveBook_TextChanged(object sender, EventArgs e)
        {
            if (this.BookTitelRadioButton.Checked)
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = "Titel LIKE '" + SearchBookTextRemoveBook.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            else if (this.ISBNRadioButton.Checked)
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = "ISBN LIKE '" + SearchBookTextRemoveBook.Text + "%'";
                dataGridView1.DataSource = dv;
            }
        }

        // DataGridView cell double click event
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.RemoveBookNameTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.ISBNNOTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.RemoveBookNameTextBox.Clear();
            this.ISBNNOTextBox.Clear();
            this.RemoveBookNameTextBox.Focus();
        }
    }
}
