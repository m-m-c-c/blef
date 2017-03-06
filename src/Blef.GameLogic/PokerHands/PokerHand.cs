namespace Blef.GameLogic.PokerHands
{
    /// <summary>
    /// Ranks should be assigned according to
    /// <see href="https://pl.wikipedia.org/wiki/Blef_(gra)"/>
    /// </summary>
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