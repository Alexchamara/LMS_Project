
using LMS1.Classes;
using LMS1.Librarian;
using System.ComponentModel;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Runtime.InteropServices;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;
using MySqlX.XDevAPI;
using static System.Reflection.Metadata.BlobBuilder;

namespace LMS1
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            runApplication();
        }

        //Run the application
        static void runApplication()
        {
            bool isClose = false;
            do
            {
                try
                {
                    int choice = 0;
                    welcomeMg();
                    Console.WriteLine("Choose the application you want to run");
                    Console.WriteLine();
                    Console.WriteLine("\t1. Console Application");
                    Console.WriteLine();
                    Console.WriteLine("\t2. Windows Form Application");
                    Console.WriteLine();
                    Console.WriteLine("\t3. Exit");
                    Console.WriteLine();
                    Console.Write("Enter your choice: ");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 1:   //Run the console application
                            Console.Write("* Running console from");
                            repeatDots();
                            Console.Clear();
                            Loging();
                            break;
                        case 2:  //Run the windows form application
                            Console.WriteLine("Running Windows Form Application");
                            FreeConsole();
                            ApplicationConfiguration.Initialize();
                            Application.Run(new MainInterFace());
                            isClose = true;
                            break;
                        case 3:     //Exit the application
                            Console.CursorVisible = false;  //Hide the cursor
                            Console.Write("Exiting");
                            repeatDots();
                            isClose = true;
                            break;
                        default:
                            invalidInputMg();
                            break;
                    }
                }
                catch (FormatException e)
                {
                    invalidInputMg();
                }
            } while (!isClose);
        }

        //Invalid input message
        static void invalidInputMg()
        {
            Console.WriteLine();
            Console.WriteLine("Invalid Input. Please ENTRY VALID number!");
            Thread.Sleep(1500);
            Console.Clear();
        }

        //Welcome message
        static void welcomeMg()
        {
            style("WELCOME TO LIBRARY MANAGMENT SYSTEM");
        }

        //the style for title
        static void style(String title)
        {
            Console.Clear();
            for (int i = 0; i < 120; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine(String.Format("\t\t\t\t\t" + title));
            for (int i = 0; i < 120; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        //Repeat dots style
        static void repeatDots()
        {
            for (int i = 0; i < 6; i++)
            {
                Thread.Sleep(150);
                Console.Write(".");
            }
        }

        //Login to the system
        static void Loging()
        {
            bool isRepeating = false;
            do
            {
                try
                {
                    int choice = 0;
                    style("WELCOME TO LIBRARY MANAGMENT SYSTEM");
                    Console.WriteLine("Choose the application you want to run");
                    Console.WriteLine();
                    Console.WriteLine("\t1. Librarian Login");
                    Console.WriteLine();
                    Console.WriteLine("\t2. Member Login");
                    Console.WriteLine();
                    Console.WriteLine("\t3. Main menu");
                    Console.WriteLine();
                    Console.Write("Enter your choice: ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:     //Librarian login
                            LibrarianLogin();
                            isRepeating = true;
                            break;
                        case 2:     //Member login
                            MemberLogin();
                            isRepeating = true;
                            break;
                        case 3:     //Main menu
                            runApplication();
                            isRepeating = true;
                            break;
                        default:
                            invalidInputMg();
                            isRepeating = false;
                            break;
                    }
                }
                catch
                {
                    invalidInputMg();
                    isRepeating = false;
                }
            } while (!isRepeating);
        }

        //Librarian login////////////////////////
        static void LibrarianLogin()
        {
            string userId;
            string password;

            style("WELCOME TO LIBRARY MANAGMENT SYSTEM : LOG IN");

            Console.WriteLine("Librarian Login");
            Console.WriteLine();
            Console.Write("\tEnter your user id: ");
            userId = Console.ReadLine();
            Console.WriteLine();
            Console.Write("\tEnter your password: ");
            password = Console.ReadLine();

            //Finds the librarian from the database
            var client = new MongoClient().GetDatabase("LMSdb");
            var librarian = client.GetCollection<LibrarianClass>("Librariandb").Find(_ => _.UserId == userId).FirstOrDefault();

            //Check the librarian name and password is matched
            if (librarian != null)
            {
                if (librarian.librarianLogin(userId, password))
                {
                    Console.WriteLine();
                    Console.WriteLine("* Login successful");
                    Console.WriteLine();
                    Console.Write("* Log in");
                    repeatDots();
                    LibrarianFace();
                }
                else
                {
                    //If the login is not successful
                    bool isRepeat = true;
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid user id or password");
                        Console.WriteLine();
                        Console.Write("Do you want to try again? (Y/N): ");
                        Console.WriteLine();
                        string choice = Console.ReadLine();
                        if (choice == "N" || choice == "n")
                        {
                            runApplication();
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            isRepeat = true;
                        }
                        else if (choice == "Y" || choice == "y")
                        {
                            LibrarianLogin();
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            isRepeat = true;
                        }
                        else
                        {
                            for (int i = 0; i < 2; i++)
                            {
                                Console.WriteLine("** Please entry Y or N **");
                            }
                        }
                    } while (isRepeat);
                }
            }
            else
            {
                //If the login is not successful
                Console.WriteLine();
                Console.WriteLine("Invalid user id or password");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                LibrarianLogin();
            }
        }

        //Librarian face
        static void LibrarianFace()
        {
            int choice = 0;
            while (choice != 5)
            {
                try
                {
                    style("WELCOME TO LIBRARY MANAGMENT SYSTEM : LIBRARIAN");
                    Console.WriteLine("Choose the application you want to run");
                    Console.WriteLine();
                    Console.WriteLine("\t1. View all transactions");
                    Console.WriteLine();
                    Console.WriteLine("\t2. Manage members");
                    Console.WriteLine();
                    Console.WriteLine("\t3. Manage books");
                    Console.WriteLine();
                    Console.WriteLine("\t4. Search");
                    Console.WriteLine();
                    Console.WriteLine("\t5. Log out");
                    Console.WriteLine();
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (choice == 1)    //View all transactions
                    {
                        Console.Write("* View all transactions");
                        repeatDots();
                        Console.Clear();
                        viewAllTransactions();
                    }
                    else if (choice == 2)   //Manage members
                    {
                        Console.Write("* Manage members");
                        repeatDots();
                        memberManage();
                        Console.Clear();
                    }
                    else if (choice == 3)   //Manage books
                    {
                        Console.Write("* Manage books");
                        repeatDots();
                        manageBooks();
                        Console.Clear();
                    }
                    else if (choice == 4)   //Search
                    {
                        Console.Write("* Search");
                        repeatDots();
                        search();
                        Console.Clear();
                    }
                    else if (choice == 5)   //Log out
                    {
                        bool isLogOut = false;
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Do you want to log out? (Y/N): ");
                            Console.WriteLine();
                            string respond = Console.ReadLine();
                            if (respond == "N" || respond == "n")
                            {
                                LibrarianFace();
                                isLogOut = false;
                            }
                            else if (respond == "Y" || respond == "y")
                            {
                                Console.Write("Exiting");
                                repeatDots();
                                Loging();
                                isLogOut = true;
                            }
                            else
                            {
                                for (int i = 0; i < 2; i++)
                                {
                                    Console.WriteLine("** Please entry Y or N **");
                                    Application.Exit();
                                }
                            }
                        }
                        while (!isLogOut);
                    }
                    else    //Invalid choice
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice!!");
                        Console.WriteLine();
                        bool isRepeat = false;
                        do
                        {
                            Console.Write("Do you want to try again? (Y/N): ");
                            Console.WriteLine();
                            string respond = Console.ReadLine();
                            if (respond == "N" || respond == "n")
                            {
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Loging();
                                isRepeat = false;
                            }
                            else if (respond == "Y" || respond == "y")
                            {
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                LibrarianFace();
                                isRepeat = true;
                            }
                            else
                            {
                                Console.WriteLine("** Please entry Y or N **");
                                Thread.Sleep(1500);
                                Application.Exit();
                                //for (int i = 0; i < 2; i++)
                                //{
                                //}
                            }
                        }
                        while (!isRepeat);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("** " + e.Message);
                    Console.WriteLine();
                    Console.WriteLine("* Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        //view all trasactions
        static void viewAllTransactions()
        {
            try
            {
                style("WELCOME TO LIBRARY MANAGMENT SYSTEM : VIEW ALL TRANSACTIONS");
                //Connect to the database
                var client = new MongoClient().GetDatabase("LMSdb");
                var collection = client.GetCollection<Transaction>("Transactiondb");
                var transactions = collection.Find(new BsonDocument()).ToList();

                //Display all transactions
                foreach (var transaction in transactions)
                {
                    Console.WriteLine("\t1. Transaction ID: " + transaction.Id);
                    Console.WriteLine("\t2. Member Name: " + transaction.MemberName);
                    Console.WriteLine("\t3. Member ID: " + transaction.MemberId);
                    Console.WriteLine("\t4. Book Title: " + transaction.BookTitle);
                    Console.WriteLine("\t5. Book ID: " + transaction.BookId);
                    Console.WriteLine("\t6. Transaction Type: " + transaction.TransactionType);
                    Console.WriteLine("\t7. Transaction Date: " + transaction.TransactionDateTime);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("** " + e.Message);
                //Thread.Sleep(1500);
                invalidInputMg();
            }
        }

        //manage books
        static void manageBooks()
        {
            int choice = 0;
            while (choice != 3)
            {
                try
                {
                    style("WELCOME TO LIBRARY MANAGMENT SYSTEM : MANAGE BOOKS");

                    Console.WriteLine("Choose the application you want to run");
                    Console.WriteLine();
                    Console.WriteLine("\t1. Add book");
                    Console.WriteLine();
                    Console.WriteLine("\t2. Remove book");
                    Console.WriteLine();
                    Console.WriteLine("\t3. Back to menu");
                    Console.WriteLine();
                    Console.Write("Enter your choice: ");
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)    //Add book
                    {
                        Console.Clear();
                        addBook();
                        Thread.Sleep(150);
                    }
                    else if (choice == 2)   //Remove book
                    {
                        Console.WriteLine();
                        removeBook();
                        Console.Clear();
                    }
                    else if (choice == 3)   //Back to menu
                    {
                        Console.WriteLine();
                        LibrarianFace();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine("** " + e.Message);
                }
            }
        }

        //Add book
        static void addBook()
        {
            style("WELCOME TO LIBRARY MANAGMENT SYSTEM : ADD BOOK");
            try
            {
                //Entry book details
                string bookName;
                string ISBN;
                string author;
                string publisher;
                string subject;
                int price;

                Console.WriteLine("*** Add a new book ***");
                Console.WriteLine();
                Console.Write("\t1. Entry book name: ");
                bookName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t2. Entry book ID: ");
                ISBN = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t3. Entry author: ");
                author = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t4. Entry Subject: ");
                subject = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t5. Entry publisher: ");
                publisher = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t7. Price: ");
                price = int.Parse(Console.ReadLine());

                //Add the book to the database
                Library library = new Library();
                //LibrarianClass librarian = new LibrarianClass("admin", "admin", "admin", "admin", "admin", 123456789);
                library.addBook(bookName, ISBN, author, publisher, subject, price);

                Console.WriteLine();
                Console.WriteLine("Book saved successfully!");
                Console.WriteLine();

                //Ask to add another book
                bool isRepeat = false;
                do
                {
                    Console.Write("Do you want to add another book? (Y/N): ");
                    string respond = Console.ReadLine();
                    if (respond == "N" || respond == "n")
                    {
                        manageBooks();
                        isRepeat = false;
                    }
                    else if (respond == "Y" || respond == "y")
                    {
                        addBook();
                        isRepeat = true;
                    }
                    else
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine("** Please entry Y or N **");
                            Console.WriteLine();
                            Application.Exit();
                        }
                    }
                }
                while (!isRepeat);
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("** " + e.Message);
                Thread.Sleep(1500);
                addBook();
            }
        }

        //remove book
        static void removeBook()
        {
            style("WELCOME TO LIBRARY MANAGMENT SYSTEM : REMOVE BOOK");
            try
            {
                //Entry book details
                string bookName;
                string ISBN;
                string reason;

                Console.WriteLine("*** Remove a book ***");
                Console.WriteLine();
                Console.Write("\t1. Book name: ");
                bookName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t2. ISBN: ");
                ISBN = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t3. Reson: ");
                reason = Console.ReadLine();

                //Remove the book from the database
                Library library = new Library();
                library.removeBook(ISBN, bookName);

                Console.WriteLine();
                Console.WriteLine("Book removed successfully!");
                Console.WriteLine();

                //Ask to remove another book
                bool isRepeat = false;
                do
                {
                    Console.Write("Do you want to add another book? (Y/N): ");
                    string respond = Console.ReadLine();
                    if (respond == "N" || respond == "n")
                    {
                        manageBooks();
                        isRepeat = false;
                    }
                    else if (respond == "Y" || respond == "y")
                    {
                        removeBook();
                        isRepeat = true;
                    }
                    else
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine("** Please entry Y or N **");
                            Console.WriteLine();
                            Application.Exit();
                        }
                    }
                }
                while (!isRepeat);
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("** " + e.Message);
                Thread.Sleep(1500);
                removeBook();
            }
        }

        //Manage members
        static void memberManage()
        {
            style("WELCOME TO LIBRARY MANAGMENT SYSTEM : MANAGE MEMBER");

            int choice = 0;
            while (choice != 3)
            {
                try
                {
                    Console.WriteLine("Choose the application you want to run");
                    Console.WriteLine();
                    Console.WriteLine("\t1. Add member");
                    Console.WriteLine();
                    Console.WriteLine("\t2. Remove member");
                    Console.WriteLine();
                    Console.WriteLine("\t3. Back to menu");
                    Console.WriteLine();
                    Console.Write("Enter your choice: ");
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)    //Add member
                    {
                        Console.Clear();
                        addMember();
                        Thread.Sleep(150);
                    }
                    else if (choice == 2)   //Remove member
                    {
                        Console.WriteLine();
                        removeMember();
                        Console.Clear();
                    }
                    else if (choice == 3)   //Back to menu
                    {
                        Console.WriteLine();
                        LibrarianFace();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine("** " + e.Message);
                }
            }
        }

        //Add member
        static void addMember()
        {
            style("WELCOME TO LIBRARY MANAGMENT SYSTEM : ADD MEMBER");
            try
            {
                //Entry member details
                string name;
                string membershipId;
                string NIC;
                int contact;
                string email;
                string loginPassword;

                Console.WriteLine("*** Add a new member ***");
                Console.WriteLine();
                Console.Write("\t1. Entry full name: ");
                name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t2. Entry membership ID: ");
                membershipId = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t3. Entry NIC: ");
                NIC = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t4. Entry contact number: ");
                contact = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("\t5. Entry email: ");
                email = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t6. Entry login password: ");
                loginPassword = Console.ReadLine();

                //Add the member to the database
                LibrarianClass librarian = new LibrarianClass("admin", "admin", "admin", "admin", "admin", 123456789);
                librarian.addMember(name, membershipId, NIC, contact, email, loginPassword);

                Console.WriteLine();
                Console.Write("Member saved successfully");
                repeatDots();
                Console.WriteLine();

                //Ask to add another member
                bool isRepeat = false;
                do
                {
                    Console.Write("Do you want to add another member? (Y/N): ");
                    string respond = Console.ReadLine();
                    if (respond == "N" || respond == "n")
                    {
                        memberManage();
                        isRepeat = false;
                    }
                    else if (respond == "Y" || respond == "y")
                    {
                        addMember();
                        isRepeat = true;
                    }
                    else
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine("** Please entry Y or N **");
                            Console.WriteLine();
                            Application.Exit();
                        }
                    }
                }
                while (!isRepeat);
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("** " + e.Message);
                Thread.Sleep(1500);
                addMember();
            }
        }

        //remove member
        static void removeMember()
        {
            style("WELCOME TO LIBRARY MANAGMENT SYSTEM : REMOVE MEMBER");

            try
            {
                //Entry member details
                string name;
                string membershipId;
                string NIC;
                string reason;

                Console.WriteLine("*** Remove a member ***");
                Console.WriteLine();
                Console.Write("\t1. Member name: ");
                name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t2. membership ID: ");
                membershipId = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t3. NIC: ");
                NIC = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t4. Reson: ");
                reason = Console.ReadLine();

                //Remove the member from the database
                LibrarianClass librarian = new LibrarianClass("admin", "admin", "admin", "admin", "admin", 123456789);
                librarian.removeMember(membershipId, name);

                Console.WriteLine();
                Console.WriteLine("Member removed successfully");
                repeatDots();
                Console.WriteLine();

                //Ask to remove another member
                bool isRepeat = false;
                do
                {
                    Console.Write("Do you want to add another member? (Y/N): ");
                    string respond = Console.ReadLine();
                    if (respond == "N" || respond == "n")
                    {
                        memberManage();
                        isRepeat = false;
                    }
                    else if (respond == "Y" || respond == "y")
                    {
                        removeMember();
                        isRepeat = true;
                    }
                    else
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine("** Please entry Y or N **");
                            Console.WriteLine();
                            Application.Exit();
                        }
                    }
                }
                while (!isRepeat);
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("** " + e.Message);
                Thread.Sleep(1500);
                removeMember();
            }
        }

        //Search
        static void search()
        {

            int choice = 0;
            while (choice != 3)
            {
                try
                {
                    style("WELCOME TO LIBRARY MANAGMENT SYSTEM : SEARCH");
                    Console.WriteLine("Choose the application you want to run");
                    Console.WriteLine();
                    Console.WriteLine("\t1. Search a book");
                    Console.WriteLine();
                    Console.WriteLine("\t2. Search a member");
                    Console.WriteLine();
                    Console.WriteLine("\t3. Back to menu");
                    Console.WriteLine();
                    Console.Write("Enter your choice: ");
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)    //Search a book
                    {
                        searchBook();
                        Thread.Sleep(150);
                        Console.Clear();
                    }
                    else if (choice == 2)   //Search a member
                    {
                        Console.WriteLine();
                        //searchMember();
                        Console.Clear();
                    }
                    else if (choice == 3)   //Back to menu
                    {
                        Console.WriteLine();
                        LibrarianFace();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine();
                        invalidInputMg();
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine("** " + e.Message);
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }

        //Search book by title and isbn
        static void searchBook()
        {
            style("WELCOME TO LIBRARY MANAGMENT SYSTEM : SEARCH");
            int choice = 0;
            do
            {
                try
                {
                    //Entry book details
                    string bookName;
                    string ISBN;

                    Console.WriteLine("*** Search a book ***");
                    Console.WriteLine();
                    Console.WriteLine("\t1. Book name");
                    Console.WriteLine();
                    Console.WriteLine("\t2. ISBN");
                    Console.WriteLine();
                    Console.WriteLine("\t3. Back to menu");
                    Console.WriteLine();
                    Console.Write("* Enter choice: ");
                    choice = int.Parse(Console.ReadLine());

                    var database = new MongoClient().GetDatabase("LMSdb");
                    Book book;
                    switch (choice)
                    {
                        case 1:
                            //Console.Clear();
                            Console.WriteLine();
                            Console.Write("\t* Enter Title: ");
                            bookName = Console.ReadLine();
                            Console.WriteLine();
                            book = database.GetCollection<Book>("Bookdb").Find(b => b.BookTitel == bookName).FirstOrDefault();
                            displayBookDetails(book);
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.Write("Enter ISBN: ");
                            ISBN = Console.ReadLine();
                            book = database.GetCollection<Book>("Bookdb").Find(b => b.BookISBN == ISBN).FirstOrDefault();
                            displayBookDetails(book);
                            break;
                        case 3:
                            Console.WriteLine();
                            LibrarianFace();
                            break;
                    }
                    Console.WriteLine();

                    //Ask to search another book
                    bool isRepeat = false;
                    do
                    {
                        Console.Write("Do you want to search another book? (Y/N): ");
                        string respond = Console.ReadLine();
                        if (respond == "N" || respond == "n")
                        {
                            LibrarianFace();
                            isRepeat = false;
                        }
                        else if (respond == "Y" || respond == "y")
                        {
                            searchBook();
                            isRepeat = true;
                        }
                        else
                        {
                            for (int i = 0; i < 2; i++)
                            {
                                Console.WriteLine("** Please entry Y or N **");
                                Console.WriteLine();
                                Application.Exit();
                            }
                        }
                    }
                    while (!isRepeat);
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine("** " + e.Message);
                    Thread.Sleep(2000);
                    searchBook();
                }
            } while (choice != 2);
            Console.Clear();
        }

        //Search by book name
        static void displayBookDetails(Book book)
        {
            Console.WriteLine("\t\t* Book name: " + book.BookTitel);
            Console.WriteLine();
            Console.WriteLine("\t\t* ISBN: " + book.BookISBN);
            Console.WriteLine();
            Console.WriteLine("\t\t* Author: " + book.BookAuthor);
            Console.WriteLine();
            Console.WriteLine("\t\t* Publication: " + book.BookPublication);
            Console.WriteLine();
            Console.WriteLine("\t\t* Subject: " + book.BookSubject);
            Console.WriteLine();
            Console.WriteLine("\t\t* Price: " + book.BookPrice);
            Console.WriteLine();
            Console.WriteLine("\t\t* Available: " + book.BookAvailablility);
            Console.WriteLine();
        }

        //Member face
        static void MemberFace()
        {
            int choice = 0;
            while (choice != 5)
            {
                try
                {
                    style(" WELCOME TO LIBRARY MANAGMENT SYSTEM");
                    Console.WriteLine("Choose the application you want to run");
                    Console.WriteLine("\t1. View all transactions");
                    Console.WriteLine("\t2. Manage members");
                    Console.WriteLine("\t3. Manage books");
                    Console.WriteLine("\t4. Search");
                    Console.WriteLine("\t5. Log out");
                    Console.WriteLine("\t6. Exit");
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("View all transactions");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Manage members");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Manage books");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("Search");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("Log outing...");
                        runApplication();
                    }
                    else if (choice == 6)
                    {
                        Console.WriteLine("Exiting...");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        //Member login
        static void MemberLogin()
        {
            string userId;
            string password;

            Console.Write("Enter your user id: ");
            userId = Console.ReadLine();

            Console.Write("Enter your password: ");
            password = Console.ReadLine();

            var client = new MongoClient().GetDatabase("LMSdb");
            var member = client.GetCollection<Member>("Memberdb").Find(_ => _.UserId == userId).FirstOrDefault();

            if (member != null)
            {
                Console.WriteLine("Login successful");
                if (member.memberLogin(userId, password))
                {
                    Console.WriteLine("Login successful");
                    MemberFace();
                }
                else
                {
                    Console.WriteLine("Invalid user id or password");
                }
            }
            else
            {
                Console.WriteLine("Invalid user id or password");
            }
        }




        //static void style(string title)
        //{
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.ForegroundColor = ConsoleColor.Black;
        //    Console.Clear();
        //}
    }
}