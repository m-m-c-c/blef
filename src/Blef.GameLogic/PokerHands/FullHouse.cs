using System;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class FullHouse : PokerHand
    {
        private const int BasicValue = 100000;
        private const int ThreeOfKindValueCoefficient = 10;

        private readonly Rank threeOfKindRank;
        private readonly Rank pairRank;

        public FullHouse(Rank threeOfKindRank, Rank pairRank)
        {
            if (threeOfKindRank == pairRank)
            {
                throw new ArgumentException("Both ranks cannot be the same", nameof(pairRank));
            }

            this.threeOfKindRank = threeOfKindRank;
            this.pairRank = pairRank;
        }

        public override bool IsOnTable(Table table)
        {
            var firstRankCount = table.GetAllCards().Count(x => x.Rank == threeOfKindRank);
            var secondRankCount = table.GetAllCards().Count(x => x.Rank == pairRank);
            return firstRankCount >= 3 && secondRankCount >= 2;
        }

        protected override long Value => BasicValue + ThreeOfKindValueCoefficient * GetRankValue(threeOfKindRank) +  GetRankValue(pairRank);

        public override string ToString()
        {
            return $"FullHouse of {threeOfKindRank} and {pairRank}";
        }
    }
}