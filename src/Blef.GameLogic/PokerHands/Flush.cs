namespace Blef.GameLogic.PokerHands
{
    public class Flush : PokerHand
    {
        private readonly Suit suit;

        public Flush(Suit suit)
        {
            this.suit = suit;
        }

        public override bool IsOnTable(Table table)
        {
            return table.HasSuit(suit);
        }

        public override bool IsStrongerThan(PokerHand otherPokerHand)
        {
            throw new System.NotImplementedException();
        }
    }
}