using FizzBuzz_Kata;
using FluentAssertions;

namespace FizzBuzz_Tests
{
    public class FizzBuzzTests
    {
        private readonly FizzBuzz _fizzBuzz = new();

        [Test]
        public void Calculate_WhenCalledWithMultipleOfThree_ReturnsFizz([Values(3,63,99)] int value)
        {
            //arrange
            const string expectedResult = "Fizz";

            //act
            var result = _fizzBuzz.Calculate(value);

            //assert
            result.Should().Be(expectedResult);
        }

        [Test]
        public void Calculate_WhenCalledWithMultipleOfFive_ReturnsBuzz([Values(5, 55, 95)] int value)
        {
            //arrange
            const string expectedResult = "Buzz";

            //act
            var result = _fizzBuzz.Calculate(value);

            //assert
            result.Should().Be(expectedResult);
        }

        [Test]
        public void Calculate_WhenCalledWithOtherNumber_ReturnsTheNumber([Values(1, 54, 98)] int value)
        {
            //arrange
            var expectedResult = value.ToString();

            //act
            var result = _fizzBuzz.Calculate(value);

            //assert
            result.Should().Be(expectedResult);
        }
    }
}