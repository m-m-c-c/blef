using System.Collections.Generic;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class HighCard : PokerHand
    {
        public HighCard(Card card)
        {
            Card = card;
        }

        public Card Card { get; }

        public override bool IsOnTable(IEnumerable<Card> cards)
        {
            return cards.Contains(Card);
        }

        public override short GetRank()
        {
            return 1;
        }
    }
}