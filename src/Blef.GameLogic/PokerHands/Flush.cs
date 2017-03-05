namespace Blef.GameLogic.PokerHands
{
    public class Flush : PokerHand
    {
        private const int BasicValue = 1000000;
        private readonly Suit suit;

        public Flush(Suit suit)
        {
            this.suit = suit;
        }

        public override bool IsOnTable(Table table)
        {
            return table.HasSuit(suit);
        }

        protected override long Value => BasicValue * GetSuitValue(suit);

        public override string ToString()
        {
            return $"Flush of {suit}";
        }
    }
}