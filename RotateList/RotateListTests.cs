using FluentAssertions;
using Xunit;

namespace LeetCode.RotateList
{
    public class RotateListTests
    {
        private readonly RotateListAlgorithm algorithm = new();

        [Fact]
        public void IsShouldRotate_KLessSize()
        {
            var list = ListNode.Create(new[] {1, 2, 3, 4, 5});
            var result = algorithm.RotateRight(list, 2);

            var actual = result.ToIntArray();
            actual.Should().Equal(4, 5, 1, 2, 3);
        }

        [Fact]
        public void IsShouldRotate_KGreaterSize()
        {
            var list = ListNode.Create(new[] {0, 1, 2});
            var result = algorithm.RotateRight(list, 4);

            var actual = result.ToIntArray();
            actual.Should().Equal(2, 0, 1);
        }

        [Fact]
        public void IsShouldRotate_KEqualSize()
        {
            var list = ListNode.Create(new[] {0, 1, 2});
            var result = algorithm.RotateRight(list, 3);

            var actual = result.ToIntArray();
            actual.Should().Equal(0, 1, 2);
        }

        [Fact]
        public void IsShouldRotate_ZeroSize()
        {
            var result = algorithm.RotateRight(null, 1);
            result.Should().BeNull();
        }
    }
}
