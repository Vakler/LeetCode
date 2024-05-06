using LeetCode.Solutions;

namespace LeetCode.Tests.Solutions;

public class DefangingAnIpAddressTests
{
    [Test]
    public void OutputIsCorrect()
    {
        Assert.Multiple(() =>
        {
            Assert.That(S1108DefangingAnIPAddress.Defang("1.1.1.1"), Is.EqualTo("1[.]1[.]1[.]1"));
            Assert.That(S1108DefangingAnIPAddress.Defang("255.100.50.0"), Is.EqualTo("255[.]100[.]50[.]0"));
        });
    }
}