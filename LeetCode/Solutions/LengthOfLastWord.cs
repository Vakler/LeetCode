namespace LeetCode.Solutions;

public static class LengthOfLastWord
{
    public static int Length(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }
        var last = s
            .Split(" ")
            .Last(x => x.Length > 0)
            .Length;
        return last;
    }
}