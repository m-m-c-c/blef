using System;
using System.Collections.Generic;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class HighCard : PokerHand
    {
        public Card Card { get; private set; }

        public HighCard(Card card)
        {
            Card = card;
        }

        public override bool IsOnTable(IEnumerable<Card> cards)
        {
            return cards.Contains(Card);
        }

        protected override short GetRank()
        {
            return 1;
        }

        protected override int GetInnerRank()
        {
            return (int)Card.Rank;
        }
    }
}