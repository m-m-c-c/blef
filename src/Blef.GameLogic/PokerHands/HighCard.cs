using System;
using System.Collections.Generic;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class HighCard : PokerHand
    {
        public HighCard(Rank rank)
        {
            Rank = rank;
        }

        public Rank Rank { get; }

        public override bool IsOnTable(IEnumerable<Rank> cards)
        {
            return cards.Contains(Rank);
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

            return Rank - highCard.Rank;
        }
    }
}