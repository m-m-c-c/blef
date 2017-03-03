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

        protected override int GenericPokerHand => 4;

        protected override int CompareWithinSameGenericPokerHand(PokerHand otherPokerHand)
        {
            return 0;
        }
    }
}