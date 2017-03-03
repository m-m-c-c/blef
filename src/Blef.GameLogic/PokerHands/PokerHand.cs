namespace Blef.GameLogic.PokerHands
{
    public abstract class PokerHand
    {
        public abstract bool IsOnTable(Table table);

        public int CompareWith(PokerHand otherPokerHand)
        {
            int genericValueResult = GenericPokerHand - otherPokerHand.GenericPokerHand;

            if (genericValueResult == 0)
            {
                return CompareWithinSameGenericPokerHand(otherPokerHand);
            }

            return genericValueResult;
        }

        protected abstract int GenericPokerHand { get; }

        protected abstract int CompareWithinSameGenericPokerHand(PokerHand otherPokerHand);
    }
}