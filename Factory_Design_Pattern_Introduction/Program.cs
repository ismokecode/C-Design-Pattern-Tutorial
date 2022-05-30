using System;
using Factory_Design_Pattern_Introduction.Factory;
using Factory_Design_Pattern_Introduction.Managers;

namespace Factory_Design_Pattern_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManagerFactory empFactory = new EmployeeManagerFactory();
            IEmployeeManager empManager = empFactory.GetEmployeeManager(1);
            decimal pay = empManager.GetPay();
            decimal bonus = empManager.GetBonus();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
