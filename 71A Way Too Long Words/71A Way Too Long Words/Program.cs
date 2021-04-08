using System;
using System.Linq;

namespace _71A_Way_Too_Long_Words
{   
    class Program
    {

        static void Main()

        {

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)

            {

                string str = Console.ReadLine();

                int l = str.Length;

                if (l <= 10)

                {
                    Console.WriteLine(str);
                }

                else

                {

                    Console.Write(str[0]);
                    Console.Write((l - 2));
                    Console.WriteLine(str[l - 1]);
                }
            }

        }

    }
}