using LeetCode.Solutions;
using LeetCode.Utility;

namespace LeetCode.Tests.Solutions;

[TestFixture]
public class ValidParenthesesTests
{
    [Test]
    public void OutputTrueChild()
    {
        Assert.That(ValidParentheses.IsValid("{[]}"), Is.True);
    }

    [Test]
    public void OutputTrueMulti()
    {
        Assert.That(ValidParentheses.IsValid("()[]{}"), Is.True);
    }

    [Test]
    public void OutputTrueSingle()
    {
        Assert.That(ValidParentheses.IsValid("()"), Is.True);
    }

    [Test]
    public void OutputIsFalseTwoNoClose()
    {
        Assert.That(ValidParentheses.IsValid("(]"), Is.False);
    }

    [Test]
    public void OutputIsFalseOpenInClose()
    {
        Assert.That(ValidParentheses.IsValid("({)"), Is.False);
    }

    [Test]
    public void OutputIsFalseSingle()
    {
        Assert.That(ValidParentheses.IsValid("["), Is.False);
    }

    [Test]
    public void OutputIsFalseCloseOpen()
    {
        Assert.That(ValidParentheses.IsValid("}("), Is.False);
    }
    
    [Test]
    public void OutputIsFalseClose()
    {
        Assert.That(ValidParentheses.IsValid("}"), Is.False);
    }
    [Test]
    public void OutputIsFalseLong()
    {
        Assert.That(ValidParentheses.IsValid("({{{{}}}))"), Is.False);
    }

}