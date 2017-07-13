using System;

namespace _03.English_digit
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int digit = input[input.Length - 1]-'0';

            Console.WriteLine(LastDigitAsWord(digit));
        }
        public static string LastDigitAsWord(int digit)
        {
            string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
           
            return words[digit];
        }
    }
}
