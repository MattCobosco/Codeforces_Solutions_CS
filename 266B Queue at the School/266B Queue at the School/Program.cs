using System;

namespace _266B_Queue_at_the_School
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nt = Console.ReadLine().Split(); // read input as 2d array of strings

            int n = int.Parse(nt[0]); // out n (not used)
            int t = int.Parse(nt[1]); // out t

            string queue = Console.ReadLine(); // read queue as from input as string

            while (t > 0) // repeat t times
            {
                queue = queue.Replace("BG", "GB"); // replace each BG in the string with GB (if a Boy is in front of a Girl, switch their places)
                t--; // reduce t by 1 on each run
            }
            
            Console.WriteLine(queue); // return new queue after t seconds
        }
    }
}
