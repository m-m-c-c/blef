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
    }
}