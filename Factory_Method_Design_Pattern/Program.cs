using System;
using Factory_Method_Design_Pattern.Factory;
using Factory_Method_Design_Pattern.Factory.FactoryMethod;
using Factory_Method_Design_Pattern.Models;

namespace Factory_Method_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { employeeType=1 };
            BaseEmployeeFactory factory = new EmployeeManagerBaseFactory().CreateFactory(emp);
            emp = factory.ApplySalary();
            Console.WriteLine("Hello World!");
        }
    }
}
