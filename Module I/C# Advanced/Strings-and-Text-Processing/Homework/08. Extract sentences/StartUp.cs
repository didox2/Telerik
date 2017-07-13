using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Extract_sentences
{
    class StartUp
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            string[] sentances = TextToSentancesArray(text);

            string result = WordContainsInSentances(word, sentances);

            Console.WriteLine(result);
        }

        private static string WordContainsInSentances(string word, string[] sentances)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < sentances.Length; i++)
            {
                string sentance = sentances[i].Trim();
                char[] separators = GetSentanceSeparator(sentance);
                string[] words = sentance.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (words.Contains(word))
                {
                    sb.Append(sentance + ". ");
                }
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        private static char[] GetSentanceSeparator(string sentance)
        {
            List<char> charSeparators = new List<char>();

            for (int i = 0; i < sentance.Length; i++)
            {
                if (!char.IsLetter(sentance[i]))
                {
                    charSeparators.Add(sentance[i]);
                }
            }
            return charSeparators.ToArray();
        }

        private static string[] TextToSentancesArray(string text)
        {
            string[] sentances = text.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            return sentances;
        }
    }
}
