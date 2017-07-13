using System;
using System.Linq;

namespace _06.First_larger_than_neighbours
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(PrintLargerNeighbours(array));
        }
        public static int PrintLargerNeighbours(int[] array)
        {
            int result = -1;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}
