namespace FindMaxNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 3, 54, 3, 2, 54, 2, 3, 67 };
            int[] answer = FindMaxNum(array);

            Console.Write("{ ");
            Console.Write($"{answer[0]}, {answer[1]}");
            Console.WriteLine(" }");
        }

        static public int[] FindMaxNum(int[] array)
        {
            int[] answer = { -1, -1 };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > answer[0])
                {
                    answer[0] = array[i];
                    answer[1] = i;
                }
            }

            return answer;
        }
    }
}
