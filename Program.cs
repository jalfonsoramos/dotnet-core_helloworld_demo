using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("What is your name?");

            var name = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {name}");
        }
    }
}
