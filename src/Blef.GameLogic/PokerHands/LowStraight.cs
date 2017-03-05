namespace Blef.GameLogic.PokerHands
{
    public class LowStraight : PokerHand
    {
        private int BasicValue = 1000;

        public override bool IsOnTable(Table table)
        {
            return table.HasRank(Rank.Nine) &&
                   table.HasRank(Rank.Ten) &&
                   table.HasRank(Rank.Jack) &&
                   table.HasRank(Rank.Queen) &&
                   table.HasRank(Rank.King);
        }

        protected override long Value => BasicValue;

        public override string ToString()
        {
            return $"LowStraight";
        }
    }
}