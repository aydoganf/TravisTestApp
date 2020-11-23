using System;
using SomeBusinessLib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyService myService = new MyService();

            var result = myService.Sum(1, 5);
            Console.WriteLine($"Result is {result}");
        }
    }
}
