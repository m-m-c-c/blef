using System;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class ThreeOfKind : PokerHand
    {
        private readonly Rank rank;

        public ThreeOfKind(Rank rank)
        {
            this.rank = rank;
        }

        public override bool IsOnTable(Table table)
        {
            return table.GetAllCards().Count(x => x.Rank == rank) >= 3;
        }

        protected override int GenericPokerHand => 6;

        protected override int CompareWithinSameGenericPokerHand(PokerHand otherPokerHand)
        {
            var otherThreeOfKind = otherPokerHand as ThreeOfKind;

            if (otherThreeOfKind == null)
            {
                throw new InvalidOperationException($"This method can compare only {nameof(PokerHand)} with the same GenericPokerHand value");
            }

            return rank - otherThreeOfKind.rank;
        }
    }
}