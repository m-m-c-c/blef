using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Kareta
    /// </summary>
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

        public override bool IsStrongerThan(PokerHand otherPokerHand)
        {
            throw new System.NotImplementedException();
        }
    }
}