using System;

namespace _282A_Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<n; i++)
            {
                string CommandString = Console.ReadLine();

                bool c = CommandString.Contains("+");

                if (c)
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }

            Console.WriteLine(x);
        }
    }
}
