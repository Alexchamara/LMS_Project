
using LMS1.Classes;
using System.ComponentModel;
using MongoDB.Driver;

namespace LMS1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Library library = new Library();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainInterFace());
            //Application.Run(new MemberFace());
            //Application.Run(new AddBooksForm());
            //Application.Run(new LibrarianFace(library));




            ////Add the librarian to the database
            //Librarian librarian = new Librarian("admin", "admin", "admin", "admin", "admin", 123456789);
            //var client = new MongoClient().GetDatabase("LMSdb");
            //client.GetCollection<Librarian>("Librariandb").InsertOne(librarian);

            ////Librarian lib = client.GetCollection<Librarian>("Librariandb").Find(_ => _.UserName == "admin").FirstOrDefault();
            ////Console.WriteLine(lib.UserName);

        }
    }
}