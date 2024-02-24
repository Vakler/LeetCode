using LeetCode.Utility;

namespace LeetCode.Tests;

public class ValidParenthesesTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void OutputTrueChild()
    {
        Assert.That(ValidParenthesesSolution.IsValid("{[]}"), Is.True);
    }

    [Test]
    public void OutputTrueMulti()
    {
        Assert.That(ValidParenthesesSolution.IsValid("()[]{}"), Is.True);
    }

    [Test]
    public void OutputTrueSingle()
    {
        Assert.That(ValidParenthesesSolution.IsValid("()"), Is.True);
    }

    [Test]
    public void OutputIsFalseTwoNoClose()
    {
        Assert.That(ValidParenthesesSolution.IsValid("(]"), Is.False);
    }

    [Test]
    public void OutputIsFalseOpenInClose()
    {
        Assert.That(ValidParenthesesSolution.IsValid("({)"), Is.False);
    }

    [Test]
    public void OutputIsFalseSingle()
    {
        Assert.That(ValidParenthesesSolution.IsValid("["), Is.False);
    }

    [Test]
    public void OutputIsFalseCloseOpen()
    {
        Assert.That(ValidParenthesesSolution.IsValid("}("), Is.False);
    }
    
    [Test]
    public void OutputIsFalseClose()
    {
        Assert.That(ValidParenthesesSolution.IsValid("}"), Is.False);
    }
    [Test]
    public void OutputIsFalseLong()
    {
        Assert.That(ValidParenthesesSolution.IsValid("({{{{}}}))"), Is.False);
    }

}