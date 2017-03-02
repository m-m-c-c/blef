using System.Collections.Generic;
using System.Linq;
using Blef.GameLogic.PokerHands;

namespace Blef.GameLogic
{
    /// <summary>
    /// Use for generating all possible Hand.
    /// Will help for algorithms search for best Hand to bet
    /// </summary>
    public class PokerHandsGenerator
    {
        public static IEnumerable<PokerHand> GetAll()
        {
            return HighCardGenerator.GetAll();
        }
        
        public class HighCardGenerator
        {
            public static IEnumerable<PokerHand> GetAll()
            {
                return CardsGenerator.GetAllRanks().Select(x => new HighCard(x));
            }
        }

        // Implement other PokerHand generators if you like the idea,
        // maybe it can be moved inside PokerHand classes, but I will would wait with decision
    }
}