using NUnit.Framework;
using CodeKatas.Sum_of_two_lowest_positive_integers;
using CodeKatas;

[TestFixture]
public class DuplicateNumbersTests {
  DuplicateNumbers dup = new DuplicateNumbers();
  [Test]
  public void Test1() {
    int[] numbers = { 2, 4, 3, 5, 1 };
    dup.firstDuplicate(numbers);
  }
  [Test]
  public void Test2() {
    int[] numbers = { 5, 98, 12, 19, 22 };
    Assert.AreEqual(17, Kata.SumTwoSmallestNumbers(numbers));
  }
}