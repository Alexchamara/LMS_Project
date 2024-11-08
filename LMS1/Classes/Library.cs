﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace LMS1.Classes
{
    public class Library
    {
        //Add book to the database
        public void addBook(string titel, string author, string publication, string subject, string isbn, int price)
        {
            Book book = new Book(titel, author, publication, subject, isbn, price);

            var client = new MongoClient().GetDatabase("LMSdb");
            client.GetCollection<Book>("Bookdb").InsertOne(book);
        }

        //Remove book from the database
        public void removeBook(string isbn, string bname)
        {
            if (isMatched(isbn, bname))
            {
                var client = new MongoClient().GetDatabase("LMSdb");
                var collection = client.GetCollection<Book>("Bookdb");

                if (bookAvailability(isbn))
                {
                    collection.DeleteOne(m => m.BookISBN == isbn);
                }
                else
                {
                    MessageBox.Show("Someone already borrowed this book. Failed to remove the book!");
                }


            }
        }

        //Check the book availability before remove the book
        private bool bookAvailability(string isbn)
        {
            var client = new MongoClient().GetDatabase("LMSdb");
            var collection = client.GetCollection<Book>("Bookdb");
            Book book = collection.Find(m => m.BookISBN == isbn).FirstOrDefault();

            if (book.BookAvailablility)
            {
                return true;
            }else
            {
                return false;
            }
        }

        //Check the book name and ISBN is matched
        private bool isMatched(string isbn, string bname)
        {
            var client = new MongoClient().GetDatabase("LMSdb");
            var collection = client.GetCollection<Book>("Bookdb");
            Book book = collection.Find(m => m.BookISBN == isbn && m.BookTitel == bname).FirstOrDefault();

            if (book != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Book Name or ISBN is wrong!");
                return false;
            }
        }
    }
}
