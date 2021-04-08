using System;

namespace _677A_Vanya_and_Fence
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] n_h = Console.ReadLine().Split();
            string [] people = Console.ReadLine().Split();

            int n = int.Parse(n_h[0]);
            int h = int.Parse(n_h[1]);
            int road = n;

            for (int i=0; i<n; i++)
            {
                int person = int.Parse(people[i]);

                if (person > h)
                {
                    road++;
                }
            }

            Console.WriteLine(road);
        }
    }
}
