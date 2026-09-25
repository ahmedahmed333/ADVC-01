using System;
using System.Collections.Generic;
using System.Text;

namespace ADVC_01
{
    internal class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        public virtual void MakeSound() => Console.WriteLine("sound");
    }
}
