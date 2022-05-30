using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_Pattern_Introduction.Managers
{
    public interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetPay();
    }
}
