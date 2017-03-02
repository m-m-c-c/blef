namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Mały strit
    /// </summary>
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

        protected override int Value => 1000;

    }
}