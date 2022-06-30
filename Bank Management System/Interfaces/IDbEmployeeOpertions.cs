using Bank_Management_System.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System.Interfaces
{
    internal interface IDbEmployeeOpertions
    {
        bool insertCustomer(Customer customer);
        bool updateCustomer(Customer customer);
        bool setCustomerBalance(string cusAccNo, double amount);
        string getCustomerAccNo();
    }
}
