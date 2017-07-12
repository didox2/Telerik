using System;
using System.Linq;

namespace _05.Larger_than_neighbours
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            PrintLargerNeighbours(array);
        }
        public static void PrintLargerNeighbours(int[] array)
        {
            int counter = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
