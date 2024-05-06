using LeetCode.Solutions;
using LeetCode.Utility;

namespace LeetCode.Tests.Solutions;

[TestFixture]
public class S20ValidParenthesesTests
{
    [Test]
    public void OutputTrueChild()
    {
        Assert.That(S20ValidParentheses.IsValid("{[]}"), Is.True);
    }

    [Test]
    public void OutputTrueMulti()
    {
        Assert.That(S20ValidParentheses.IsValid("()[]{}"), Is.True);
    }

    [Test]
    public void OutputTrueSingle()
    {
        Assert.That(S20ValidParentheses.IsValid("()"), Is.True);
    }

    [Test]
    public void OutputIsFalseTwoNoClose()
    {
        Assert.That(S20ValidParentheses.IsValid("(]"), Is.False);
    }

    [Test]
    public void OutputIsFalseOpenInClose()
    {
        Assert.That(S20ValidParentheses.IsValid("({)"), Is.False);
    }

    [Test]
    public void OutputIsFalseSingle()
    {
        Assert.That(S20ValidParentheses.IsValid("["), Is.False);
    }

    [Test]
    public void OutputIsFalseCloseOpen()
    {
        Assert.That(S20ValidParentheses.IsValid("}("), Is.False);
    }
    
    [Test]
    public void OutputIsFalseClose()
    {
        Assert.That(S20ValidParentheses.IsValid("}"), Is.False);
    }
    [Test]
    public void OutputIsFalseLong()
    {
        Assert.That(S20ValidParentheses.IsValid("({{{{}}}))"), Is.False);
    }

}