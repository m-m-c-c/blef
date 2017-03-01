namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Trójka
    /// </summary>
    public class ThreeOfKind : PokerHand
    {
        private readonly Rank rank;

        public ThreeOfKind(Rank rank)
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