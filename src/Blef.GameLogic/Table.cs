using System;
using System.Collections.Generic;
using System.Linq;

namespace Blef.GameLogic
{
    public class Table
    {
        public PlayerHand[] PlayerHands { get; set; }

        public IReadOnlyCollection<Card> GetAllCards()
        {
            return PlayerHands.SelectMany(x => x.Cards).ToList();
        }

        public bool HasRank(Rank rank)
        {
            return GetAllCards().Any(x => x.Rank == rank);
        }

        public bool HasSuit(Suit suit)
        {
            return GetAllCards().Any(x => x.Suit == suit);
        }

        public bool HasCard(Card card)
        {
            return GetAllCards().Any(x => x.Rank == card.Rank && x.Suit == card.Suit);
        }
    }
}