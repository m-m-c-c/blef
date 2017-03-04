using Blef.GameLogic.PokerHands;
using Xunit;

namespace Blef.GameLogic.Tests.PokerHands
{
    public class TwoPairHandTests
    {
        [Fact]
        public void TwoPair_Ace_and_Nine_should_be_stronger_than_king_and_queen()
        {
            TwoPairs A9 = new TwoPairs(Rank.Ace, Rank.Nine);
            TwoPairs KQ = new TwoPairs(Rank.King, Rank.Queen);

            Assert.True(A9.IsStrongerThan(KQ));
        }
    }
}