using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("What is your name?");

            var name = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {name}");

            Console.ReadLine();
        }
    }
}
