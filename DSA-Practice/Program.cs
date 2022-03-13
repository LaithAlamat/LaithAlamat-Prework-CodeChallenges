using System;

namespace DSA_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Console.WriteLine("arrayMaxResult Answer is: " + arrayMaxResult(numbers));
            Console.WriteLine("Result for LeapYearCalculator : " + LeapYearCalculator());
            int[] sequence = { 1, 2, 3 };
            Console.WriteLine("Result for perfectSequence: " + perfectSequence(sequence));
            int[,] arr2 = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            Console.WriteLine("Result for SumOfRows : ");
            int[] resultArr = SumOfRows(arr2, 3, 5);
            printArray(resultArr);
        }

        static int arrayMaxResult(int[] arr)
        {
            Console.WriteLine("Please enter five numbers from 1-10");
            getArray(arr);
            int count = 0;
            Console.WriteLine("Please select a number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }
            int result = number * count;
            return result;
        }

        static void getArray(int[] arr)
        {
           
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] < 1 || arr[i] > 10)
                {
                    Console.WriteLine("this is not number. enter valid num");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            printArray(arr);
        }


        static void printArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

        }

        static Boolean LeapYearCalculator()
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year.", Year);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year.", Year);
                return false;
            }
            Console.ReadLine();
        }

        static String perfectSequence(int[] arr)
        {
            Boolean isPositive = true;
            int summation = 0;
            int product = 1;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < 0)
                {
                    isPositive = false;

                }
                else
                {
                    summation += arr[i];
                    product *= arr[i];
                }
            }

            if (isPositive == true && summation == product)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        static int[] SumOfRows(int[,] arr, int rows, int colms)
        {
            int[] sum = new int[rows];


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colms; j++)
                {
                    sum[i] += arr[i, j];
                }
            }
            return sum;
        }

    }
}