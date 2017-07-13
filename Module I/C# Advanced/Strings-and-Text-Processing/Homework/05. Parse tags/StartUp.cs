using System;
using System.Text;

namespace _05.Parse_tags
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(ParseTags(input));
        }
        public static string ParseTags(string str)
        {
            StringBuilder sb = new StringBuilder();
            string openTag = "<upcase>";
            string closeTag = "</upcase>";
            bool isBetween = false;
            int startIndex = 0;
            int i = 0;
            while (i < str.Length)
            {
                if (i > str.IndexOf(openTag, startIndex) + openTag.Length - 1 && i < str.IndexOf(closeTag, startIndex))
                {
                    isBetween = true;
                }
                else
                {
                    isBetween = false;
                }
                if (isBetween == false)
                {
                    sb.Append(str[i]);
                    i++;
                }
                else if (isBetween == true)
                {
                    sb.Append(str.Substring(i, str.IndexOf(closeTag, i)).ToUpper());
                    i += (str.Substring(i, str.IndexOf(closeTag, i))).Length;
                }
            }
            string result = sb.ToString().Replace(openTag, string.Empty).Replace(closeTag, string.Empty);
            return result;
        }
    }
}
