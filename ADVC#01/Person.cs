using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ADVC_01
{
    internal interface Person : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("person");
        }
    }
}
