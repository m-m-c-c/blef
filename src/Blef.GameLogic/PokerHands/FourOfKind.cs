using System;
using System.Linq;

namespace Blef.GameLogic.PokerHands
{
    public class FourOfKind : PokerHand
    {
        private readonly Rank rank;

        public FourOfKind(Rank rank)
        {
            this.rank = rank;
        }

        public override bool IsOnTable(Table table)
        {
            return table.GetAllCards().Count(x => x.Rank == rank) == 4;
        }

        protected override int PokerHandRank => 9;

        protected override int GetInnerRank()
        {
            return (int)rank;
        }
    }
}