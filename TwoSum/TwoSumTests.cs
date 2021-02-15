using FluentAssertions;
using Xunit;

namespace LeetCode.TwoSum
{
    public class TwoSumTests
    {
        private readonly TwoSumAlgorithm algorithm = new();

        [Fact]
        public void IsShouldReturnTwoSum()
        {
            var array = IntArray.Parse("[2,7,11,15]");
            algorithm.TwoSum(array, 9).Should().BeEquivalentTo(new[] {0, 1});
        }

        [Fact]
        public void IsShouldReturnTwoSum2()
        {
            var array = IntArray.Parse("[3,2,4]");
            algorithm.TwoSum(array, 6).Should().BeEquivalentTo(new[] {1, 2});
        }
    }
}
