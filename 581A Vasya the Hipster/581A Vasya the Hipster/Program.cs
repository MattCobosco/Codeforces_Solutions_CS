using System;

namespace _581A_Vasya_the_Hipster
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ab = Console.ReadLine().Split();

            int a = int.Parse(ab[0]);   // red socks
            int b = int.Parse(ab[1]);   // blue socks
            int differentSocksDays = 0;
            int sameSocksDays = 0;

            while (a > 0 || b > 0)
            {

                if (a > 0 && b > 0)
                {
                    a--;
                    b--;
                    differentSocksDays++;
                }
                else if (a > 1)
                {
                    a -= 2;
                    sameSocksDays++;
                }
                else if (b > 1)
                {
                    b -= 2;
                    sameSocksDays++;
                }
                else
                    break;
                }

            Console.WriteLine("{0} {1}", differentSocksDays, sameSocksDays);
        }
    }
}
