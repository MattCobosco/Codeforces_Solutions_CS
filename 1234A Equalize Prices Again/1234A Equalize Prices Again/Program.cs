using System;

namespace _1234A_Equalize_Prices_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int q); // read q (number of cases) from input

            for (int i = 0; i < q; i++) // loop through q cases
            {
                int n = Convert.ToInt32(Console.ReadLine()); // read n (number of prices in a case) from input

                string[] prices = Console.ReadLine().Split(); //read prices as string from input

                decimal pricesSum = 0; //sum of prices is initially 0

                for (int j = 0; j < n; j++) // loop through the prices
                {
                    pricesSum += int.Parse(prices[j]); // convert the prices from the string into ints and add them to the sum one by one
                }

                decimal averagePriceCeiling = Math.Ceiling(pricesSum / n); // calculate the ceiling of the average price

                Console.WriteLine(averagePriceCeiling); // print it as output
            }
        }
    }
}
