using System;
using System.Linq;

namespace _09.Sorting_array
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int[] sortedArray = SortAscending(array);
            Console.WriteLine(string.Join(" ", sortedArray));
        }
        public static int[] SortAscending(int[] array)
        {
            int[] sortedArray = new int[array.Length];
            SortDescending(array);
            for (int i = array.Length - 1, index = 0; i >= 0; i--, index++)
            {
                sortedArray[index] = array[i];
            }
            return sortedArray;
        }

        public static int[] SortDescending(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                int curMaxIndex = MaximalElement(i, array);
                if (i != curMaxIndex)
                {
                    array[i] ^= array[curMaxIndex];
                    array[curMaxIndex] ^= array[i];
                    array[i] ^= array[curMaxIndex];
                }
            }
            return array;
        }

        public static int MaximalElement(int startIndex, int[] array)
        {
            int maxElement = int.MinValue;
            int maxIndex = -1;
            for (int i = startIndex; i < array.Length; i++)
            {
                if (maxElement <= array[i])
                {
                    maxElement = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
    }
}
