namespace LeetCode.SearchInsertPosition
{
    /// <summary>
    /// https://leetcode.com/problems/search-insert-position/
    /// </summary>
    public class SearchInsertPositionAlgorithm
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0] >= target ? 0 : 1;

            var min = 0;
            var max = nums.Length - 1;

            while (true)
            {
                var middle = (max - min + 1) / 2 + min;
                if (nums[middle] == target) return middle;

                if (nums[middle] > target)
                {
                    if (min == max) return middle == 0 ? 0 : middle - 1;
                    max = middle == max ? min : middle;
                }
                else
                {
                    if (min == max) return middle + 1;
                    min = middle == min ? max : middle;
                }
            }
        }
    }
}
