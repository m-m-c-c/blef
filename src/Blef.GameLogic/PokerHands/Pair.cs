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

        public override bool IsStrongerThan(PokerHand otherPokerHand)
        {
            throw new System.NotImplementedException();
        }
    }
}