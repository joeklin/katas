using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Deck_of_Cards {
  public class DeckOfCardsTests {
    [Test]
    public void DeckOfCardsBuilt() {
      var DeckOfCards = new DeckOfCards();
      var deck = DeckOfCards.BuildDeck();
      Assert.AreEqual(52,deck.Count());
      Assert.Contains("king of diamonds", deck);
    }
  }
}
