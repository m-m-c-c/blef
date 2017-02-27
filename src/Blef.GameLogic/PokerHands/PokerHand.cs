using System.Collections.Generic;

namespace Blef.GameLogic.PokerHands
{
    public abstract class PokerHand
    {
        public abstract bool IsOnTable(IEnumerable<Card> cards);
    }
}