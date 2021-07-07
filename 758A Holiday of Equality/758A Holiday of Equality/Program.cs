using System;

namespace _758A_Holiday_of_Equality
{
    class Program
    {
        static void Main(string[] args)
        {   /* The idea is to go through the citizen balances twice with 2 for loops. 
             * First to determine the max value among the citizen account balances.
             * Second to determine how much the treasury will have to pay to each individial citizen to equalize their account ballance to the max value from the first loop.
             * On the second run each difference between max value and the analysed account balance will be added to a counter and then displayed as the output.
             */

            int n = Convert.ToInt32(Console.ReadLine()); // read number of cases from input (not used in the code - substituted by input.Length)

            string[] input = Console.ReadLine().Split(); // read the citizen's account balances from input as a string array

            int max = 0; // set max to 0
            for (int i = 0; i < input.Length; i++) // first loop to determine the max value
            {
                int bench = int.Parse(input[i]); // each analysed value is assigned to a temp int named bench 
                if (max < bench) // if bench is bigger than the max, it becomes the new max
                {
                    max = bench;
                }
            }

            int costCounter = 0; // costCounter to sum the expenses needed to equalize all accounts to the max value
            for (int i = 0; i < input.Length; i++)
            {
                int bench = int.Parse(input[i]); //again, each analysed value is assigned to a temp int named bench 
                if (bench < max) //if bench is smaller than max, add the difference between the max and bench to the total counter of expenses
                {
                    costCounter += (max - bench);
                }
            }
            Console.WriteLine(costCounter); // return costCounter after analysing all accounts
        }
    }
}
