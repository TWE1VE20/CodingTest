namespace SameCharRemove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("wwww","w"));
        }

        static string solution(string my_string, string letter)
        {
            string answer = my_string;

            for (int i = 0; i < answer.Length; 
                i++)
            {
                if (answer[i] == letter[0])
                {
                    if (i == 0)
                    {
                        if (answer.Length == 1)
                        {
                            answer = "";
                        }
                        else
                        {
                            answer = $"{answer.Substring(1, answer.Length - 1)}";
                        }
                    }
                    else if (i == answer.Length - 1)
                    {
                        answer = $"{answer.Substring(0, answer.Length - 1)}";
                    }
                    else
                    {
                        answer = $"{answer.Substring(0, i)}{answer.Substring(i + 1, answer.Length - i - 1)}";
                    }

                    i = -1;
                }
                else
                {
                    Console.Write("");
                }
            }


            return answer;
        }
    }
}
