using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class Even_Odd
    {
        public void Even_odd()
        {
            //String[] s;

            //Console.Clear();
            //s = Console.ReadLine().Split(' ');

            //int a = Int32.Parse(s[0]);
            int a = 100;
            if (a % 2 == 0)
                Console.WriteLine($"{a} is even");
            else
                Console.WriteLine($"{a} is odd");
        }
    }
}
