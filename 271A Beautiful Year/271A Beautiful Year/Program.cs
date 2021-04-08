
using System;

namespace _271A_Beautiful_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputYear = Convert.ToInt32(Console.ReadLine());
            int millenium, century, decade, year;

            while (true)
            {   
                inputYear++;
                millenium = inputYear / 1000;
                century = inputYear % 1000 / 100;
                decade = inputYear % 100 / 10;
                year = inputYear % 10;

                if (millenium != century &&
                    millenium != decade &&
                    millenium != year &&
                    century != decade &&
                    century != year &&
                    decade != year)
                {
                    break;
                }
            }
            Console.WriteLine(inputYear);
        }
    }
}
