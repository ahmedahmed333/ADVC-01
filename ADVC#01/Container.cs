using System;
using System.Collections.Generic;
using System.Text;

namespace ADVC_01
{
    internal class Container<T>
    {
        private T value;

        public void Add(T item)
        {
            value = item;
        }
        public T Get()
        {
            return value;
        }


        static void Swap<T>(ref T a, ref T b)

        {
            T temp = a;
            a = b;
            b = temp;
        }

     
    }
}
