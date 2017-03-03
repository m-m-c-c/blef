namespace Blef.GameLogic.PokerHands
{
    public class HighStraight : PokerHand
    {
        public override bool IsOnTable(Table table)
        {
            return table.HasRank(Rank.Ten) &&
               table.HasRank(Rank.Jack) &&
               table.HasRank(Rank.Queen) &&
               table.HasRank(Rank.King) &&
               table.HasRank(Rank.Ace);
        }

        protected override int PokerHandRank => 5;

        protected override int GetInnerRank()
        {
            // It is not important for this kind of PokerHand
            return 0;
        }
    }
}