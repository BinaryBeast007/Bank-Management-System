using Bank_Management_System.Classes;
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
    public partial class CustomerSignUp : Form
    {
        public CustomerSignUp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeDashboard().Show();
        }
        private bool isValidToSaveData()
        {
            if (!txtEmail.Text.Contains("@") && !txtEmail.Text.Contains(".com"))
            {
                MessageBox.Show("Invalid Email");
                return false;
            }
            if (String.IsNullOrEmpty(txtFullName.Text) || String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtMobileNo.Text) || String.IsNullOrEmpty(txtNidNo.Text) ||  String.IsNullOrEmpty(comboBoxNationality.Text) || (!rbtnMale.Checked && !rbtnFemale.Checked))
            {
                MessageBox.Show("Empty text field(s)");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnCreateCustomerAcc_Click(object sender, EventArgs e)
        {
            txtAccNo.Text = new DbEmployeeOperations().getCustomerAccNo();
            bool isValid = isValidToSaveData();
            if (!isValid) return;
            Customer customer = new Customer();
            customer.Name = txtFullName.Text;
            if (rbtnMale.Checked) customer.Gender = "Male";
            else customer.Gender = "Female";
            customer.Address = txtAddress.Text;
            customer.Dob = dtpDob.Text;
            customer.Nationality = comboBoxNationality.Text;
            customer.Email = txtEmail.Text;
            customer.MobileNumber = txtMobileNo.Text;
            customer.NidNo = txtNidNo.Text;
            customer.AccountType = comboBoxAccType.Text;
            customer.Balance = Convert.ToDouble(txtInitialDeposit.Text);
            customer.AccountNo = txtAccNo.Text;

            DbEmployeeOperations dbEmployeeOperations = new DbEmployeeOperations();
            bool isInserted = dbEmployeeOperations.insertCustomer(customer);
            if (isInserted)
            {
                MessageBox.Show("Registration Successful!");
                this.Hide();
                new EmployeeDashboard().Show();
            }
            else
            {
                MessageBox.Show("Registration Not Successful!");
            }
        }
    }
}
