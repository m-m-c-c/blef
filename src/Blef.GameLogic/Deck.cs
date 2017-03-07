using System;
using System.Collections.Generic;
using System.Linq;
using Blef.GameLogic.Utils;

namespace Blef.GameLogic
{
    public class Deck
    {
        readonly List<Card> _cards;

        public static Deck GetFullDeck()
        {
            IReadOnlyCollection<Card> readOnlyCollection = DeckCardsGenerator.GetStartingDeck();

            var fullDeck = new Deck(readOnlyCollection.ToList());

            return fullDeck;
        }

        Deck(List<Card> cards)
        {
            _cards = cards;
        }

        public Card DealCard()
        {
            if (_cards.Count <= 0)
            {
                throw new InvalidOperationException("Cannot deal more cards from deck. Deck is empty");
            }

            Random random = StaticRandom.Instance;

            int randomPosition = random.Next(0, _cards.Count);

            Card card = _cards[randomPosition];

            _cards.RemoveAt(randomPosition);

            return card;
        }
    }
}