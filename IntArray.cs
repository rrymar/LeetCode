using System.Linq;
using FluentAssertions;
using Xunit;

namespace LeetCode
{
    public static class IntArray
    {
        private const char Separator = ',';

        public static int[] Parse(string srt)
        {
            var trimmed = srt.Trim('[', ']');
            return trimmed.Split(Separator).Select(int.Parse).ToArray();
        }

        public static string ToLeetCodeString(this int[] array)
        {
            return $"[{string.Join(Separator, array)}]";
        }
    }

    public class IntArrayTests
    {
        [Fact]
        public void ItShouldParseString()
        {
            var actual = IntArray.Parse("[3,6,2]");
            actual.Should().BeEquivalentTo(new[] {3, 6, 2});
        }

        [Fact]
        public void ItShouldReturnLeetCodeString()
        {
            var actual = new[] {1, 2, 3}.ToLeetCodeString();
            actual.Should().Be("[1,2,3]");
        }
    }
}
