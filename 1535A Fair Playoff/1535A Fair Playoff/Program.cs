using System;

namespace _1535A_Fair_Playoff
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine()); // read number of test cases

            for(int i = 0; i < t; i++) //loop through test cases
            {
                string[] players = Console.ReadLine().Split(); // read player skill from each test case and parse it into individual skill grades of 4 players
                int player1 = int.Parse(players[0]);
                int player2 = int.Parse(players[1]);
                int player3 = int.Parse(players[2]);
                int player4 = int.Parse(players[3]);

                int winner1 = Math.Max(player1, player2); //determine the winner and loser of each round
                int winner2 = Math.Max(player3, player4);
                int loser1 = Math.Min(player1, player2);
                int loser2 = Math.Min(player3, player4);

                /*
                 * if winner of the 1st round is better than the loser of the 2nd round and winner of the 2nd round is better than the loser of the 1st round
                 * then this means 2 top players overall fought in the final round
                 * (it's guaranteed that all the numbers in input array are different so cases of equal skill grades can be omitted) 
                 */

                if (winner1 > loser2 && winner2 > loser1) 
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
