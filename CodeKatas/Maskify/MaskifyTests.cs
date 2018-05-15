using NUnit.Framework;

namespace CodeKatas.Maskify {
  public class MaskifyTests {
    private readonly MaskifyKata _kata = new MaskifyKata();

    [Test]
    public void EmptyStringReturnsEmptyString() {
      Assert.AreEqual("", _kata.Maskify(""));
    }

    [Test]
    public void StringLengthOfFourReturnsAllNumbers() {
      Assert.AreEqual("abcd", _kata.Maskify("abcd"));
    }

    [Test]
    public void StringLengthOfTenReturnsSixPoundSignsAndLastFourChar() {
      Assert.AreEqual("######7890", _kata.Maskify("1234567890"));
    }

    [Test]
    public void ExampleTestsPass() {
      Assert.AreEqual(_kata.Maskify("4556364607935616"), "############5616");
      Assert.AreEqual(_kata.Maskify("1"), "1");
      Assert.AreEqual(_kata.Maskify("11111"), "#1111");
      Assert.AreEqual("####################################man!", _kata.Maskify("Nananananananananananananananana Batman!"));
    }
  }
}
