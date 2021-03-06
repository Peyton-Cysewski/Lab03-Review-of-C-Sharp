﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace Lab03_Review_of_C_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Challenge 1
            Console.WriteLine("Challenge 1:\nEnter three numbers on the same line separated by spaces:");
            string input1 = Console.ReadLine();
            int output1 = SplitThenMultiplyArray(input1);
            Console.WriteLine($"Challenge 1 produced this output: {output1}");

            // Challenge 2
            Challenge2Container();

            // Challenge 3
            Console.WriteLine("Challenge 3:");
            StarPattern();

            // Challenge 4
            Console.WriteLine("Challenge 4:\nExample Input: [3, 4, 2, 6, 4, 9, 7, 8, 5]");
            int[] array4 = new int[] { 3, 4, 2, 6, 4, 9, 7, 8, 5 };
            int num4 = MostCommonNumber(array4);
            Console.WriteLine($"Challenge 4 produced this output: {num4}");

            // Challenge 5
            Console.WriteLine("Challenge 5:\nExample Input: [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ]");
            int[] array5 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int num5 = LargestNumber(array5);
            Console.WriteLine($"Challenge 5 produced this output: {num5}");

            // Challenge 6
            Console.WriteLine("Challenge 6:\nWrite a word that will be entered to a test.txt file:");
            string word = Console.ReadLine();
            UpdateAFile(word);

            // Challenge 7
            Console.WriteLine("Challenge 7:\nThe contents of the file you just added to are below:");
            ReadAFile();

            // Challenge 8
            Console.WriteLine("Challenge 8:\nThis will remove a random word from the same test file.");
            RemoveAWord();

            // Challenge 9
            Console.WriteLine("Challenge 9:\nEnter a sentence to be analyzed:");
            string sentence = Console.ReadLine();
            string[] output9 = SentenceData(sentence);
            string result9 = String.Join(", ", output9);
            Console.WriteLine($"Challenge 9 produced the output:\n{result9}");
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

        /// <summary>
        /// Finds the most common occurance of a number, if there are multiple numbers of equal occurance, the first one is returned.
        /// </summary>
        /// <param name="array">array of numbers</param>
        /// <returns>most common number</returns>
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

        /// <summary>
        /// Takes in an array of integers and returns the largest number.
        /// </summary>
        /// <param name="array">array of numbers</param>
        /// <returns>largest number</returns>
        public static int LargestNumber(int[] array)
        {
            int num = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > num)
                    num = array[i];
            }
            return num;
        }

        /// <summary>
        /// Takes a string and appends it to the end of a file.
        /// </summary>
        /// <param name="word">appended to the file</param>
        public static void UpdateAFile(string word)
        {
            string path = "../../../words.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(word);
            }
        }

        /// <summary>
        /// Reads the contents of the test file and displays them in the console.
        /// </summary>
        public static void ReadAFile()
        {
            string path = "../../../words.txt";
            string[] contents = File.ReadAllLines(path);
            for (int i = 0; i < contents.Length; i++)
            {
                Console.WriteLine(contents[i]);
            }
        }

        /// <summary>
        /// Randomly removes a word from the test file.
        /// </summary>
        public static void RemoveAWord()
        {
            System.Random Random = new System.Random();
            string path = "../../../words.txt";
            string[] contents = File.ReadAllLines(path);
            string[] newContents = new string[contents.Length - 1];
            int random = Random.Next(0, contents.Length);
            for (int i = 0; i < contents.Length; i++)
            {
                if (i > random)
                    newContents[i - 1] = contents[i];
                else
                    newContents[i] = contents[i];
            }
            File.WriteAllLines(path, newContents);
        }

        /// <summary>
        /// Takes a sentece, splits it into words, and returns a string array that has each word paired with its length of characters.
        /// </summary>
        /// <param name="sentence">the sentence to be analyzed</param>
        /// <returns>analyzed sentence data</returns>
        public static string[] SentenceData(string sentence)
        {
            char[] delimiters = new char[] { ' ', ',', '.', ':', '\t', '!', ';' };
            string[] data = sentence.Split(delimiters, System.StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < data.Length; i++)
            {
                data[i] += $": {data[i].Length}";
            }
            return data;
        }
    }
}
