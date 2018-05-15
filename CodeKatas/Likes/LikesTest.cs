using NUnit.Framework;

namespace CodeKatas.Likes {
  public class LikesTest {

    [Test]
    public void OneNameReturnsCorrectly() {
      Assert.AreEqual("John likes this", Kata.Likes(new string[] { "John" }));
    }

    [Test]
    public void TwoNamesReturnCorrectly() {
      Assert.AreEqual("John and Sally like this", Kata.Likes(new string[] { "John", "Sally" }));
    }

    [Test]
    public void ThreeNamesReturnCorrectly() {
      Assert.AreEqual("John, Sally, and Jim like this", Kata.Likes(new string[] { "John", "Sally", "Jim" }));
    }

    [Test]
    public void FourNamesReturnCorrectly() {
      Assert.AreEqual("John, Sally, and 2 others like this", Kata.Likes(new string[] { "John", "Sally", "Jim", "Bob" }));
    }

    [Test]
    public void ZeroNamesReturnsCorrectly() {
      Assert.AreEqual("no one likes this", Kata.Likes(new string[] { }));
    }
  }
}
