using System;
using System.Collections.Generic;
using System.Text;
using Factory_Design_Pattern_Introduction.Managers;

namespace Factory_Design_Pattern_Introduction.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int emptype)
        {
            IEmployeeManager returnValue = null;
            if (emptype == 1)
            {
                returnValue = new PermanentEmployeeManager();
            }
            else if(emptype==2)
            {
                returnValue = new ContractEmployeeManager();
            }
            return returnValue;
        }
    }
}
