using LeetCode.Models;
using LeetCode.Utility;

namespace LeetCode.Tests;



[TestFixture]
public class MergeTwoSortedLists
{
    ListNode listNode1;
    ListNode listNode2;

    [SetUp]
    public void Setup()
    {
        listNode1 = new(1);
        listNode1.next = new(2);
        listNode1.next.next = new(4);

        listNode2 = new(1);
        listNode2.next = new(2);
        listNode2.next.next = new(5);
    }

    [Test]
    public void Test1()
    {
        Setup();
        MergeTwoSortedListsSolution.MergeTwoLists(listNode1, listNode2);
    }
}