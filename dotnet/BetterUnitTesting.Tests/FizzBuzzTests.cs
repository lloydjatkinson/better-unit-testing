using BetterUnitTesting.FizzBuzz;

using Shouldly;

using Xunit;

namespace BetterUnitTesting.Tests
{
    public class FizzBuzzIterationOne
    {
        [Fact]
        public void ShouldReturnNumberWhenNotAMultiple()
        {
            Assert.Equal("11", FizzBuzzer.GetFizzOrBuzz(11));
        }

        [Fact]
        public void ShouldFizzWhenGivenMultipleOfThree()
        {
            Assert.Equal("Fizz", FizzBuzzer.GetFizzOrBuzz(3));
        }

        [Fact]
        public void ShouldBuzzWhenGivenMultipleOfFive()
        {
            Assert.Equal("Buzz", FizzBuzzer.GetFizzOrBuzz(20));
        }

        [Fact]
        public void ShouldFizzBuzzWhenGivenMultipleOfThreeAndFive()
        {
            Assert.Equal("FizzBuzz", FizzBuzzer.GetFizzOrBuzz(15));
        }
    }

    public class FizzBuzzIterationTwo
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void ShouldFizzWhenGivenMultiplesOfThree(int input)
        {
            Assert.Equal("Fizz", FizzBuzzer.GetFizzOrBuzz(input));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        public void ShouldFizzWhenGivenMultiplesOfTFive(int input)
        {
            Assert.Equal("Buzz", FizzBuzzer.GetFizzOrBuzz(input));
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(60)]
        public void ShouldFizzBuzzWhenGivenMultiplesOfTFiveAndThree(int input)
        {
            Assert.Equal("FizzBuzz", FizzBuzzer.GetFizzOrBuzz(input));
        }
    }

    public class FizzBuzzIterationThree
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void ShouldFizzWhenGivenMultiplesOfThree(int input)
        {
            FizzBuzzer.GetFizzOrBuzz(input).ShouldBe("Fizz");
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void ShouldBuzzWhenGivenMultiplesOfFive(int input)
        {
            FizzBuzzer.GetFizzOrBuzz(input).ShouldBe("Fizz");
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(60)]
        public void ShouldFizzBuzzWhenGivenMultiplesOfTFiveAndThree(int input)
        {
            FizzBuzzer.GetFizzOrBuzz(input).ShouldBe("FizzBuzz");
        }
    }
}