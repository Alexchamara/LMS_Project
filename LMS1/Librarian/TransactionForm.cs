using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using LMS1.Classes;
using LMS1.Librarian;
using MongoDB.Driver;
namespace LMS1
{
    public partial class TransactionForm : Form
    {
        List<ClassTransaction> transactions = new List<ClassTransaction>();
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            transactions = new MongoClient().GetDatabase("LMSdb").GetCollection<ClassTransaction>("Transactiondb").Find(_ => true).ToList();

            foreach (ClassTransaction transaction in transactions)
            {
                this.flowLayoutPanel1.Controls.Add(new TrasactionCard(transaction));
            }
        }
    }
}
