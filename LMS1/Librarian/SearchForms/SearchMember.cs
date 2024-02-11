using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS1
{
    public partial class SearchMember : Form
    {
        // MongoDB connection
        IMongoClient client = new MongoClient();
        IMongoDatabase database;
        List<Member> members = new List<Member>();

        // DataTable for the DataGridView
        DataTable table;

        public SearchMember()
        {
            InitializeComponent();

            // Fill the members list with the members from the database
            database = client.GetDatabase("LMSdb");
            members = database.GetCollection<Member>("Memberdb").Find(_ => true).ToList();
        }

        private void SearchMember_Load(object sender, EventArgs e)
        {
            this.SearchMemberTextRemove.Focus();

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

        // Remove member button click event
        private void SearchMemberTextRemoveMember_TextChanged(object sender, EventArgs e)
        {
            if (this.memberNameRadioBtn.Checked)
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = "Name LIKE '" + SearchMemberTextRemove.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            else if (this.membershipIdRadioBtn.Checked)
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = "Membership_ID LIKE '" + SearchMemberTextRemove.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            else if (this.NICRadioBtn.Checked)
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = "NIC LIKE '" + SearchMemberTextRemove.Text + "%'";
                dataGridView1.DataSource = dv;
            }
        }

        // Remove member button click event
        private void memberNameRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.SearchMemberTextRemove.Clear();
            this.SearchMemberTextRemove.Focus();

            DataView dv = table.DefaultView;
            dv.RowFilter = "Name LIKE '" + SearchMemberTextRemove.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        // Radio button checked changed to Membership ID
        private void membershipIdRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.SearchMemberTextRemove.Clear();
            this.SearchMemberTextRemove.Focus();

            DataView dv = table.DefaultView;
            dv.RowFilter = "Membership_ID LIKE '" + SearchMemberTextRemove.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        // Radio button checked changed to NIC
        private void NICRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.SearchMemberTextRemove.Clear();
            this.SearchMemberTextRemove.Focus();

            DataView dv = table.DefaultView;
            dv.RowFilter = "NIC LIKE '" + SearchMemberTextRemove.Text + "%'";
            dataGridView1.DataSource = dv;
        }
    }
}
