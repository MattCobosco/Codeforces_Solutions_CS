using System;

namespace _510A_Fox_and_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(); // read n and m from input line

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            for (int i = 1; i < n + 1; i++) // loop through lines (1-based line numbering to make the line counting easier)
            {

                if (i % 2 != 0) // if the line number is even, fill it with m (line length) '#'s
                {
                    for (int k = 0; k < m; k++)
                    {
                        Console.Write('#');

                    }
                    Console.Write("\n"); // move to a new line
                }

                else // if the line number is uneven then...
                {
                    if (i % 4 == 0) // if it's divisible by 4, print one '#' and then m-1 (line length - 1 '.'s)
                    {
                        Console.Write('#');
                        for (int k = 0; k < m - 1; k++)
                        {
                            Console.Write('.');
                        }
                        Console.Write("\n"); // move to a new line after finishing filling it with chars
                    }
                    else // else (if the line is divisible by 2 but not by 4)
                    {
                        for (int k = 0; k < m - 1; k++) // print m-1 (line length - 1 '.'s)
                        {
                            Console.Write('.');
                        }
                        Console.Write('#'); // then print one '#'
                        Console.Write("\n"); // and move to a new line the line
                    }
                }

            }
        }
    }
}
