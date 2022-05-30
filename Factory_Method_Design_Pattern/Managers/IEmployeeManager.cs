using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Design_Pattern.Managers
{
    public interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetPay();
    }
}
