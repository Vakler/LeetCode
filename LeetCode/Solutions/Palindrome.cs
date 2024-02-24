using System;

namespace LeetCode.Solutions;

public static class Palindrome
{
    public static bool IsPalindrome(int x)
    {
        if (int.IsNegative(x)) return false;
        var mArr = x
            .ToString()
            .ToCharArray();

        var mirror = "";
        Array.Reverse(mArr, 0, mArr.Length);
        foreach (var cha in mArr) mirror += cha;

        if (int.TryParse(mirror, out var a)) return a == x;

        return false;
    }
}