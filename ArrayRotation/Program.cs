namespace ArrayRotation
{
    internal class Program
    {
        static public int[] Solution(int[] numbers, string direction)
        {
            int[] answer = new int[numbers.Length];

            switch (direction)
            {
                case "right":
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        answer[i + 1] = numbers[i];
                    }

                    answer[0] = numbers[numbers.Length - 1];
                    break;
                case "left":
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        answer[i] = numbers[i + 1];
                    }

                    answer[numbers.Length - 1] = numbers[0];
                    break;
            }
            return answer;
        }

        static void Main(string[] args)
        {
        }
    }
}
