using System.Collections.Generic;

namespace Blef.GameLogic
{
    public class PlayerHand
    {
        public PlayerHand(IEnumerable<Rank> cards)
        {
            Cards = cards;
        }

        public IEnumerable<Rank> Cards { get; }
    }
}