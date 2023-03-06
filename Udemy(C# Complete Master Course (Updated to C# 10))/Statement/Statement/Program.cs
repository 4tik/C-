using System;

namespace Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Some String";
            Console.WriteLine($"{nameof(firstString)} : {firstString}");
            PrintSomething();
            Console.WriteLine($"The value of Square : {Square(12)}");
        }

        static void PrintSomething()
        {
            Console.WriteLine("Hello from Print Something method");
        }

        static int Square(int number)
        {
            return (number * number);
        }
    }
}
