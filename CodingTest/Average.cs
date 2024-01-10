using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    //프로그래머스 평균 구하기 https://school.programmers.co.kr/learn/courses/30/lessons/12944
    internal class Average
    {
        public static double GetAverage(int[] arr)
        {
            double sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum / arr.Length;
        }
    }
}

