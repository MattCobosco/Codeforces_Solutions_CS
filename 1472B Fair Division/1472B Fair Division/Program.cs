using System;

namespace _1472B_Fair_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine()); // read number of cases from input
            
            for (int i = 0; i < t; i++) // loop through cases
            {
                int n = Convert.ToInt32(Console.ReadLine()); // read number of candies the kids received
                string[] candies = Console.ReadLine().Split(); // read list of candies weight the kids got

                int oneGramCount = 0; //counters for one gram and two gram candies 
                int twoGramCount = 0;

                for (int j = 0; j < n; j++) // loop through candies and count one gram and two gram ones
                {
                    int bench = int.Parse(candies[j]);

                    if (bench == 1)
                        oneGramCount++;
                    else
                        twoGramCount++;
                }

                if (oneGramCount != 0 && oneGramCount % 2 == 0 && twoGramCount % 2 == 1) // if there is a positive even number of one gram candies and an uneven number of two gram candies then candies weight can be distributed equally
                    Console.WriteLine("YES");
                else if (oneGramCount % 2 == 0 && twoGramCount % 2 == 0) // same if both one gram and two gram candies are in a quantities that are even numbers
                    Console.WriteLine("YES");
                else // in all other cases candies weight cannot be distributed equally (without cutting them)
                    Console.WriteLine("NO");
            }
        }
    }
}
