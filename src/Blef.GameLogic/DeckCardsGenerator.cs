using System.Collections.Generic;

namespace Blef.GameLogic
{
    internal static class DeckCardsGenerator
    {
        /// <summary>
        /// This list is readonly so it can be reused by all Decks (<see cref="Deck"/>).
        /// <see cref="Card"/> is immutable and it is enough to have only one instance
        /// of each Card in the whole system.
        /// </summary>
        public static IReadOnlyCollection<Card> GetStartingDeck()
        {
            var cards = new List<Card>(24);

            foreach (var rank in CardsGenerator.GetAllRanks())
            {
                foreach (var suit in CardsGenerator.GetAllSuites())
                {
                    cards.Add(new Card(rank, suit));
                }
            }

            return cards.AsReadOnly();
        }
    }
}