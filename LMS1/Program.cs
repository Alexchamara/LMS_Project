
using LMS1.Classes;
using System.ComponentModel;

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
            Library library = new Library();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new MemberFace());
              Application.Run(new MainInterFace());
            //Application.Run(new AddBooksForm());
            //Application.Run(new LibrarianFace(library));
        }

 


    }
}