using System;

namespace _734A_Anton_and_Danik
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string games = Console.ReadLine();

            int ac = 0;
            int dc = 0;

            foreach (char a in games)
                if (a == 'A') ac++;

            foreach (char d in games)
                if (d == 'D') dc++;

            if (ac > dc)
            {
                Console.WriteLine("Anton");
            }
            else if (dc > ac)
            {
                Console.WriteLine("Danik");
            }
            else
            {
                Console.WriteLine("Friendship");
            }
        }
    }
}
