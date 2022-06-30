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
    public partial class SearchAccount : Form
    {
        public SearchAccount()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            goBackForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static Form formToOpen = null;
        public static Form goBackForm = null;
        private void updateCustomerForm()
        {
            if (txtAccNo.Text[0] == 'C')
            {
                DbOperation dbOperation = new DbOperation();
                Customer customer = dbOperation.searchCustomer(txtAccNo.Text);
                if (customer == null)
                {
                    MessageBox.Show("No Account Found!");
                }
                UpdateCustomer updateCustomer = new UpdateCustomer();
                updateCustomer.txtFullName.Text = customer.Name;
                if (customer.Gender == "Male") { updateCustomer.rbtnMale.Checked = true; }
                else { updateCustomer.rbtnFemale.Checked = true; }
                updateCustomer.txtAddress.Text = customer.Address;
                updateCustomer.dtpDob.Text = customer.Dob;
                updateCustomer.comboBoxNationality.Text = customer.Nationality;
                updateCustomer.txtEmail.Text = customer.Email;
                updateCustomer.txtMobileNo.Text = customer.MobileNumber;
                updateCustomer.txtNidNo.Text = customer.NidNo;
                updateCustomer.comboBoxAccType.Text = customer.AccountType;
                updateCustomer.txtBalance.Text = customer.Balance.ToString();
                updateCustomer.txtAccNo.Text = customer.AccountNo;
                this.Hide();
                updateCustomer.Show();
            }
            else
            {
                MessageBox.Show("No Account Found!");
            }
        }
        private void removeAccount()
        {
            if (txtAccNo.Text[0] == 'C')
            {
                DbOperation dbOperation = new DbOperation();
                Customer customer = dbOperation.searchCustomer(txtAccNo.Text);
                if (customer == null)
                {
                    MessageBox.Show("No Account Found!");
                    return;
                }
                RemoveAccount remove = new RemoveAccount();
                remove.lblRemAccName.Text = customer.Name;
                remove.lblRemAccNo.Text = customer.AccountNo;
                RemoveAccount.removeAccID = customer.AccountNo;
                this.Hide();
                remove.Show();
            }else if(txtAccNo.Text[0] == 'E')
            {
                DbManagerOperations dbOperation = new DbManagerOperations();
                Employee employee = dbOperation.searchEmployee(txtAccNo.Text);
                if (employee == null)
                {
                    MessageBox.Show("No Account Found!");
                    return;
                }
                RemoveAccount remove = new RemoveAccount();
                remove.lblRemAccName.Text = employee.Name;
                remove.lblRemAccNo.Text = employee.EmployeeID;
                remove.lblAccOrId.Text = "ID";
                RemoveAccount.removeAccID = employee.EmployeeID;
                this.Hide();
                remove.Show();
            }
            else
            {
                MessageBox.Show("No Account Found!");
            }
        }
        private void addMoney()
        {
            if (txtAccNo.Text[0] == 'C')
            {
                DbOperation dbOperation = new DbOperation();
                Customer customer = dbOperation.searchCustomer(txtAccNo.Text);
                if (customer == null)
                {
                    MessageBox.Show("No Account Found!");
                    return;
                }
                AddMoney addMoney = new AddMoney();
                addMoney.lblAMName.Text = customer.Name;
                addMoney.lblAMAccNo.Text = customer.AccountNo;
                addMoney.lblAMBalance.Text = customer.Balance.ToString();
                AddMoney.addMoneyAccNo = customer.AccountNo;
                this.Hide();
                addMoney.Show();
            }
            else
            {
                MessageBox.Show("No Account Found!");
            }
        }
        private void withdrawMoney()
        {
            if (txtAccNo.Text[0] == 'C')
            {
                DbOperation dbOperation = new DbOperation();
                Customer customer = dbOperation.searchCustomer(txtAccNo.Text);
                if (customer == null)
                {
                    MessageBox.Show("No Account Found!");
                    return;
                }
                WithdrawMoney withdrawMoney = new WithdrawMoney();
                withdrawMoney.lblWMName.Text = customer.Name;
                withdrawMoney.lblWMAccNo.Text = customer.AccountNo;
                withdrawMoney.lblWMBalance.Text = customer.Balance.ToString();
                WithdrawMoney.withdrawMoneyAccNo = customer.AccountNo;
                this.Hide();
                withdrawMoney.Show();
            }
            else
            {
                MessageBox.Show("No Account Found!");
            }
        }
        private void checkBalance()
        {
            if (txtAccNo.Text[0] == 'C')
            {
                DbOperation dbOperation = new DbOperation();
                Customer customer = dbOperation.searchCustomer(txtAccNo.Text);
                if (customer == null)
                {
                    MessageBox.Show("No Account Found!");
                    return;
                }
                CheckBalance checkBalance = new CheckBalance();
                checkBalance.lblName.Text = customer.Name;
                checkBalance.lblAccNo.Text = customer.AccountNo;
                checkBalance.lblBalance.Text = customer.Balance.ToString();
                this.Hide();
                checkBalance.Show();
            }
            else
            {
                MessageBox.Show("No Account Found!");
            }
        }
        private void customerDetails()
        {
            if (txtAccNo.Text[0] == 'C')
            {
                DbOperation dbOperation = new DbOperation();
                Customer customer = dbOperation.searchCustomer(txtAccNo.Text);
                if (customer == null)
                {
                    MessageBox.Show("No Account Found!");
                    return;
                }
                CustomerAccountDetails customerAccount = new CustomerAccountDetails();
                customerAccount.lblFullName.Text = customer.Name;
                customerAccount.lblAccNo.Text = customer.AccountType;
                customerAccount.lblBalance.Text = customer.Balance.ToString();
                customerAccount.lblAccountType.Text = customer.AccountType;
                customerAccount.lblAddress.Text = customer.Address; 
                customerAccount.lblDob.Text = customer.Dob;
                customerAccount.lblEmail.Text = customer.Email;
                customerAccount.lblMobileNo.Text = customer.MobileNumber;
                customerAccount.lblNationality.Text = customer.Nationality;
                customerAccount.lblNidNo.Text = customer.NidNo; 
                customerAccount.lblGender.Text = customer.Gender;
                this.Hide();
                customerAccount.Show();
            }
            else
            {
                MessageBox.Show("No Account Found!");
            }
        }
        private void employeeDetails()
        {
            if (txtAccNo.Text[0] == 'E')
            {
                DbManagerOperations dbOperation = new DbManagerOperations();
                Employee employee = dbOperation.searchEmployee(txtAccNo.Text);
                if (employee == null)
                {
                    MessageBox.Show("No Account Found!");
                    return;
                }
                EmployeeDetails employeeDetails = new EmployeeDetails();
                employeeDetails.lblFullName.Text = employee.Name;
                employeeDetails.lblIDNo.Text = employee.EmployeeID;
                employeeDetails.lblAddress.Text = employee.Address;
                employeeDetails.lblDob.Text = employee.Dob;
                employeeDetails.lblEmail.Text = employee.Email;
                employeeDetails.lblMobileNo.Text = employee.MobileNumber;
                employeeDetails.lblNationality.Text = employee.Nationality;
                employeeDetails.lblNidNo.Text = employee.NidNo;
                employeeDetails.lblGender.Text = employee.Gender;
                this.Hide();
                employeeDetails.Show();
            }
            else
            {
                MessageBox.Show("No Account Found!");
            }
        }
        private void updateEmployee()
        {
            if (txtAccNo.Text[0] == 'E')
            {
                DbManagerOperations dbOperation = new DbManagerOperations();
                Employee employee = dbOperation.searchEmployee(txtAccNo.Text);
                if (employee == null)
                {
                    MessageBox.Show("No Account Found!");
                }
                UpdateEmployee updateEmployee = new UpdateEmployee();
                updateEmployee.txtFullName.Text = employee.Name;
                if (employee.Gender == "Male") { updateEmployee.rbtnMale.Checked = true; }
                else { updateEmployee.rbtnFemale.Checked = true; }
                updateEmployee.txtAddress.Text = employee.Address;
                updateEmployee.dtpDob.Text = employee.Dob;
                updateEmployee.comboBoxNationality.Text = employee.Nationality;
                updateEmployee.txtEmail.Text = employee.Email;
                updateEmployee.txtMobileNo.Text = employee.MobileNumber;
                updateEmployee.txtNidNo.Text = employee.NidNo;
                updateEmployee.txtIDNo.Text = employee.EmployeeID;
                this.Hide();
                updateEmployee.Show();
            }
            else
            {
                MessageBox.Show("No Account Found!");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtAccNo.Text))
            {
                MessageBox.Show("Enter a Account No/Id");
                return;
            }
            if(formToOpen is UpdateCustomer)
            {
                updateCustomerForm();
            }else if(formToOpen is RemoveAccount)
            {
                removeAccount();
            }else if(formToOpen is AddMoney)
            {
                addMoney();
            }else if(formToOpen is WithdrawMoney)
            {
                withdrawMoney();
            }else if(formToOpen is CheckBalance)
            {
                checkBalance();
            }else if(formToOpen is CustomerAccountDetails)
            {
                customerDetails();
            }
            else if (formToOpen is EmployeeDetails)
            {
                if(txtAccNo.Text[0] == 'E')
                {
                    employeeDetails();
                }else if(txtAccNo.Text[0] == 'C')
                {
                    customerDetails();
                }else
                {
                    MessageBox.Show("Account Not Found!");
                }
            }
            else if (formToOpen is UpdateEmployee)
            {
                updateEmployee();
            }
        }
    }
}
