﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class CountUp
    {
        public int[] solution(int start_num, int end_num)
        {
            int[] answer = new int[] { };
            List<int> list = new List<int>();
            for (int i = start_num; i <= end_num; i++)
                list.Add(i);
            answer = list.ToArray();
            return answer;
        }
    }
}
