using System;
using System.Collections.Generic;
using System.Text;

namespace labosi62
{
    class Utilities
    {
        public static void Filter(List<int> data, Func<int, bool> condition)
        {
            for(int index = 0; index < data.Count; index++)
            {
                if (!condition(data[index]))
                {
                    data.Remove(data[index]);
                }
            }
        }
    }
}
