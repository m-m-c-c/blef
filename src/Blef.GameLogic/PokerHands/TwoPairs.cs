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
            if (first <= second)
            {
                throw new ArgumentException($"First pair '{first}' has to be greater than second pair '{second}'");
            }

            this.first = first;
            this.second = second;
        }

        public override bool IsOnTable(Table table)
        {
            var firstRankCount = table.GetAllCards().Count(x => x.Rank == first);
            var secondRankCount = table.GetAllCards().Count(x => x.Rank == second);
            return firstRankCount >= 2 && secondRankCount >= 2;
        }

        protected override int PokerHandRank => 3;

        protected override int GetInnerRank()
        {
            return 10 * (int)first + (int)second;
        }
    }
}