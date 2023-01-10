using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Maximum_Problem_Using_Ganerics
{
    internal class FindMaximum<T> where T : IComparable
    {
        public T input1, input2, input3, input4, input5;
        public FindMaximum(T input1, T input2, T input3, T input4, T input5)
        {
            this.input1 = input1;
            this.input2 = input2;
            this.input3 = input3;
            this.input4 = input4;
            this.input5 = input5;
        }

        public static T testMaximum(T input1, T input2, T input3, T input4, T input5)
        {
            if (input1.CompareTo(input2) >= 0 && input1.CompareTo(input3) >= 0 && input1.CompareTo(input4) >= 0 && input1.CompareTo(input5) >= 0)
            {
                return input1;
            }
            else if (input2.CompareTo(input1) >= 0 && input2.CompareTo(input3) >= 0 && input2.CompareTo(input4) >= 0 && input2.CompareTo(input5) >= 0)
            {
                return input2;
            }
            else if (input3.CompareTo(input1) >= 0 && input3.CompareTo(input2) >= 0 && input3.CompareTo(input4) >= 0 && input3.CompareTo(input5) >= 0)
            {
                return input3;
            }
            else if (input4.CompareTo(input1) >= 0 && input4.CompareTo(input2) >= 0 && input4.CompareTo(input3) >= 0 && input4.CompareTo(input5) >= 0)
            {
                return input4;
            }
            else
            {
                return input5;
            }
        }

    }
}
