namespace Blef.GameLogic.PokerHands
{
    public class LowStraight : PokerHand
    {
        public override bool IsOnTable(Table table)
        {
            return table.HasRank(Rank.Nine) &&
                   table.HasRank(Rank.Ten) &&
                   table.HasRank(Rank.Jack) &&
                   table.HasRank(Rank.Queen) &&
                   table.HasRank(Rank.King);
        }

        protected override int PokerHandRank => 4;

        protected override int GetInnerRank()
        {
            // It is not important for this kind of PokerHand
            return 0;
        }
    }
}