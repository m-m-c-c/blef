﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class LowStraightFlush : PokerHand
    {
        private readonly Suit suit;
        private readonly IReadOnlyCollection<Card> cards;

        public LowStraightFlush(Suit suit)
        {
            this.suit = suit;
            cards = new List<Card>()
            {
                new Card(Rank.Nine,  suit),
                new Card(Rank.Ten,  suit),
                new Card(Rank.Jack,  suit),
                new Card(Rank.Queen,  suit),
                new Card(Rank.King,  suit)
            };
        }

        public override bool IsOnTable(Table table)
        {
            return cards.All(table.HasCard);
        }

        protected override int PokerHandRank => 10;

        protected override int GetInnerRank()
        {
            return (int)suit;
        }
    }
}