namespace LeetCode.Solutions;

public class SRemoveDuplicates
{
    public static int RemoveDuplicates(int[] nums)
    {
        var uniques = nums.Select(x => x)
            .Distinct()
            .ToArray();

        nums = uniques;
        
        return uniques.Length;
    }
}