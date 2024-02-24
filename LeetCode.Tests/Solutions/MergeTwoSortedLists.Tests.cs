using LeetCode.Models;
using LeetCode.Solutions;
using LeetCode.Utility;

namespace LeetCode.Tests.Solutions;
[TestFixture]
public class MergeTwoSortedListsTests
{
    ListNode listNode1;
    ListNode listNode2;

    [SetUp]
    public void Setup()
    {
        listNode1 = new ListNode(1)
        {
            next = new ListNode(2)
            {
                next = new ListNode(4)
            }
        };

        listNode2 = new ListNode(1)
        {
            next = new ListNode(2)
            {
                next = new ListNode(5)
            }
        };
    }

    [Test]
    public void Test1()
    {
        Setup();
        MergeTwoSortedLists.Merge(listNode1, listNode2);
    }
}