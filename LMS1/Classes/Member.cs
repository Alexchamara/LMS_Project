using LMS1.Classes;
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



    //public void BorrowBook(Book borrowingBook)     //Create a method for borrw book and takes a 'Book' object as a parameter named 'borrowingBook'.
    //{
    //    if (borrowingBook.BookAvailablility)
    //    {
    //        this.borrowedList.Add(borrowingBook);   //Add borrowed book to 'borrowedList'
    //        borrowingBook.BorrowedBy = this;        //Set borrwed member in Book class
    //        borrowingBook.BookAvailablility = false;//Update availablility
    //    }
    //    else
    //    {
    //        MessageBox.Show($"{borrowingBook.BookTitel} is not available for borrowing.");
    //    }
    //}

    //public void ReturnBook(Book returningBook)
    //{
    //    if (this.borrowedList.Contains(returningBook))  //Check the book is borrowed
    //    {
    //        this.borrowedList.Remove(returningBook);    //If book was borrowed. The book remove from 'borrowedList'
    //        returningBook.BorrowedBy = null;            //Remove the borrowed member as well
    //        returningBook.BookAvailablility = true;     //Set the now book is available
    //        Console.WriteLine($"\n{returningBook.BookTitel} returned succesfully!" +
    //            $"\nPress Enter to continue...");
    //        while (Console.ReadKey().Key != ConsoleKey.Enter) ; //Set entry key to continue
    //    }
    //}
}
