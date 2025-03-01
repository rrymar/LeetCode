using System;
using FluentAssertions;
using LeetCode.RemoveElement;
using Xunit;

namespace LeetCode.MergeSortedArray
{
    public class MergeSortedArraysTests
    {
        private readonly MergeSortedArraysAlgorithm algorithm = new();

        [Fact]
        public void ItMergesArrays()
        {
            var nums1 = new[] { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int n = 3;
            var nums2 = new[] { 2, 5, 6 };
            algorithm.Merge(nums1, m, nums2, n);

            nums1.Should().BeEquivalentTo(new[] { 1, 2, 2, 3, 5, 6 });
        }

        [Fact]
        public void ItMergesSingleElementsArrays()
        {
            var nums1 = new[] { 2,0 };
            int m = 1;
            int n = 1;
            var nums2 = new[] { 1 };
            algorithm.Merge(nums1, m, nums2, n);

            nums1.Should().BeEquivalentTo(new[] { 1, 2 });
        }

        [Fact]
        public void ItMergesEmptySecondArray()
        {
            var nums1 = new[] { 1 };
            int m = 1;
            int n = 0;
            var nums2 = Array.Empty<int>();
            algorithm.Merge(nums1, m, nums2, n);

            nums1.Should().BeEquivalentTo(new[] { 1 });
        }
    }
}