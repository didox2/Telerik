using System;
using System.Numerics;

namespace _10.N_Factorial
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            CalculateNFactorail(n);
        }
        public static void CalculateNFactorail(int n)
        {
            BigInteger factorial = 1;
            int[] array = new int[n];
            for (int i = 1; i <= array.Length; i++)
            {
                array[i-1] = i;
            }
            for (int i = 0; i < array.Length; i++)
            {
                factorial *= array[i];
            }
            Console.WriteLine(factorial);
        }
    }
}
