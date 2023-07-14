namespace LeetCode.IndexOfString;

/// <summary>
/// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
/// </summary>
public class IndexOfStringAlgorithm
{
    public int StrStr(string haystack, string needle)
    {
        if(needle.Length == 0) return 0;

        const int notStarted = -1;
        var needleIndex = 0;
        var startIndex = notStarted;
        
        for(var i = 0; i < haystack.Length; i++)
        {
            if(haystack[i] == needle[needleIndex])
            {
                if(startIndex == notStarted) startIndex = i; 
                
                needleIndex++;
                
                if(needleIndex >= needle.Length)
                    return startIndex;
            }
            else
            {
                needleIndex = 0;
                if (startIndex == notStarted) 
                    continue;
                
                i = startIndex;
                startIndex = notStarted;
            }
        }

        return -1;
    }
}