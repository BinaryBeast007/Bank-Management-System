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
    public partial class RemoveAccount : Form
    {
        public RemoveAccount()
        {
            InitializeComponent();
        }
        public static string removeAccID = "";
        private void btnConfirmRemove_Click(object sender, EventArgs e)
        {
            if (removeAccID[0] == 'C')
            {
                DbOperation dbOperation = new DbOperation();
                bool isRemoved = dbOperation.removeCustomer(removeAccID);
                if (isRemoved)
                {
                    MessageBox.Show("Removed Successfully!!");
                }
                else
                {
                    MessageBox.Show("Can't Remove the account!");
                }
            }
            else if (removeAccID[0] == 'E')
            {
                DbManagerOperations dbOperation = new DbManagerOperations();
                bool isRemoved = dbOperation.removeEmployee(removeAccID);
                if (isRemoved)
                {
                    MessageBox.Show("Removed Successfully!!");
                }
                else
                {
                    MessageBox.Show("Can't Remove the account!");
                }
            }else
            {
                MessageBox.Show("Account not found!!");
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeDashboard().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
