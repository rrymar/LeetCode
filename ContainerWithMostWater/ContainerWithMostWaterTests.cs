using FluentAssertions;
using Xunit;

namespace LeetCode.ContainerWithMostWater
{
    public class ContainerWithMostWaterTests
    {
        private readonly ContainerWithMostWaterAlgorithm algorithm = new();

        [Theory]
        [InlineData("[1,8,6,2,5,4,8,3,7]",49)]
        [InlineData("[1,1]",1)]
        public void IsShouldReturnSubstringLength(string arrayString, int expected)
        {
            algorithm.MaxArea(IntArray.Parse(arrayString)).Should().Be(expected);
        }

    }
}
