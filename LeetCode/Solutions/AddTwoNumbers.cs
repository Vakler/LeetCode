using LeetCode.Models;

namespace LeetCode.Solutions;

public static class AddTwoNumbers
{
    public static ListNode Add(ListNode l1, ListNode l2)
    {
        var remainder = 0;
        var firstRun = true;
        var ln3 = new ListNode();

        while (l1 != null && l2 != null)
        {
            var num = l1.val;
            var num2 = l2.val;
            var total = num + num2;
            if (total >= 10)
            {
                remainder = total % 10;
                total =- 10 + remainder;
            }
            var current = new ListNode(total);
            if (firstRun)
            {
                ln3.val = total;
                firstRun = !firstRun;
                ln3 = ln3.next;
                continue;
            }
            ln3 = current;
            l1 = l1.next;
            l2 = l2.next;
            ln3 = ln3.next;
        }

        return l1;
    }
}