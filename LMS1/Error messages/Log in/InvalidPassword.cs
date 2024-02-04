using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS1.Error_messages
{
    public partial class InvalidPassword : Form
    {
        public InvalidPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
