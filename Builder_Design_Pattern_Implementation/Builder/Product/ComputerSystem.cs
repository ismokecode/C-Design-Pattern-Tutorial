using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Design_Pattern_Implementation
{
    public class ComputerSystem
    {
        public string RAM { get; set; }
        public string HDDSize { get; set; }
        public string flopy { get; set; }
        public string KeyBoard { get; set; }
        public string Mouse { get; set; }
        public string TouchScreen { get; set; }

        //public string Build()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.Append(string.Format(" RAM: {0}", RAM));

        //    sb.Append(string.Format(" HDDSize: {0}", HDDSize));

        //    return sb.ToString();
        //}
    }
}
