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
    internal class DbManagerOperations : IDbManagerOperations
    {
        SqlConnection connection = new SqlConnection(@"Data Source=SAYEM-PC\SQLEXPRESS;Initial Catalog=BankManagementSystem;Integrated Security=True");
        public bool insertManager(Manager manager)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into ManagerInformation(ID, Name, Password, Gender, Address, Dob, Nationality, Email, MobileNo, NidNo) values('" + manager.ManagerID + "','" + manager.Name + "','" + manager.ManagerPassword + "','" + manager.Gender + "','" + manager.Address + "','" + manager.Dob + "','" + manager.Nationality + "','" + manager.Email + "','" + manager.MobileNumber + "','" + manager.NidNo + "')", connection);
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
        public bool insertEmployee(Employee employee)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into EmployeeInformation(ID, Name, Password, Gender, Address, Dob, Nationality, Email, MobileNo, NidNo) values('" + employee.EmployeeID + "','" + employee.Name + "','" + employee.EmployeePassword + "','" + employee.Gender + "','" + employee.Address + "','" + employee.Dob + "','" + employee.Nationality + "','" + employee.Email + "','" + employee.MobileNumber + "','" + employee.NidNo + "')", connection);
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
        public Employee searchEmployee(string empID)
        {
            connection.Open();
            string command = "select* from EmployeeInformation Where ID = '" + empID + "'";
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
            Employee employee = new Employee();
            if (reader.Read())
            {
                try
                {
                    employee.EmployeeID = reader["ID"].ToString();
                    employee.Name = reader["Name"].ToString();
                    employee.Gender = reader["Gender"].ToString();
                    employee.Address = reader["Address"].ToString();
                    employee.Dob = reader["Dob"].ToString();
                    employee.Nationality = reader["Nationality"].ToString();
                    employee.Email = reader["Email"].ToString();
                    employee.MobileNumber = reader["MobileNo"].ToString();
                    employee.NidNo = reader["NidNo"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                return null;
            }
            connection.Close();
            return employee;
        }
        public bool removeEmployee(string empID)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from EmployeeInformation where ID = '" + empID + "'", connection);
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
        public string getEmployeeAccNo()
        {
            connection.Open();
            string command = "SELECT TOP 1 ID FROM EmployeeInformation ORDER BY ID DESC";
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            SqlDataReader reader = null;
            string empID = "";
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
                    empID = reader["ID"].ToString();
                    if (empID.Equals("")) empID = "E-0";
                    string temp = empID.Remove(0, 2);
                    empID = "E-" + (Convert.ToInt32(temp) + 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            connection.Close();
            return empID;
        }
        public bool updateEmployee(Employee employee)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update EmployeeInformation set Name = '" + employee.Name + "', Gender = '" + employee.Gender + "', Address = '" + employee.Address + "', Dob = '" + employee.Dob + "', Nationality = '" + employee.Nationality + "', Email = '" + employee.Email + "', MobileNo = '" + employee.MobileNumber + "', NidNo = '" + employee.NidNo + "' Where ID = '" + employee.EmployeeID + "'", connection);
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
    }
}
