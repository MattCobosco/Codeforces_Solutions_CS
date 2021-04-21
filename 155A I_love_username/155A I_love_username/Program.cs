using System;

namespace _155A_I_love_username
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // read number of contests from input
            string[] contest_scores = Console.ReadLine().Split(); //read contest scores input and split it into an array of strings
            int firstScore = int.Parse(contest_scores[0]); // parse the first score from the array
            int amazingCounter = 0; // set counter of amazing performances to 0

            int max = firstScore; // first score is the lowest and the highest score at the beginning
            int min = firstScore;

            for (int i=1;i<n; i++) // loop through scores, starting with the second one
            {
                int benchmark = int.Parse(contest_scores[i]); //benchmark is the current element analyzed by the loop
                if (benchmark < min) // if the benchmark is smaller than the current minimum then set it as the new minimum and increase the counter of amazing performances by 1
                {
                    min = benchmark;
                    amazingCounter++;
                }
                else if (benchmark > max) // if the benchmark is greater than the current maximum then set it as the new minimum and increase the counter of amazing performances by 1
                {
                    max = benchmark;
                    amazingCounter++;
                }
            }

            Console.WriteLine(amazingCounter); // print the counter of amazing performances
        }
    }
}
