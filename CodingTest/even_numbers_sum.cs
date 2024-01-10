using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class even_numbers_sum
    {
    
        public int solution(int n)
        {
            int result = 0;
            for (int i = 2; i <= n; i += 2)
            {
                result += i;

            }
            return result;
        }

    }
}
