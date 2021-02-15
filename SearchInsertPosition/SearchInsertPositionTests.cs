using FluentAssertions;
using Xunit;

namespace LeetCode.SearchInsertPosition
{
    public class SearchInsertPositionTests
    {
        private readonly SearchInsertPositionAlgorithm algorithm = new();

        [Theory]
        [InlineData("[1,3,5,6]", 5, 2)]
        [InlineData("[1,3,5,6]", 2, 1)]
        [InlineData("[1,3,5,6,11]", 2, 1)]
        [InlineData("[1,3,5,6]", 7, 4)]
        [InlineData("[1,3,5,6]", 0, 0)]
        [InlineData("[1]", 0, 0)]
        [InlineData("[1]", 1, 0)]
        [InlineData("[1,3]", 1, 0)]
        public void IsShouldReturnInsertPosition(string arrayStr, int number, int expected)
        {
            var array = IntArray.Parse(arrayStr);
            algorithm.SearchInsert(array, number).Should().Be(expected);
        }
    }
}
