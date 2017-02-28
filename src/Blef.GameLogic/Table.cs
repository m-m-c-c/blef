using System.Collections.Generic;
using System.Linq;
using Blef.GameLogic.PokerHands;

namespace Blef.GameLogic
{
    public class Table
    {
        public Table(IEnumerable<PlayerHand> playerHands)
        {
            PlayerHands = playerHands;
        }

        public IEnumerable<PlayerHand> PlayerHands { get; }

        public bool IsPokerHandOnTable(PokerHand pokerHand)
        {
            IEnumerable<Card> allCardsOnTable = PlayerHands.SelectMany(x => x.Cards);

            return pokerHand.IsOnTable(allCardsOnTable);
        }
    }
}