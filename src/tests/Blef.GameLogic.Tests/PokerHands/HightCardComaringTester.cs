using Blef.GameLogic.PokerHands;
using Xunit;

namespace Blef.GameLogic.Tests.PokerHands
{
    public class HightCardComaringTester
    {
        [Fact]
        public void When_comparing_better_hand_to_worse_hand_then_result_is_bigger_than_zero()
        {
            HighCard betterHand = new HighCard(new Card(Rank.Jack, Suit.Diamonds));
            HighCard worseHand = new HighCard(new Card(Rank.Nine, Suit.Diamonds));

            int result = betterHand.CompareTo(worseHand);

            Assert.True(result > 0);
        }
    }
}