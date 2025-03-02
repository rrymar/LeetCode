using FluentAssertions;
using LeetCode.LongestSubstring;
using Xunit;

namespace LeetCode.PalindromeNumber
{
    public class PalindromeNumberTests
    {
        private readonly PalindromeNumberAlgorithm algorithm = new();

        [Theory]
        [InlineData(121,true)]
        [InlineData(1,true)]
        [InlineData(10,false)]
        [InlineData(-121,false)]
        public void IsReturnIsPalindrome(int number, bool result)
        {
            algorithm.IsPalindrome(number).Should().Be(result);
        }

    }
}
