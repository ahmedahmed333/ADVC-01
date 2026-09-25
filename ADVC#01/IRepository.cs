using System;
using System.Collections.Generic;
using System.Text;

namespace ADVC_01
{
    internal interface IRepository<T>
    {
        T Get(int id);

        void Add(T item);
    }
}
