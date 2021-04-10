using System;

namespace _822A_I_m_bored_with_life
{
    class Program
    {
        static void Main(string[] args)
        {
            // parsing input into a and b
            string[] ab = Console.ReadLine().Split(); 

            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);

            // declaring Factorial as 1 - it needs to be declared and have a value of 1 (even factorial of 0! is still 1)
            // in order to use it in one of the for loops below
            int Factorial = 1;

            // GCD is always the factorial of the smaller (or equal) number from input

            if (a < b) // if a is smaller than b calculate the factorial of a using a for loop
            {
                for (int i = 1; i < a + 1; i++) // i must be equal to 1 in order not to multiply by 0 at the beginning
                                                // i < a + 1 => + 1 to account the extra step of multiplying by 1
                                                // ex: 4! = 1 (the initial factorial) * 1 (start of the loop) * 2 * 3 * 4
                                                // (5 steps instead of 4 thus a + 1 and not just a)
                {
                    Factorial *= i;             
                }
            }
            else // if b is smaller or equal to a calculate the factorial of b with the other for loop (same rules as in loop no.1)
            {
                for (int i = 1; i < b + 1; i++)
                {
                    Factorial *= i;
                }
            }

            Console.WriteLine(Factorial); //output the factorial
        }
    }
}
