using System;

namespace _281A_Word_Capitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(char.ToUpper(input[0]) + input.Substring(1));
        }
    }
}
