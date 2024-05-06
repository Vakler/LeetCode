using LeetCode.Solutions;

namespace LeetCode.Tests.Solutions;

public class LengthOfLastWordTests
{
    [Test]
    public void OutputIsTrue()
    {
        Assert.Multiple(() =>
        {
            Assert.That(LengthOfLastWord.Length("Hello World"), Is.EqualTo(5));
            Assert.That(LengthOfLastWord.Length("   fly me   to   the moon  "), Is.EqualTo(4));
            Assert.That(LengthOfLastWord.Length("luffy is still joyboy"), Is.EqualTo(6));

        });
    }
}