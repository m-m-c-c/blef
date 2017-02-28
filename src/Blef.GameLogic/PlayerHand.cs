using System.Collections.Generic;

namespace Blef.GameLogic
{
    public class PlayerHand
    {
        public PlayerHand(IEnumerable<Card> cards)
        {
            Cards = cards;
        }

        public IEnumerable<Card> Cards { get; }
    }
}