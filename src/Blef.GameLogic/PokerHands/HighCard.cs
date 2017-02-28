using System;
using System.Collections.Generic;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class HighCard : PokerHand
    {
        public HighCard(Card card)
        {
            Card = card;
        }

        public Card Card { get; }

        public override bool IsOnTable(IEnumerable<Card> cards)
        {
            return cards.Contains(Card);
        }

        public override short GetRank()
        {
            return 1;
        }

        public override int CompareToWithinSameRank(PokerHand value)
        {
            HighCard highCard = value as HighCard;

            if (highCard == null)
            {
                throw new InvalidOperationException($"Can compare only {nameof(PokerHand)} with the same rank");
            }

            return Card - highCard.Card;
        }
    }
}