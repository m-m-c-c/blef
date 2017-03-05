using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class FourOfKind : PokerHand
    {
        private const int BasicValue = 10000000;

        private readonly Rank rank;
        
        public FourOfKind(Rank rank)
        {
            this.rank = rank;
        }

        public override bool IsOnTable(Table table)
        {
            return table.GetAllCards().Count(x => x.Rank == rank) == 4;
        }

        protected override long Value => BasicValue * GetRankValue(rank);

        public override string ToString()
        {
            return $"FourOfKind of {rank}";
        }
    }
}