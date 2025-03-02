using System.Collections.Generic;

namespace LeetCode.PalindromeNumber
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public class PalindromeNumberAlgorithm
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            if (x < 10) return true;

            var nums = new List<int>();

            while (x > 0)
            {
                var mod = x % 10;
                nums.Add(mod);
                x = x / 10;
            }

            for (int i = 0; i < nums.Count / 2; i++)
            {
                var rigthIndex = nums.Count - i - 1;
                if (rigthIndex <= i) break;

                var left = nums[i];
                var rigth = nums[rigthIndex];
                if (left != rigth) return false;
            }

            return true;
        }
    }
}