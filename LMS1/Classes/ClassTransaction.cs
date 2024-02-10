using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS1.Classes
{
    public class ClassTransaction
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string id;

        string memberName;
        string memberId;

        string bookTitle;
        string bookId;


        string transactiontype;
        DateTime transactionDateTime;

        public ClassTransaction(string memberName, string memberId, string bookTitle, string bookId, string transactiontype, DateTime transactionDateTime)
        {
            this.memberName = memberName;
            this.memberId = memberId;
            this.bookTitle = bookTitle;
            this.bookId = bookId;
            this.transactiontype = transactiontype;
            this.transactionDateTime = transactionDateTime;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string MemberName
        {
            get { return memberName; }
            set { memberName = value; }
        }

        public string MemberId
        {
            get { return memberId; }
            set { memberId = value; }
        }

        public string BookTitle
        {
            get { return bookTitle; }
            set { bookTitle = value; }
        }

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public string TransactionType
        {
            get { return transactiontype; }
            set { transactiontype = value; }
        }

        public DateTime TransactionDateTime
        {
            get { return transactionDateTime; }
            set { transactionDateTime = value; }
        }
    }
}
