namespace Blef.GameLogic.PokerHands
{
    public class HighStraight : PokerHand
    {
        private const int BasicValue = 5000;

        public override bool IsOnTable(Table table)
        {
            return table.HasRank(Rank.Ten) &&
               table.HasRank(Rank.Jack) &&
               table.HasRank(Rank.Queen) &&
               table.HasRank(Rank.King) &&
               table.HasRank(Rank.Ace);
        }

        protected override long Value => BasicValue;

        public override string ToString()
        {
            return $"HighStraight";
        }
    }
}