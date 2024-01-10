using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.LHJ
{
    internal class MoseCode
    {
        public string solution(string letter)
        {
            StringBuilder sb = new StringBuilder();
            string[] moses =
            {
           ".-","-...","-.-.","-..",".","..-.",
    "--.","....","..",".---","-.-",".-..",
    "--" ,"-.","---",".--.","--.-",".-.",
    "...","-" ,"..-","...-",".--" ,"-..-",
    "-.--","--.."
        };

            string[] splited = letter.Split(' ');

            for (int i = 0; i < splited.Length; i++)
            {
                for (int j = 0; j < moses.Length; j++)
                {
                    if (splited[i] == moses[j])
                    {
                        sb.Append((char)('a' + j));
                        break;
                    }
                }
            }

            return sb.ToString();
        }
    }
}
