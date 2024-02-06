using LMS1.Classes;

namespace LMS1
{
    public partial class LibrarianFace : Form
    {
        Librarian librarian;
        Library library = new Library();

        //Create a constructor for 'LibrarianFace' class
        public LibrarianFace(Library library, Librarian librarian)
        {
            InitializeComponent();
            librarianLoadPalen(new AddBooksForm(library));

            SidePanel.Height = addBookBtn.Height;
            SidePanel.Top = addBookBtn.Top;
            this.library = library;
            this.librarian = librarian;
        }

        //Load the panel
        public void librarianLoadPalen(object Form)
        {
            if (this.LibrarianMainPanel.Controls.Count > 0)
                this.LibrarianMainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.LibrarianMainPanel.Controls.Add(f);
            this.LibrarianMainPanel.Tag = f;
            f.Show();
        }

        //Close the form
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TransactionBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = TransactionBtn.Height;
            SidePanel.Top = TransactionBtn.Top;


        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = addBookBtn.Height;
            SidePanel.Top = addBookBtn.Top;

            librarianLoadPalen(new AddBooksForm(library));
        }

        private void removeBookBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = removeBookBtn.Height;
            SidePanel.Top = removeBookBtn.Top;

            librarianLoadPalen(new RemoveBooksForm(library));

        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = addMemberBtn.Height;
            SidePanel.Top = addMemberBtn.Top;

            librarianLoadPalen(new AddMemberForm(librarian));
        }

        private void removeMemberBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = removeMemberBtn.Height;
            SidePanel.Top = removeMemberBtn.Top;

            librarianLoadPalen(new RemoverMemberForm(librarian));

        }

        private void searchBookBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = searchBookBtn.Height;
            SidePanel.Top = searchBookBtn.Top;

            //librarianLoadPalen(new SearchBook());
            librarianLoadPalen(new LibrarianSearchForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new MainInterFace().Show();
            this.Hide();
        }
        private void LibrarianFace_Load(object sender, EventArgs e)
        {

        }

        
    }
}
