using System;

namespace _58A_Chat_room
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // read input string

            bool? hello = null; // hello bool to declare whether hello was found or not

            for (int i = 0; i < input.Length; i++) // loop through chars in the input list looking for 'h'
            {
                if (input[i] == 'h') // if 'h' was found, look for 'e' among the rest of the chars in the input string
                {
                    for (; i < input.Length; i++) // if 'e' was found, look for first 'l' among the rest of the chars in the input string
                    {
                        if (input[i] == 'e')
                        {
                            for (; i < input.Length; i++) // if first 'l' was found, look for second 'l' among the rest of the chars in the input string
                            {
                                if (input[i] == 'l')
                                {
                                    for (; i + 1 < input.Length; i++) // move index to the next char (leaving it at the same position would accept the previous 'l' as the second one)
                                    {
                                        if (input[i + 1] == 'l')
                                        {
                                            for (; i < input.Length; i++) // if second 'l' was found, look for 'e' among the rest of the chars in the input string
                                            {
                                                if (input[i] == 'o') // if 'o' was found change bool to true
                                                {
                                                    hello = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (hello == true) // return "yes" or "no" to console depending whether bool is true or not 
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

