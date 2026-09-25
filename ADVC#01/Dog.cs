using System;
using System.Collections.Generic;
using System.Text;

namespace ADVC_01
{
    internal class Dog : Animal
    {
        public static void Process<T>(T item) where T : Animal
        {
            item.Eat();
        }
    }
}
