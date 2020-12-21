using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TPADestop_GA20_2_.Strategy;

namespace TPADestop_GA20_2_.Facade
{
    public class windowOpener //Facade
    {
        Window window;
        windowStrategy strategy = new windowStrategy();
        public windowOpener()
        {
            
        }

        public void setRole(String role, DataRow dataRow)
        {
            if (role == "teller")
            {
                strategy.setStrategy(new TellerWindow(new Employee(dataRow["EmployeeID"].ToString(), dataRow["EmployeeEmail"].ToString(), dataRow["EmployeePassword"].ToString(), dataRow["EmployeeRole"].ToString())));
            }

            if (role == "queueMachine")
            {
                strategy.setStrategy(new QueuingMachine(new Employee(dataRow["EmployeeID"].ToString(), dataRow["EmployeeEmail"].ToString(), dataRow["EmployeePassword"].ToString(), dataRow["EmployeeRole"].ToString())));
            }

            if (role == "atm")
            {
                strategy.setStrategy(new ATMWindow(new Employee(dataRow["EmployeeID"].ToString(), dataRow["EmployeeEmail"].ToString(), dataRow["EmployeePassword"].ToString(), dataRow["EmployeeRole"].ToString())));
            }

            if (role == "customerService")
            {
                strategy.setStrategy(new CustomerServiceWindow(new Employee(dataRow["EmployeeID"].ToString(), dataRow["EmployeeEmail"].ToString(), dataRow["EmployeePassword"].ToString(), dataRow["EmployeeRole"].ToString())));
            }
        }
    }
}
