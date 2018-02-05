using System.Collections.Generic;

namespace FizzBuzz.ConsoleApp
{
    public interface IFizzBuzzService
    {
        string GetFizzBuzzValue(int i);
        IEnumerable<string> GetFizzBuzzResults(int numberOfItems);
    }
}
