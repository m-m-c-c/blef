using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Full
    /// </summary>
    public class FullHouse : PokerHand
    {
        private readonly Rank first;
        private readonly Rank second;

        public FullHouse(Rank first, Rank second)
        {
            this.first = first;
            this.second = second;
        }

        public override bool IsOnTable(Table table)
        {
            var firstRankCount = table.GetAllCards().Count(x => x.Rank == first);
            var secondRankCount = table.GetAllCards().Count(x => x.Rank == second);
            return firstRankCount >= 3 && secondRankCount >= 2;
        }

        public override bool IsStrongerThan(PokerHand otherPokerHand)
        {
            throw new System.NotImplementedException();
        }
    }
}