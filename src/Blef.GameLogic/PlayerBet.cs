using Blef.GameLogic.PokerHands;

namespace Blef.GameLogic
{
    public class PlayerBet
    {
        public Player Player { get; set; }
        public PokerHand Hand { get; set; }
    }
}