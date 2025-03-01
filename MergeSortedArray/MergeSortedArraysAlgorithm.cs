using System.Collections.Generic;

namespace LeetCode.MergeSortedArray
{
    /// <summary>
    /// https://leetcode.com/problems/merge-sorted-array/
    /// </summary>
    public class MergeSortedArraysAlgorithm
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0) return;

            var output = m != 0 ? new int[m + n] : nums2;

            var index1 = 0;
            var index2 = 0;

            for (int i = 0; i < output.Length; i++)
            {
                if (index2 >= n || (index1 < m && nums1[index1] <= nums2[index2]))
                {
                    output[i] = nums1[index1];
                    index1++;
                }
                else
                {
                    output[i] = nums2[index2];
                    index2++;
                }
            }

            for (int i = 0; i < output.Length; i++)
            {
                nums1[i] = output[i];
            }
        }

        public void Merge2(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0) return;

            var output = new List<int>(m + n);

            var index1 = 0;
            var index2 = 0;

            var firstDone = false;
            var secondDone = false;

            while (!firstDone || !secondDone)
            {
                if (!firstDone && nums1[index1] <= nums2[index2])
                {
                    output.Add(nums1[index1]);
                    index1++;
                }
                else
                {
                    output.Add(nums2[index2]);
                    index2++;
                }

                firstDone = index1 >= m;
                secondDone = index2 >= n;
            }


            for (int i = 0; i < output.Count; i++)
            {
                nums1[i] = output[i];
            }
        }
    }
}