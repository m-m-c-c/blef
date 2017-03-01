namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Kareta
    /// </summary>
    public class FourOfKind : PokerHand
    {
        private readonly Rank rank;

        public FourOfKind(Rank rank)
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