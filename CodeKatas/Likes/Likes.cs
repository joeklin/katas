
using System.Collections.Generic;

namespace CodeKatas.Likes {
  public static class Kata {
    private static Dictionary<int, string> likeConfigurations = new Dictionary<int, string>();

    public static string Likes(string[] names) {
      switch (names.Length) {
        case 0:
          return "no one likes this";
        case 1:
          return string.Format("{0} likes this", names);
        case 2:
          return string.Format("{0} and {1} like this", names[0], names[1]);
        case 3:
          return string.Format("{0}, {1}, and {2} like this", names[0], names[1], names[2]);
        default:
          return string.Format("{0}, {1}, and {2} others like this", names[0], names[1], names.Length - 2);
      }
    }
  }
}
