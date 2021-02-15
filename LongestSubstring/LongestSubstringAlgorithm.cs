namespace LeetCode.LongestSubstring
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    public class LongestSubstringAlgorithm
    {
        public int LengthOfLongestSubstring(string s)
        {
            var map = new ushort[128];
            ushort result = 0, start = 0;
            for (ushort end = 0; end < s.Length; end++)
            {
                var currentChar = s[end];

                start = map[currentChar] > start ? map[currentChar] : start;

                var newResult = (ushort) (end - start + 1);
                if (newResult > result)
                    result = newResult;

                map[currentChar] = (ushort) (end + 1);
            }


            return result;
        }
    }
}
