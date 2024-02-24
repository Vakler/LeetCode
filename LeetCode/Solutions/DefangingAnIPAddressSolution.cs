namespace LeetCode.Utility;

public static class DefangingAnIPAddressSolution
{
    public static string DefangIPaddr(string address)
    {
        var nAddress = address.Replace(".", "[.]");
        return nAddress;
    }
}