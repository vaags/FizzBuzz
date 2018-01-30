using FizzBuzz.ConsoleApp;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzServiceTests
    {
        [Fact]
        public void GetFizzBuzzValue_ShouldReturnStringifiedNumber()
        {
            // Arrange
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();
            const int i = 1;

            // Act
            var result = fizzBuzzService.GetFizzBuzzValue(i);

            // Assert
            Assert.Equal(i.ToString(), result);
        }

        [Fact]
        public void GetFizzBuzzValue_ShouldReturnFizz()
        {
            // Arrange
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();
            const int i = 3;

            // Act
            var result = fizzBuzzService.GetFizzBuzzValue(i);

            // Assert
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void GetFizzBuzzValue_ShouldReturnBuzz()
        {
            // Arrange
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();
            const int i = 5;

            // Act
            var result = fizzBuzzService.GetFizzBuzzValue(i);

            // Assert
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void GetFizzBuzzValue_ShouldReturnFizzBuzz()
        {
            // Arrange
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();
            const int i = 15;

            // Act
            var result = fizzBuzzService.GetFizzBuzzValue(i);

            // Assert
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void GetFizzBuzzResults_ShouldReturnExpectedSequence()
        {
            // Arrange
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();

            var expectedList = new List<string>() { "1", "2", "Fizz", "4", "Buzz" };

            // Act
            var results = fizzBuzzService.GetFizzBuzzResults(expectedList.Count);

            // Assert
            Assert.Equal(expectedList, results);
        }
    }
}
