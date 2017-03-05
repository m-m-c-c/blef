namespace Blef.GameLogic
{
    public class Card
    {
        public Rank Rank { get; }
        public Suit Suit { get; }

        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }
    }

    public enum Rank
    {
        Nine=1,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public enum Suit
    {
        Spades = 1,
        Hearts,
        Diamonds,
        Clubs
    }
}