using System;
using System.Collections.Generic;
using System.Text;
using Fluent_Builder_Design_Pattern;
using Fluent_Builder_Design_Pattern.Builder;
using Fluent_Builder_Design_Pattern.Builder.IBuilder;
using Fluent_Builder_Design_Pattern.Builder.Product;

namespace Fluent_Builder_Design_Pattern.Builder.ConcreteBuilder
{
    public class DesktopBuilder : ISystemBuilder
    {
        ComputerSystem desktop = new ComputerSystem();
        public ISystemBuilder AddDrive(string size)
        {
            desktop.HDDSize = size;
            return this;
        }

        public ISystemBuilder AddKeyBoard(string type)
        {
            desktop.KeyBoard = type;
            return this;
        }

        public ISystemBuilder AddMemory(string Memory)
        {
            desktop.RAM = Memory;
            return this;
        }

        public ISystemBuilder AddMouse(string type)
        {
            desktop.Mouse = type;
            return this;
        }

        public ISystemBuilder AddTouchScreen(string enabled)
        {
            return this;
        }

        public ComputerSystem GetSystem()
        {
            return desktop;
        }
    }
}
