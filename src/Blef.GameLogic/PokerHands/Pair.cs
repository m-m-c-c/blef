namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Para
    /// </summary>
    public class Pair : PokerHand
    {
        private readonly Rank rank;

        public Pair(Rank rank)
        {
            this.rank = rank;
        }

        public override PokerHandHierarchy CompareWith(PokerHand otherPokerHand)
        {
            throw new System.NotImplementedException();
        }

        public override bool IsOnTable(Table table)
        {
            throw new System.NotImplementedException();
        }
    }
}