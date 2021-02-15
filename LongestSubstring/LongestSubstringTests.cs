using FluentAssertions;
using Xunit;

namespace LeetCode.LongestSubstring
{
    public class LongestSubstringTests
    {
        private readonly LongestSubstringAlgorithm algorithm = new();

        [Theory]
        [InlineData("abcabcbb",3)]
        [InlineData("bbbbb",1)]
        [InlineData("pwwkew",3)]
        [InlineData("",0)]
        public void IsShouldReturnSubstringLength(string str, int expected)
        {
            algorithm.LengthOfLongestSubstring(str).Should().Be(expected);
        }

    }
}
