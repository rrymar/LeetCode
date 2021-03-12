using FluentAssertions;
using LeetCode.LongestSubstring;
using Xunit;

namespace LeetCode.MaxSubstring
{
    public class MaxSubstringTests
    {
        private readonly MaxSubstringAlgorithm algorithm = new();

        [Theory]
        [InlineData("123456789","908345600","3456")]
        [InlineData("qwertrt000","sdfsdftrt", "trt")]
        [InlineData("aabcd","aagabcd", "abcd")]
        public void IsShouldReturnMaxSubstring(string str1,string str2,string expected)
        {
            algorithm.MaxSubstring(str1,str2).Should().Be(expected);
        }

    }
}
