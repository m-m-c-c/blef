using System;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class TwoPairs : PokerHand
    {
        private readonly Rank first;
        private readonly Rank second;

        public TwoPairs(Rank first, Rank second)
        {
            this.first = first;
            this.second = second;
        }

        public override bool IsOnTable(Table table)
        {
            var firstRankCount = table.GetAllCards().Count(x => x.Rank == first);
            var secondRankCount = table.GetAllCards().Count(x => x.Rank == second);
            return firstRankCount >= 2 && secondRankCount >= 2;
        }

        protected override int GenericPokerHand => 3;

        protected override int CompareWithinSameGenericPokerHand(PokerHand otherPokerHand)
        {
            var otherTwoPair = otherPokerHand as TwoPairs;

            if (otherTwoPair == null)
            {
                throw new InvalidOperationException($"This method can compare only {nameof(PokerHand)} with the same GenericPokerHand value");
            }

            return CompareWithinSameGenericPokerHand(otherTwoPair);
        }

        int CompareWithinSameGenericPokerHand(TwoPairs otherTwoPair)
        {
            int firstRankResult = first - otherTwoPair.first;

            if (firstRankResult == 0)
            {
                return second - otherTwoPair.second;
            }

            return firstRankResult;
        }
    }
}