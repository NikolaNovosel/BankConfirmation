using BankConfirmation_UI_WF.REST;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankConfirmation_UI_WF
{
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
        }
        private void GetAccountListClick(object sender, EventArgs e)
        {
            AccountRest accountRest = new();
            dataGridView1.DataSource = accountRest.GetAll().Select(i => new { i.Id, i.Number, i.Balance, i.AccountDateOpen, i.AccountType }).ToList();
        }
    }
}
