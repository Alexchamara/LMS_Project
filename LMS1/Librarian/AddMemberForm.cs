using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS1.Classes;
using MongoDB.Driver;

namespace LMS1
{
    public partial class AddMemberForm : Form
    {
        Librarian librarian;

        public AddMemberForm(Librarian librarian)
        {
            InitializeComponent();
            this.librarian = librarian;
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidate())
                {
                    librarian.addMember(this.AddMemberNameTextBox.Text, this.AddMembershipIdTextBox.Text, this.AddNICTextBox.Text, int.Parse(this.MemberContactTexBox.Text), this.AddEmailTextBox.Text, this.MemberLoginPasswordTextBox.Text);
                    MessageBox.Show("Member saved successfully!");
                    this.AddMemberNameTextBox.Clear();
                    this.AddMembershipIdTextBox.Clear();
                    this.AddNICTextBox.Clear();
                    this.MemberContactTexBox.Clear();
                    this.AddEmailTextBox.Clear();
                    this.MemberLoginPasswordTextBox.Clear();
                    this.AddMemberNameTextBox.Focus();
                }
            }
            catch (MongoWriteException ex)
            {
                if (ex.WriteError.Category == ServerErrorCategory.DuplicateKey)
                {
                    MessageBox.Show("Duplicate Key Error: " + ex.WriteError.Message);
                    this.AddMembershipIdTextBox.Clear();
                    this.AddMembershipIdTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("MongoDB write error: " + ex.WriteError.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool isValidate()
        {
            if (this.AddMemberNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter the member name!");
                this.AddMemberNameTextBox.Focus();
                return false;
            }
            else if (this.AddMembershipIdTextBox.Text == "")
            {
                MessageBox.Show("Please enter the membership ID!");
                this.AddMembershipIdTextBox.Focus();
                return false;
            }
            else if (this.AddNICTextBox.Text == "")
            {
                MessageBox.Show("Please enter the NIC!");
                this.AddNICTextBox.Focus();
                return false;
            }
            else if (this.MemberContactTexBox.Text == "")
            {
                MessageBox.Show("Please enter the contact number!");
                this.MemberContactTexBox.Focus();
                return false;
            }
            else if (this.MemberLoginPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please enter the password!");
                this.MemberLoginPasswordTextBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {
            this.AddMemberNameTextBox.Focus();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.AddMemberNameTextBox.Clear();
            this.AddMembershipIdTextBox.Clear();
            this.AddNICTextBox.Clear();
            this.MemberContactTexBox.Clear();
            this.AddEmailTextBox.Clear();
            this.MemberLoginPasswordTextBox.Clear();
            this.AddMemberNameTextBox.Focus();
        }
    }
}
