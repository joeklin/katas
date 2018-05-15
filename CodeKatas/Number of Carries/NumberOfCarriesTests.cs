using NUnit.Framework;

namespace CodeKatas.Number_of_Carries {
  [TestFixture]
  public class NumverOfCarriesTests {

    [Test]
    public void BasicTests() {
      var kata = new NumberOfCarriesKata();

      Assert.AreEqual(0, kata.NumberOfCarries(543, 3456));

      Assert.AreEqual(2, kata.NumberOfCarries(1927, 6426));

      Assert.AreEqual(4, kata.NumberOfCarries(9999, 1));

      Assert.AreEqual(2, kata.NumberOfCarries(1234, 5678));

    }

  }
}