using System;
using System.Collections.Generic;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class HighStraightFlush : PokerHand
    {
        private readonly Suit suit;
        private readonly IReadOnlyCollection<Card> cards;

        public HighStraightFlush(Suit suit)
        {
            this.suit = suit;
            cards = new List<Card>()
            {
                new Card(Rank.Ten,  suit),
                new Card(Rank.Jack,  suit),
                new Card(Rank.Queen,  suit),
                new Card(Rank.King,  suit),
                new Card(Rank.Ace,  suit)
            };
        }

        public override bool IsOnTable(Table table)
        {
            return cards.All(table.HasCard);
        }

        protected override int GenericPokerHand => 11;

        protected override int CompareWithinSameGenericPokerHand(PokerHand otherPokerHand)
        {
            var otherHightStraightFlush = otherPokerHand as HighStraightFlush;

            if (otherHightStraightFlush == null)
            {
                throw new InvalidOperationException($"This method can compare only {nameof(PokerHand)} with the same GenericPokerHand value");
            }

            return suit - otherHightStraightFlush.suit;
        }
    }
}