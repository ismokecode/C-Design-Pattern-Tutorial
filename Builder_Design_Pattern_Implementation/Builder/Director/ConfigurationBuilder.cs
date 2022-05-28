using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using Builder_Design_Pattern_Implementation.Builder.Product;

namespace Builder_Design_Pattern_Implementation.Builder.Director
{
    public class ConfigurationBuilder
    {
        public void BuildSystem(ISystemBuilder systembuilder, Dictionary<string,string> collection)
        {
            systembuilder.AddDrive(collection["Drive"]);
            systembuilder.AddMemory(collection["RAM"]);
            systembuilder.AddMouse(collection["Mouse"]);
            systembuilder.AddKeyBoard(collection["Keyboard"]);
            systembuilder.AddTouchScreen(collection["TouchScreen"]);
        }
    }
}
