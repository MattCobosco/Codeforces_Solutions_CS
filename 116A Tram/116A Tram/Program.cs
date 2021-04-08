using System;

namespace _116A_Tram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());    //number of stops
            int p = 0;                                      //initial number of passengers
            int pMax = 0;                                   //max capacity needed

            while (n>0)
            {
                string[] tokens = Console.ReadLine().Split();

                int ex = int.Parse(tokens[0]);              //number of passengers exiting
                int en = int.Parse(tokens[1]);              //number of passengers entering
                
                p = p -ex + en;
                if (p > pMax)
                {
                    pMax = p;
                }

                n--;
            }
            Console.WriteLine(pMax);
        }
    }
}
