using System;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class FullHouse : PokerHand
    {
        private readonly Rank firstRank;
        private readonly Rank secondRank;

        public FullHouse(Rank firstRank, Rank secondRank)
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
            return firstRankCount >= 3 && secondRankCount >= 2;
        }

        protected override long Value => 100000 + 10 * GetRankValue(firstRank) +  GetRankValue(secondRank);

        public override string ToString()
        {
            return $"FullHouse of {firstRank} and {secondRank}";
        }
    }
}