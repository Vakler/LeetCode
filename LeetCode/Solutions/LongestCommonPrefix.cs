namespace LeetCode.Solutions;

public class LongestCommonPrefix
{
    public string Find(string[] strs)
    {
        var prefix = "";

        for (var i = 0; i < strs.Length; i++)
        {
            var split = strs[i].ToCharArray();

            if (i < strs.Length)
            {
                var nSplit = strs[i + 1].ToCharArray();
            }
        }

        return prefix;
    }
}