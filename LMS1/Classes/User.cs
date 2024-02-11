using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace LMS1.Classes
{
    public class User
    {
        private string userName;
        private string userId;
        private string password;
        private string userNIC;
        private string userEmail;
        private int contact;


        public User(string userName, string userId, string password, string userNIC, string userEmail, int contact)
        {
            this.userName = userName;
            this.userId = userId;
            this.password = password;
            this.userNIC = userNIC;
            this.userEmail = userEmail;
            this.contact = contact;
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string UserPassword
        {
            get { return password; }
            set { password = value; }
        }

        public string UserNIC
        {
            get { return userNIC; }
            set { userNIC = value; }
        }

        public string UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
        }

        public int Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        //Search the book using ISBN from the database
        public Book searchBook(string keyword)
        {
            var client = new MongoClient().GetDatabase("LMSdb");
            var bookCollection = client.GetCollection<Book>("Bookdb");

            Book book = bookCollection.Find(b => b.BookISBN == keyword).FirstOrDefault();
            if (book != null)
            {
                return book;
            }
            else
            {
                return book = bookCollection.Find(b => b.BookTitel == keyword).FirstOrDefault();
            }
        }

        //Check the librarian name and password is matched
        public bool librarianLogin(string librarianId, string librarianPassword)
        {
            if (userId != null && this.userId == librarianId && this.password == librarianPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Check the member name and password is matched
        public bool memberLogin(string memberId, string memberPassword)
        {
            if (userId != null && this.userId == memberId && this.password == memberPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }


}
