using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.LHJ
{
    internal class RemoveSameChar
    {
        static string solution(string my_string)
        {
            string result = "";
            HashSet<char> seen = new HashSet<char>();

            foreach (char c in my_string)
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    result+=c;
                }
            }
            return result.ToString();
        }
    }
}
