using System;
using System.Linq;

namespace _02.Get_largest_number
{
    class StartUp
    {
        static void Main()
        {
            int[] numbers = ParseLineToIntArr(Console.ReadLine());
            int firstNumber = numbers[0];
            int secondNumber = numbers[1];
            int thirdNumber = numbers[2];

            int temp = GetMax(firstNumber, secondNumber);

            Console.WriteLine(GetMax(temp,thirdNumber));
        }
        public static int[] ParseLineToIntArr(string input)
        {
            int[] numbers = input.Split(' ').Select(x => int.Parse(x)).ToArray();
            return numbers;
        }
        public static int GetMax(int firstNum, int secondNum)
        {
            return firstNum >= secondNum ? firstNum : secondNum;
        }
    }
}
