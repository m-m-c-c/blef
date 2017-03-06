using System;

namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Ranks should be assigned according to
    /// <see href="https://pl.wikipedia.org/wiki/Blef_(gra)"/>
    /// </summary>
    public abstract class PokerHand
    {
        public abstract bool IsOnTable(Table table);

        protected abstract int Value
        {
            get;
        }

        public bool IsStrongerThan(PokerHand otherPokerHand)
        {
            return this.Value > otherPokerHand.Value;
        }

        protected int GetRankValue(Rank rank)
        {
            switch (rank)
            {
                case Rank.Nine:
                    return 1;
                case Rank.Ten:
                    return 2;
                case Rank.Jack:
                    return 3;
                case Rank.Queen:
                    return 4;
                case Rank.King:
                    return 5;
                case Rank.Ace:
                    return 6;
                default:
                    throw new ArgumentOutOfRangeException(nameof(rank), rank, null);
            }
        }

        protected int GetSuitValue(Suit suit)
        {
            switch (suit)
            {
                case Suit.Spades:
                    return 4;
                case Suit.Hearts:
                    return 3;
                case Suit.Diamonds:
                    return 2;
                case Suit.Clubs:
                    return 1;
                default:
                    throw new ArgumentOutOfRangeException(nameof(suit), suit, null);
            }
        }
    }
}