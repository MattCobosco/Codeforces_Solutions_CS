using System;

namespace _703A_Mishka_and_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int mishka_counter = 0;
            int chris_counter = 0;

            for (int i = 0; i < n; i++)
            {
                string[] mishka_chris = Console.ReadLine().Split();

                int mishka = int.Parse(mishka_chris[0]);
                int chris = int.Parse(mishka_chris[1]);

                

                if (mishka > chris)
                {
                    mishka_counter++;
                }
                else if (chris > mishka)
                {
                    chris_counter++;
                }
            }

            if (mishka_counter > chris_counter)
            {
                Console.WriteLine("Mishka");
            }
            else if (chris_counter > mishka_counter)
            {
                Console.WriteLine("Chris");
            }
            else
            {
                Console.WriteLine("Friendship is magic!^^");
            }
        }
    }
}
