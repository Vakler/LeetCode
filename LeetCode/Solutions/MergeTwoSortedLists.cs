using LeetCode.Models;

namespace LeetCode.Solutions;

public static class MergeTwoSortedLists
{
    public static ListNode Merge(ListNode list1, ListNode list2)
    {
        ListNode lNode = new();
        while (list1.val != null && list2.val != null)
            if (list1.val > list2.val)
                lNode = new ListNode(list1.val);
            else
                lNode = new ListNode(list2.val);
        return lNode;
    }
}