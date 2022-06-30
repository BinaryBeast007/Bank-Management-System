using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System.Classes
{
    internal class Manager : User
    {
        private string managerID;
        private string managerPassword;

        public Manager() { }
        public Manager(string name, string gender, string address, string dob, string nationality, string email, string mobileNumber, string nidNo, string employeeID, string employeePassword) : base(name, gender, address, dob, nationality, email, mobileNumber, nidNo)
        {
            this.managerID = employeeID;
            this.managerPassword = employeePassword;
        }
        public string ManagerID { get { return managerID; } set { managerID = value; } }
        public string ManagerPassword { get { return managerPassword; } set { managerPassword = value; } }
    }
}
