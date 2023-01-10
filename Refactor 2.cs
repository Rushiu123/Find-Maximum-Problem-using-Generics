using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Maximum_Problem_Using_Ganerics
{
    internal class FindMaximum<T> where T : IComparable
    {
        public T input1, input2, input3;
        public FindMaximum(T input1, T input2, T input3)
        {
            this.input1 = input1;
            this.input2 = input2;
            this.input3 = input3;
        }

        public static T testMaximum(T input1, T input2, T input3)
        {
            if (input1.CompareTo(input2) >= 0 && input1.CompareTo(input3) >= 0)
            {
                return input1;
            }
            else if (input2.CompareTo(input2) >= 0 && input2.CompareTo(input3) >= 0)
            {
                return input2;
            }
            else
            {
                return input3;
            }
        }

    }
}
