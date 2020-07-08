﻿using System;

namespace Lab03_Review_of_C_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
    }
}
