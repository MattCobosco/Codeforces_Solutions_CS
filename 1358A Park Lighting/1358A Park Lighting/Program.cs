using System;

namespace _1358A_Park_Lighting
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine()); // read number of cases from input
            
            int output; // declare output variable

            for (int i = 0; i < t; i++) // loop through cases
            {
                string[] input = Console.ReadLine().Split(); // read case as string array

                int n = int.Parse(input[0]); // parse this string into n and m ints
                int m = int.Parse(input[1]);

                int size = m * n; // calculate size of the square
                

                if (size % 2 == 0) // if the size of the square an even number then the whole park can be lit by putting one lantern between every 2 squares
                    output = size / 2;
                else
                    output = size / 2 + 1; // if not then the park can be lit by putting a lantern between every 2 squares + 1 extra lantern for the one extra square
                
                Console.WriteLine(output);
            }            
        }
    }
}
