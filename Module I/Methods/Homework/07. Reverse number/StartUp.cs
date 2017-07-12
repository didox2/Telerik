using System;
using System.Text;

namespace _07.Reverse_number
{
    class StartUp
    {
        static void Main()
        {
            decimal input = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReverseDeciamlNumber(input));
        }
        public static decimal ReverseDeciamlNumber(decimal number)
        {
            string n = number.ToString();
            StringBuilder sb = new StringBuilder();
            for (int i = n.Length -1; i >= 0; i--)
            {
                sb.Append(n[i]);
            }
            return decimal.Parse(sb.ToString());
        }
    }
}
