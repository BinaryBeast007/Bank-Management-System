using Bank_Management_System.Classes;
using Bank_Management_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management_System.Operations
{
    internal class DbEmployeeOperations : IDbEmployeeOpertions
    {
        SqlConnection connection = new SqlConnection(@"Data Source=SAYEM-PC\SQLEXPRESS;Initial Catalog=BankManagementSystem;Integrated Security=True");
        public bool insertCustomer(Customer customer)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into CustomerInformation(AccountNo, Name, Gender, Address, Dob, Nationality, Email, MobileNo, NidNo, AccountType, Balance) values('" + customer.AccountNo + "','" + customer.Name + "','" + customer.Gender + "','" + customer.Address + "','" + customer.Dob + "','" + customer.Nationality + "','" + customer.Email + "','" + customer.MobileNumber + "','" + customer.NidNo + "','" + customer.AccountType + "','" + customer.Balance + "')", connection);
            int count = 0;
            try
            {
                count = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            if (count > 0) { return true; }
            else { return false; }
        }
        
        public bool updateCustomer(Customer customer)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update CustomerInformation set Name = '" + customer.Name + "', Gender = '" + customer.Gender + "', Address = '" + customer.Address + "', Dob = '" + customer.Dob + "', Nationality = '" + customer.Nationality +"', Email = '" + customer.Email + "', MobileNo = '" + customer.MobileNumber + "', NidNo = '" + customer.NidNo + "', AccountType = '" + customer.AccountType + "', Balance = '" + customer.Balance + "' Where AccountNo = '" + customer.AccountNo + "'", connection);
            int count = 0;
            try
            {
                count = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            connection.Close();
            if (count > 0) { return true; }
            else { return false; }
        }
        public bool setCustomerBalance(string cusAccNo, double amount)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update CustomerInformation set Balance = '" + amount + "' Where AccountNo = '" + cusAccNo + "'", connection);
            int count = 0;
            try
            {
                count = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            if (count > 0) { return true; }
            else { return false; }
        }
        public string getCustomerAccNo()
        {
            connection.Open();
            string command = "SELECT TOP 1 AccountNo FROM CustomerInformation ORDER BY AccountNo DESC";
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            SqlDataReader reader = null;
            string cusAccNo = "";
            try
            {
                reader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (reader.Read())
            {
                try
                {
                    cusAccNo = reader["AccountNo"].ToString();
                    if (cusAccNo.Equals("")) cusAccNo = "C-0";
                    string temp = cusAccNo.Remove(0, 2);
                    cusAccNo = "C-" + (Convert.ToInt32(temp) + 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            connection.Close();
            return cusAccNo;
        }
    }
}
