// See https://aka.ms/new-console-template for more information

using System;
using LeetCode.Algorithms;
using LeetCode.Models;
using LeetCode.Solutions;
using LeetCode.Utility;

int[] numArr = [31, 12, 59, 26, 41, 58];
// var result = TwoSum.TwoSum(numarr,21);
// ListNode ln2 = new();
// ListNode ln = new(1,ln2);

// Console.WriteLine($"Index of Number {result[0]} : {result[1]}");

// Console.WriteLine(Palindrome.IsPalindrome(1234567899));

// Console.WriteLine("RomanToIntergerSolution.RomanToInt(\"MCMXCIV\")");
//Console.WriteLine($"{ValidParentheses.IsValid("{}")}");

var a = InsertionSort.SortDec(numArr);
//Console.WriteLine($"{InsertionSort.Sort(numArr)}");
Console.WriteLine($"{a}");