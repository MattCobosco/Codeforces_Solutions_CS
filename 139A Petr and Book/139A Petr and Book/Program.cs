using System;
using System.Linq;

namespace _139A_Petr_and_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine()); // read number of pages to read from input
            int[] readingSchedule = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // read how many pages Petr reads per given week day

            int dayIndex = 0; // declare day if the week index

            while (n > 0) // while the number of pages left to read is positive
            {
                for (dayIndex = 0; dayIndex < 7; dayIndex++) // loop through the days of the week
                {
                    if (n > 0) // if there are still pages to read
                    {
                        n -= readingSchedule[dayIndex]; // subtract the number of pages read on that day of the week
                    }
                    else
                    {
                        break; // if there aren't any pages left, stop the loop
                    }
                }
            }

            Console.WriteLine(dayIndex); // return the index of the day on which the loop has been stopped
        }
    }
}
