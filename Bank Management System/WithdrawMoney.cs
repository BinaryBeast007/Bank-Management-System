using Bank_Management_System.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management_System
{
    public partial class WithdrawMoney : Form
    {
        public WithdrawMoney()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchAccount().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string withdrawMoneyAccNo = "";
        private void btnConfirmWithdrawMoney_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Add amount please!");
                return;
            }
            if(Convert.ToDouble(lblWMBalance.Text) < Convert.ToDouble(txtAmount.Text))
            {
                MessageBox.Show("Not enough money in account");
                return;
            }
            double amount = Convert.ToDouble(lblWMBalance.Text) - Convert.ToDouble(txtAmount.Text);
            DbEmployeeOperations dbEmployeeOperations = new DbEmployeeOperations();
            bool isAdded = dbEmployeeOperations.setCustomerBalance(withdrawMoneyAccNo, amount);
            if (isAdded)
            {
                MessageBox.Show("Withdrawn Successfully!");
                lblWMBalance.Text = amount.ToString();
                txtAmount.Text = "";
            }
            else
            {
                MessageBox.Show("Can't Withdraw Money!!");
            }
        }
    }
}
