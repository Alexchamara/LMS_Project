
using LMS1.Classes;
using System.ComponentModel;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Runtime.InteropServices;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //bool isRunning = true;
            //int choice = 0;
            //do
            //{
            //    //Create a CLI menu to choose whether to run a colsole app or windows form application
            //    Console.WriteLine("Welcome to the Library Management System");
            //    Console.WriteLine("Choose the application you want to run");
            //    Console.WriteLine("1. Console Application");
            //    Console.WriteLine("2. Windows Form Application");
            //    Console.WriteLine("3. Exit");
            //    Console.Write("Enter your choice: ");
            //    string choice = Console.ReadLine();
            //    switch (choice)
            //    {
            //        case "1":
            //            Console.WriteLine("Running Console Application");
            //            Console.WriteLine("Press any key to continue...");
            //            Console.ReadKey();
            //            Console.Clear();
            //            LibrarianFace();
            //            break;
            //        case "2":
            //            Console.WriteLine("Running Windows Form Application");
            //            FreeConsole();
            //            ApplicationConfiguration.Initialize();
            //            Application.Run(new MainInterFace());
            //            isRunning = false; 
            //            break;
            //        case "3":
            //            Console.WriteLine("Exiting...");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid choice");
            //            break;
            //    }
            //}
            //while (isRunning);



            //static void LibrarianFace()
            //{
            //    Console.WriteLine("Welcome to the Library Management System");
            //    Console.WriteLine("Choose the application you want to run");
            //    Console.WriteLine("1. View all transactions");
            //    Console.WriteLine("2. Manage members");
            //    Console.WriteLine("3. Manage books");
            //    Console.WriteLine("4. Search");
            //    Console.WriteLine("5. Exit");
            //    Console.Write("Enter your choice: ");
            //    string choice = Console.ReadLine();
            //    switch (choice)
            //    {
            //        case "1":
            //            Console.WriteLine("Add a new member");
            //            Console.WriteLine("Press any key to continue...");
            //            Console.ReadKey();
            //            Console.Clear();
            //            break;
            //        case "2":
            //            Console.WriteLine("Add a new book");
            //            Console.WriteLine("Press any key to continue...");
            //            Console.ReadKey();
            //            Console.Clear();
            //            break;
            //        case "3":
            //            Console.WriteLine("Issue a book");
            //            Console.WriteLine("Press any key to continue...");
            //            Console.ReadKey();
            //            Console.Clear();
            //            break;
            //        case "4":
            //            Console.WriteLine("Return a book");
            //            Console.WriteLine("Press any key to continue...");
            //            Console.ReadKey();
            //            Console.Clear();
            //            break;
            //        case "5":
            //            Console.WriteLine("Search for a member");
            //            Console.WriteLine("Press any key to continue...");
            //            Console.ReadKey();
            //            Console.Clear();
            //            break;
            //        case "6":
            //            Console.WriteLine("Search for a book");
            //            Console.WriteLine("Press any key to continue...");
            //            Console.ReadKey();
            //            Console.Clear();
            //            break;
            //        case "7":
            //            Console.WriteLine("View all members");
            //            Console.WriteLine("Press any key to continue...");
            //            Console.ReadKey();
            //            Console.Clear();
            //            break;
            //        case "8":
            //            Console.WriteLine("View all books");
            //            Console.WriteLine("Press any key to continue...");
            //            Console.ReadKey();
            //            Console.Clear();
            //            break;
            //        case "9":
            //            Console.WriteLine("View all transactions");
            //            Console.WriteLine("Press any key to continue...");
            //            Console.ReadKey();
            //            Console.Clear();
            //            break;
            //        case "10":
            //            Console.WriteLine("Exiting...");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid choice");
            //            break;
            //    }
            //}
            //ApplicationConfiguration.Initialize();
            //Application.Run(new MainInterFace());


            ////Add the librarian to the database
            //LibrarianClass librarian = new LibrarianClass("admin", "admin", "admin", "admin", "admin", 123456789);
            //var client = new MongoClient().GetDatabase("LMSdb");
            //client.GetCollection<LibrarianClass>("Librariandb").InsertOne(librarian);

            ////Librarian lib = client.GetCollection<Librarian>("Librariandb").Find(_ => _.UserName == "admin").FirstOrDefault();
            ////Console.WriteLine(lib.UserName);

        }

        //Run the application
        static void runApplication()
        {
            int choice = 0;
            while (choice != 3)
            {
                style("WELCOME TO LIBRARY MANAGMENT SYSTEM");

                Console.WriteLine("Choose the application you want to run");
                Console.WriteLine("\t1. Console Application");
                Console.WriteLine("\t2. Windows Form Application");
                Console.WriteLine("\t3. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Running Console Application");
                        Console.Clear();
                        Loging();
                        break;
                    case 2:
                        Console.WriteLine("Running Windows Form Application");
                        FreeConsole();
                        ApplicationConfiguration.Initialize();
                        Application.Run(new MainInterFace());
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        //Login to the system
        static void Loging()
        {
            style("WELCOME TO LIBRARY MANAGMENT SYSTEM");
            
            Console.WriteLine("\t1. Librarian Login");
            Console.WriteLine("\t2. Member Login");
            Console.WriteLine("\t3. Main menu");
            Console.WriteLine("\t4. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                LibrarianLogin();
            }
            else if (choice == 2)
            {
                //MemberLogin();
            }
            else if (choice == 3)
            {
                runApplication();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Exiting...");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }

        //Librarian login
        static void LibrarianLogin()
        {
            string userId;
            string password;

            style("WELCOME TO LIBRARY MANAGMENT SYSTEM : LIBRARIAN LOG IN");

            Console.Write("Enter your user id: ");
            userId = Console.ReadLine();

            Console.Write("Enter your password: ");
            password = Console.ReadLine();

            var client = new MongoClient().GetDatabase("LMSdb");
            var librarian = client.GetCollection<LibrarianClass>("Librariandb").Find(_ => _.UserId == userId).FirstOrDefault();

            if (librarian != null)
            {
                Console.WriteLine("Login successful");
                if (librarian.librarianLogin(userId, password))
                {
                    Console.WriteLine("Login successful");
                    LibrarianFace();
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

        //Librarian face
        static void LibrarianFace()
        {
            int choice = 0;
            while (choice != 5)
            {
                try
                {
                    style("WELCOME TO LIBRARY MANAGMENT SYSTEM");

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

        //the style for title
        static void style(String title)
        {
            Console.Clear();
            for (int i = 0; i < 80; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine(String.Format("\t\t\t\t" + title));
            for (int i = 0; i < 80; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine();
        }


        //static void style(string title)
        //{
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.ForegroundColor = ConsoleColor.Black;
        //    Console.Clear();
        //}
    }
}