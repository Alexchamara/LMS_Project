using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace LMS1.Classes
{
    public class Book
    {
        private string ISBN;
        private string titel;       //Add fields
        private string author;
        private string publication;
        private string subject;
        private int price;
        private bool availablility;
        private DateTime borrowedDate;
        private DateTime returnDate;
        Member borrowedMember;


        public Book  //Create a class constructor for 'AddBook' class
            (string titel, string author, string publication, string subject,
            string ISBN, int price, bool availablility = true)
        {
            this.titel = titel;
            this.author = author;
            this.publication = publication;
            this.subject = subject;
            this.ISBN = ISBN;
            this.price = price;
            this.availablility = availablility;
        }

        public string BookTitel
        {
            get { return titel; }
            set { titel = value; }
        }

        public string BookAuthor
        {
            get { return author; }
            set { author = value; }
        }

        public string BookPublication
        {
            get { return publication; }
            set { publication = value; }
        }

        public string BookSubject
        {
            get { return subject; }
            set { subject = value; }
        }

        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string BookISBN
        {
            get { return ISBN; }
            set { ISBN = value; }
        }

        public int BookPrice
        {
            get { return price; }
            set { price = value; }
        }

        public bool BookAvailablility
        {
            get { return availablility; }
            set { availablility = value; }
        }

        public DateTime BorrowedDate
        {
            get { return this.borrowedDate; }
            set { this.borrowedDate = value; }
        }

        public DateTime ReturnDate
        {
            get { return this.returnDate; }
            set { this.returnDate = value; }
        }

        public Member BorrowedBy
        {
            get { return borrowedMember; }
            set { borrowedMember = value; }
        }
    }
}
