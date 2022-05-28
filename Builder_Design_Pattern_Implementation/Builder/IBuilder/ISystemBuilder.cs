using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Design_Pattern_Implementation.Builder.Product
{
    public interface ISystemBuilder
    {
        void AddMemory(string Memory);
        void AddDrive(string size);
        void AddKeyBoard(string type);
        void AddMouse(string type);
        void AddTouchScreen(string enabled);
        ComputerSystem GetSystem();
    }
}
