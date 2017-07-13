using System;

namespace _05.Maximal_increasing_sequence
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            FillArray(arr);
            CountMaximalIncreasingSequence(arr);
        }
        public static void CountMaximalIncreasingSequence(int[] array)
        {
            int counter = 1;
            int maxCounter = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    counter++;
                    if (maxCounter < counter)
                    {
                        maxCounter = counter;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            Console.WriteLine(maxCounter);
        }

        public static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}