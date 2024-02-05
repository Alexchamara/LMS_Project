using LMS1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LMS1
{
    public partial class RemoverMemberForm : Form
    {
        Librarian librarian;

        // MongoDB connection
        IMongoClient client = new MongoClient();
        IMongoDatabase database;
        List<Member> members = new List<Member>();

        // DataTable for the DataGridView
        DataTable table;

        public RemoverMemberForm(Librarian librarian)
        {
            this.librarian = librarian;
            InitializeComponent();

            // Fill the members list with the members from the database
            database = client.GetDatabase("LMSdb");
            members = database.GetCollection<Member>("Memberdb").Find(_ => true).ToList();
        }

        private void RemoveMemberBtn_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                // Remove the member from the library
                librarian.removeMember(this.RemoveMembershipIdTextBox.Text, this.RemoveMemberNameTextBox.Text);
                this.RemoveMembershipIdTextBox.Clear();
                this.RemoveMemberNameTextBox.Clear();
                this.RemoveNICTextBox.Clear();
                this.RemoveMemberResonTexBox.Clear();
                this.RemoveMemberNameTextBox.Focus();
            }
            refreshMembertb();
        }

        private bool isValidated()
        {
            if (this.RemoveMemberNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter the member name!");
                this.RemoveMemberNameTextBox.Focus();
                return false;
            }
            else if (this.RemoveMembershipIdTextBox.Text == "")
            {
                MessageBox.Show("Please enter the membership ID!");
                this.RemoveMembershipIdTextBox.Focus();
                return false;
            }
            else if (this.RemoveMemberResonTexBox.Text == "")
            {
                MessageBox.Show("Please enter the reason for removing the member!");
                this.RemoveMemberResonTexBox.Focus();
                return false;
            }
            return true;
        }

        private void RemoverMemberForm_Load(object sender, EventArgs e)
        {
            this.RemoveMemberNameTextBox.Focus();
            refreshMembertb();
        }

        private void refreshMembertb()
        {
            // Fill the DataGridView with the members from the database
            members = database.GetCollection<Member>("Memberdb").Find(_ => true).ToList();

            table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Membership_ID", typeof(string));
            table.Columns.Add("Contact No", typeof(string));
            table.Columns.Add("NIC", typeof(string));
            table.Columns.Add("Email", typeof(string));

            // Add the members to the DataTable
            foreach (Member member in members)
            {
                table.Rows.Add(member.UserName, member.UserId, member.Contact, member.UserNIC, member.UserEmail);
            }

            // Set the DataGridView data source to the DataTable
            dataGridView1.DataSource = table;
        }

        // Search text changed event
        private void SearchMemberTextRemoveMember_TextChanged(object sender, EventArgs e)
        {
            if (this.memberNameRadioBtn.Checked)
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = "Name LIKE '" + SearchMemberTextRemoveMember.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            else if (this.membershipIdRadioBtn.Checked)
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = "Membership_ID LIKE '" + SearchMemberTextRemoveMember.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            else if (this.NICRadioBtn.Checked)
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = "NIC LIKE '" + SearchMemberTextRemoveMember.Text + "%'";
                dataGridView1.DataSource = dv;
            }
        }

        // Radio button checked changed to Member Name
        private void memberNameRadioBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            this.SearchMemberTextRemoveMember.Focus();

            DataView dv = table.DefaultView;
            dv.RowFilter = "Name LIKE '" + SearchMemberTextRemoveMember.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        // Radio button checked changed to Membership ID
        private void membershipIdRadioBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            this.SearchMemberTextRemoveMember.Focus();

            DataView dv = table.DefaultView;
            dv.RowFilter = "Membership_ID LIKE '" + SearchMemberTextRemoveMember.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        // Radio button checked changed to NIC
        private void NICRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.SearchMemberTextRemoveMember.Focus();

            DataView dv = table.DefaultView;
            dv.RowFilter = "NIC LIKE '" + SearchMemberTextRemoveMember.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        // DataGridView cell double click event
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.RemoveMemberNameTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.RemoveMembershipIdTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.RemoveNICTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            this.RemoveMemberResonTexBox.Focus();
        }

        // Clear button click event
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.RemoveMembershipIdTextBox.Clear();
            this.RemoveMemberNameTextBox.Clear();
            this.RemoveNICTextBox.Clear();
            this.RemoveMemberResonTexBox.Clear();
            this.RemoveMemberNameTextBox.Focus();
        }
    }
}
