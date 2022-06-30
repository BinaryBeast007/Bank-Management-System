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
    public partial class AddMoney : Form
    {
        public AddMoney()
        {
            InitializeComponent();
        }
        public static string addMoneyAccNo = "";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchAccount().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirmAddMoney_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Add amount please!");
                return;
            }
            double amount = Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(lblAMBalance.Text);
            DbEmployeeOperations dbEmployeeOperations = new DbEmployeeOperations();
            bool isAdded = dbEmployeeOperations.setCustomerBalance(addMoneyAccNo, amount);
            if (isAdded)
            {
                MessageBox.Show("Money Added Successfully!");
                lblAMBalance.Text = amount.ToString();  
                txtAmount.Text = "";
            }else
            {
                MessageBox.Show("Can't Add Money!!");
            }
        }
    }
}
