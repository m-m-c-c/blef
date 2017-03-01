using System;
using Xunit;

namespace Blef.GameLogic.Tests.PokerHands
{
    public class CardCompareTester
    {
        [Fact]
        public void Compare_all_cards_in_deck_test()
        {
            int deckSize = 24;
            int counter = 0;
            Card[] deck = new Card[deckSize];
            foreach (Rank r in Enum.GetValues(typeof(Rank)))
            {
                foreach (Suit s in Enum.GetValues(typeof(Suit)))
                {
                    deck[counter++] = new Card(r, s);
                }
            }

            int penultimateCard = deckSize - 1;
            for (int i = 0; i < penultimateCard; i++)
            {
                int result = deck[i].CompareTo(deck[i + 1]);
                Assert.True(result < 0);
            }
        }
    }
}