using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.LHJ
{
    internal class RemoveSameChar
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");
            solution("people");
        }
        static string solution(string my_string)
        {
            string answer = "";
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = i + 1; j < my_string.Length; j++)
                {
                    if (my_string[i] == my_string[j])
                        break;
                    else if(j == my_string.Length - 1)
                        answer += my_string[i];
                }
            }
            return answer;
        }
    }
}
