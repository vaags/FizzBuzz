using System.Collections.Generic;

namespace FizzBuzz.ConsoleApp
{
    public class FizzBuzzService : IFizzBuzzService
    {
        /// <summary>
        /// Determines FizzBuzz value of number.
        /// See https://en.wikipedia.org/wiki/Fizz_buzz for details
        /// </summary>
        /// <param name="i">Number to be FizzBuzzed</param>
        /// <returns>FizzBuzz value of number</returns>
        public string GetFizzBuzzValue(int i)
        {
            var isFizz = i % 3 == 0; // The number is divisible by 3
            var isBuzz = i % 5 == 0; // The number is divisible by 5

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

        /// <summary>
        /// Creates list of FizzBuzz values
        /// </summary>
        /// <param name="numberOfItems">Number of list items</param>
        /// <returns>List of FizzBuzz values</returns>
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
