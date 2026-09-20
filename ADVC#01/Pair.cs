using System;
using System.Collections.Generic;
using System.Text;

namespace ADVC_01
{
    internal class Pair<Tkey, TValue>
    {
        public Tkey Key { get; set; }
        public TValue Value { get; set; }


        public Pair(Tkey key, TValue value)
        {

            Key = key;
            Value = value;

        }

    }
}
