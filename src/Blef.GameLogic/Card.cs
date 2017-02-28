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
    }
}