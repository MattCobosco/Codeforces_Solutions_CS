using System;

namespace _1030A_In_Search_of_an_Easy_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfPeople = Convert.ToInt32(Console.ReadLine());
            string[] people = Console.ReadLine().Split();
            int opinion_hard = 0;

            for (int i=0; i<NumberOfPeople; i++)
            {
                int person = int.Parse(people[i]);

                if (person == 1)
                {
                    opinion_hard++;
                }
            }
            if (opinion_hard > 0)
            {
                Console.WriteLine("HARD");
            }
            else
            {
                Console.WriteLine("EASY");
            }
        }
    }
}
