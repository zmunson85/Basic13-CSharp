using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            for (int i = 1; i < 256; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += i;
                Console.WriteLine($"New number:{i} Sum: {sum}");
            }
        }
        public static void LoopArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

            }
            Console.WriteLine(max);
            return max;
        }
        public static double GetAverage(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double avg = sum / numbers.Length;
            Console.WriteLine(avg);
            return avg;
        }
        public static List<int> OddArray()
        {
            List<int> numArray = new List<int>();
            for (int i = 1; i < 256; i += 2)
            {
                numArray.Add(i);
            }
            Console.WriteLine(numArray);
            return numArray;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > y)
                {
                    count++;
                }
            }
            return count;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
            Console.WriteLine(String.Join(",", numbers));
        }
        public static void EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine(String.Join(",", numbers));
        }
        public static void MinMaxAverage(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            double avg = GetAverage(numbers);
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

            }
            Console.WriteLine($"{max}, {min}, {avg}");
        }
        public static void ShiftValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = 0;
            Console.WriteLine(String.Join(",", numbers));
        }
        public static List<object> NumToString(int[] numbers)
        {
            List<object> newObject = new List<object>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    newObject.Add("Dojo");
                }
                else
                {
                    newObject.Add(numbers[i]);
                }
            }
            return newObject;
        }
        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // LoopArray(array);
            // FindMax(array);
            // GetAverage(array);
            // Console.WriteLine(String.Join(",",OddArray()));
            // Console.WriteLine(GreaterThanY(array, 2));
            // SquareArrayValues(array);
            // EliminateNegatives(array);
            // MinMaxAverage(array);
            // ShiftValues(array);
            int[] array = new int[] { 1, 2, -3, 4, 5, 10, -7 };
            Console.WriteLine(String.Join(",", NumToString(array)));
        }
    }
}