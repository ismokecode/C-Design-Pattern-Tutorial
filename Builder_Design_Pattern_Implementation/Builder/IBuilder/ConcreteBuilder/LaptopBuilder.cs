using System;
using System.Collections.Generic;
using System.Text;
using Builder_Design_Pattern_Implementation.Builder.Product;
using Builder_Design_Pattern_Implementation.Builder.IBuilder;


namespace Builder_Design_Pattern_Implementation.Builder.IBuilder.ConcreteBuilder
{
    public class LaptopBuilder : ISystemBuilder
    {
        ComputerSystem laptop = new ComputerSystem();
        public void AddDrive(string size)
        {
            laptop.HDDSize = size;
        }

        public void AddKeyBoard(string type)
        {
            return;
        }

        public void AddMemory(string Memory)
        {
            laptop.RAM = Memory;
        }

        public void AddMouse(string type)
        {
            return;
        }

        public void AddTouchScreen(string enabled)
        {
            laptop.TouchScreen = enabled;
        }

        public ComputerSystem GetSystem()
        {
            return laptop;
        }
    }
}
