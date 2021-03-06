﻿using System;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class ThreeOfKind : PokerHand
    {
        private readonly Rank rank;

        public ThreeOfKind(Rank rank)
        {
            this.rank = rank;
        }

        public override bool IsOnTable(Table table)
        {
            return table.GetAllCards().Count(x => x.Rank == rank) >= 3;
        }

        protected override int PokerHandRank => 6;

        protected override int GetInnerRank()
        {
            return (int)rank;
        }
    }
}