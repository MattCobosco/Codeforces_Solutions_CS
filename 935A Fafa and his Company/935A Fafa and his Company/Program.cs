using System;

namespace _935A_Fafa_and_his_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // read input as n - total number of employees

            int ways = 0; // setting the number of ways to 0;
            for (int i = 1; i < n; i++) // for loop to test check all possible numbers of teamleaders (1 to n)
            {
                if ((n - i) % i == 0) // if total number of employees minus number of teamleaders
                                      // is divisible by number of teamleaders then increase ways counter by 1. 
                {
                    ways++;
                }
            }
            Console.WriteLine(ways); // print ways as output
        }
    }
}
