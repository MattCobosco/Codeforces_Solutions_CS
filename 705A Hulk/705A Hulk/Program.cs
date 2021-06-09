using System;

namespace _705A_Hulk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // read n from input

            Console.Write("I hate");  // print "I hate" in console - that's always the beginning of the sentence

            for (int i = 1; i < n; i++) // for loop to add the statements to the middle of Hulk's sentence, works only if n > 1
            {
                if (i % 2 != 0) // if i is divisible by 2 then put " that I love" in the middle
                {
                    Console.Write(" that I love");
                }
                else
                {
                    Console.Write(" that I hate"); // if it isn't then put " that I hate" in the middle
                }
            }

            Console.Write(" it"); // print " it" in console - that's always the ending of the sentence
        }
    }
}
