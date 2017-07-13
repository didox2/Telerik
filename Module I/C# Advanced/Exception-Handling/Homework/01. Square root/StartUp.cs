using System;

namespace _01.Square_root
{
    class StartUp
    {
        static void Main()
        {
            try
            {
                string input = Console.ReadLine();
                double number = double.Parse(input);
                if (number < 0)
                {
                    throw new Exception("Invalid number");
                }
                Console.WriteLine("{0:F3}",Math.Sqrt(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
