using System;
using System.Collections.Generic;

namespace LeetCode.ContainerWithMostWater
{
    /// <summary>
    /// hhttps://leetcode.com/problems/container-with-most-water/
    /// </summary>
    public class ContainerWithMostWaterAlgorithm
    {
        public int MaxArea(int[] height)
        {
            var max = 0;
            var left = 0;
            var right = height.Length - 1;
            while(left < right)
            {
                var waterAmount = (right - left) * Math.Min(height[right], height[left]);
                if (waterAmount > max) max = waterAmount;
                if (height[left] <= height[right])
                    left++;
                else
                    right--;
            }

            return max;
        }
    }
}
