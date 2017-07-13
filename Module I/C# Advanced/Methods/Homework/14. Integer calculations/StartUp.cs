using System;
using System.Linq;

namespace _14.Integer_calculations
{
    class StartUp
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            CalculateMinMaxAvgSumPrd(input);
        }
        public static void CalculateMinMaxAvgSumPrd(int[] array)
        {
            int minimum = int.MaxValue;
            int maximum = int.MinValue;
            int sum = 0;
            long product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                product *= array[i];
                if (array[i]<minimum)
                {
                    minimum = array[i];
                }
                if (array[i] > maximum)
                {
                    maximum = array[i];
                }
            }
            double average = (double)sum/array.Length;
            Console.WriteLine("{0}\n{1}\n{2:F2}\n{3}\n{4}", minimum, maximum, average, sum, product);
        }
    }
}
