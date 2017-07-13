using System;
using System.Linq;

namespace _04.Appearance_count
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = ParseLineToIntArr(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(CountNumberInArray(numbers, x));
        }
        public static int[] ParseLineToIntArr(string input)
        {
            int[] numbers = input.Split(' ').Select(x => int.Parse(x)).ToArray();
            return numbers;
        }
        public static int CountNumberInArray(int[] array, int number)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
