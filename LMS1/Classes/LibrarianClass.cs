﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS1.Classes
{
    public class LibrarianClass : User
    {
        //Create a class constructor for 'Librarian' class
        public LibrarianClass(string userName, string userId, string password, string userNIC, string userEmail, int contact) : base(userName, userId, password, userNIC, userEmail, contact)
        {
        }

        //Add member to the database
        public void addMember(string name, string membershipId, string NIC, int contact, string email, string loginPassword)
        {
            //Create a new member object
            Member member = new Member(name, membershipId, loginPassword, NIC, email, contact);

            var client = new MongoClient().GetDatabase("LMSdb");
            client.GetCollection<Member>("Memberdb").InsertOne(member);
        }

        //Remove member from the database
        public void removeMember(string membershipId, string memname)
        {
            if (isMatched(membershipId, memname))
            {
                var client = new MongoClient().GetDatabase("LMSdb");
                var collection = client.GetCollection<Member>("Memberdb");
                collection.DeleteOne(m => m.UserId == membershipId);
            }
        }

        //Check the user name and membership ID is matched
        private bool isMatched(string memberId, string memname)
        {
            var client = new MongoClient().GetDatabase("LMSdb");
            var collection = client.GetCollection<Member>("Memberdb");
            Member member = collection.Find(m => m.UserId == memberId && m.UserName == memname).FirstOrDefault();

            if (member != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("User Name or Membership ID is wrong!");
                return false;
            }
        }
    }
}
