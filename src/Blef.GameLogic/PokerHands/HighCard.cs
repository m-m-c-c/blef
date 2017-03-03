
using System;

namespace Blef.GameLogic.PokerHands
{
    public class HighCard : PokerHand
    {
        private readonly Rank rank;

        public HighCard(Rank rank)
        {
            this.rank = rank;
        }

        public override bool IsOnTable(Table table)
        {
            return table.HasRank(rank);
        }

        protected override int GenericPokerHand => 1;

        protected override int CompareWithinSameGenericPokerHand(PokerHand otherPokerHand)
        {
            HighCard otherHighCard = otherPokerHand as HighCard;

            if (otherHighCard == null)
            {
                throw new InvalidOperationException($"This method can compare only {nameof(PokerHand)} with the same GenericPokerHand value");
            }

            return rank - otherHighCard.rank;
        }
    }
}