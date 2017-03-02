using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class ThreeOfKind : PokerHand
    {
        private readonly Rank rank;

        public ThreeOfKind(Rank rank)
        {
            this.rank = rank;
        }

        public override bool IsOnTable(Table table)
        {
            return table.GetAllCards().Count(x => x.Rank == rank) >= 3;
        }

        public override bool IsStrongerThan(PokerHand otherPokerHand)
        {
            throw new System.NotImplementedException();
        }
    }
}