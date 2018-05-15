using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeKatas.Best_Travel {
  public class SumOfKTests {
    private List<int> listOfThreeDistances = new List<int> { 1, 2, 3 };
    private IEnumerable<int> firstCombination = new List<int> { 1, 2 };
    private IEnumerable<IEnumerable<int>> DifferentCombinationOfThreeDistances
      = new List<List<int>>
      { new List<int> { 1, 2 },
        new List<int> { 2, 3 },
        new List<int> { 1, 3 }
      };

    [Test]
    public void AllCombinationsAreCorrectlyCalculated() {
      var missingCombinaiton = "";
      foreach (var combination in listOfThreeDistances.DifferentCombinations(2))
        foreach (var combo2 in DifferentCombinationOfThreeDistances) {
          missingCombinaiton = string.Join(" ", combo2.Select(x => x));        
          if (combination.SequenceEqual(combo2)) {
            break;
          }
        }
      Assert.Fail("missing " + missingCombinaiton);
    }
  }
}
