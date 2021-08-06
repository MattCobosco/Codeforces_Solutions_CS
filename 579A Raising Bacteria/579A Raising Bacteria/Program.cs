using System;

namespace _579A_Raising_Bacteria
{
    class Program
    {
        static void Main(string[] args)
            /*
             * The program will decrease x either dividing it by 2 when the x is even or subtracting 1 when it's not even. When it's not even, the counter of bacterium will be increased by 1.
             * 8 - 4 - 2 - 1 (bacteria counter++) => one bacterium was enough
             * 5 (bacteria counte++) - 4 - 2 - 1 (bacteria counter++) => two bacteria were enough
             */
        {
            int x = Convert.ToInt32(Console.ReadLine()); // read x from input - number of bacteria needed
            int counter = 0; // counter of bacteria added

            while (x != 0)
            {
                if (x % 2 == 1) // if the number of bacteria isn't an even number, subtract one bacterium from x, increase bacterium added counter by 1
                {
                    x -= 1;
                    counter++;
                }
                else // else (if the number is even) - divide the number of bacteria by 2
                {
                    x /= 2;
                }
            }

            Console.WriteLine(counter); // return the counter to the console
        }
    }
}
