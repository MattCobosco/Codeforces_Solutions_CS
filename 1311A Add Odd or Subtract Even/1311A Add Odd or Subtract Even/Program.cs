using System;

namespace _1311A_Add_Odd_or_Subtract_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<t; i++) 
            {
                string[] ab = Console.ReadLine().Split();

                int a = int.Parse(ab[0]);
                int b = int.Parse(ab[1]);

                //add an odd int / subtract an even int

                int steps;

                if (a > b)
                {
                   if ((a - b) % 2 == 0)
                   {
                       steps = 1;
                   }
                   else
                   {
                       steps = 2;
                   }
                }
                else if (a < b)
                {
                    if ((a - b) % 2 == 0)
                    {
                        steps = 2;
                    }
                    else
                    {
                        steps = 1;
                    }
                }
                else
                {
                    steps = 0;
                }
                Console.WriteLine(steps);
            }
        }
    }
}
