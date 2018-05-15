using NUnit.Framework;
using CodeKatas.Sum_of_two_lowest_positive_integers;

[TestFixture]
public class ConverterTests {
  [Test]
  public void Test1() {
    int[] numbers = { 5, 8, 12, 19, 22 };
    Assert.AreEqual(13, Kata.SumTwoSmallestNumbers(numbers));
  }
  [Test]
  public void Test2() {
    int[] numbers = { 5, 98, 12, 19, 22 };
    Assert.AreEqual(17, Kata.SumTwoSmallestNumbers(numbers));
  }
}