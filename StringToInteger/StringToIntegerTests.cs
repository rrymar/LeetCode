using FluentAssertions;
using Xunit;

namespace LeetCode.StringToInteger
{
    public class StringToIntegerTests
    {
        private readonly StringToIntegerAlgorithm algorithm = new();

        [Theory]
        [InlineData("42",42)]
        [InlineData("-42",-42)]
        [InlineData("4193 with words",4193)]
        [InlineData("words and 987",0)]
        [InlineData("-91283472332",-2147483648)]
        public void IsShouldReturnInteger(string str, int expected)
        {
            algorithm.MyAtoi(str).Should().Be(expected);
        }

    }
}
