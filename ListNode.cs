using System.Collections.Generic;
using FluentAssertions;
using Xunit;
// LeetCode contract issue
// ReSharper disable InconsistentNaming
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public int[] ToIntArray()
        {
            var list = new List<int>();
            var current = this;
            do
            {
                list.Add(current.val);
                current = current.next;

            } while (current != null);
            return list.ToArray();
        }

        public static ListNode Create(int[] numbers)
        {
            if (numbers.Length == 0) return null;

            var top = new ListNode(numbers[0]);
            var current = top;
            for (int i = 1; i < numbers.Length; i++)
            {
                current.next = new ListNode(numbers[i]);
                current = current.next;
            }

            return top;
        }
    }

    public class ListNodeTests
    {
        [Fact]
        public void IsShouldReturnArray()
        {
            var first = ListNode.Create(new[] {1, 2, 3});
            var result = first.ToIntArray();
            result.Should().Equal(1, 2, 3);
        }

        [Fact]
        public void IsShouldCreateList()
        {
            var first = ListNode.Create(new[] {1, 2, 3});
            first.val.Should().Be(1);

            var second = first.next;
            second.Should().NotBeNull();
            second.val.Should().Be(2);

            var third = second.next;
            third.Should().NotBeNull();
            third.val.Should().Be(3);
        }
    }
}
