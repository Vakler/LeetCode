﻿namespace LeetCode.Solutions;

public static class DefangingAnIPAddress
{
    public static string Defang(string address)
    {
        var nAddress = address.Replace(".", "[.]");
        return nAddress;
    }
}