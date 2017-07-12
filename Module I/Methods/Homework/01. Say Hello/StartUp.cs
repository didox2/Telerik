using System;

namespace _01.Say_Hello
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            SayHello(input);
        }

        public static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
