using System;

namespace _226A_Stones_on_the_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string stonesString = Console.ReadLine();

            char [] stones = stonesString.ToCharArray();
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                if (i + 1 < n)
                {
                    char stoneLeft = stones[i];
                    char stoneRight = stones[i + 1];

                    if (stoneLeft == stoneRight)
                    {
                        counter++;
                    }
                }
                else
                    break;
            }
            Console.WriteLine(counter);

        }
    }
}
