namespace Horse_Racing
{
    internal class Program
    {
        public class Solution
        {
            static public string[] solution(string[] players, string[] callings)
            {
                string[] answer = new string[] { };

                LinkedList<string> list = new LinkedList<string>();
                var ranking = new Dictionary<string, LinkedListNode<string>>();

                for (int i = 0; i < players.Length; i++)
                    ranking.Add(players[i], list.AddLast(players[i]));

                for (int j = 0; j < callings.Length; j++)
                {
                    LinkedListNode<string> buf = ranking[callings[j]].Previous;
                    list.Remove(ranking[callings[j]].Previous);
                    list.AddAfter(ranking[callings[j]], buf);
                }

                string[] buf2 = new string[players.Length];
                list.CopyTo(buf2, 0);
                answer = buf2;
                return answer;
            }

            static void Main(string[] args)
            {

            }
        }
    }
}
