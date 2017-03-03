namespace Blef.GameLogic.PokerHands
{
    public abstract class PokerHand
    {
        public abstract bool IsOnTable(Table table);

        public int CompareWith(PokerHand otherPokerHand)
        {
            int genericValueResult = PokerHandRank - otherPokerHand.PokerHandRank;

            if (genericValueResult == 0)
            {
                return GetInnerRank();
            }

            return genericValueResult;
        }

        protected abstract int PokerHandRank { get; }

        protected abstract int GetInnerRank();
    }
}