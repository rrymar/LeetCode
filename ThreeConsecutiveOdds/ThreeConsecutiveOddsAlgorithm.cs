using System;

namespace LeetCode.ThreeConsecutiveOdds
{
    /// <summary>
    /// https://leetcode.com/problems/three-consecutive-odds/
    /// </summary>
    public class ThreeConsecutiveOddsAlgorithm
    {
        public bool ThreeConsecutiveOdds(int[] arr)
        {
            var sequenceLen = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sequenceLen++;
                    if (sequenceLen == 3) return true;
                }
                else
                {
                    sequenceLen = 0;
                }
            }

            return false;
        }
    }
}