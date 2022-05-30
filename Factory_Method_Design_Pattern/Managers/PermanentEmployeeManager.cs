using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Design_Pattern.Managers
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
        public decimal GetHomeAllowance()
        {
            return 1500;
        }
    }
}
