using LeetCode.Solutions;
using LeetCode.Utility;

namespace LeetCode.Tests.Solutions;

[TestFixture]
public class PalindromeTests
{
    [Test]
    public void OutputIsTrue()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Palindrome.IsPalindrome(121), Is.True);
            Assert.That(Palindrome.IsPalindrome(3993), Is.True);
        });
    }

    [Test]
    public void OutputIsFalse()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Palindrome.IsPalindrome(-121), Is.False);
            Assert.That(Palindrome.IsPalindrome(395),Is.False);
        });
    }
}