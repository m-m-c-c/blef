using Blef.GameLogic.PokerHands;

namespace Blef.GameLogic
{
    public class PlayerDecision
    {
        public PlayerChoice Choice { get; set; }
        public PokerHand PokerHand { get; set; }

        public static PlayerDecision Check()
        {
            return new PlayerDecision
            {
                Choice = PlayerChoice.Check
            };
        }

        public static PlayerDecision Bet(PokerHand pokerHand)
        {
            return new PlayerDecision
            {
                Choice = PlayerChoice.Bet,
                PokerHand = pokerHand
            };
        }

        PlayerDecision()
        {
        }
    }
}