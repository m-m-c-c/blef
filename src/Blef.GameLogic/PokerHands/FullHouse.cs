namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Full
    /// </summary>
    public class FullHouse : PokerHand
    {
        private readonly Rank first;
        private readonly Rank second;

        public FullHouse(Rank first, Rank second)
        {
            this.first = first;
            this.second = second;
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