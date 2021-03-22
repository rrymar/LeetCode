using FluentAssertions;
using Xunit;

namespace LeetCode.ThreeConsecutiveOdds
{
    public class ThreeConsecutiveOddsTests
    {
        private readonly ThreeConsecutiveOddsAlgorithm algorithm = new();

        [Theory]
        [InlineData(false,2,6,4,1)]
        [InlineData(true,1,2,34,3,4,5,7,23,12)]
        public void IsShouldReturnInteger(bool expected, params int[] numbers)
        {
            algorithm.ThreeConsecutiveOdds(numbers).Should().Be(expected);
        }
    }
}