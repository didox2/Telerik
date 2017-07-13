using System;

namespace _08.Maximal_sum
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            FindMaximumSum(array);
        }

        public static void FindMaximumSum(int[] array)
        {
            int sum = 0;
            int maxSum = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                if (sum < 0)
                {
                    sum = 0;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
