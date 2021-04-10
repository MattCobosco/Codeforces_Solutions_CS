using System;

namespace _9A_Die_Roll
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rolls = Console.ReadLine().Split(); // splitting input into a string

            int y = int.Parse(rolls[0]);    // parsing string into 2 ints - Yakkos and Wakkos die rolls
            int w = int.Parse(rolls[1]);

            int max = Math.Max(y, w); // checking whose roll is higher

            int winningOptions = 6 - max + 1; // calculating amount of winning options
            // + 1 is for a a draw which also wins in this case

            /* converting the answers into an irreductable fraction
             * even if both yukko and wukko roll 6, dot still has a 1/6 chance to win - if she rolls 6
             * and she can have 100% chance to win if both yukko and wukko roll 1
             * which means the number of winning options will be from range 1 - 6 */


            if (winningOptions % 6 == 0) // this if covers 6 winning options (Dot rolls 1-6)
                                         // without it the result would be 2/2 so an reductible fraction which isn't allowed
            {
                Console.WriteLine("1/1");
            }
            else if (winningOptions % 3 == 0) // this one converts the case of 3 winning options (r 4,5,6) into 1/2 
            {
                Console.WriteLine(winningOptions / 3 + "/" + 2); 
            }
            else if (winningOptions % 2 == 0) // this one covers 2 (r 5,6) and 4 (r 3,4,5,6) winning options into 1/3 or 2/3
            {
                Console.WriteLine(winningOptions / 2 + "/" + 3);
            }
            else // and the last one covers the rest (1 and 5 winning options out of 6) - those can't be reduced
            {
                Console.WriteLine(winningOptions + "/" + 6);
            }
        }
    }
}
