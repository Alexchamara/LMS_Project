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
    public partial class MemberReturnBookForm : Form
    {
        Member member;

        IMongoClient client = new MongoClient();
        IMongoDatabase database;
        IMongoCollection<Member> memberCollection;
        List<Book> borrowedList = new List<Book>();

        DataTable table;

        public MemberReturnBookForm(Member member)
        {
            InitializeComponent();
            this.member = member;

            database = client.GetDatabase("LMSdb");
            memberCollection = database.GetCollection<Member>("Memberdb");
            borrowedList = memberCollection.Find(mem => mem.UserId == this.member.UserId).FirstOrDefault().BorrowedBook;
        }

        private void MemberReturnBookBtn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                try
                {
                    // Call the returnBook method from the Member class
                    member.returnBook(this.MemberReturnBookNameTextBox.Text, this.MemberReturnISBNNOTextBox.Text);
                    this.MemberReturnBookNameTextBox.Clear();
                    this.MemberReturnISBNNOTextBox.Clear();
                    this.MemberReturnBookDate.Value = DateTime.Now;
                    this.MemberReturnBookNameTextBox.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            refreshtb();
        }

        // Check if the fields are empty
        private bool isValid()
        {
            if (MemberReturnBookNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Book Name is required!", "Error");
                MemberReturnBookNameTextBox.Focus();
                return false;
            }
            if (MemberReturnISBNNOTextBox.Text == string.Empty)
            {
                MessageBox.Show("ISBN No is required!", "Error");
                MemberReturnISBNNOTextBox.Focus();
                return false;
            }
            return true;
        }

        private void refreshtb()
        {
            borrowedList = database.GetCollection<Member>("Memberdb").Find(m => m.UserId == member.UserId).FirstOrDefault().BorrowedBook;


            table = new DataTable();
            table.Columns.Add("Book Title");
            table.Columns.Add("ISBN No");
            table.Columns.Add("Borrowed Date");
            table.Columns.Add("Return Date");

            foreach (var book in borrowedList)
            {
                table.Rows.Add(book.BookTitel, book.BookISBN);
            }

            dataGridView1.DataSource = table;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.MemberReturnBookNameTextBox.Clear();
            this.MemberReturnISBNNOTextBox.Clear();
            this.MemberReturnBookDate.Value = DateTime.Now;
            this.MemberReturnBookNameTextBox.Focus();
        }

        private void MemberReturnBookForm_Load(object sender, EventArgs e)
        {
            this.MemberReturnBookNameTextBox.Focus();
            refreshtb();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.MemberReturnBookNameTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.MemberReturnISBNNOTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
