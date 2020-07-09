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
            //Challenge2Container();

            // Challenge 3
            //Console.WriteLine("Challenge 3:");
            //StarPattern();

            // Challenge 4
            int[] array = new int[] { 3, 4, 2, 6, 1, 9, 7, 8, 5 };
            int num = MostCommonNumber(array);
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

        /// <summary>
        /// Makes a cool star pattern
        /// </summary>
        public static void StarPattern()
        {
            char star = '*';
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i < 5)
                    {
                        if (j < 4 - i || j > 4 + i)
                            Console.Write(' ');
                        else
                            Console.Write(star);
                    }
                    else
                    {
                        if (j < i - 4 || j > 12 - i)
                            Console.Write(' ');
                        else
                            Console.Write(star);
                    }
                }
                Console.Write("\n");
            }
        }

        public static int MostCommonNumber(int[] array)
        {
            int[] results = new int[array.Length];
            results[0] = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0)
                {
                    for (int a = 0; a < i; a++)
                    {
                        if (array[i] == array[a])
                        {
                            results[a] += 1;
                            results[i] = 0;
                            break;
                        }
                        else if (a == i - 1)
                        {
                            results[i] = 1;
                        }
                    }
                }
            }
            int index = 0;
            int num = 1;
            for (int i = results.Length - 1; i >= 0; i--)
            {
                if (results[i] >= num)
                {
                    num = results[i];
                    index = i;
                }
            }
            return array[index];
        }
    }
}
