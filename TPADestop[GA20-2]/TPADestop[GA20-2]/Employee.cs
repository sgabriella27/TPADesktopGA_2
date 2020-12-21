using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPADestop_GA20_2_
{
    public class Employee
    {
        public string employeeID;
        public string employeeEmail;
        public string employeePassword;
        public string emplyeeRole;

        public Employee(string employeeID, string employeeEmail, string employeePassword, string emplyeeRole)
        {
            this.employeeID = employeeID;
            this.employeeEmail = employeeEmail;
            this.employeePassword = employeePassword;
            this.emplyeeRole = emplyeeRole;
        }

        public Employee()
        {

        }


    }
}
