namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Kolor
    /// </summary>
    public class Flush : PokerHand
    {
        private readonly Suit suit;

        public Flush(Suit suit)
        {
            this.suit = suit;
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