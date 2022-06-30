using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System.Classes
{
    internal class Customer : User 
    {
        private string accountType;
        private string accountNo;
        private double balance;

        public Customer() { }
        public Customer(string name, string gender, string address, string dob, string nationality, string email, string mobileNumber, string nidNo, string accountType, string accountNo, double balance) : base(name, gender, address, dob, nationality, email, mobileNumber, nidNo)
        {
            this.accountType = accountType;
            this.accountNo = accountNo; 
            this.balance = balance;
        }
        public string AccountType { get { return accountType; } set { accountType = value; } }
        public string AccountNo { get { return accountNo; } set { accountNo = value; } }
        public double Balance { get { return balance; } set { balance = value; } }
    }
}
