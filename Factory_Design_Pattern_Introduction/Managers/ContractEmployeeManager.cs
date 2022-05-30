using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_Pattern_Introduction.Managers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 400;
        }

        public decimal GetPay()
        {
            return 200;
        }
    }
}
