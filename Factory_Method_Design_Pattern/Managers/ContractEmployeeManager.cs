using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Design_Pattern.Managers
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
        public decimal GetMedicleAllowance()
        {
            return 500;
        }
    }
}
