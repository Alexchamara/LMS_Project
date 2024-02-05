
using LMS1.Classes;
using System.ComponentModel;
using MongoDB.Driver;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

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
            //Member member = new Member("chamara", "chamara", "1234", "1234", "asddf", 88789);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainInterFace());
            //Application.Run(new MemberFace(member));
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