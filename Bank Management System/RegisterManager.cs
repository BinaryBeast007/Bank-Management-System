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
    public partial class RegisterManager : Form
    {
        public RegisterManager()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignIn().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateManagerAcc_Click(object sender, EventArgs e)
        {
            bool isValid = isValidToSaveData();
            if (!isValid) return;
            Manager manager = new Manager();
            manager.Name = txtFullName.Text;
            if (rbtnMale.Checked) manager.Gender = "Male";
            else manager.Gender = "Female";
            manager.Address = txtAddress.Text;
            manager.Dob = dtpDob.Text;
            manager.Nationality = comboBoxNationality.Text;
            manager.Email = txtEmail.Text;
            manager.MobileNumber = txtMobileNo.Text;
            manager.NidNo = txtNidNo.Text;
            manager.ManagerPassword = txtPassword.Text;
            manager.ManagerID = txtIdNo.Text;

            DbManagerOperations dbManagerOperations = new DbManagerOperations();
            bool isInserted = dbManagerOperations.insertManager(manager);
            if (isInserted)
            {
                MessageBox.Show("Registration Successful!");
                this.Hide();
                new SignIn().Show();
            }
            else
            {
                MessageBox.Show("Registration Not Successful!");
            }
        }
        private bool isValidToSaveData()
        {
            if(!txtEmail.Text.Contains("@") && !txtEmail.Text.Contains(".com"))
            {
                MessageBox.Show("Invalid Email");
                return false;
            }
            if(!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Password doesn't match!");
                return false;
            }
            if(String.IsNullOrEmpty(txtFullName.Text) || String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtMobileNo.Text) || String.IsNullOrEmpty(txtNidNo.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtConfirmPassword.Text) || String.IsNullOrEmpty(comboBoxNationality.Text) || (!rbtnMale.Checked && !rbtnFemale.Checked))
            {
                MessageBox.Show("Empty text field(s)");
                return false;
            }else
            {
                return true;
            }
        }
    }
}
