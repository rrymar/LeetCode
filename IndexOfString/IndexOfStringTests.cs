using FluentAssertions;
using Xunit;

namespace LeetCode.IndexOfString;

public class IndexOfStringTests
{
    private readonly IndexOfStringAlgorithm algorithm = new();

    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("sadbutsad", "", 0)]
    [InlineData("sadbutsad", "but", 3)]
    [InlineData("sadbutsad", "butu", -1)]
    [InlineData("sadbutsad", "utsad", 4)]
    [InlineData("sadbutsad", "sads", -1)]
    [InlineData("sadbutsad", "sdff", -1)]
    [InlineData("sadbutsadbuter", "bute", 9)]
    [InlineData("sadbutsad", "sadbutsadbut", -1)]
    [InlineData("mississippi", "issip", 4)]
    [InlineData("mississippi", "pi", 9)]
    public void IsShouldReturnSubstringLength(string haystack, string needle, int expected)
    {
        algorithm.StrStr(haystack, needle).Should().Be(expected);
    }
}