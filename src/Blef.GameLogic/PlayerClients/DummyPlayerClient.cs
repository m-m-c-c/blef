using System.Collections.Generic;
using System.Linq;
using Blef.GameLogic.PokerHands;

namespace Blef.GameLogic.PlayerClients
{
    public class DummyPlayerClient
    {
        public PlayerMove GetMove(GameHistoryForClient gameHistory)
        {
            var lastBet = gameHistory.PlayerBets.Last();

            IEnumerable<PokerHand> pokerHands = PokerHandsGenerator.GetAll();

            foreach (var pokerHand in pokerHands)
            {
                if (pokerHand.IsStrongerThan(lastBet.Hand))
                {
                    return PlayerMove.Bet(pokerHand);
                }
            }

            return PlayerMove.Check();
        }
    }
}