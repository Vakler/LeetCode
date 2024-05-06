using LeetCode.Solutions;

namespace LeetCode.Tests.Solutions;

public class RemoveDuplicates_Tests
{
    [Test]
    public void OutputIsTrue()
    {
        Assert.Multiple(() =>
        {
            Assert.That(SRemoveDuplicates.RemoveDuplicates([1,1,2]), Is.EqualTo(2));
            Assert.That(SRemoveDuplicates.RemoveDuplicates([0,0,1,1,1,2,2,3,3,4]), Is.EqualTo(5));
        });
    }
}