using Bank_Management_System.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System.Interfaces
{
    internal interface IDbManagerOperations
    {
        bool insertManager(Manager manager);
        Employee searchEmployee(string empID);
        bool insertEmployee(Employee employee);
        bool removeEmployee(string empID);
        string getEmployeeAccNo();
    }
}
