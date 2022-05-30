using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_Pattern_Introduction.Managers
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 1000;
        }

        public decimal GetPay()
        {
            return 500;
        }
    }
}
