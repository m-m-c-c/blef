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

        protected override long Value => 10000000 * GetRankValue(rank);
    }
}