namespace Blef.GameLogic.PokerHands
{
    public class HandsComparer
    {
        public bool IsBetter(PokerHand first, PokerHand second)
        {
            short result = CompareByPokerHandRank(first, second);

            return result > 0;
        }

        public short CompareByPokerHandRank(PokerHand first, PokerHand second)
        {
            return (short)(first.GetRank() - second.GetRank());
        }
    }
}