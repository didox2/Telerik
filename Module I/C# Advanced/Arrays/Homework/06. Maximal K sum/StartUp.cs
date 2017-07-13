using System;

namespace _06.Maximal_K_sum
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            FindMaximalSumOfKElements(k, array);

        }
        public static void FindMaximalSumOfKElements(int k, int[] array)
        {
            int[] kArray = new int[k];
            int biggest = int.MinValue;
            int index = 0;
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j]>biggest)
                    {
                        biggest = array[j];
                        index = array[j];
                    }
                }
                kArray[i] = biggest;
                biggest = int.MinValue;
                array[index] = int.MinValue;
            }
            for (int i = 0; i < kArray.Length; i++)
            {
                sum += kArray[i];
            }
            Console.WriteLine(sum);
        }
    }
}
