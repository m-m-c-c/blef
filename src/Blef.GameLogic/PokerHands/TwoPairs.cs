namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Dwie pary
    /// </summary>
    public class TwoPairs : PokerHand
    {
        private readonly Rank first;
        private readonly Rank second;

        public TwoPairs(Rank first, Rank second)
        {
            this.first = first;
            this.second = second;
        }

        public override bool IsOnTable(Table table)
        {
            throw new System.NotImplementedException();
        }

        public override bool IsStrongerThan(PokerHand otherPokerHand)
        {
            throw new System.NotImplementedException();
        }
    }
}