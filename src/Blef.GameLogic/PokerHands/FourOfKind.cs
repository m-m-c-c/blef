using System;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class FourOfKind : PokerHand
    {
        private readonly Rank rank;

        public FourOfKind(Rank rank)
        {
            this.rank = rank;
        }

        public override bool IsOnTable(Table table)
        {
            return table.GetAllCards().Count(x => x.Rank == rank) == 4;
        }

        protected override int GenericPokerHand => 9;

        protected override int CompareWithinSameGenericPokerHand(PokerHand otherPokerHand)
        {
            var otherFourOfKind = otherPokerHand as FourOfKind;

            if (otherFourOfKind == null)
            {
                throw new InvalidOperationException($"This method can compare only {nameof(PokerHand)} with the same GenericPokerHand value");
            }

            return rank - otherFourOfKind.rank;
        }
    }
}