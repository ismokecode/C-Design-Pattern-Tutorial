using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

using Fluent_Builder_Design_Pattern.Builder.IBuilder;

namespace Fluent_Builder_Design_Pattern.Builder.Director
{
    public class ConfigurationBuilder
    {
        public void BuildSystem(ISystemBuilder systembuilder, Dictionary<string,string> collection)
        {
             systembuilder.AddDrive(collection["Drive"])
            .AddMemory(collection["RAM"])
            .AddMouse(collection["Mouse"])
            .AddKeyBoard(collection["Keyboard"])
            .AddTouchScreen(collection["TouchScreen"]);
        }
    }
}
