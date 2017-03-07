namespace Blef.GameLogic
{
    public class CardsGenerator
    {
        public static Rank[] GetAllRanks()
        {
            return new[]
            {
                Rank.Nine,
                Rank.Ten,
                Rank.Jack,
                Rank.Queen,
                Rank.King,
                Rank.Ace
            };
        }

        public static Suit[] GetAllSuites()
        {
            return new[]
            {
                Suit.Clubs,
                Suit.Diamonds,
                Suit.Hearts,
                Suit.Spades
            };
        }
    }
}