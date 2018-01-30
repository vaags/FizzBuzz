using System;

namespace FizzBuzz.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();

            foreach (var result in fizzBuzzService.GetFizzBuzzResults(100))
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
