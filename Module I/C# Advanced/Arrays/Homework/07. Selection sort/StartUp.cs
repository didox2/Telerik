using System;

namespace _07.Selection_sort
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
            SortArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void SortArray(int[] array)
        {
            int minElement;
            int curElement = 0;

            for (int i = 0; i < array.Length; i++)
            {
                minElement = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j]<array[minElement])
                    {
                        minElement = j;
                    }
                }
                curElement = array[i]; 
                array[i] = array[minElement];
                array[minElement] = curElement;
            }
        }
    }
}
