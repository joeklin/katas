
using System;
using System.Linq;

namespace CodeKatas.Sum_of_two_lowest_positive_integers {
  public class Kata {
    public static int SumTwoSmallestNumbers(int[] numbers) {
      var lowestNumber = numbers.Min();
      return lowestNumber + numbers.Where(x => x != lowestNumber).Min();
    }
  }
}
