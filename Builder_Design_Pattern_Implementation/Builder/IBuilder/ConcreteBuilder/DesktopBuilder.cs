using System;
using System.Collections.Generic;
using System.Text;
using Builder_Design_Pattern_Implementation.Builder.IBuilder;
using Builder_Design_Pattern_Implementation.Builder.Product;

namespace Builder_Design_Pattern_Implementation.Builder.IBuilder.ConcreteBuilder
{
    public class DesktopBuilder : ISystemBuilder
    {
        ComputerSystem desktop = new ComputerSystem();
        public void AddDrive(string size)
        {
            desktop.HDDSize = size;
        }

        public void AddKeyBoard(string type)
        {
            desktop.KeyBoard = type;
        }

        public void AddMemory(string Memory)
        {
            desktop.RAM = Memory;   
        }

        public void AddMouse(string type)
        {
            desktop.Mouse = type;
        }

        public void AddTouchScreen(string enabled)
        {
            return;
        }

        public ComputerSystem GetSystem()
        {
            return desktop;
        }
    }
}
