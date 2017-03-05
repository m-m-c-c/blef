using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class Pair : PokerHand
    {
        private const int BasicValue = 10;

        private readonly Rank rank;

        public Pair(Rank rank)
        {
            this.rank = rank;
        }

        public override bool IsOnTable(Table table)
        {
            return table.GetAllCards().Count(x => x.Rank == rank) >= 2;
        }

        protected override long Value => BasicValue * GetRankValue(rank);


        public override string ToString()
        {
            return $"Pair of {rank}";
        }
    }
}