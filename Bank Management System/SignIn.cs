using Bank_Management_System.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management_System
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DbOperation dbOperation = new DbOperation();
            bool isVerified = dbOperation.verifyLogin(txtSignInEmail.Text, txtSignInPassword.Text);
            if(!isVerified)
            {
                MessageBox.Show("Wrong Credentials!");
                return;
            }
            string id = txtSignInEmail.Text;
            if (id[0] == 'M')
            {
                this.Hide();
                SearchAccount.goBackForm = new ManagerDashboard();
                new ManagerDashboard().Show();
            }else if(id[0] == 'E')
            {
                this.Hide();
                SearchAccount.goBackForm = new EmployeeDashboard();
                new EmployeeDashboard().Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkSignInToSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=SAYEM-PC\SQLEXPRESS;Initial Catalog=BankManagementSystem;Integrated Security=True");
            connection.Open();
            string command = "select* from ManagerInformation";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (dataTable.Rows.Count < 2)
            {
                this.Hide();
                RegisterManager registerManager = new RegisterManager();
                registerManager.txtIdNo.Text = new DbOperation().getManagerAccNo();
                registerManager.Show();
            }
            else
            {
                MessageBox.Show("Can't register anymore managers!!");
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please remember the password!");
        }
    }
}
