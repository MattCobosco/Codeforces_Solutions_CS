using System;

namespace _255A_Greg_s_Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // read number of series from input
            string[] input = Console.ReadLine().Split(); // read series log from input

            int chestCounter = 0; // total numbers of excercises of a given muscle
            int bicepsCounter = 0;
            int backCounter = 0;

            for (int i = 1; i <= n; i++) // loop through the series from input (start at one to simplify the calculation of mods)
            {
                int t = int.Parse(input[i-1]); // t is currently analysed excercise count (i-1 to compensate for 0-based index numbering in C#)

                if (i % 3 == 1) // if index mod 3 is 1 (indexes 1,4,...)
                {
                    chestCounter += t; // add the excercise count to chestCounter
                }
                else if (i % 3 == 2) // if index mod 3 is 2 (indexes 2,5,...)
                {
                    bicepsCounter += t; // add the excercise count to bicepsCounter
                }
                else // if index mod 3 isn't 1 or 2 then it must be 0 (indexes 3,6,...)
                    backCounter += t; // add the excercise count to backCounter
            }
            
            // then determine the topCount - max of 3 counters

            int topCount = Math.Max(chestCounter, Math.Max(bicepsCounter, backCounter));

            // provide the answer depending on which of the muscle counters is the topCounter
            if (chestCounter == topCount)
                Console.WriteLine("chest");
            else if (bicepsCounter == topCount)
                Console.WriteLine("biceps");
            else
                Console.WriteLine("back");
        }
    }
}
