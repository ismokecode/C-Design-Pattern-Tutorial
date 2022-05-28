using System;
using System.Collections.Generic;
using System.Text;
using Fluent_Builder_Design_Pattern.Builder.Product;

namespace Fluent_Builder_Design_Pattern.Builder.IBuilder
{
    public interface ISystemBuilder
    {
        ISystemBuilder AddMemory(string Memory);
        ISystemBuilder AddDrive(string size);
        ISystemBuilder AddKeyBoard(string type);
        ISystemBuilder AddMouse(string type);
        ISystemBuilder AddTouchScreen(string enabled);
        ComputerSystem GetSystem();
    }
}
