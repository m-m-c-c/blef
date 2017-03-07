using System;
using Xunit;

namespace Blef.GameLogic.Tests
{
    public class DeckTests
    {
        [Fact]
        public void Can_deal_maximum_24_cards_from_deck()
        {
            var fullDeck = Deck.GetFullDeck();

            for (int i = 0; i < 24; i++)
            {
                fullDeck.DealCard();
            }

            Assert.Throws<InvalidOperationException>(() =>
            {
                fullDeck.DealCard();
            });
        }
    }
}