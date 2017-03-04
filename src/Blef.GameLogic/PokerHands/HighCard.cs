
namespace Blef.GameLogic.PokerHands
{
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

        protected override long Value => GetRankValue(rank);
    }
}