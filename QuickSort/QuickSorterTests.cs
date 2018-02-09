using NUnit.Framework;
using QuickSort;

[TestFixture]
public class QuickSorterTests
{
    [TestCase(new int[] { 4, 5, 6 }, new int[] { 4, 5, 6 }, TestName = "In Order")]
    [TestCase(new int[] {}, new int[] {}, TestName = "Empty")]
    [TestCase(new int[] { 3, 1, 5, 2, 8 }, new int[] { 1, 2, 3, 5, 8 }, TestName = "Out of order (OOO)")]
    [TestCase(new int[] { 6, -5, 2, 1, 18, -23, 45 }, new int[] { -23, -5, 1, 2, 6, 18, 45 }, TestName = "Negative OOO")]
    public void TestInOrder(int[] value, int[] expected)
    {
        Assert.AreEqual(expected, QuickSorter.QuickSort(value));
    }    
}