using Blef.GameLogic.PokerHands;
using Xunit;

namespace Blef.GameLogic.Tests.PokerHands
{
    public class HightCardComaringTester
    {
        [Fact]
        public void compare_jack_and_nine_given_jack_is_better_test()
        {
            HighCard betterHand = new HighCard(new Card(Rank.Jack, Suit.Diamonds));
            HighCard worseHand = new HighCard(new Card(Rank.Nine, Suit.Diamonds));

            int result = betterHand.CompareTo(worseHand);

            Assert.True(result > 0);
        }

        [Fact]
        public void compare_ace_and_ace_given_no_one_is_better_test()
        {
            HighCard notBetterHand = new HighCard(new Card(Rank.Ace, Suit.Diamonds));
            HighCard notWorseHand = new HighCard(new Card(Rank.Ace, Suit.Clubs));

            int result = notBetterHand.CompareTo(notWorseHand);

            Assert.True(result == 0);
        }
    }
}