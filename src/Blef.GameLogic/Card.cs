using System;
using System.Collections.Generic;

namespace Blef.GameLogic
{
    public class Card : IComparable<Card>
    {
        public Rank Rank { get; }
        public Suit Suit { get; }

        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public override int GetHashCode()
        {
            return Rank.GetHashCode() ^ Suit.GetHashCode();
        }

        public override bool Equals(object other)
        {
            return Equals(other as Card);
        }

        public static bool operator ==(Card a, Card b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if ((object)a == null || (object)b == null)
            {
                return false;
            }

            return a.Equals(b);
        }

        public static bool operator !=(Card a, Card b)
        {
            return !(a == b);
        }

        private bool Equals(Card other)
        {
            if ((object)other == null)
            {
                return false;
            }

            return (Rank == other.Rank) && (Suit == other.Suit);
        }

        public int CompareTo(Card other)
        {
            if (ReferenceEquals(this, other))
                return 0;

            if (ReferenceEquals(null, other))
                return 1;

            var rankComparison = Rank.CompareTo(other.Rank);
            if (rankComparison != 0)
                return rankComparison;

            return Suit.CompareTo(other.Suit);
        }
    }
}