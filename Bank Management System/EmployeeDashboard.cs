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
    public partial class EmployeeDashboard : Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }
        
        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchAccount.formToOpen = new AddMoney(); 
            new SearchAccount().Show();
        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchAccount.formToOpen = new WithdrawMoney();
            new SearchAccount().Show();
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchAccount.formToOpen = new CheckBalance();
            new SearchAccount().Show();
        }

        private void btnCheckbookIssue_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchAccount().Show();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchAccount.formToOpen = new UpdateCustomer();
            new SearchAccount().Show();
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchAccount.formToOpen = new CustomerAccountDetails();
            new SearchAccount().Show();
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchAccount.formToOpen = new RemoveAccount();
            new SearchAccount().Show();
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSignUp customerSignUp = new CustomerSignUp();
            customerSignUp.txtAccNo.Text = new DbEmployeeOperations().getCustomerAccNo();
            customerSignUp.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignIn().Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new About().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PrivacyPolicy().Show();
        }
    }
}
