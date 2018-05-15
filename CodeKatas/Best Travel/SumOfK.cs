using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKatas.Best_Travel {
  public static class SumOfK {

    public static int? chooseBestSum(int totalDistance, int numberOfTowns, List<int> ls) {

      var combinations = ls.DifferentCombinations(numberOfTowns);
      return null;
    }

    public static IEnumerable<IEnumerable<T>> DifferentCombinations<T>(this IEnumerable<T> elements, int k) {
      return k == 0 ? new[] { new T[0] } :
        elements.SelectMany((e, i) =>
          elements.Skip(i + 1).DifferentCombinations(k - 1).Select(c => (new[] { e }).Concat(c)));

    }
  }
}

