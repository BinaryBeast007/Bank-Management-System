using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System.Classes
{
    internal class Employee : User
    {
        private string employeeID;
        private string employeePassword;

        public Employee() { }
        public Employee(string name, string gender, string address, string dob, string nationality, string email, string mobileNumber, string nidNo, string employeeID, string employeePassword) : base(name, gender, address, dob, nationality, email, mobileNumber, nidNo) 
        {
            this.employeeID = employeeID;
            this.employeePassword = employeePassword;   
        }
        public string EmployeeID { get { return employeeID; } set { employeeID = value; } }
        public string EmployeePassword { get { return employeePassword; } set { employeePassword = value; } }
    }
}
