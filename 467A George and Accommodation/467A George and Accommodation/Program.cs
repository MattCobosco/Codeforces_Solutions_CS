using System;

namespace _467A_George_and_Accommodation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;

            for (int i = 0; i < n; i++)
            {
                string [] rooms =Console.ReadLine().Split();

                int inhabitants = int.Parse(rooms[0]);
                int capacity = int.Parse(rooms[1]);

                if (inhabitants + 2 <= capacity)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}
