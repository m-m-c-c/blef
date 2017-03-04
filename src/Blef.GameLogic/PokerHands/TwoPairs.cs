using System;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class TwoPairs : PokerHand
    {
        private readonly Rank firstRank;
        private readonly Rank secondRank;

        public TwoPairs(Rank firstRank, Rank secondRank)
        {
            if (firstRank == secondRank)
            {
                throw new ArgumentException("Both ranks cannot be the same", nameof(secondRank));
            }
            this.firstRank = firstRank;
            this.secondRank = secondRank;
        }

        public override bool IsOnTable(Table table)
        {
            var firstRankCount = table.GetAllCards().Count(x => x.Rank == firstRank);
            var secondRankCount = table.GetAllCards().Count(x => x.Rank == secondRank);
            return firstRankCount >= 2 && secondRankCount >= 2;
        }

        protected override long Value
        {
            get
            {
                var sortedRankValues = new[] {GetRankValue(firstRank), GetRankValue(secondRank)}.OrderBy(x => x).ToArray();
                return 100 + 10 * sortedRankValues[1] + sortedRankValues[0];
            }
        }

        public override string ToString()
        {
            return $"TwoPairs of {firstRank} and {secondRank}";
        }
    }
}