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
        Nine = 1,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    /// <summary>
    /// Order of suits taken from https://pl.wikipedia.org/wiki/Blef_(gra)
    /// (Starszeństwo wartości i kolorów)
    /// </summary>
    public enum Suit
    {
        Clubs = 1, // krajc, trefl
        Diamonds, // dzwonek, karo
        Hearts, // czerwa, kier
        Spades // wina, pik
    }
}