using System;

namespace Blef.GameLogic
{
    public class PlayerHand
    {
        public Card[] Cards { get; set; }
        public Player Player { get; set; }

        public static PlayerHand DealHand(Player player, int cardsCount)
        {
            Card[] cards = new Card[cardsCount];

            for (int i = 0; i < cardsCount; i++)
            {
                cards[i] = Card.DealCard();
            }

            return new PlayerHand
            {
                Player = player,
                Cards = cards
            };
        }
    }
}