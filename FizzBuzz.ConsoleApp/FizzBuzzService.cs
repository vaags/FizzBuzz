using System.Collections.Generic;

namespace FizzBuzz.ConsoleApp
{
    public interface IFizzBuzzService
    {
        string GetFizzBuzzValue(int i);
        List<string> GetFizzBuzzResults(int numberOfItems);
    }

    public class FizzBuzzService : IFizzBuzzService
    {
        public string GetFizzBuzzValue(int i)
        {
            var isFizz = i % 3 == 0;
            var isBuzz = i % 5 == 0;

            if (isFizz && isBuzz)
            {
                return "FizzBuzz";
            }

            if (isFizz)
            {
                return "Fizz";
            }

            if (isBuzz)
            {
                return "Buzz";
            }

            return i.ToString();
        }

        public List<string> GetFizzBuzzResults(int numberOfItems)
        {
            var results = new List<string>();

            for (int i = 1; i <= numberOfItems; i++)
            {
                results.Add(GetFizzBuzzValue(i));
            }

            return results;
        }
    }
}
