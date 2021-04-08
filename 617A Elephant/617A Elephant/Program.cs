using System;

namespace _617A_Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            if (x<=5)
            {
                Console.WriteLine(i);
            }
            else
            {
                while (x>5)
                {
                    x = x - 5;
                    i++;
                }
                Console.WriteLine(i);
            }
        }
    }
}
