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
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new SearchAccount().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool isValidToSaveData()
        {
            if (!txtEmail.Text.Contains("@") && !txtMobileNo.Text.Contains(".com"))
            {
                MessageBox.Show("Invalid Email");
                return false;
            }
            if (String.IsNullOrEmpty(txtFullName.Text) || String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtMobileNo.Text) || String.IsNullOrEmpty(txtNidNo.Text) || String.IsNullOrEmpty(comboBoxNationality.Text) || (!rbtnMale.Checked && !rbtnFemale.Checked))
            {
                MessageBox.Show("Empty text field(s)");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnUpdateEmployeeAcc_Click(object sender, EventArgs e)
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
            employee.EmployeeID = txtIDNo.Text;

            DbManagerOperations dbEmployeeOperations = new DbManagerOperations();
            bool isUpdated = dbEmployeeOperations.updateEmployee(employee);
            if (isUpdated) { MessageBox.Show("Account Updated!"); this.Hide(); new ManagerDashboard().Show(); }
            else { MessageBox.Show("Account Can't be updated!"); }
        }
    }
}
