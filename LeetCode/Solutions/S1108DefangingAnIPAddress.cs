namespace LeetCode.Solutions;

public static class S1108DefangingAnIPAddress
{
    public static string Defang(string address)
    {
        var nAddress = address.Replace(".", "[.]");
        return nAddress;
    }
}