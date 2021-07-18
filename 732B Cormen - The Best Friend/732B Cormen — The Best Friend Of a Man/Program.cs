using System;
using System.Linq;

namespace _732B_Cormen___The_Best_Friend_Of_a_Man
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // read n and k from input as int array

            int[] walksLog = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // read walks/day from input as int array

            int n = nk[0]; // out n and k
            int k = nk[1];
            int changeCounter = 0; // declare counter of needed changes

            for (int i = 0; i < walksLog.Length - 1; i++) // loop through the walksLog n-1 times (walksLog.Lenght is substitute of n)
            {
                while (walksLog[i] + walksLog[i + 1] < k) // while number of walks in the two consecutive days are less than k - the required number of walks in the two consecutive days to keep the do happy
                {
                    changeCounter++; // increase change counter by 1;
                    walksLog[i + 1]++; // increase the number of walks on the second day analysed day by 1
                }
            }

            Console.WriteLine(changeCounter); // return the changeCounter to the console in new line
            foreach (int day in walksLog) // return the new version of the walksLog after the required changes were made
            {
                Console.Write(day + " ");
            }
        }
    }
}
