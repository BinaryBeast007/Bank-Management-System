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
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchAccount.formToOpen = new EmployeeDetails();
            SearchAccount.goBackForm = new ManagerDashboard();
            new SearchAccount().Show();
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterEmployee registerEmployee = new RegisterEmployee();
            registerEmployee.txtIDNo.Text = new DbManagerOperations().getEmployeeAccNo(); 
            registerEmployee.Show(); 
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignIn().Show();
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            SearchAccount.formToOpen = new UpdateEmployee();
            SearchAccount.goBackForm = new ManagerDashboard();
            this.Hide();
            new SearchAccount().Show();
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            SearchAccount.formToOpen = new RemoveAccount();
            SearchAccount.goBackForm = new ManagerDashboard();
            this.Hide();
            new SearchAccount().Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new About().Show(); 
        }

        private void btnPrivacyPolicy_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PrivacyPolicy().Show(); 
        }
    }
}
