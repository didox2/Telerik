using System;
using System.Linq;

namespace _02.Compare_arrays
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];
            FillArray(array1);
            FillArray(array2);

            CompareArrays(array1, array2);
        }

        public static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void CompareArrays(int[] arr1, int[] arr2)
        {
            bool isEqual = true;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i]!=arr2[i])
                {
                    isEqual = false;
                    break;
                }
            }
            if (arr1.Length!=arr2.Length)
            {
                isEqual = false;
            }
            Console.WriteLine(isEqual?"Equal":"Not equal");
        }
    }
}
