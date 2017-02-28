namespace Blef.GameLogic
{
    public class Card
    {
        private readonly Rank rank;
        private readonly Suit suit;

        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }
    }
}