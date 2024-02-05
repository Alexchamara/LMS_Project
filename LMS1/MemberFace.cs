using LMS1.Classes;

namespace LMS1
{
    public partial class MemberFace : Form
    {
        Member member;
        public MemberFace(Member member)
        {
            this.member = member;

            InitializeComponent();
            memberLoadPanel(new MemberBorrowBookForm(member));

            SidePanel.Height = borrowBookBtn.Height;
            SidePanel.Top = borrowBookBtn.Top;
        }

        public void memberLoadPanel(object Form)
        {
            if (this.MemberMainPanel.Controls.Count > 0)
                this.MemberMainPanel.Controls.RemoveAt(0);
            Form fm = Form as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.MemberMainPanel.Controls.Add(fm);
            this.MemberMainPanel.Tag = fm;
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void borrowBookBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = borrowBookBtn.Height;
            SidePanel.Top = borrowBookBtn.Top;

            memberLoadPanel(new MemberBorrowBookForm(member));
        }

        private void returnBookBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = returnBookBtn.Height;
            SidePanel.Top = returnBookBtn.Top;

            memberLoadPanel(new MemberReturnBookForm());
        }

        private void borrowedBookBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = borrowedBookBtn.Height;
            SidePanel.Top = borrowedBookBtn.Top;

        }

        private void searchBookBtn_Click(object sender, EventArgs e)
        {
            memberLoadPanel(new SearchBook());

            SidePanel.Height = searchBookBtn.Height;
            SidePanel.Top = searchBookBtn.Top;
        }

        private void MemberFace_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new MainInterFace().Show();
            this.Hide();
        }
    }
}
