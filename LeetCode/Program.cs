// See https://aka.ms/new-console-template for more information

using System;
using LeetCode.Algorithms;
using LeetCode.Models;
using LeetCode.Solutions;
using LeetCode.Utility;

int[] numbers = new[] { 1, 2, 3, 0, 0, 0 };
int[] numbers2 = new[] { 2, 5, 6 };

MergeSortedArray.Merge(numbers, 3, numbers2, 3);

//
//
//
// var listNode1 = new ListNode(2)
// {
//     next = new ListNode(3)
//     {
//         next = new ListNode(4)
//     }
// };
//
// var listNode2 = new ListNode(5)
// {
//     next = new ListNode(6)
//     {
//         next = new ListNode(4)
//     }
// };

// Console.WriteLine($"{AddTwoNumbers.Add(listNode1,listNode2)}");

// int[] numArr = [31, 12, 59, 26, 41, 58];
// int[] numArr2 = [3, 41, 52, 26, 38, 57, 9, 49];
//
// var a = InsertionSort.SortDec(numArr);
// var b = MergeSort.Sort(numArr2);
//
// Console.WriteLine($"{b}");