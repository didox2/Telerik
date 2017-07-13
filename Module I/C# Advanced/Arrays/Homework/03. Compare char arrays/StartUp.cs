using System;

namespace _03.Compare_char_arrays
{
    class StartUp
    {
        static void Main()
        {
            char[] charArray1 = Console.ReadLine().ToCharArray();
            char[] charArray2 = Console.ReadLine().ToCharArray();

            CompareCharArrays(charArray1, charArray2);
        }
        public static void CompareCharArrays(char[] arr1, char[] arr2)
        {
            bool areEqual = true;
            if (arr1.Length==arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i]>arr2[i])
                    {
                        areEqual = false;
                        Console.WriteLine(">");
                        break;
                    }
                    else if (arr1[i]<arr2[i])
                    {
                        areEqual = false;
                        Console.WriteLine("<");
                        break;
                    }
                }
                if (areEqual)
                {
                    Console.WriteLine("=");
                }
            }
            else if (arr1.Length>arr2.Length)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (arr1[i]>arr2[i])
                    {
                        areEqual = false;
                        Console.WriteLine(">");
                        break;
                    }
                    else if (arr1[i]<arr2[i])
                    {
                        areEqual = false;
                        Console.WriteLine("<");
                        break;
                    }
                }
                if (areEqual)
                {
                    Console.WriteLine(">");
                }
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] > arr2[i])
                    {
                        areEqual = false;
                        Console.WriteLine(">");
                        break;
                    }
                    else if (arr1[i] < arr2[i])
                    {
                        areEqual = false;
                        Console.WriteLine("<");
                        break;
                    }
                }
                if (areEqual)
                {
                    Console.WriteLine("<");
                }
            }
        }
    }
}
