using System.Collections.Generic;

namespace LeetCode.RemoveElement
{
    /// <summary>
    /// https://leetcode.com/problems/remove-element/
    /// </summary>
    public class RemoveElementAlgorithm
    {
        public int RemoveElement(int[] nums, int val) {
            var initialCount = nums.Length;
            var output = new List<int>(initialCount);
            for(int i = 0; i<nums.Length; i++)
            {
                if(nums[i] != val){
                    output.Add(nums[i]);
                }
            } 

            for(int j = 0; j<output.Count; j++){
                nums[j] = output[j];
            }

            return output.Count;
        }
    }
}
