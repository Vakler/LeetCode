using LeetCode.Utility;

namespace LeetCode.Tests.Utility;

[TestFixture]
public class AlgorithmSortingTests
{
    private readonly int[] _sorted = [1, 2, 3, 4, 5, 6];
    private readonly int[] _unSorted = [2, 6, 4, 1, 5, 3];

    [SetUp]
    public void Setup()
    {
        var bs = new BubbleSort();
    }

    [Test]
    public void OutputSorted()
    {
        BubbleSort.Sort(_unSorted);
        Assert.That(BubbleSort.Sort(_unSorted), Is.EqualTo(_sorted));
    }
}