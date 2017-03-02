using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Para
    /// </summary>
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

        protected override int Value => 10 * GetRankValue(rank);
    }
}