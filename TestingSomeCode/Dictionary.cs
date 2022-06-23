using System;
using System.Collections.Generic;

namespace TestingSomeCode
{
    internal class Dictionary
    {
        public static implicit operator Dictionary(Dictionary<int, int> v)
        {
            throw new NotImplementedException();
        }
    }
}