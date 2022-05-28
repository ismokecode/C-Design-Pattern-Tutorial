using System;
using System.Collections.Generic;
using System.Text;
using Fluent_Builder_Design_Pattern.Builder.IBuilder;
using Fluent_Builder_Design_Pattern.Builder.Product;

namespace Fluent_Builder_Design_Pattern.Builder.ConcreteBuilder
{
    public class LaptopBuilder : ISystemBuilder
    {
        ComputerSystem laptop = new ComputerSystem();
        public ISystemBuilder AddDrive(string size)
        {
            laptop.HDDSize = size;
            return this;
        }

        public ISystemBuilder AddKeyBoard(string type)
        {
            return this;
        }

        public ISystemBuilder AddMemory(string Memory)
        {
            laptop.RAM = Memory;
            return this;
        }

        public ISystemBuilder AddMouse(string type)
        {
            return this;
        }

        public ISystemBuilder AddTouchScreen(string enabled)
        {
            laptop.TouchScreen = enabled;
            return this;
        }

        public ComputerSystem GetSystem()
        {
            return laptop;
        }
    }
}
