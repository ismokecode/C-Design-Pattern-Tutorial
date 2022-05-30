using System;
using System.Collections.Generic;
using System.Text;
using Factory_Method_Design_Pattern.Managers;
using Factory_Method_Design_Pattern.Models;

namespace Factory_Method_Design_Pattern.Factory.FactoryMethod
{
    public class ContractEmployeeFactory:BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp): base(emp)
        {

        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            emp.medicleAllowance = manager.GetMedicleAllowance();
            return manager;
        }
    }
}
