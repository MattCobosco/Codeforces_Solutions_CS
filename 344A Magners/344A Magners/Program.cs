using System;

namespace _344A_Magners
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int mag_groups = 0;

            for (int i = 0; i < n; i++)
            {   
                int mag_prev=0;
                int mag_current = Convert.ToInt32(Console.ReadLine());

                if (mag_prev != mag_current)
                {
                    mag_prev = mag_current;
                    mag_groups++;
                }
                else if (mag_prev == mag_current)
                {
                    mag_prev = mag_current;
                }
                else 
                    Console.WriteLine("diff");
            }

            Console.WriteLine(mag_groups - 1);
        }
    }
}
