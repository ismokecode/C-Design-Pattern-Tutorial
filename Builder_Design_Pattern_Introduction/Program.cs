using System;

namespace Builder_Design_Pattern_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string RAM = "4GB";
            string HDDSize = "300 GB";
            ComputerSystem computerSystem = new ComputerSystem(RAM, HDDSize);
            string SystemConfigurationDetails = computerSystem.Build();
            Console.WriteLine(SystemConfigurationDetails);
            Console.ReadLine();
        }
    }
}
