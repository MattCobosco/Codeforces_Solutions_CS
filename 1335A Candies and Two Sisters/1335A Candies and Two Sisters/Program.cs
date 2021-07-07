using System;

namespace _1335A_Candies_and_Two_Sisters
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < t; i++) 
            {
                int input = Convert.ToInt32(Console.ReadLine());
                int output;

                if (input % 2 == 0)
                    output = input / 2 - 1;
                else
                    output= (input-1)/ 2;

                Console.WriteLine(output);
            }
        }
    }
}
