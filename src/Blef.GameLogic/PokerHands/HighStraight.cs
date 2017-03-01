namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Duży strit
    /// </summary>
    public class HighStraight : PokerHand
    {
        private readonly Card card;

        public HighStraight(Card card)
        {
            this.card = card;
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