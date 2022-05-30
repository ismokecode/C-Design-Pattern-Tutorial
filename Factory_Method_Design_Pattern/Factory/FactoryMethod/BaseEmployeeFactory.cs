using System;
using System.Collections.Generic;
using System.Text;
using Factory_Method_Design_Pattern.Managers;
using Factory_Method_Design_Pattern.Models;

namespace Factory_Method_Design_Pattern.Factory
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee emp;
        public BaseEmployeeFactory(Employee _emp)
        {
            emp = _emp;
        }
        public abstract IEmployeeManager Create();
        public Employee ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            emp.bonus = manager.GetBonus();
            emp.pay = manager.GetPay();
            return emp;
        }
    }
}
