using System;
using System.Collections.Generic;

namespace Samples.StaticLocalFunctions
{
    internal class StaticLocalFunctions
    {
        public IEnumerable<int> Counter(int start, int end)
        {
            if (start >= end)
            {
                throw new ArgumentOutOfRangeException("start must be less than end");
            }

            return localCounter();

            IEnumerable<int> localCounter()
            {
                for (var i = start; i < end; i++)
                {
                    yield return i;
                }
            }
        }
    }
}