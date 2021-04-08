using System;

namespace _231A_Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());    //number of problems in the contest
            int solCounter = 0;                             //solutions used counter
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                int p = int.Parse(tokens[0]);               //Petya's certainty
                int v = int.Parse(tokens[1]);               //Vasya's certainty
                int t = int.Parse(tokens[2]);               //Tonya's certainty

                if (p + v + t >= 2)
                {
                    solCounter++;
                }
            }
            Console.WriteLine(solCounter);
        }  
    }
}
