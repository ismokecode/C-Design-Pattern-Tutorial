using System;
using System.Collections.Generic;
using System.Text;
using Factory_Method_Design_Pattern.Models;

namespace Factory_Method_Design_Pattern.Factory.FactoryMethod
{
    public class EmployeeManagerBaseFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            BaseEmployeeFactory returnValue = null;
            if (emp.employeeType == 1)
            {
                returnValue = new PermanentEmployeeFactory(emp);
            }
            else if (emp.employeeType == 2)
            {
                returnValue = new ContractEmployeeFactory(emp);
            }
            return returnValue;
        }
    }
}
