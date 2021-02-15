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

            var min = 0;
            var max = nums.Length - 1;

            while (min <= max)
            {
                var middle = (max - min + 1) / 2 + min;
                if (nums[middle] == target) return middle;

                if (nums[middle] > target)
                    max =  middle - 1;
                else
                    min = middle + 1;
            }

            return min;
        }
    }
}
