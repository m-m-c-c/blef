namespace Blef.GameLogic.PokerHands
{
    public abstract class PokerHand
    {
        public abstract bool IsOnTable(Table table);
        public abstract bool IsStrongerThan(PokerHand otherPokerHand);
    }
}