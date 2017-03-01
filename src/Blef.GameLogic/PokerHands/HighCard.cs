using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Wysoka karta
    /// </summary>
    public class HighCard : PokerHand
    {
        private readonly Rank rank;
        
        public HighCard(Rank rank)
        {
            this.rank = rank;
        }

        public override bool IsOnTable(Table table)
        {
            return table.HasRank(rank);
        }

        public override bool IsStrongerThan(PokerHand otherPokerHand)
        {
            throw new System.NotImplementedException();
        }
    }
}