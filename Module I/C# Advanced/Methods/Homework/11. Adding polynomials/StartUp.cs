using System;
using System.Linq;

namespace _11.Adding_polynomials
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            SumPolynomials(array1, array2);
        }
        public static void SumPolynomials(int[] array1, int[] array2)
        {
            int[] resultArray = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                resultArray[i] = array1[i] + array2[i];
            }
            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
