﻿namespace Blef.GameLogic.PokerHands
{
    public class HighCard : PokerHand
    {
        private readonly Rank rank;

        public HighCard(Rank rank)
        {
            this.rank = rank;
        }

        public override bool IsOnTable(Table table)
        {
            return table.HasRank(rank);
        }

        protected override int PokerHandRank => 1;

        protected override int GetInnerRank()
        {
            return (int)rank;
        }
    }
}