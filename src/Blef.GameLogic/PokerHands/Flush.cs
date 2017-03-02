﻿namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Kolor
    /// </summary>
    public class Flush : PokerHand
    {
        private readonly Suit suit;

        public Flush(Suit suit)
        {
            this.suit = suit;
        }

        public override bool IsOnTable(Table table)
        {
            return table.HasSuit(suit);
        }

        protected override int Value => 1000000 * GetSuitValue(suit);
    }
}