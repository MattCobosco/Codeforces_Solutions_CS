using System;

namespace _1409A_Yet_Another_Two_Integers_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine()); // read t from input

            for (int i = 0; i < t; i++) // loop through test cases
            {
                string[] inputCase = Console.ReadLine().Split(); // read test case as string array and parse it into a and b ints

                int a = int.Parse(inputCase[0]);
                int b = int.Parse(inputCase[1]);

                int diff = a - b; // calculate difference between a and b

                if (diff < 0) // get absolute value of diff
                {
                    diff = -diff;
                }

                int output; // declare output

                if (diff % 10 == 0) // if the difference is divisible by 10 then the amount of steps needed to obtain b from a is diff/10
                {
                    output = diff / 10;
                }

                else // if the difference isn't divisible by 10 then the amount of moves to obtain b from a is diff/10 + 1 (one extra step for adding/subtracting the remaining 1-9) - the result of division is rounded down when int%x!=0 (91/10=9)
                {
                    output = diff / 10 + 1;
                }

                Console.WriteLine(output); // return output to the console
            }
        }
    }
}
