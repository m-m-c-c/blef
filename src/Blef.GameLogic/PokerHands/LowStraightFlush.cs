using System.Collections.Generic;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class LowStraightFlush : PokerHand
    {
        private readonly IReadOnlyCollection<Card> cards;

        public LowStraightFlush(Suit suit)
        {
            cards = new List<Card>()
            {
                new Card(Rank.Nine,  suit),
                new Card(Rank.Ten,  suit),
                new Card(Rank.Jack,  suit),
                new Card(Rank.Queen,  suit),
                new Card(Rank.King,  suit)
            };
        }

        public override bool IsOnTable(Table table)
        {
            return cards.All(table.HasCard);
        }

        public override bool IsStrongerThan(PokerHand otherPokerHand)
        {
            throw new System.NotImplementedException();
        }
    }
}