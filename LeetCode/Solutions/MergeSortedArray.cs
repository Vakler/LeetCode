using System.Collections.Immutable;

namespace LeetCode.Solutions;

public class MergeSortedArray
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        Array.Reverse(nums1);
        if (n != 0)
        {
            Array.Copy(nums2, nums1, n);
        }
        Array.Sort(nums1);
    }
}