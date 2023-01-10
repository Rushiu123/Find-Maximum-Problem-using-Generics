using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Maximum_Problem_Using_Ganerics
{
    internal class UC3_FindStringMax
    {
        public static string FindStringMaximum(string word1, string word2, string word3)
        {
            if (word1.CompareTo(word2) >= 0 && word1.CompareTo(word3) >= 0)
            {
                return word1;
            }
            else if (word2.CompareTo(word1) >= 0 && word2.CompareTo(word3) >= 0)
            {
                return word2;
            }
            else
            {
                return word3;
            }
        }
    }
}
