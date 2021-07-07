using System;

namespace _1374A_Required_Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine()); // read number of cases from input

            for (int i = 0; i < t; i++) // loop through test cases
            {
                string[] inputCase = Console.ReadLine().Split(); // read test case as string array

                int x = int.Parse(inputCase[0]); // out ints x,y,n from the array
                int y = int.Parse(inputCase[1]);
                int n = int.Parse(inputCase[2]);

                while (n % x != y) // as long as n mod x isn't equal to y decrease n by 1
                {
                    n--;
                }

                Console.WriteLine(n); // return n
            }
        }
    }
}
