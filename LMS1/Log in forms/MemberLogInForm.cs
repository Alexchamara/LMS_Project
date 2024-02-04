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

namespace LMS1
{
    public partial class MemberLogInForm : Form
    {
        public MemberLogInForm()
        {
            InitializeComponent();
        }

        private void MemberLogInFormBtn_Click(object sender, EventArgs e)
        {
            if (MemberUserNaneTextBox.Text == "chamara" && MemberLogInPassword.Text == "0987")
            {
                
                MainInterFace mainInterFaceForm = Application.OpenForms["MainInterFace"] as MainInterFace;
                mainInterFaceForm?.Hide();  //error

                this.Hide();

                new MemberFace().Show();
            }
            else if (isValid())
            {
                new InvalidUname_Password().ShowDialog();
                MemberUserNaneTextBox.Clear();
                MemberLogInPassword.Clear();
                MemberUserNaneTextBox.Focus();
            }
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MemberUserNaneTextBox.Focus();
            MemberUserNaneTextBox.Clear();
            MemberLogInPassword.Clear();
        }

        private void MemberLogInForm_Load(object sender, EventArgs e)
        {
            MemberUserNaneTextBox.Focus();
        }

        

        
    }
}
