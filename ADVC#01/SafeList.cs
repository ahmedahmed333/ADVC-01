using System;
using System.Collections.Generic;
using System.Text;

namespace ADVC_01
{
    internal class SafeList<T>
    {

        private List<T> _items = new List<T>();

        public void Add(T item) => _items.Add(item);
        public int Count => _items.Count;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _items.Count) return default;

                return _items[index];
            }
        }


    }
}
