using LMS1.Classes;
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Member : User
{
    List<Book> borrowedList = new List<Book>(); //create a new list for borrowd books

    public Member(string userName, string userId, string password, string userNIC, string userEmail, int contact)
        : base(userName, userId, password, userNIC, userEmail, contact)
    {
    }

    public List<Book> BorrowedBook
    {
        get { return this.borrowedList; }
        set { this.borrowedList = value; }
    }

    //borrow book method
    public void borrowBook(string bTitle, string bISBN)
    {
        //connect to the database
        var client = new MongoClient().GetDatabase("LMSdb");
        var bookCollection = client.GetCollection<Book>("Bookdb");
        var memberCollection = client.GetCollection<Member>("Memberdb");

        //find the book from the database
        var book = bookCollection.Find(m => m.BookISBN == bISBN).FirstOrDefault();

        //check the book is available for borrowing
        if (book == null)
        {
            MessageBox.Show("This book is not found!");
        }
        else if (!book.BookAvailablility)
        {
            MessageBox.Show("The book is not availabe for borrowing!");
        }
        else if (!(book.BookTitel == bTitle && book.BookISBN == bISBN))
        {
            MessageBox.Show("Incorrect Title or ISBN. Please try again!");
        }
        else
        {
            //update the book availability
            var update = Builders<Book>.Update
                .Set("BookAvailablility", false);

            //update the book collection
            bookCollection.UpdateOne(m => m.BookISBN == book.BookISBN, update);

            update = Builders<Book>.Update
                .Set("BorrowedBy", this);

            bookCollection.UpdateOne(m => m.BookISBN == book.BookISBN, update);

            //add the book to the borrow list
            this.borrowedList.Add(book);

            //update the member collection
            var memberUpdate = Builders<Member>.Update
                .Set("BorrowedBook", this.borrowedList);

            //update the member collection
            memberCollection.UpdateOne(m => m.UserId == this.UserId, memberUpdate);

            MessageBox.Show("The book is borrowed successfully!");
        }

    }

    //return book method
    public void returnBook(string bTitle, string bISBN)
    {
        //connect to the database
        var client = new MongoClient().GetDatabase("LMSdb");
        var bookRemoveCollection = client.GetCollection<Book>("Bookdb");
        var memberCollection = client.GetCollection<Member>("Memberdb");

        //find the book from the database
        var book = bookRemoveCollection.Find(m => m.BookISBN == bISBN).FirstOrDefault();
        if (book == null)
        {
            MessageBox.Show("This book is not found!");
        }
        else if (!(book.BookTitel == bTitle && book.BookISBN == bISBN))
        {
            MessageBox.Show("Incorrect Title or ISBN. Please try again!");
        }
        else if (book.BorrowedBy == null || !book.BorrowedBy.Equals(this))
        {
            MessageBox.Show("This book is not borrowed by you!");
        }
        else
        {
            //update the book availability
            var update = Builders<Book>.Update
                .Set("BookAvailablility", true);

            //update the book collection
            bookRemoveCollection.UpdateOne(m => m.BookISBN == book.BookISBN, update);

            update = Builders<Book>.Update.Unset("BorrowedBy");

            bookRemoveCollection.UpdateOne(m => m.BookISBN == book.BookISBN, update);

            //remove the book from the borrow list
            this.borrowedList.RemoveAll(b => b.BookISBN == book.BookISBN);

            //update the member collection
            var memberUpdate = Builders<Member>.Update
                .Set("BorrowedBook", this.borrowedList);

            //update the member collection
            memberCollection.UpdateOne(m => m.UserId == this.UserId, memberUpdate);

            MessageBox.Show("The book is returned successfully!");
        }
    }
}



