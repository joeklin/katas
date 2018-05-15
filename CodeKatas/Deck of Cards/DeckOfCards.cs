using System.Collections.Generic;
using System.Linq;
public class DeckOfCards {
  private static List<string> values = new List<string> { "ace", "king", "queen", "jack", "ten", "nine", "eight", "seven", "six", "five", "four", "three", "two" };
  private static List<string> suits = new List<string> { "diamonds", "spades", "hearts", "clubs" };
  public static string[] BuildDeck() => (from v in values
                                         from s in suits
                                         select (v + " of " + s)).ToArray();
}