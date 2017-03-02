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

        public override bool IsStrongerThan(PokerHand otherPokerHand)
        {
            throw new System.NotImplementedException();
        }
    }
}