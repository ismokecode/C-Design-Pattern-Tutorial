using System;
using System.Collections.Generic;
using System.Text;
using Factory_Method_Design_Pattern.Managers;
using Factory_Method_Design_Pattern.Models;

namespace Factory_Method_Design_Pattern.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp):base(emp)
        {

        }
        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            emp.homeAllowance = manager.GetHomeAllowance();
            return manager;
        }
    }
}
