using System.Runtime.Serialization.Json;
using LeetCode.Models;

namespace LeetCode.Utility;

public static class MergeTwoSortedListsSolution
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode lNode = new();
        while (list1.val != null && list2.val != null)
        {
            
            if (list1.val > list2.val)
            {
                lNode = new(list1.val);
            }
            else
            {
                lNode = new(list2.val);
            }
        }
        return lNode;
    }
}