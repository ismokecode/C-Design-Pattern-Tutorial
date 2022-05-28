using System;
using System.Collections.Generic;
using Builder_Design_Pattern_Implementation.Builder.Director;
using Builder_Design_Pattern_Implementation.Builder.IBuilder.ConcreteBuilder;
using Builder_Design_Pattern_Implementation.Builder.Product;

namespace Builder_Design_Pattern_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> formCollection = new Dictionary<string, string>();
            formCollection.Add("Drive", "300GB");
            formCollection.Add("RAM", "4B");
            formCollection.Add("Mouse", "MTech");
            formCollection.Add("Keyboard", "KTech");
            formCollection.Add("TouchScreen", "Yes");
            //Concrete Builder
            ISystemBuilder systemBuilder = new LaptopBuilder();
            //Director
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.BuildSystem(systemBuilder, formCollection);
            ComputerSystem system = systemBuilder.GetSystem();
            Console.WriteLine("Hello World!");
        }
    }
}
