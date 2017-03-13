using System;
using Blef.GameLogic.Utils;

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

        public static Card DealCard()
        {
            Random random = StaticRandom.Instance;

            // It's hardcoded, I know it, you know it, let's leave with it
            // we can use some reflection here, but it will look more hacky and
            // this numbers will never change.
            int randomRank = random.Next(1, 7);
            int randomSuit = random.Next(1, 5);

            return new Card((Rank) randomRank, (Suit) randomSuit);
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