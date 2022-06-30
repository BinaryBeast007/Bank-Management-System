using Bank_Management_System.Classes;
using Bank_Management_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management_System.Operations
{
    internal class DbOperation : IDbOperations
    {
        SqlConnection connection = new SqlConnection(@"Data Source=SAYEM-PC\SQLEXPRESS;Initial Catalog=BankManagementSystem;Integrated Security=True");
        public bool verifyLogin(string userName, string password)
        {
            connection.Open();
            string command = "select* from ManagerInformation Where ID = '" + userName + "' and Password = '" + password + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            bool isVerified = false;
            if(dataTable.Rows.Count > 0) isVerified = true;
            command = "select* from EmployeeInformation Where ID = '" + userName + "' and Password = '" + password + "'";
            SqlDataAdapter adapter2 = new SqlDataAdapter(command, connection);
            DataTable dataTable2 = new DataTable();
            try
            {
                adapter2.Fill(dataTable2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            if (dataTable2.Rows.Count > 0) isVerified = true;
            return isVerified;
        }
        public Customer searchCustomer(string cusAccNo)
        {
            connection.Open();
            string command = "select* from CustomerInformation Where AccountNo = '" + cusAccNo + "'";
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            SqlDataReader reader = null;
            try
            {
                reader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Customer customer = new Customer();
            if (reader.Read())
            {
                try
                {
                    customer.AccountNo = reader["AccountNo"].ToString();
                    customer.Name = reader["Name"].ToString();
                    customer.Gender = reader["Gender"].ToString();
                    customer.Address = reader["Address"].ToString();
                    customer.Dob = reader["Dob"].ToString();
                    customer.Nationality = reader["Nationality"].ToString();
                    customer.Email = reader["Email"].ToString();
                    customer.MobileNumber = reader["MobileNo"].ToString();
                    customer.NidNo = reader["NidNo"].ToString();
                    customer.AccountType = reader["NidNo"].ToString();
                    customer.Balance = Convert.ToDouble(reader["Balance"].ToString());
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else
            {
                return null;
            }
            connection.Close();
            return customer;
        }
        public bool removeCustomer(string cusAccNo)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from CustomerInformation where AccountNo = '" + cusAccNo + "'", connection);
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
        public string getManagerAccNo()
        {
            connection.Open();
            string command = "SELECT TOP 1 ID FROM ManagerInformation ORDER BY ID DESC";
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            SqlDataReader reader = null;
            string manID = "";
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
                    manID = reader["ID"].ToString();
                    if (manID.Equals("")) manID = "M-0";
                    string temp = manID.Remove(0, 2);
                    manID = "M-" + (Convert.ToInt32(temp) + 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            connection.Close();
            return manID;
        }   
    }
}
