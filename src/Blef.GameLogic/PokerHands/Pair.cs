using System;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class Pair : PokerHand
    {
        private readonly Rank rank;

        public Pair(Rank rank)
        {
            this.rank = rank;
        }

        public override bool IsOnTable(Table table)
        {
            return table.GetAllCards().Count(x => x.Rank == rank) >= 2;
        }

        protected override int GenericPokerHand => 2;

        protected override int CompareWithinSameGenericPokerHand(PokerHand otherPokerHand)
        {
            var otherPair = otherPokerHand as Pair;

            if (otherPair == null)
            {
                throw new InvalidOperationException($"This method can compare only {nameof(PokerHand)} with the same GenericPokerHand value");
            }

            return rank - otherPair.rank;
        }
    }
}