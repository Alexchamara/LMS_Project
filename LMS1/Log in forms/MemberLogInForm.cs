using LMS1.Error_messages;
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

namespace LMS1
{
    public partial class MemberLogInForm : Form
    {
        public MemberLogInForm()
        {
            InitializeComponent();
        }

        //Check the memberId and password is valid
        private void MemberLogInFormBtn_Click(object sender, EventArgs e)
        {
            //Create a connection with the database
            var client = new MongoClient().GetDatabase("LMSdb");
            var memberInfo = client.GetCollection<Member>("Memberdb").Find(m => m.UserId == MemberUserNaneTextBox.Text).FirstOrDefault();

            //Check the memberId and password is valid
            if (memberInfo != null && memberInfo.memberLogin(this.MemberUserNaneTextBox.Text, MemberLogInPassword.Text))
            {
                //Hide the main interface form
                if (memberInfo.memberLogin(this.MemberUserNaneTextBox.Text, this.MemberLogInPassword.Text))
                {
                    MainInterFace mainInterFaceForm = Application.OpenForms["MainInterFace"] as MainInterFace;
                    mainInterFaceForm?.Hide();

                    this.Hide();

                    new MemberFace().Show();
                }
                else    //If the memberId and password is invalid
                {
                    new InvalidUname_Password().ShowDialog();
                    MemberUserNaneTextBox.Clear();
                    MemberLogInPassword.Clear();
                    MemberUserNaneTextBox.Focus();
                }
            }   //If the memberId and password is invalid
            else if (isValid())
            {
                new InvalidUname_Password().ShowDialog();
                MemberUserNaneTextBox.Clear();
                MemberLogInPassword.Clear();
                MemberUserNaneTextBox.Focus();
            }
            //if (MemberUserNaneTextBox.Text == "chamara" && MemberLogInPassword.Text == "0987")
            //{
            //  MainInterFace mainInterFaceForm = Application.OpenForms["MainInterFace"] as MainInterFace;
            //  mainInterFaceForm?.Hide();

            //  this.Hide();

            //  new MemberFace().Show();
            //}
            //else if (isValid())
            //{
            //    new InvalidUname_Password().ShowDialog();
            //    MemberUserNaneTextBox.Clear();
            //    MemberLogInPassword.Clear();
            //    MemberUserNaneTextBox.Focus();
            //}
        }

        //Check the text boxs are empty
        private bool isValid()
        {
            if (MemberUserNaneTextBox.Text == string.Empty)
            {
                new InvalidUserName().ShowDialog();
                MemberUserNaneTextBox.Focus();
                return false;
            }
            else if (MemberLogInPassword.Text == string.Empty)
            {
                new InvalidPassword().ShowDialog();
                MemberLogInPassword.Focus();
                return false;
            }
            return true;
        }
        
        //Clear the text boxes
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MemberUserNaneTextBox.Focus();
            MemberUserNaneTextBox.Clear();
            MemberLogInPassword.Clear();
        }

        //Close the form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MemberLogInForm_Load(object sender, EventArgs e)
        {
            MemberUserNaneTextBox.Focus();
        }
    }
}
