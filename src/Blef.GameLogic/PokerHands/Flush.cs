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

        protected override int PokerHandRank => 8;

        protected override int GetInnerRank()
        {
            return (int)suit;
        }
    }
}