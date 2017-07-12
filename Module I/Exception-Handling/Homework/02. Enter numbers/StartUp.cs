using System;

namespace _02.Enter_numbers
{
    class StartUp
    {
        static void Main()
        {
            ReadNumber(1, 100);
        }

        public static void ReadNumber(int start, int end)
        {
            int[] numbers = new int[10];
            try
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception)
            {
                throw new Exception("Exception");
            }
            try
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] <= start || numbers[i] >= end || numbers[i] >= numbers[i + 1])
                    {
                        throw new Exception("Exception");
                    }
                }
                Console.WriteLine("1 < " + string.Join(" < ", numbers) + " < 100");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
