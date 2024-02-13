using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

namespace NumberArrayConsole
{
    internal class Program
    {
        //  Declare and initialize program constants
        const int SIZE = 25;
        const int MINTESTSCORE = 0;
        const int MAXTESTSCORE = 100;

        //  Declare and initialize class variables
        static int[] numbers = new int[SIZE];
        static int sum = 0;

        static void Main(string[] args)
        {
            while (1 == 1)
            {
                Clear();
                InitializeArray();
                SortArrayAsending();
                SortArrayDescending();
                GetSmallestArrayElement();
                GetLargestArrayElement();
                GetSumOfArrayElements();
                GetAverageOfArrayElements();
            }
        }

        //  Create 25 random test scores between 0 - 100
        static void InitializeArray()
        {
            //  "Seed" the rand
            Random rand = new Random();

            //  Generate 25 random numbers between 0 - 100
            for (int lcv = 0; lcv < SIZE; ++lcv)
            {
                //numbers[lcv] = rand.Next(0, 101);
                numbers[lcv] = rand.Next(MINTESTSCORE, (MAXTESTSCORE + 1));
            }

            WriteLine("Display the 25 numbers in their original order:");
            DisplayArray();
        }

        static void DisplayArray()
        {
            //  Display the 25 random numbers
            for (int lcv = 0; lcv < SIZE; ++lcv)
            {
                Write(numbers[lcv] + " ");
            }
        }

        static void SortArrayAsending()
        {
            Array.Sort(numbers);
            ReadLine();

            Write("\nHere is the array in ascending order:\n");
            DisplayArray();

            ReadLine();
        }

        static void SortArrayDescending()
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            ReadLine();

            Write("\nHere is the array in descending order:\n");
            DisplayArray();

            ReadLine();
        }

        static void GetSmallestArrayElement()
        {
            Array.Sort(numbers);
            ReadLine();

            WriteLine("\nThe smallest array element is:\t" + numbers[0].ToString());

            ReadLine();
        }

        static void GetLargestArrayElement()
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            ReadLine();

            WriteLine("\nThe largest array element is:\t" + numbers[0].ToString());

            ReadLine();
        }

        static void GetSumOfArrayElements()
        {
            sum = 0;

            for (int lcv = 0; lcv < SIZE; ++lcv)
            {
                sum += numbers[lcv];
            }

            ReadLine();

            WriteLine("\nThe sum of all array elements is:\t" + sum.ToString());

            ReadLine();

        }

        static void GetAverageOfArrayElements()
        {
            decimal average = 0m;

            average = (decimal)sum / numbers.Length;

            ReadLine();

            WriteLine("\nThe avg of all array elements is:\t" + average.ToString());

            ReadLine();

        }

    }
}
