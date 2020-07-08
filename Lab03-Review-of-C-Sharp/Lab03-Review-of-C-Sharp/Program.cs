using System;
using System.Diagnostics.CodeAnalysis;

namespace Lab03_Review_of_C_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Challenge 1
            //Console.WriteLine("Challenge 1:\nEnter three numbers on the same line separated by spaces:");
            //string input1 = Console.ReadLine();
            //int output = SplitThenMultiplyArray(input1);
            //Console.WriteLine($"Challenge 1 produced this output: {output}");

            // Challenge 2
            Challenge2Container();
        }

        /// <summary>
        /// Takes in a string of numbers. If there are at least three, it returns their product, otherwise it returns 0.
        /// </summary>
        /// <param name="input">string of whitespace separated numbers</param>
        /// <returns>product of the first three numbers</returns>
        public static int SplitThenMultiplyArray(string input)
        {
            int product = 1;
            string[] inputNums = input.Split(' ');
            if (inputNums.Length < 3)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    int convertedNum = Int32.TryParse(inputNums[i], out int result) ? result : 1;
                    product *= convertedNum;
                }
                return product;
            }
        }

        /// <summary>
        /// takes two integers and divides them, but returns it as a double.
        /// </summary>
        /// <param name="dividend">the sum of the user inputs</param>
        /// <param name="divisor">the total amount of user inputs</param>
        /// <returns>the average of the user inputs (sum)</returns>
        public static double GetAverage(int dividend, int divisor)
        {
            double average = (double)dividend / (double)divisor;
            return average;
        }

        /// <summary>
        /// Houses the proper user intake validation for challenge 2.
        /// </summary>
        public static void Challenge2Container()
        {
            int sum = 0;
            int divisor = 0;
            string input2 = "";
            int converted2 = 0;
            while (converted2 < 2 || converted2 > 10)
            {
                Console.Write("Challenge 2:\nPlease enter a number between 2 and 10: ");
                input2 = Console.ReadLine();
                converted2 = Int32.TryParse(input2, out int result) ? result : 0;
            }

            divisor = converted2;

            for (int i = 0; i < divisor; i++)
            {
                converted2 = -1;
                while (converted2 < 0)
                {
                    Console.Write($"{i + 1} of {divisor} - Enter a number: ");
                    input2 = Console.ReadLine();
                    converted2 = Int32.TryParse(input2, out int result) ? result : -1;
                }
                sum += converted2;
            }

            double average = GetAverage(sum, divisor);
            Console.WriteLine($"Challenge 2 Produced this output: {average}");
        }
    }
}
