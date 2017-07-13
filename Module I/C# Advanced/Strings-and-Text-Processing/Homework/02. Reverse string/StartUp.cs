using System;
using System.Text;

namespace _02.Reverse_string
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReverseString(input));
        }
        public static string ReverseString(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length -1 ; i >=0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
