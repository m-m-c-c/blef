using Blef.GameLogic.PokerHands;

namespace Blef.GameLogic
{
    public class PlayerMove
    {
        public PlayerChoice Choice { get; set; }
        public PokerHand PokerHand { get; set; }

        public static PlayerMove Check()
        {
            return new PlayerMove
            {
                Choice = PlayerChoice.Check
            };
        }

        public static PlayerMove Bet(PokerHand pokerHand)
        {
            return new PlayerMove
            {
                Choice = PlayerChoice.Bet,
                PokerHand = pokerHand
            };
        }

        PlayerMove()
        {
        }
    }
}