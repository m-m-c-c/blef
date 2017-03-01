namespace Blef.GameLogic.PokerHands
{
    public abstract class PokerHand
    {
        public abstract PokerHandHierarchy CompareWith(PokerHand otherPokerHand);
        public abstract bool IsOnTable(Table table);
    }

    public enum PokerHandHierarchy
    {
        Lower,
        Equal,
        Higher
    }
}