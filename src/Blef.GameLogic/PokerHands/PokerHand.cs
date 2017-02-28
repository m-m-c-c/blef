﻿using System.Collections.Generic;

namespace Blef.GameLogic.PokerHands
{
    public abstract class PokerHand
    {
        public abstract bool IsOnTable(IEnumerable<Card> cards);

        /// <summary>
        /// Ranks should be assigned according to <see href="https://pl.wikipedia.org/wiki/Blef_(gra)"/> 
        /// where "wysoka karta" <see cref="HighCard"/> is starting at 1
        /// </summary>
        public abstract short GetRank();
   }
}