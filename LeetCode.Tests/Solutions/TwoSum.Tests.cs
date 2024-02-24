using LeetCode.Solutions;

namespace LeetCode.Tests.Solutions;


[TestFixture]
public class TwoSumTests
{
    [Test]
    public void SumIsCorrect()
    {
        Assert.Multiple(() =>
        {
            int[] a;
            Assert.That(TwoSum.Sum([2, 7, 11, 15], 9), Is.EqualTo(a = [0,1]));
            Assert.That(TwoSum.Sum([3,2,4], 6), Is.EqualTo(a = [1,2]));
        });
    }
}