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
    public partial class RegisterEmployee : Form
    {
        public RegisterEmployee()
        {
            InitializeComponent();
        }
        private bool isValidToSaveData()
        {
            if (!txtEmail.Text.Contains("@") && !txtEmail.Text.Contains(".com"))
            {
                MessageBox.Show("Invalid Email");
                return false;
            }
            if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Password doesn't match!");
                return false;
            }
            if (String.IsNullOrEmpty(txtFullName.Text) || String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtMobileNo.Text) || String.IsNullOrEmpty(txtNidNo.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtConfirmPassword.Text) || String.IsNullOrEmpty(comboBoxNationality.Text) || (!rbtnMale.Checked && !rbtnFemale.Checked))
            {
                MessageBox.Show("Empty text field(s)");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnCreateEmployeeAcc_Click(object sender, EventArgs e)
        {
            bool isValid = isValidToSaveData();
            if (!isValid) return;
            Employee employee = new Employee();
            employee.Name = txtFullName.Text;
            if (rbtnMale.Checked) employee.Gender = "Male";
            else employee.Gender = "Female";
            employee.Address = txtAddress.Text;
            employee.Dob = dtpDob.Text;
            employee.Nationality = comboBoxNationality.Text;
            employee.Email = txtEmail.Text;
            employee.MobileNumber = txtMobileNo.Text;
            employee.NidNo = txtNidNo.Text;
            employee.EmployeePassword = txtPassword.Text;
            employee.EmployeeID = txtIDNo.Text;

            DbManagerOperations dbManagerOperations = new DbManagerOperations();
            bool isInserted = dbManagerOperations.insertEmployee(employee);
            if (isInserted)
            {
                MessageBox.Show("Registration Successful!");
                this.Hide();
                new ManagerDashboard().Show();
            }
            else
            {
                MessageBox.Show("Registration Not Successful!");
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManagerDashboard().Show();
        }
    }
}
