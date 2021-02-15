using System;
using System.Collections.Generic;

namespace LeetCode.TwoSum
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class TwoSumAlgorithm
    {
        public int[] TwoSum(int[] nums, int target) {
            var originalHash = new HashSet<int>(nums);

            for(int i = 0; i< nums.Length;i++) {
                var num1 = nums[i];
                var num2 = target - num1;

                if(!originalHash.Contains(num2))
                    continue;

                var index2 = Array.IndexOf(nums,num2);

                if(i == index2) continue;

                return new int[] { i, index2 };
            }


            throw new ArgumentException();
        }
    }
}
