namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Duży strit
    /// </summary>
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

        protected override int Value => 5000;
    }
}