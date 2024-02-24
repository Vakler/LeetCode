namespace LeetCode.Solutions;

public class TwoSum
{
    public static int[] Sum(int[] nums, int target)
    {
        int i, j;
        for (i = 0; i < nums.Length; i++)
        for (j = 1; j < nums.Length; j++)
            if (nums[i] + nums[j] == target)
                return [i, j];
        return null;
    }
}