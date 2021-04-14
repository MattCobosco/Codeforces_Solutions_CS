using System;

namespace _61A_Ultra_Fast_Mathematician
{
    class Program
    {
        static void Main(string[] args)
        {
            // read numbers from input as strings (ints ignore 0s at the beginning)
            string firstNumber = Console.ReadLine(); 
            string secondNumber = Console.ReadLine();

            // convert numbers into char arrays to separate the digits
            char[] firstArray = firstNumber.ToCharArray();
            char[] secondArray = secondNumber.ToCharArray();

            // declaration of another array that will be used to construct the output number
            char[] answerArray = new char [firstArray.Length];

            //for loop to analyse both numbers
            for (int i=0; i < firstArray.Length; i++)
            {
                // if the i-th digit of the first number == the i-th digit of the second number the i-th value of the answer array is 0
                if (firstArray[i] == secondArray[i]) answerArray[i] = '0';
                // if the i-th digit of the first number != the i=th digit of the second number the i-th value of the answer array is 1
                else answerArray[i] = '1';
            }
            // print answerArray converted into a string
            Console.WriteLine(String.Join("", answerArray));
        }
    }
}
