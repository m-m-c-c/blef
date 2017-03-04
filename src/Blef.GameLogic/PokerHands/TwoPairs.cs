using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class TwoPairs : PokerHand
    {
        private readonly Rank first;
        private readonly Rank second;

        public TwoPairs(Rank first, Rank second)
        {
            this.first = first;
            this.second = second;
        }

        public override bool IsOnTable(Table table)
        {
            var firstRankCount = table.GetAllCards().Count(x => x.Rank == first);
            var secondRankCount = table.GetAllCards().Count(x => x.Rank == second);
            return firstRankCount >= 2 && secondRankCount >= 2;
        }

        protected override long Value => 100 + GetRankValue(first) + GetRankValue(second);

        public override string ToString()
        {
            return $"TwoPairs od {first} and {second}";
        }
    }
}