using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Maximum_Problem_Using_Ganerics
{
    internal class Refactor1
    {
        public static T FindingMaximum<T>(T input1, T input2, T input3) where T : IComparable
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
