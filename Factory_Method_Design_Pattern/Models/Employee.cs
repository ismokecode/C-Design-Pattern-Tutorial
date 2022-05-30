using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Design_Pattern.Models
{
    public class Employee
    {
        public int employeeType { get; set; }
        public decimal homeAllowance { get; set; }
        public decimal medicleAllowance { get; set; }
        public decimal bonus { get; set; }
        public decimal pay { get; set; }
    }
}
