using LeetCode.Solutions;
using LeetCode.Utility;

namespace LeetCode.Tests.Solutions;

[TestFixture]
public class S9PalindromeTests
{
    [Test]
    public void OutputIsTrue()
    {
        Assert.Multiple(() =>
        {
            Assert.That(S9Palindrome.IsPalindrome(121), Is.True);
            Assert.That(S9Palindrome.IsPalindrome(3993), Is.True);
        });
    }

    [Test]
    public void OutputIsFalse()
    {
        Assert.Multiple(() =>
        {
            Assert.That(S9Palindrome.IsPalindrome(-121), Is.False);
            Assert.That(S9Palindrome.IsPalindrome(395),Is.False);
        });
    }
}