using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Maximum_Problem_Using_Ganerics
{
    internal class UC
    {
        class ExtendGenericMaximum<T> where T : IComparable
        {
            public T[] value;

            //Parameter Constructor
            public ExtendGenericMaximum(T[] value)
            {
                this.value = value;
            }

            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }

            public T MaxValue(params T[] values)
            {
                var sorted_values = Sort(values);
                return sorted_values[sorted_values.Length - 1];
            }
            public T MaxMethod()
            {
                var max = MaxValue(this.value);
                return max;
            }

        }
    }
}
