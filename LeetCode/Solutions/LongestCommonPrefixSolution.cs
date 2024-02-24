namespace LeetCode.Utility;

public class LongestCommonPrefixSolution
{
    public string LongestCommonPrefix(string[] strs)
    {
        
        var prefix = "";
        
        for (int i = 0; i < strs.Length; i++)
        {
            var split = strs[i].ToCharArray();
            
            if (i < strs.Length)
            {
                var nSplit = strs[i+1].ToCharArray();
                
            }
            
            
        }
        return prefix;
    }
}