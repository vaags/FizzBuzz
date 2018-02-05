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
            bool isFizz = IsDivisibleByThree(i);
            bool isBuzz = IsDivisibleByFive(i);

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

        private static bool IsDivisibleByFive(int i)
        {
            return i % 5 == 0;
        }

        private static bool IsDivisibleByThree(int i)
        {
            return i % 3 == 0;
        }

        /// <summary>
        /// Creates list of FizzBuzz values
        /// </summary>
        /// <param name="numberOfItems">Number of list items</param>
        /// <returns>List of FizzBuzz values</returns>
        public IEnumerable<string> GetFizzBuzzResults(int numberOfItems)
        {
            for (int i = 1; i <= numberOfItems; i++)
            {
                yield return GetFizzBuzzValue(i);
            }
        }
    }
}
