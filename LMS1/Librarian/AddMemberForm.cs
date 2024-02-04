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
                librarian.addMember(this.AddMemberNameTextBox.Text, this.AddMembershipIdTextBox.Text, this.AddNICTextBox.Text, int.Parse(this.MemberContactTexBox.Text), this.AddEmailTextBox.Text, this.MemberLoginPasswordTextBox.Text);
                MessageBox.Show("Member saved successfully!");
                this.AddMemberNameTextBox.Clear();
                this.AddMembershipIdTextBox.Clear();   
                this.AddNICTextBox.Clear();
                this.MemberContactTexBox.Clear();
                this.AddEmailTextBox.Clear();
                this.MemberLoginPasswordTextBox.Clear();
            }
            catch (MongoWriteException ex)
            {
                if(ex.WriteError.Category == ServerErrorCategory.DuplicateKey)
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

        private void AddMemberForm_Load(object sender, EventArgs e)
        {

        }

    }
}
