
namespace CodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //달리기 경주 코드테스트 실행코드
            //https://school.programmers.co.kr/learn/courses/30/lessons/178871 풀었다
            Horse_Racing horse_racing = new Horse_Racing();
            string[] players = ["mumu", "soe", "poe", "kai", "mine"];
            string[] callings = ["kai", "kai", "mine", "mine"];
            horse_racing.ArrayWrite<string>(horse_racing.solution(players, callings));
        }
    }
}
