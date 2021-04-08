using System;

namespace _432A_Choosing_Teams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split();
            string[] timesParticipated = Console.ReadLine().Split();

            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);
            int counter = 0;

            for (int i=0; i < n; i++)
            {
                int studentTimesParticipated = int.Parse(timesParticipated[i]);
                if (studentTimesParticipated + k <= 5)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter / 3);
        }
    }
}
